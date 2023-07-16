﻿namespace LInjector
{
    partial class application
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
            System.Windows.Forms.Button EditButton;
            System.Windows.Forms.Button FileButton;
            System.Windows.Forms.Button LInjectorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(application));
            this.EditStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.CopyTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimapTool = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.OpenFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.titlebar = new System.Windows.Forms.Panel();
            this.titleDialog = new System.Windows.Forms.Panel();
            this.menuSettings = new System.Windows.Forms.Panel();
            this.infSettings = new System.Windows.Forms.Button();
            this.ClearTB = new System.Windows.Forms.Button();
            this.controlmenu = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.Panel();
            this.execinjPanel = new System.Windows.Forms.Panel();
            this.fileNameString = new System.Windows.Forms.Button();
            this.terminalPanel = new System.Windows.Forms.Panel();
            this.githubPanel = new System.Windows.Forms.Panel();
            this.dscPanel = new System.Windows.Forms.Panel();
            this.Attach = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.holder = new System.Windows.Forms.Panel();
            this.TabsPanel = new System.Windows.Forms.Panel();
            this.OpenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalButton = new System.Windows.Forms.PictureBox();
            this.githubButton = new System.Windows.Forms.PictureBox();
            this.dscButton = new System.Windows.Forms.PictureBox();
            this.LInjectorIcon = new System.Windows.Forms.PictureBox();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            EditButton = new System.Windows.Forms.Button();
            FileButton = new System.Windows.Forms.Button();
            LInjectorLabel = new System.Windows.Forms.Button();
            this.EditStrip.SuspendLayout();
            this.FileStrip.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.titleDialog.SuspendLayout();
            this.menuSettings.SuspendLayout();
            this.controlmenu.SuspendLayout();
            this.icon.SuspendLayout();
            this.execinjPanel.SuspendLayout();
            this.terminalPanel.SuspendLayout();
            this.githubPanel.SuspendLayout();
            this.dscPanel.SuspendLayout();
            this.holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terminalButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LInjectorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.AutoEllipsis = true;
            EditButton.BackColor = System.Drawing.Color.Transparent;
            EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            EditButton.ContextMenuStrip = this.EditStrip;
            EditButton.Dock = System.Windows.Forms.DockStyle.Left;
            EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            EditButton.ForeColor = System.Drawing.Color.White;
            EditButton.Location = new System.Drawing.Point(147, 0);
            EditButton.Name = "EditButton";
            EditButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            EditButton.Size = new System.Drawing.Size(53, 29);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit";
            EditButton.UseMnemonic = false;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditButton_Click);
            // 
            // EditStrip
            // 
            this.EditStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EditStrip.Depth = 0;
            this.EditStrip.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.EditStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTool,
            this.ReloadTool,
            this.MinimapTool});
            this.EditStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditStrip.Name = "FileStrip";
            this.EditStrip.ShowCheckMargin = true;
            this.EditStrip.ShowImageMargin = false;
            this.EditStrip.Size = new System.Drawing.Size(218, 76);
            // 
            // CopyTool
            // 
            this.CopyTool.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.CopyTool.Name = "CopyTool";
            this.CopyTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.CopyTool.ShowShortcutKeys = false;
            this.CopyTool.Size = new System.Drawing.Size(217, 24);
            this.CopyTool.Text = "Copy TextBox";
            this.CopyTool.ToolTipText = "Copy the current tab editor text.";
            this.CopyTool.Click += new System.EventHandler(this.copyTextbox_Click);
            // 
            // ReloadTool
            // 
            this.ReloadTool.Name = "ReloadTool";
            this.ReloadTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ReloadTool.ShowShortcutKeys = false;
            this.ReloadTool.Size = new System.Drawing.Size(217, 24);
            this.ReloadTool.Text = "Reload LInjector";
            this.ReloadTool.ToolTipText = "Reload LInjector Application";
            this.ReloadTool.Click += new System.EventHandler(this.reloadApp_Click);
            // 
            // MinimapTool
            // 
            this.MinimapTool.Name = "MinimapTool";
            this.MinimapTool.Size = new System.Drawing.Size(217, 24);
            this.MinimapTool.Text = "Toggle Editor Minimap";
            this.MinimapTool.Click += new System.EventHandler(this.ToggleMinimap_Click);
            // 
            // FileButton
            // 
            FileButton.AutoEllipsis = true;
            FileButton.BackColor = System.Drawing.Color.Transparent;
            FileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            FileButton.ContextMenuStrip = this.FileStrip;
            FileButton.Dock = System.Windows.Forms.DockStyle.Left;
            FileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            FileButton.FlatAppearance.BorderSize = 0;
            FileButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            FileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            FileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FileButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            FileButton.ForeColor = System.Drawing.Color.White;
            FileButton.Location = new System.Drawing.Point(94, 0);
            FileButton.Name = "FileButton";
            FileButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            FileButton.Size = new System.Drawing.Size(53, 29);
            FileButton.TabIndex = 6;
            FileButton.Text = "File";
            FileButton.UseMnemonic = false;
            FileButton.UseVisualStyleBackColor = false;
            FileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileButton_MouseClick);
            // 
            // FileStrip
            // 
            this.FileStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FileStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FileStrip.Depth = 0;
            this.FileStrip.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.FileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileTool,
            this.SaveFileTool});
            this.FileStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileStrip.Name = "FileStrip";
            this.FileStrip.ShowCheckMargin = true;
            this.FileStrip.ShowImageMargin = false;
            this.FileStrip.Size = new System.Drawing.Size(138, 52);
            // 
            // OpenFileTool
            // 
            this.OpenFileTool.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.OpenFileTool.Name = "OpenFileTool";
            this.OpenFileTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileTool.ShowShortcutKeys = false;
            this.OpenFileTool.Size = new System.Drawing.Size(137, 24);
            this.OpenFileTool.Text = "Open file";
            this.OpenFileTool.ToolTipText = "Open file and load it into editor.";
            this.OpenFileTool.Click += new System.EventHandler(this.openFile_Click);
            // 
            // SaveFileTool
            // 
            this.SaveFileTool.Name = "SaveFileTool";
            this.SaveFileTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFileTool.ShowShortcutKeys = false;
            this.SaveFileTool.Size = new System.Drawing.Size(137, 24);
            this.SaveFileTool.Text = "Save to file";
            this.SaveFileTool.ToolTipText = "Save the editor content into a script file.";
            this.SaveFileTool.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // LInjectorLabel
            // 
            LInjectorLabel.BackColor = System.Drawing.Color.Transparent;
            LInjectorLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            LInjectorLabel.Dock = System.Windows.Forms.DockStyle.Left;
            LInjectorLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            LInjectorLabel.FlatAppearance.BorderSize = 0;
            LInjectorLabel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            LInjectorLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            LInjectorLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            LInjectorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LInjectorLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            LInjectorLabel.ForeColor = System.Drawing.Color.White;
            LInjectorLabel.Location = new System.Drawing.Point(10, 0);
            LInjectorLabel.Name = "LInjectorLabel";
            LInjectorLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            LInjectorLabel.Size = new System.Drawing.Size(84, 29);
            LInjectorLabel.TabIndex = 6;
            LInjectorLabel.Text = "LInjector";
            LInjectorLabel.UseMnemonic = false;
            LInjectorLabel.UseVisualStyleBackColor = false;
            LInjectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LInjectorLabel_MouseDown);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.titlebar.Controls.Add(this.titleDialog);
            this.titlebar.Controls.Add(this.controlmenu);
            this.titlebar.Controls.Add(this.icon);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(5, 5);
            this.titlebar.Margin = new System.Windows.Forms.Padding(10);
            this.titlebar.Name = "titlebar";
            this.titlebar.Padding = new System.Windows.Forms.Padding(3);
            this.titlebar.Size = new System.Drawing.Size(990, 35);
            this.titlebar.TabIndex = 4;
            // 
            // titleDialog
            // 
            this.titleDialog.BackColor = System.Drawing.Color.Transparent;
            this.titleDialog.Controls.Add(this.menuSettings);
            this.titleDialog.Controls.Add(this.ClearTB);
            this.titleDialog.Controls.Add(EditButton);
            this.titleDialog.Controls.Add(FileButton);
            this.titleDialog.Controls.Add(LInjectorLabel);
            this.titleDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleDialog.Location = new System.Drawing.Point(32, 3);
            this.titleDialog.Name = "titleDialog";
            this.titleDialog.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titleDialog.Size = new System.Drawing.Size(865, 29);
            this.titleDialog.TabIndex = 6;
            this.titleDialog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleDialog_MouseDown);
            // 
            // menuSettings
            // 
            this.menuSettings.Controls.Add(this.infSettings);
            this.menuSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSettings.Location = new System.Drawing.Point(311, 0);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Padding = new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.menuSettings.Size = new System.Drawing.Size(544, 29);
            this.menuSettings.TabIndex = 9;
            this.menuSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuSettings_MouseDown);
            // 
            // infSettings
            // 
            this.infSettings.BackColor = System.Drawing.Color.Transparent;
            this.infSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.infSettings.FlatAppearance.BorderSize = 0;
            this.infSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.infSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.infSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infSettings.Location = new System.Drawing.Point(10, 1);
            this.infSettings.Name = "infSettings";
            this.infSettings.Size = new System.Drawing.Size(524, 27);
            this.infSettings.TabIndex = 0;
            this.infSettings.Text = ". . .";
            this.infSettings.UseVisualStyleBackColor = false;
            this.infSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.infSettings_MouseDown);
            // 
            // ClearTB
            // 
            this.ClearTB.BackColor = System.Drawing.Color.Transparent;
            this.ClearTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClearTB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearTB.FlatAppearance.BorderSize = 0;
            this.ClearTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClearTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClearTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.ClearTB.ForeColor = System.Drawing.Color.White;
            this.ClearTB.Location = new System.Drawing.Point(200, 0);
            this.ClearTB.Name = "ClearTB";
            this.ClearTB.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ClearTB.Size = new System.Drawing.Size(111, 29);
            this.ClearTB.TabIndex = 8;
            this.ClearTB.Text = "Clear TextBox";
            this.ClearTB.UseMnemonic = false;
            this.ClearTB.UseVisualStyleBackColor = false;
            this.ClearTB.Click += new System.EventHandler(this.ClearTB_Click);
            // 
            // controlmenu
            // 
            this.controlmenu.Controls.Add(this.CloseButton);
            this.controlmenu.Controls.Add(this.Maximize);
            this.controlmenu.Controls.Add(this.Minimize);
            this.controlmenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlmenu.Location = new System.Drawing.Point(897, 3);
            this.controlmenu.Name = "controlmenu";
            this.controlmenu.Size = new System.Drawing.Size(90, 29);
            this.controlmenu.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(58, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 29);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "❌";
            this.CloseButton.UseMnemonic = false;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Maximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize.ForeColor = System.Drawing.Color.Transparent;
            this.Maximize.Location = new System.Drawing.Point(29, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(29, 29);
            this.Maximize.TabIndex = 1;
            this.Maximize.Text = "▢";
            this.Maximize.UseMnemonic = false;
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Transparent;
            this.Minimize.Location = new System.Drawing.Point(0, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 29);
            this.Minimize.TabIndex = 0;
            this.Minimize.Text = "—";
            this.Minimize.UseMnemonic = false;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // icon
            // 
            this.icon.Controls.Add(this.LInjectorIcon);
            this.icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(29, 29);
            this.icon.TabIndex = 0;
            // 
            // execinjPanel
            // 
            this.execinjPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.execinjPanel.Controls.Add(this.fileNameString);
            this.execinjPanel.Controls.Add(this.terminalPanel);
            this.execinjPanel.Controls.Add(this.githubPanel);
            this.execinjPanel.Controls.Add(this.dscPanel);
            this.execinjPanel.Controls.Add(this.Attach);
            this.execinjPanel.Controls.Add(this.Execute);
            this.execinjPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.execinjPanel.Location = new System.Drawing.Point(5, 40);
            this.execinjPanel.Name = "execinjPanel";
            this.execinjPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.execinjPanel.Size = new System.Drawing.Size(990, 28);
            this.execinjPanel.TabIndex = 7;
            this.execinjPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.execinjPanel_MouseDown);
            // 
            // fileNameString
            // 
            this.fileNameString.AutoSize = true;
            this.fileNameString.Dock = System.Windows.Forms.DockStyle.Right;
            this.fileNameString.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fileNameString.FlatAppearance.BorderSize = 0;
            this.fileNameString.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fileNameString.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fileNameString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileNameString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameString.Location = new System.Drawing.Point(753, 0);
            this.fileNameString.Name = "fileNameString";
            this.fileNameString.Size = new System.Drawing.Size(150, 28);
            this.fileNameString.TabIndex = 12;
            this.fileNameString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileNameString.UseVisualStyleBackColor = true;
            this.fileNameString.Visible = false;
            // 
            // terminalPanel
            // 
            this.terminalPanel.Controls.Add(this.terminalButton);
            this.terminalPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.terminalPanel.Location = new System.Drawing.Point(903, 0);
            this.terminalPanel.Name = "terminalPanel";
            this.terminalPanel.Padding = new System.Windows.Forms.Padding(5);
            this.terminalPanel.Size = new System.Drawing.Size(28, 28);
            this.terminalPanel.TabIndex = 11;
            // 
            // githubPanel
            // 
            this.githubPanel.Controls.Add(this.githubButton);
            this.githubPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.githubPanel.Location = new System.Drawing.Point(931, 0);
            this.githubPanel.Name = "githubPanel";
            this.githubPanel.Padding = new System.Windows.Forms.Padding(5);
            this.githubPanel.Size = new System.Drawing.Size(28, 28);
            this.githubPanel.TabIndex = 5;
            // 
            // dscPanel
            // 
            this.dscPanel.Controls.Add(this.dscButton);
            this.dscPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dscPanel.Location = new System.Drawing.Point(959, 0);
            this.dscPanel.Name = "dscPanel";
            this.dscPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dscPanel.Size = new System.Drawing.Size(28, 28);
            this.dscPanel.TabIndex = 4;
            // 
            // Attach
            // 
            this.Attach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Attach.Dock = System.Windows.Forms.DockStyle.Left;
            this.Attach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Attach.FlatAppearance.BorderSize = 0;
            this.Attach.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Attach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Attach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attach.ForeColor = System.Drawing.Color.Transparent;
            this.Attach.Location = new System.Drawing.Point(32, 0);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(29, 28);
            this.Attach.TabIndex = 10;
            this.Attach.Text = "🧩";
            this.Attach.UseMnemonic = false;
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // Execute
            // 
            this.Execute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Execute.Dock = System.Windows.Forms.DockStyle.Left;
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Execute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Location = new System.Drawing.Point(3, 0);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(29, 28);
            this.Execute.TabIndex = 10;
            this.Execute.Text = "▶";
            this.Execute.UseMnemonic = false;
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // holder
            // 
            this.holder.Controls.Add(this.materialExpansionPanel1);
            this.holder.Controls.Add(this.TabsPanel);
            this.holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holder.Location = new System.Drawing.Point(5, 68);
            this.holder.Name = "holder";
            this.holder.Padding = new System.Windows.Forms.Padding(5);
            this.holder.Size = new System.Drawing.Size(990, 427);
            this.holder.TabIndex = 8;
            // 
            // TabsPanel
            // 
            this.TabsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsPanel.Location = new System.Drawing.Point(5, 5);
            this.TabsPanel.Name = "TabsPanel";
            this.TabsPanel.Size = new System.Drawing.Size(980, 417);
            this.TabsPanel.TabIndex = 0;
            // 
            // OpenTool
            // 
            this.OpenTool.Name = "OpenTool";
            this.OpenTool.Size = new System.Drawing.Size(32, 19);
            // 
            // SaveTool
            // 
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(32, 19);
            // 
            // terminalButton
            // 
            this.terminalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalButton.Image = global::LInjector.Properties.Resources.terminal_icon;
            this.terminalButton.Location = new System.Drawing.Point(5, 5);
            this.terminalButton.Name = "terminalButton";
            this.terminalButton.Size = new System.Drawing.Size(18, 18);
            this.terminalButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.terminalButton.TabIndex = 0;
            this.terminalButton.TabStop = false;
            this.terminalButton.Click += new System.EventHandler(this.terminalButton_Click);
            this.terminalButton.MouseEnter += new System.EventHandler(this.terminalButton_MouseEnter);
            this.terminalButton.MouseLeave += new System.EventHandler(this.terminalButton_MouseLeave);
            // 
            // githubButton
            // 
            this.githubButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.githubButton.Image = global::LInjector.Properties.Resources.github_mark_white;
            this.githubButton.Location = new System.Drawing.Point(5, 5);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(18, 18);
            this.githubButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.githubButton.TabIndex = 0;
            this.githubButton.TabStop = false;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            this.githubButton.MouseEnter += new System.EventHandler(this.githubButton_MouseEnter);
            this.githubButton.MouseLeave += new System.EventHandler(this.githubButton_MouseLeave);
            // 
            // dscButton
            // 
            this.dscButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dscButton.Image = global::LInjector.Properties.Resources.discord_icon;
            this.dscButton.Location = new System.Drawing.Point(5, 5);
            this.dscButton.Name = "dscButton";
            this.dscButton.Size = new System.Drawing.Size(18, 18);
            this.dscButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dscButton.TabIndex = 0;
            this.dscButton.TabStop = false;
            this.dscButton.Click += new System.EventHandler(this.dscButton_Click);
            this.dscButton.MouseEnter += new System.EventHandler(this.dscButton_MouseEnter);
            this.dscButton.MouseLeave += new System.EventHandler(this.dscButton_MouseLeave);
            // 
            // LInjectorIcon
            // 
            this.LInjectorIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.LInjectorIcon.Image = global::LInjector.Properties.Resources.LInjector;
            this.LInjectorIcon.Location = new System.Drawing.Point(0, 0);
            this.LInjectorIcon.Name = "LInjectorIcon";
            this.LInjectorIcon.Size = new System.Drawing.Size(29, 29);
            this.LInjectorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LInjectorIcon.TabIndex = 0;
            this.LInjectorIcon.TabStop = false;
            this.LInjectorIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LInjectorIcon_MouseDown);
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(451, 0);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(480, 240);
            this.materialExpansionPanel1.TabIndex = 13;
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.holder);
            this.Controls.Add(this.execinjPanel);
            this.Controls.Add(this.titlebar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "application";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Load += new System.EventHandler(this.application_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.application_MouseDown);
            this.EditStrip.ResumeLayout(false);
            this.FileStrip.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.titleDialog.ResumeLayout(false);
            this.menuSettings.ResumeLayout(false);
            this.controlmenu.ResumeLayout(false);
            this.icon.ResumeLayout(false);
            this.execinjPanel.ResumeLayout(false);
            this.execinjPanel.PerformLayout();
            this.terminalPanel.ResumeLayout(false);
            this.githubPanel.ResumeLayout(false);
            this.dscPanel.ResumeLayout(false);
            this.holder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.terminalButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LInjectorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.PictureBox LInjectorIcon;
        private System.Windows.Forms.Panel controlmenu;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel titleDialog;
        private System.Windows.Forms.Button ClearTB;
        private System.Windows.Forms.Panel execinjPanel;
        protected System.Windows.Forms.Panel holder;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Panel menuSettings;
        private System.Windows.Forms.Button infSettings;
        private System.Windows.Forms.Panel dscPanel;
        private System.Windows.Forms.PictureBox dscButton;
        private System.Windows.Forms.Panel githubPanel;
        private System.Windows.Forms.PictureBox githubButton;
        private System.Windows.Forms.Panel terminalPanel;
        private System.Windows.Forms.PictureBox terminalButton;
        private System.Windows.Forms.Panel TabsPanel;
        public System.Windows.Forms.Button fileNameString;
        private System.Windows.Forms.ToolStripMenuItem OpenTool;
        private System.Windows.Forms.ToolStripMenuItem SaveTool;
        private MaterialSkin.Controls.MaterialContextMenuStrip FileStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenFileTool;
        private System.Windows.Forms.ToolStripMenuItem SaveFileTool;
        private MaterialSkin.Controls.MaterialContextMenuStrip EditStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyTool;
        private System.Windows.Forms.ToolStripMenuItem ReloadTool;
        private System.Windows.Forms.ToolStripMenuItem MinimapTool;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
    }
}