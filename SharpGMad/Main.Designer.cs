﻿namespace SharpGMad
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstFiles = new System.Windows.Forms.ListView();
            this.ofdAddon = new System.Windows.Forms.OpenFileDialog();
            this.tsFileOperations = new System.Windows.Forms.ToolStrip();
            this.tsbAddFile = new System.Windows.Forms.ToolStripButton();
            this.tssExportHeaderSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPullAll = new System.Windows.Forms.ToolStripButton();
            this.tsbDropAll = new System.Windows.Forms.ToolStripButton();
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.pnlFilelist = new System.Windows.Forms.Panel();
            this.pnlFileOpsToolbar = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlRightSide = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tsMetadata = new System.Windows.Forms.ToolStrip();
            this.tsbUpdateMetadata = new System.Windows.Forms.ToolStripButton();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbCreateAddon = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenAddon = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAddon = new System.Windows.Forms.ToolStripButton();
            this.tssAddonSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbLegacy = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLegacyCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLegacyExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdAddFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdAddon = new System.Windows.Forms.SaveFileDialog();
            this.sfdExportFile = new System.Windows.Forms.SaveFileDialog();
            this.tsmFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tssExportSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmFileExportTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFilePull = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileDropExport = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFileEntry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmFileExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdFileExtractMulti = new System.Windows.Forms.FolderBrowserDialog();
            this.tsFileOperations.SuspendLayout();
            this.pnlLeftSide.SuspendLayout();
            this.pnlFilelist.SuspendLayout();
            this.pnlFileOpsToolbar.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlRightSide.SuspendLayout();
            this.tsMetadata.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            this.cmsFileEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(0, 0);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(530, 300);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Tile;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            this.lstFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFiles_KeyDown);
            this.lstFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstFiles_MouseClick);
            // 
            // ofdAddon
            // 
            this.ofdAddon.Filter = "Garry\'s Mod Addons|*.gma";
            this.ofdAddon.Title = "Open addon file";
            // 
            // tsFileOperations
            // 
            this.tsFileOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsFileOperations.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFileOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddFile,
            this.tssExportHeaderSeparator,
            this.tsbPullAll,
            this.tsbDropAll});
            this.tsFileOperations.Location = new System.Drawing.Point(0, 0);
            this.tsFileOperations.Name = "tsFileOperations";
            this.tsFileOperations.Size = new System.Drawing.Size(530, 26);
            this.tsFileOperations.TabIndex = 0;
            // 
            // tsbAddFile
            // 
            this.tsbAddFile.AutoToolTip = false;
            this.tsbAddFile.Enabled = false;
            this.tsbAddFile.Image = global::SharpGMad.Properties.Resources.add;
            this.tsbAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFile.Name = "tsbAddFile";
            this.tsbAddFile.Size = new System.Drawing.Size(68, 23);
            this.tsbAddFile.Text = "Add file";
            this.tsbAddFile.Click += new System.EventHandler(this.tsbAddFile_Click);
            // 
            // tssExportHeaderSeparator
            // 
            this.tssExportHeaderSeparator.Name = "tssExportHeaderSeparator";
            this.tssExportHeaderSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbPullAll
            // 
            this.tsbPullAll.AutoToolTip = false;
            this.tsbPullAll.Enabled = false;
            this.tsbPullAll.Image = global::SharpGMad.Properties.Resources.pull_all;
            this.tsbPullAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPullAll.Name = "tsbPullAll";
            this.tsbPullAll.Size = new System.Drawing.Size(138, 23);
            this.tsbPullAll.Text = "Update exported files";
            this.tsbPullAll.ToolTipText = "Updates all changes from external files into the addon";
            this.tsbPullAll.Click += new System.EventHandler(this.tsbPullAll_Click);
            // 
            // tsbDropAll
            // 
            this.tsbDropAll.AutoToolTip = false;
            this.tsbDropAll.Enabled = false;
            this.tsbDropAll.Image = global::SharpGMad.Properties.Resources.drop;
            this.tsbDropAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDropAll.Name = "tsbDropAll";
            this.tsbDropAll.Size = new System.Drawing.Size(94, 23);
            this.tsbDropAll.Text = "Drop exports";
            this.tsbDropAll.ToolTipText = "Deletes all exported files";
            this.tsbDropAll.Click += new System.EventHandler(this.tsbDropAll_Click);
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.Controls.Add(this.pnlFilelist);
            this.pnlLeftSide.Controls.Add(this.pnlFileOpsToolbar);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(530, 326);
            this.pnlLeftSide.TabIndex = 11;
            // 
            // pnlFilelist
            // 
            this.pnlFilelist.Controls.Add(this.lstFiles);
            this.pnlFilelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilelist.Location = new System.Drawing.Point(0, 26);
            this.pnlFilelist.Name = "pnlFilelist";
            this.pnlFilelist.Size = new System.Drawing.Size(530, 300);
            this.pnlFilelist.TabIndex = 2;
            // 
            // pnlFileOpsToolbar
            // 
            this.pnlFileOpsToolbar.Controls.Add(this.tsFileOperations);
            this.pnlFileOpsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFileOpsToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlFileOpsToolbar.Name = "pnlFileOpsToolbar";
            this.pnlFileOpsToolbar.Size = new System.Drawing.Size(530, 26);
            this.pnlFileOpsToolbar.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlLeftSide);
            this.pnlForm.Controls.Add(this.pnlRightSide);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 25);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(737, 326);
            this.pnlForm.TabIndex = 12;
            // 
            // pnlRightSide
            // 
            this.pnlRightSide.Controls.Add(this.txtDescription);
            this.pnlRightSide.Controls.Add(this.tsMetadata);
            this.pnlRightSide.Controls.Add(this.txtAuthor);
            this.pnlRightSide.Controls.Add(this.lblAuthor);
            this.pnlRightSide.Controls.Add(this.lblDescription);
            this.pnlRightSide.Controls.Add(this.txtTags);
            this.pnlRightSide.Controls.Add(this.lblTags);
            this.pnlRightSide.Controls.Add(this.txtType);
            this.pnlRightSide.Controls.Add(this.lblType);
            this.pnlRightSide.Controls.Add(this.txtTitle);
            this.pnlRightSide.Controls.Add(this.lblTitle);
            this.pnlRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightSide.Location = new System.Drawing.Point(530, 0);
            this.pnlRightSide.Name = "pnlRightSide";
            this.pnlRightSide.Size = new System.Drawing.Size(207, 326);
            this.pnlRightSide.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(20, 184);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(184, 116);
            this.txtDescription.TabIndex = 7;
            // 
            // tsMetadata
            // 
            this.tsMetadata.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMetadata.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUpdateMetadata});
            this.tsMetadata.Location = new System.Drawing.Point(0, 0);
            this.tsMetadata.Name = "tsMetadata";
            this.tsMetadata.Size = new System.Drawing.Size(207, 25);
            this.tsMetadata.TabIndex = 10;
            // 
            // tsbUpdateMetadata
            // 
            this.tsbUpdateMetadata.AutoToolTip = false;
            this.tsbUpdateMetadata.Enabled = false;
            this.tsbUpdateMetadata.Image = global::SharpGMad.Properties.Resources.metadata;
            this.tsbUpdateMetadata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateMetadata.Name = "tsbUpdateMetadata";
            this.tsbUpdateMetadata.Size = new System.Drawing.Size(118, 22);
            this.tsbUpdateMetadata.Text = "Update metadata";
            this.tsbUpdateMetadata.ToolTipText = "Edit the metadata of the addon";
            this.tsbUpdateMetadata.Click += new System.EventHandler(this.tsbUpdateMetadata_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Location = new System.Drawing.Point(20, 74);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(184, 13);
            this.txtAuthor.TabIndex = 9;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 58);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 168);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtTags
            // 
            this.txtTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTags.Location = new System.Drawing.Point(20, 145);
            this.txtTags.Name = "txtTags";
            this.txtTags.ReadOnly = true;
            this.txtTags.Size = new System.Drawing.Size(184, 13);
            this.txtTags.TabIndex = 5;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(6, 129);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 4;
            this.lblTags.Text = "Tags:";
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Location = new System.Drawing.Point(20, 106);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(184, 13);
            this.txtType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(20, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(184, 13);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // tsToolbar
            // 
            this.tsToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCreateAddon,
            this.tsbOpenAddon,
            this.tsbSaveAddon,
            this.tssAddonSeparator,
            this.tsddbLegacy});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(737, 25);
            this.tsToolbar.TabIndex = 13;
            // 
            // tsbCreateAddon
            // 
            this.tsbCreateAddon.AutoToolTip = false;
            this.tsbCreateAddon.Image = global::SharpGMad.Properties.Resources.newaddon;
            this.tsbCreateAddon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateAddon.Name = "tsbCreateAddon";
            this.tsbCreateAddon.Size = new System.Drawing.Size(86, 22);
            this.tsbCreateAddon.Text = "Create new";
            this.tsbCreateAddon.Click += new System.EventHandler(this.tsbCreateAddon_Click);
            // 
            // tsbOpenAddon
            // 
            this.tsbOpenAddon.AutoToolTip = false;
            this.tsbOpenAddon.Image = global::SharpGMad.Properties.Resources.open;
            this.tsbOpenAddon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenAddon.Name = "tsbOpenAddon";
            this.tsbOpenAddon.Size = new System.Drawing.Size(56, 22);
            this.tsbOpenAddon.Text = "Open";
            this.tsbOpenAddon.Click += new System.EventHandler(this.tsbOpenAddon_Click);
            // 
            // tsbSaveAddon
            // 
            this.tsbSaveAddon.AutoToolTip = false;
            this.tsbSaveAddon.Enabled = false;
            this.tsbSaveAddon.Image = global::SharpGMad.Properties.Resources.save;
            this.tsbSaveAddon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAddon.Name = "tsbSaveAddon";
            this.tsbSaveAddon.Size = new System.Drawing.Size(51, 22);
            this.tsbSaveAddon.Text = "Save";
            this.tsbSaveAddon.Click += new System.EventHandler(this.tsbSaveAddon_Click);
            // 
            // tssAddonSeparator
            // 
            this.tssAddonSeparator.Name = "tssAddonSeparator";
            this.tssAddonSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbLegacy
            // 
            this.tsddbLegacy.AutoToolTip = false;
            this.tsddbLegacy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLegacyCreate,
            this.tsmiLegacyExtract});
            this.tsddbLegacy.Image = global::SharpGMad.Properties.Resources.legacy;
            this.tsddbLegacy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLegacy.Name = "tsddbLegacy";
            this.tsddbLegacy.Size = new System.Drawing.Size(132, 22);
            this.tsddbLegacy.Text = "Legacy operations";
            this.tsddbLegacy.ToolTipText = "Access the legacy wrapper windows";
            // 
            // tsmiLegacyCreate
            // 
            this.tsmiLegacyCreate.Image = global::SharpGMad.Properties.Resources.create;
            this.tsmiLegacyCreate.Name = "tsmiLegacyCreate";
            this.tsmiLegacyCreate.Size = new System.Drawing.Size(171, 22);
            this.tsmiLegacyCreate.Text = "Create from folder";
            this.tsmiLegacyCreate.ToolTipText = "Use the legacy method to compile a folder into an addon";
            this.tsmiLegacyCreate.Click += new System.EventHandler(this.tsmiLegacyCreate_Click);
            // 
            // tsmiLegacyExtract
            // 
            this.tsmiLegacyExtract.Image = global::SharpGMad.Properties.Resources.extract;
            this.tsmiLegacyExtract.Name = "tsmiLegacyExtract";
            this.tsmiLegacyExtract.Size = new System.Drawing.Size(171, 22);
            this.tsmiLegacyExtract.Text = "Extract to folder";
            this.tsmiLegacyExtract.ToolTipText = "Use the legacy method to fully unpack an addon to a folder";
            this.tsmiLegacyExtract.Click += new System.EventHandler(this.tsmiLegacyExtract_Click);
            // 
            // ofdAddFile
            // 
            this.ofdAddFile.Title = "Add file";
            // 
            // sfdAddon
            // 
            this.sfdAddon.DefaultExt = "gma";
            this.sfdAddon.Filter = "Garry\'s Mod Addons|*.gma";
            this.sfdAddon.Title = "Create new addon as";
            // 
            // sfdExportFile
            // 
            this.sfdExportFile.Filter = "All files|*.*";
            // 
            // tsmFileRemove
            // 
            this.tsmFileRemove.Image = global::SharpGMad.Properties.Resources.remove;
            this.tsmFileRemove.Name = "tsmFileRemove";
            this.tsmFileRemove.Size = new System.Drawing.Size(138, 22);
            this.tsmFileRemove.Text = "Remove";
            this.tsmFileRemove.Click += new System.EventHandler(this.tsmFileRemove_Click);
            // 
            // tssExportSeparator
            // 
            this.tssExportSeparator.Name = "tssExportSeparator";
            this.tssExportSeparator.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmFileExportTo
            // 
            this.tsmFileExportTo.Enabled = false;
            this.tsmFileExportTo.Image = global::SharpGMad.Properties.Resources.export;
            this.tsmFileExportTo.Name = "tsmFileExportTo";
            this.tsmFileExportTo.Size = new System.Drawing.Size(138, 22);
            this.tsmFileExportTo.Text = "Export to...";
            this.tsmFileExportTo.ToolTipText = "Export the selected file to somewhere on your computer and set up a realtime chan" +
    "ge-watch. Changed files will be purple.";
            this.tsmFileExportTo.Click += new System.EventHandler(this.tsmFileExportTo_Click);
            // 
            // tsmFilePull
            // 
            this.tsmFilePull.Enabled = false;
            this.tsmFilePull.Image = global::SharpGMad.Properties.Resources.pull;
            this.tsmFilePull.Name = "tsmFilePull";
            this.tsmFilePull.Size = new System.Drawing.Size(138, 22);
            this.tsmFilePull.Text = "Update";
            this.tsmFilePull.ToolTipText = "Update this file with the changes from the exported file on your computer";
            this.tsmFilePull.Click += new System.EventHandler(this.tsmFilePull_Click);
            // 
            // tsmFileDropExport
            // 
            this.tsmFileDropExport.Enabled = false;
            this.tsmFileDropExport.Image = global::SharpGMad.Properties.Resources.drop;
            this.tsmFileDropExport.Name = "tsmFileDropExport";
            this.tsmFileDropExport.Size = new System.Drawing.Size(138, 22);
            this.tsmFileDropExport.Text = "Drop extract";
            this.tsmFileDropExport.ToolTipText = "Delete the exported file from your computer";
            this.tsmFileDropExport.Click += new System.EventHandler(this.tsmFileDropExport_Click);
            // 
            // cmsFileEntry
            // 
            this.cmsFileEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileRemove,
            this.tsmFileExtract,
            this.tssExportSeparator,
            this.tsmFileExportTo,
            this.tsmFilePull,
            this.tsmFileDropExport});
            this.cmsFileEntry.Name = "cmsFileEntry";
            this.cmsFileEntry.Size = new System.Drawing.Size(139, 120);
            // 
            // tsmFileExtract
            // 
            this.tsmFileExtract.Enabled = false;
            this.tsmFileExtract.Image = global::SharpGMad.Properties.Resources.extract;
            this.tsmFileExtract.Name = "tsmFileExtract";
            this.tsmFileExtract.Size = new System.Drawing.Size(138, 22);
            this.tsmFileExtract.Text = "Extract";
            this.tsmFileExtract.ToolTipText = "Save the selected file somewhere on your computer";
            this.tsmFileExtract.Click += new System.EventHandler(this.tsmFileExtract_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 351);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.tsToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SharpGMad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.tsFileOperations.ResumeLayout(false);
            this.tsFileOperations.PerformLayout();
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlFilelist.ResumeLayout(false);
            this.pnlFileOpsToolbar.ResumeLayout(false);
            this.pnlFileOpsToolbar.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlRightSide.ResumeLayout(false);
            this.pnlRightSide.PerformLayout();
            this.tsMetadata.ResumeLayout(false);
            this.tsMetadata.PerformLayout();
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            this.cmsFileEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.OpenFileDialog ofdAddon;
        private System.Windows.Forms.ToolStrip tsFileOperations;
        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Panel pnlFilelist;
        private System.Windows.Forms.Panel pnlFileOpsToolbar;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlRightSide;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripButton tsbCreateAddon;
        private System.Windows.Forms.ToolStripButton tsbOpenAddon;
        private System.Windows.Forms.ToolStripButton tsbSaveAddon;
        private System.Windows.Forms.ToolStripSeparator tssAddonSeparator;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLegacy;
        private System.Windows.Forms.ToolStripMenuItem tsmiLegacyCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmiLegacyExtract;
        private System.Windows.Forms.ToolStripButton tsbAddFile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ToolStrip tsMetadata;
        private System.Windows.Forms.ToolStripButton tsbUpdateMetadata;
        private System.Windows.Forms.OpenFileDialog ofdAddFile;
        private System.Windows.Forms.SaveFileDialog sfdAddon;
        private System.Windows.Forms.ToolStripButton tsbPullAll;
        private System.Windows.Forms.SaveFileDialog sfdExportFile;
        private System.Windows.Forms.ToolStripSeparator tssExportHeaderSeparator;
        private System.Windows.Forms.ToolStripButton tsbDropAll;
        private System.Windows.Forms.ToolStripMenuItem tsmFileRemove;
        private System.Windows.Forms.ToolStripSeparator tssExportSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmFileExportTo;
        private System.Windows.Forms.ToolStripMenuItem tsmFilePull;
        private System.Windows.Forms.ToolStripMenuItem tsmFileDropExport;
        private System.Windows.Forms.ContextMenuStrip cmsFileEntry;
        private System.Windows.Forms.ToolStripMenuItem tsmFileExtract;
        private System.Windows.Forms.FolderBrowserDialog fbdFileExtractMulti;





    }
}