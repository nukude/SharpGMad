﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace SharpGMad
{
    /// <summary>
    /// Represents a watcher declaration for an exported file.
    /// </summary>
    class FileWatch
    {
        /// <summary>
        /// Gets or sets the path of the file on the filesystem.
        /// </summary>
        public string FilePath;
        /// <summary>
        /// Gets or sets the path of the file in the loaded addon.
        /// </summary>
        public string ContentPath;
        /// <summary>
        /// Gets or sets whether the file is modified externally.
        /// </summary>
        public bool Modified;
        /// <summary>
        /// The integrated System.IO.FileSystemWatcher object.
        /// </summary>
        public FileSystemWatcher Watcher;
    }
    
    /// <summary>
    /// Encapsulates an Addon and provides the extended "realtime" functionality over it.
    /// </summary>
    class RealtimeAddon
    {
        /// <summary>
        /// The addon handled by the current RealtimeAddon instance.
        /// </summary>
        public Addon OpenAddon { get; private set; }
        /// <summary>
        /// The file handle of the current open addon.
        /// </summary>
        private FileStream AddonStream;
        /// <summary>
        /// Gets the file path of the addon on the local filesystem.
        /// </summary>
        public string AddonPath { get { return AddonStream.Name; } }
        /// <summary>
        /// Gets whether the current addon is modified (the state in memory differs from the state of the filestream).
        /// </summary>
        public bool Modified { get; private set; }
        /// <summary>
        /// Gets whether there are changed exported files.
        /// </summary>
        public bool Pullable { get; private set; }
        /// <summary>
        /// Contains the exported files.
        /// </summary>
        public List<FileWatch> WatchedFiles { get; private set; }

        /// <summary>
        /// Loads the specified addon from the local filesystem and encapsulates it within a realtime instance.
        /// </summary>
        /// <param name="filename">The path to the file on the local filesystem.</param>
        /// <returns>A RealtimeAddon instance.</returns>
        /// <exception cref="FileNotFoundException">Happens if the specified file does not exist.</exception>
        /// <exception cref="IOException">Thrown if there is a problem opening the specified file.</exception>
        /// <exception cref="ReaderException">Thrown if the addon reader and parser encounters an error.</exception>
        /// <exception cref="ArgumentException">Happens if a file with the same path is already added.</exception>
        /// <exception cref="WhitelistException">There is a file prohibited from storing by the global whitelist.</exception>
        /// <exception cref="IgnoredException">There is a file prohibited from storing by the addon's ignore list.</exception>
        static public RealtimeAddon Load(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The specified file " + filename + " does not exist.");
            }

            FileStream fs;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException e)
            {
                throw e;
            }

            Reader r;
            try
            {
                r = new Reader(fs);
            }
            catch (IOException e)
            {
                throw e;
            }
            catch (ReaderException e)
            {
                throw e;
            }

            Addon addon;
            try
            {
                addon = new Addon(r);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (WhitelistException e)
            {
                throw e;
            }
            catch (IgnoredException e)
            {
                throw e;
            }

            RealtimeAddon realtime = new RealtimeAddon(addon, fs);
            return realtime;
        }

        /// <summary>
        /// Creates a new, empty addon and encapsulates it within a realtime instance.
        /// </summary>
        /// <param name="filename">The path of the addon file to create.</param>
        /// <returns>A RealtimeAddon instance.</returns>
        /// <exception cref="UnauthorizedAccessException">The specified file already exists on the local filesystem.</exception>
        /// <exception cref="IOException">There was an error creating a specified file.</exception>
        static public RealtimeAddon New(string filename)
        {
            if (File.Exists(filename))
            {
                throw new UnauthorizedAccessException("The file already exists.");
            }

            if (Path.GetExtension(filename) != "gma")
            {
                filename = Path.GetFileNameWithoutExtension(filename);
                filename += ".gma";
            }

            FileStream fs;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException e)
            {
                throw e;
            }

            Addon addon = new Addon();

            RealtimeAddon realtime = new RealtimeAddon(addon, fs);
            return realtime;
        }

        /// <summary>
        /// Private constructor setting up references and default values.
        /// </summary>
        private RealtimeAddon()
        {
            WatchedFiles = new List<FileWatch>();
            Modified = false;
            Pullable = false;
        }

        /// <summary>
        /// Creates the RealtimeAddon instance with the specified Addon to encapsulate and the FileStream pointing to the
        /// local filesystem. This method cannot be called externally.
        /// </summary>
        /// <param name="addon">The addon to encapsulate.</param>
        /// <param name="stream">The FileStream pointing to the GMA file on the local filesystem.</param>
        protected RealtimeAddon(Addon addon, FileStream stream)
            : this()
        {
            OpenAddon = addon;
            AddonStream = stream;
        }

        /// <summary>
        /// Adds the specified file from the local filesystem to the encapsulated addon.
        /// </summary>
        /// <param name="filename">The path of the file to add.</param>
        /// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
        /// <exception cref="IOException">Thrown if a problem happens with opening the file.</exception>
        /// <exception cref="ArgumentException">Happens if a file with the same path is already added.</exception>
        /// <exception cref="WhitelistException">The file is prohibited from storing by the global whitelist.</exception>
        /// <exception cref="IgnoredException">The file is prohibited from storing by the addon's ignore list.</exception>
        public void AddFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The specified file " + filename + " does not exist.");
            }

            byte[] bytes;

            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, (int)fs.Length);
                }
            }
            catch(IOException e)
            {
                throw e;
            }

            AddFile(Whitelist.GetMatchingString(filename), bytes);
        }

        /// <summary>
        /// Adds an array of bytes to the encapsulated addon using the specified internal path.
        /// </summary>
        /// <param name="path">The path which the file should be added as.</param>
        /// <param name="content">The array of bytes containing the actual content.</param>
        /// <exception cref="ArgumentException">Happens if a file with the same path is already added.</exception>
        /// <exception cref="WhitelistException">The file is prohibited from storing by the global whitelist.</exception>
        /// <exception cref="IgnoredException">The file is prohibited from storing by the addon's ignore list.</exception>
        public void AddFile(string path, byte[] content)
        {
            try
            {
                OpenAddon.AddFile(path, content);
            }
            catch (IgnoredException e)
            {
                throw e;
            }
            catch (WhitelistException e)
            {
                throw e;
            }
            catch (ArgumentException e)
            {
                throw e;
            }

            Modified = true;
        }

        /// <summary>
        /// Removes the specified file from the encapsulated addon.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
        public void RemoveFile(string path)
        {
            try
            {
                OpenAddon.RemoveFile(path);
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }

            Modified = true;
        }

        /// <summary>
        /// Extracts a file from the encapsulated addon and saves it on the local filesystem.
        /// </summary>
        /// <param name="path">The path of the file within the addon to extract.</param>
        /// <param name="to">The path on the local filesystem where the file should be saved. If omitted,
        /// the file will be extracted to the application's current working directory.</param>
        /// <exception cref="FileNotFoundException">Thrown if the specified file does not exist within the addon.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown if a file already exists at the specified extract location.</exception>
        /// <exception cref="IOException">Thrown if there was a problem creating the extracted file.</exception>
        public void ExtractFile(string path, string to = null)
        {
            if (to == null || to == String.Empty)
            {
                to = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Path.GetFileName(path);
            }
            else
            {
                string dir = Path.GetDirectoryName(to);

                if (dir == String.Empty)
                {
                    to = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Path.GetFileName(to);
                }
            }

            ContentFile file = null;
            try
            {
                file = OpenAddon.Files.Where(f => f.Path == path).First();
            }
            catch(InvalidOperationException)
            {
                throw new FileNotFoundException("The specified file " + path + " does not exist in the addon.");
            }

            if (File.Exists(to))
            {
                throw new UnauthorizedAccessException("A file at " + to + " already exists.");
            }

            FileStream extract;
            try
            {
                extract = new FileStream(to, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException e)
            {
                throw e;
            }

            extract.Write(file.Content, 0, (int)file.Size);
            extract.Flush();
            extract.Dispose();
        }

        /// <summary>
        /// Saves the specified file on the local filesystem and sets up a notifier FileWatch object
        /// to let the application keep track of the changes in the saved file.
        /// </summary>
        /// <param name="path">The path of the file within the addon to extract.</param>
        /// <param name="to">The path on the local filesystem where the file should be saved. If omitted,
        /// the file will be extracted to the application's current working directory.</param>
        /// <exception cref="FileNotFoundException">Thrown if the specified file does not exist within the addon.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown if a file already exists at the specified extract location.</exception>
        /// <exception cref="IOException">Thrown if there was a problem creating the extracted file.</exception>
        public void ExportFile(string path, string to)
        {
            if (to == null || to == String.Empty)
            {
                to = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Path.GetFileName(path);
            }
            else
            {
                string dir = Path.GetDirectoryName(to);

                if (dir == String.Empty)
                {
                    to = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + Path.GetFileName(to);
                }
            }

            try
            {
                ExtractFile(path, to);
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (UnauthorizedAccessException e)
            {
                throw e;
            }
            catch (IOException e)
            {
                throw e;
            }

            FileSystemWatcher fsw = new FileSystemWatcher(Path.GetDirectoryName(to), Path.GetFileName(to));
            fsw.NotifyFilter = NotifyFilters.LastWrite;
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.EnableRaisingEvents = true;

            FileWatch watch = new FileWatch();
            watch.FilePath = to;
            watch.ContentPath = path;
            watch.Watcher = fsw;

            WatchedFiles.Add(watch);
        }

        /// <summary>
        /// Fires if an exported file is changed on the local filesystem.
        /// </summary>
        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            FileWatch watch = null;
            try
            {
                watch = WatchedFiles.Where(f => f.FilePath == e.FullPath).First();
            }
            catch (InvalidOperationException)
            {
                // The watch for the file was removed earlier but the Watcher remained there.
                // This should not happen. But better safe than sorry.
                ((FileSystemWatcher)sender).Dispose();
            }

            if (OpenAddon.Files.Where(f => f.Path == watch.ContentPath).Count() == 1)
            {
                watch.Modified = true;
                Pullable = true;
            }
            else
            {
                // The file we exported and watched no longer exists in the addon.
                WatchedFiles.Remove(watch);
                ((FileSystemWatcher)sender).Dispose();
            }
        }

        /// <summary>
        /// Deletes the export of the specified file from the local filesystem and stops watching the changes.
        /// </summary>
        /// <param name="filename">The path of the file within the addon to be dropped.</param>
        /// <exception cref="FileNotFoundException">Thrown if the file does not exist within the addon.</exception>
        /// <exception cref="IOException">Thrown if there was a problem deleting the file from the local filesystem.</exception>
        public void DropExport(string path)
        {
            FileWatch watch;
            try
            {
                watch = WatchedFiles.Where(f => f.ContentPath == path).First();
            }
            catch (InvalidOperationException)
            {
                throw new FileNotFoundException("There is no export for " + path);
            }
            
            watch.Watcher.Dispose();
            WatchedFiles.Remove(watch);

            try
            {
                File.Delete(watch.FilePath);
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Updates the encapsulated addon object's file entry with the changes of a previously exported file.
        /// </summary>
        /// <param name="path">The path of the file within the addon to pull the changes for.</param>
        /// <exception cref="FileNotFoundException">Thrown if the specified path does not correspond to an export.</exception>
        /// <exception cref="IOException">Thrown if there was a problem opening the exported file.</exception>
        public void Pull(string path)
        {
            FileWatch search = null;
            try
            {
                search = WatchedFiles.Where(f => f.ContentPath == path).First();
            }
            catch (InvalidOperationException)
            {
                throw new FileNotFoundException("There is no export for " + path);
            }


            if (search.Modified == false)
            {
                return;
            }

            ContentFile content = null;
            try
            {
                content = OpenAddon.Files.Where(f => f.Path == search.ContentPath).First();
            }
            catch (InvalidOperationException)
            {
                // The file we exported and watched no longer exists in the addon.
                WatchedFiles.Remove(search);
                search.Watcher.Dispose();
            }


            FileStream fs;
            try
            {
                fs = new FileStream(search.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch (IOException e)
            {
                throw e;
            }

            byte[] contBytes = new byte[fs.Length];
            fs.Read(contBytes, 0, (int)fs.Length);

            content.Content = contBytes;

            fs.Close();
            fs.Dispose();

            search.Modified = false; // The exported file is no longer modified
            Modified = true; // But the addon itself is
        }

        /// <summary>
        /// Saves the changes of the encapsulated addon to its file stream.
        /// </summary>
        public void Save()
        {
            OpenAddon.Sort();
            Writer.Create(OpenAddon, AddonStream);

            Modified = false;
        }

        /// <summary>
        /// Closes all connections of the current RealtimeAddon instance.
        /// This does NOT save the changes of the encapsulated addon!
        /// </summary>
        public void Close()
        {
            foreach (FileWatch watch in WatchedFiles)
            {
                watch.Watcher.Dispose();
            }
            WatchedFiles.Clear();

            AddonStream.Close();
            AddonStream.Dispose();

            OpenAddon.Files.Clear();
            OpenAddon = null;
        }

        /// <summary>
        /// Helps the garbage collector free all resources managed by this instance.
        /// Identical to calling Close();
        /// </summary>
        ~RealtimeAddon()
        {
            Close();
        }
    }
}