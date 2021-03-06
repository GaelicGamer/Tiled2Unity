﻿namespace Tiled2Unity
{
    partial class Tiled2UnityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiled2UnityForm));
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonViewer = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTiledFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnityPackageToProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supportTiledMapEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToTiled2UnityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTiled2UnityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.textBoxExportFolder = new System.Windows.Forms.TextBox();
            this.checkBoxPreferConvexPolygons = new System.Windows.Forms.CheckBox();
            this.buttonObjectTypesXml = new System.Windows.Forms.Button();
            this.textBoxObjectTypesXml = new System.Windows.Forms.TextBox();
            this.buttonClearObjectTypes = new System.Windows.Forms.Button();
            this.checkBoxDepthBuffer = new System.Windows.Forms.CheckBox();
            this.groupBoxAdvancedOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxExportOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelExportOptions = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelScale = new System.Windows.Forms.TableLayoutPanel();
            this.labelScaleDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanelObjectTypes = new System.Windows.Forms.TableLayoutPanel();
            this.labelExportDescription = new System.Windows.Forms.Label();
            this.labelObjectTypesDescription = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.groupBoxReviewExport = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelReviewExport = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxLaunchTip = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.groupBoxAdvancedOptions.SuspendLayout();
            this.groupBoxExportOptions.SuspendLayout();
            this.tableLayoutPanelExportOptions.SuspendLayout();
            this.tableLayoutPanelScale.SuspendLayout();
            this.tableLayoutPanelObjectTypes.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxReviewExport.SuspendLayout();
            this.tableLayoutPanelReviewExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxOutput.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(649, 119);
            this.richTextBoxOutput.TabIndex = 9;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.WordWrap = false;
            this.richTextBoxOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxOutput_LinkClicked);
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFolderBrowser.Location = new System.Drawing.Point(22, 105);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(135, 23);
            this.buttonFolderBrowser.TabIndex = 7;
            this.buttonFolderBrowser.Text = "Export To ...";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.Lavender;
            this.buttonExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonExport.Location = new System.Drawing.Point(3, 43);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(126, 70);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Big Ass Export Button";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonViewer
            // 
            this.buttonViewer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonViewer.Location = new System.Drawing.Point(3, 3);
            this.buttonViewer.Name = "buttonViewer";
            this.buttonViewer.Size = new System.Drawing.Size(126, 34);
            this.buttonViewer.TabIndex = 10;
            this.buttonViewer.Text = "Preview Map";
            this.buttonViewer.UseVisualStyleBackColor = false;
            this.buttonViewer.Click += new System.EventHandler(this.buttonViewer_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(824, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTiledFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openTiledFileToolStripMenuItem
            // 
            this.openTiledFileToolStripMenuItem.Name = "openTiledFileToolStripMenuItem";
            this.openTiledFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openTiledFileToolStripMenuItem.Text = "&Open Tiled File ...";
            this.openTiledFileToolStripMenuItem.Click += new System.EventHandler(this.openTiledFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearOutputWindowToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearOutputWindowToolStripMenuItem
            // 
            this.clearOutputWindowToolStripMenuItem.Name = "clearOutputWindowToolStripMenuItem";
            this.clearOutputWindowToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearOutputWindowToolStripMenuItem.Text = "&Clear Output Window";
            this.clearOutputWindowToolStripMenuItem.Click += new System.EventHandler(this.clearOutputWindowToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnityPackageToProjectToolStripMenuItem,
            this.showHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.supportTiledMapEditorToolStripMenuItem,
            this.donateToTiled2UnityToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutTiled2UnityToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // addUnityPackageToProjectToolStripMenuItem
            // 
            this.addUnityPackageToProjectToolStripMenuItem.Name = "addUnityPackageToProjectToolStripMenuItem";
            this.addUnityPackageToProjectToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.addUnityPackageToProjectToolStripMenuItem.Text = "Import &Unity Package to Project";
            this.addUnityPackageToProjectToolStripMenuItem.Click += new System.EventHandler(this.addUnityPackageToProjectToolStripMenuItem_Click);
            // 
            // showHelpToolStripMenuItem
            // 
            this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.showHelpToolStripMenuItem.Text = "Show Command &Help";
            this.showHelpToolStripMenuItem.Click += new System.EventHandler(this.showHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // supportTiledMapEditorToolStripMenuItem
            // 
            this.supportTiledMapEditorToolStripMenuItem.Name = "supportTiledMapEditorToolStripMenuItem";
            this.supportTiledMapEditorToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.supportTiledMapEditorToolStripMenuItem.Text = "&Support Tiled On Patreon ...";
            this.supportTiledMapEditorToolStripMenuItem.Click += new System.EventHandler(this.supportTiledMapEditorToolStripMenuItem_Click);
            // 
            // donateToTiled2UnityToolStripMenuItem
            // 
            this.donateToTiled2UnityToolStripMenuItem.Name = "donateToTiled2UnityToolStripMenuItem";
            this.donateToTiled2UnityToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.donateToTiled2UnityToolStripMenuItem.Text = "&Donate to Tiled2Unity";
            this.donateToTiled2UnityToolStripMenuItem.Click += new System.EventHandler(this.donateToTiled2UnityToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // aboutTiled2UnityToolStripMenuItem
            // 
            this.aboutTiled2UnityToolStripMenuItem.Name = "aboutTiled2UnityToolStripMenuItem";
            this.aboutTiled2UnityToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.aboutTiled2UnityToolStripMenuItem.Text = "&About Tiled2Unity";
            this.aboutTiled2UnityToolStripMenuItem.Click += new System.EventHandler(this.aboutTiled2UnityToolStripMenuItem_Click);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(87, 9);
            this.labelScale.Name = "labelScale";
            this.labelScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelScale.Size = new System.Drawing.Size(70, 13);
            this.labelScale.TabIndex = 5;
            this.labelScale.Text = "Vertex Scale:";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxScale.Location = new System.Drawing.Point(3, 3);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(94, 20);
            this.textBoxScale.TabIndex = 3;
            this.textBoxScale.Text = "1";
            this.textBoxScale.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxScale_Validating);
            // 
            // textBoxExportFolder
            // 
            this.textBoxExportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExportFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tiled2Unity.Properties.Settings.Default, "LastExportDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxExportFolder.Location = new System.Drawing.Point(163, 106);
            this.textBoxExportFolder.Name = "textBoxExportFolder";
            this.textBoxExportFolder.ReadOnly = true;
            this.textBoxExportFolder.Size = new System.Drawing.Size(621, 20);
            this.textBoxExportFolder.TabIndex = 8;
            this.textBoxExportFolder.Text = global::Tiled2Unity.Properties.Settings.Default.LastExportDirectory;
            // 
            // checkBoxPreferConvexPolygons
            // 
            this.checkBoxPreferConvexPolygons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPreferConvexPolygons.AutoSize = true;
            this.checkBoxPreferConvexPolygons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxPreferConvexPolygons.Checked = global::Tiled2Unity.Properties.Settings.Default.LastPreferConvexPolygons;
            this.checkBoxPreferConvexPolygons.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tiled2Unity.Properties.Settings.Default, "LastPreferConvexPolygons", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxPreferConvexPolygons.Location = new System.Drawing.Point(6, 19);
            this.checkBoxPreferConvexPolygons.Name = "checkBoxPreferConvexPolygons";
            this.checkBoxPreferConvexPolygons.Size = new System.Drawing.Size(326, 17);
            this.checkBoxPreferConvexPolygons.TabIndex = 1;
            this.checkBoxPreferConvexPolygons.Text = "Convex Polygon Colliders (may be overridden with unity:convex)";
            this.checkBoxPreferConvexPolygons.UseVisualStyleBackColor = false;
            this.checkBoxPreferConvexPolygons.CheckedChanged += new System.EventHandler(this.checkBoxPreferConvexPolygons_CheckedChanged);
            // 
            // buttonObjectTypesXml
            // 
            this.buttonObjectTypesXml.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonObjectTypesXml.Location = new System.Drawing.Point(22, 40);
            this.buttonObjectTypesXml.Name = "buttonObjectTypesXml";
            this.buttonObjectTypesXml.Size = new System.Drawing.Size(135, 23);
            this.buttonObjectTypesXml.TabIndex = 4;
            this.buttonObjectTypesXml.Text = "Object Types XML ...";
            this.buttonObjectTypesXml.UseVisualStyleBackColor = true;
            this.buttonObjectTypesXml.Click += new System.EventHandler(this.buttonObjectTypesXml_Click);
            // 
            // textBoxObjectTypesXml
            // 
            this.textBoxObjectTypesXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObjectTypesXml.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tiled2Unity.Properties.Settings.Default, "LastObjectTypeXmlFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxObjectTypesXml.Location = new System.Drawing.Point(3, 6);
            this.textBoxObjectTypesXml.Name = "textBoxObjectTypesXml";
            this.textBoxObjectTypesXml.ReadOnly = true;
            this.textBoxObjectTypesXml.Size = new System.Drawing.Size(495, 20);
            this.textBoxObjectTypesXml.TabIndex = 5;
            this.textBoxObjectTypesXml.Text = global::Tiled2Unity.Properties.Settings.Default.LastObjectTypeXmlFile;
            this.textBoxObjectTypesXml.TextChanged += new System.EventHandler(this.textBoxObjectTypesXml_TextChanged);
            // 
            // buttonClearObjectTypes
            // 
            this.buttonClearObjectTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonClearObjectTypes.Location = new System.Drawing.Point(503, 5);
            this.buttonClearObjectTypes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearObjectTypes.Name = "buttonClearObjectTypes";
            this.buttonClearObjectTypes.Size = new System.Drawing.Size(116, 23);
            this.buttonClearObjectTypes.TabIndex = 6;
            this.buttonClearObjectTypes.Text = "Clear Object Types";
            this.buttonClearObjectTypes.UseVisualStyleBackColor = true;
            this.buttonClearObjectTypes.Click += new System.EventHandler(this.buttonClearObjectTypes_Click);
            // 
            // checkBoxDepthBuffer
            // 
            this.checkBoxDepthBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDepthBuffer.AutoSize = true;
            this.checkBoxDepthBuffer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxDepthBuffer.Checked = global::Tiled2Unity.Properties.Settings.Default.LastDepthBufferEnabled;
            this.checkBoxDepthBuffer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Tiled2Unity.Properties.Settings.Default, "LastDepthBufferEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxDepthBuffer.Location = new System.Drawing.Point(6, 42);
            this.checkBoxDepthBuffer.Name = "checkBoxDepthBuffer";
            this.checkBoxDepthBuffer.Size = new System.Drawing.Size(589, 17);
            this.checkBoxDepthBuffer.TabIndex = 2;
            this.checkBoxDepthBuffer.Text = "Use Depth Buffer (For sprites using SpriteDepthInMap component to draw sprite bel" +
    "ow/above layers based on position.)";
            this.checkBoxDepthBuffer.UseVisualStyleBackColor = false;
            this.checkBoxDepthBuffer.CheckedChanged += new System.EventHandler(this.checkBoxDepthBuffer_CheckedChanged);
            // 
            // groupBoxAdvancedOptions
            // 
            this.groupBoxAdvancedOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdvancedOptions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAdvancedOptions.Controls.Add(this.checkBoxPreferConvexPolygons);
            this.groupBoxAdvancedOptions.Controls.Add(this.checkBoxDepthBuffer);
            this.groupBoxAdvancedOptions.Location = new System.Drawing.Point(7, 68);
            this.groupBoxAdvancedOptions.Name = "groupBoxAdvancedOptions";
            this.groupBoxAdvancedOptions.Size = new System.Drawing.Size(800, 65);
            this.groupBoxAdvancedOptions.TabIndex = 13;
            this.groupBoxAdvancedOptions.TabStop = false;
            this.groupBoxAdvancedOptions.Text = "Advanced Options";
            // 
            // groupBoxExportOptions
            // 
            this.groupBoxExportOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExportOptions.Controls.Add(this.tableLayoutPanelExportOptions);
            this.groupBoxExportOptions.Location = new System.Drawing.Point(7, 139);
            this.groupBoxExportOptions.Name = "groupBoxExportOptions";
            this.groupBoxExportOptions.Size = new System.Drawing.Size(799, 186);
            this.groupBoxExportOptions.TabIndex = 14;
            this.groupBoxExportOptions.TabStop = false;
            this.groupBoxExportOptions.Text = "Export Options";
            // 
            // tableLayoutPanelExportOptions
            // 
            this.tableLayoutPanelExportOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelExportOptions.ColumnCount = 2;
            this.tableLayoutPanelExportOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelExportOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelExportOptions.Controls.Add(this.labelScale, 0, 0);
            this.tableLayoutPanelExportOptions.Controls.Add(this.tableLayoutPanelScale, 1, 0);
            this.tableLayoutPanelExportOptions.Controls.Add(this.buttonObjectTypesXml, 0, 1);
            this.tableLayoutPanelExportOptions.Controls.Add(this.tableLayoutPanelObjectTypes, 1, 1);
            this.tableLayoutPanelExportOptions.Controls.Add(this.labelExportDescription, 1, 4);
            this.tableLayoutPanelExportOptions.Controls.Add(this.buttonFolderBrowser, 0, 3);
            this.tableLayoutPanelExportOptions.Controls.Add(this.textBoxExportFolder, 1, 3);
            this.tableLayoutPanelExportOptions.Controls.Add(this.labelObjectTypesDescription, 1, 2);
            this.tableLayoutPanelExportOptions.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanelExportOptions.Name = "tableLayoutPanelExportOptions";
            this.tableLayoutPanelExportOptions.RowCount = 5;
            this.tableLayoutPanelExportOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042F));
            this.tableLayoutPanelExportOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958F));
            this.tableLayoutPanelExportOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelExportOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelExportOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelExportOptions.Size = new System.Drawing.Size(787, 161);
            this.tableLayoutPanelExportOptions.TabIndex = 0;
            // 
            // tableLayoutPanelScale
            // 
            this.tableLayoutPanelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelScale.ColumnCount = 2;
            this.tableLayoutPanelScale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelScale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelScale.Controls.Add(this.textBoxScale, 0, 0);
            this.tableLayoutPanelScale.Controls.Add(this.labelScaleDescription, 1, 0);
            this.tableLayoutPanelScale.Location = new System.Drawing.Point(163, 3);
            this.tableLayoutPanelScale.Name = "tableLayoutPanelScale";
            this.tableLayoutPanelScale.RowCount = 1;
            this.tableLayoutPanelScale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelScale.Size = new System.Drawing.Size(621, 26);
            this.tableLayoutPanelScale.TabIndex = 6;
            // 
            // labelScaleDescription
            // 
            this.labelScaleDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScaleDescription.AutoSize = true;
            this.labelScaleDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelScaleDescription.Location = new System.Drawing.Point(103, 6);
            this.labelScaleDescription.Name = "labelScaleDescription";
            this.labelScaleDescription.Size = new System.Drawing.Size(325, 13);
            this.labelScaleDescription.TabIndex = 7;
            this.labelScaleDescription.Text = "Scale is inverse of Unity\'s \"Pixels Per Unit\" Texture Importer setting.";
            // 
            // tableLayoutPanelObjectTypes
            // 
            this.tableLayoutPanelObjectTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelObjectTypes.ColumnCount = 2;
            this.tableLayoutPanelObjectTypes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelObjectTypes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelObjectTypes.Controls.Add(this.buttonClearObjectTypes, 1, 0);
            this.tableLayoutPanelObjectTypes.Controls.Add(this.textBoxObjectTypesXml, 0, 0);
            this.tableLayoutPanelObjectTypes.Location = new System.Drawing.Point(163, 35);
            this.tableLayoutPanelObjectTypes.Name = "tableLayoutPanelObjectTypes";
            this.tableLayoutPanelObjectTypes.RowCount = 1;
            this.tableLayoutPanelObjectTypes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelObjectTypes.Size = new System.Drawing.Size(621, 33);
            this.tableLayoutPanelObjectTypes.TabIndex = 10;
            // 
            // labelExportDescription
            // 
            this.labelExportDescription.AutoSize = true;
            this.labelExportDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelExportDescription.Location = new System.Drawing.Point(163, 135);
            this.labelExportDescription.Name = "labelExportDescription";
            this.labelExportDescription.Size = new System.Drawing.Size(532, 13);
            this.labelExportDescription.TabIndex = 7;
            this.labelExportDescription.Text = "Export Hint: Select the \"Tiled2Unity.export.txt\" file in your Unity Project. This" +
    " tells Tiled2Unity where to export to.";
            // 
            // labelObjectTypesDescription
            // 
            this.labelObjectTypesDescription.AutoSize = true;
            this.labelObjectTypesDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelObjectTypesDescription.Location = new System.Drawing.Point(163, 71);
            this.labelObjectTypesDescription.Name = "labelObjectTypesDescription";
            this.labelObjectTypesDescription.Size = new System.Drawing.Size(609, 26);
            this.labelObjectTypesDescription.TabIndex = 11;
            this.labelObjectTypesDescription.Text = "(Optional) Select the Object Types XML file to be used with your map. The Object " +
    "Type file may contain extra properties for your Tiled objects.";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.richTextBoxOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 331);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(655, 138);
            this.groupBoxOutput.TabIndex = 15;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // groupBoxReviewExport
            // 
            this.groupBoxReviewExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReviewExport.Controls.Add(this.tableLayoutPanelReviewExport);
            this.groupBoxReviewExport.Location = new System.Drawing.Point(674, 331);
            this.groupBoxReviewExport.Name = "groupBoxReviewExport";
            this.groupBoxReviewExport.Size = new System.Drawing.Size(138, 135);
            this.groupBoxReviewExport.TabIndex = 16;
            this.groupBoxReviewExport.TabStop = false;
            this.groupBoxReviewExport.Text = "Review and Export";
            // 
            // tableLayoutPanelReviewExport
            // 
            this.tableLayoutPanelReviewExport.ColumnCount = 1;
            this.tableLayoutPanelReviewExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelReviewExport.Controls.Add(this.buttonViewer, 0, 0);
            this.tableLayoutPanelReviewExport.Controls.Add(this.buttonExport, 0, 1);
            this.tableLayoutPanelReviewExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReviewExport.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelReviewExport.Name = "tableLayoutPanelReviewExport";
            this.tableLayoutPanelReviewExport.RowCount = 2;
            this.tableLayoutPanelReviewExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelReviewExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelReviewExport.Size = new System.Drawing.Size(132, 116);
            this.tableLayoutPanelReviewExport.TabIndex = 0;
            // 
            // richTextBoxLaunchTip
            // 
            this.richTextBoxLaunchTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLaunchTip.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxLaunchTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLaunchTip.Location = new System.Drawing.Point(7, 28);
            this.richTextBoxLaunchTip.Name = "richTextBoxLaunchTip";
            this.richTextBoxLaunchTip.ReadOnly = true;
            this.richTextBoxLaunchTip.Size = new System.Drawing.Size(800, 34);
            this.richTextBoxLaunchTip.TabIndex = 17;
            this.richTextBoxLaunchTip.TabStop = false;
            this.richTextBoxLaunchTip.Text = "Load rtf text here";
            // 
            // Tiled2UnityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 481);
            this.Controls.Add(this.richTextBoxLaunchTip);
            this.Controls.Add(this.groupBoxReviewExport);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxExportOptions);
            this.Controls.Add(this.groupBoxAdvancedOptions);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(840, 520);
            this.Name = "Tiled2UnityForm";
            this.Text = "Tiled2Unity";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxAdvancedOptions.ResumeLayout(false);
            this.groupBoxAdvancedOptions.PerformLayout();
            this.groupBoxExportOptions.ResumeLayout(false);
            this.tableLayoutPanelExportOptions.ResumeLayout(false);
            this.tableLayoutPanelExportOptions.PerformLayout();
            this.tableLayoutPanelScale.ResumeLayout(false);
            this.tableLayoutPanelScale.PerformLayout();
            this.tableLayoutPanelObjectTypes.ResumeLayout(false);
            this.tableLayoutPanelObjectTypes.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxReviewExport.ResumeLayout(false);
            this.tableLayoutPanelReviewExport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxExportFolder;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonViewer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTiledFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOutputWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTiled2UnityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnityPackageToProjectToolStripMenuItem;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supportTiledMapEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem donateToTiled2UnityToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxPreferConvexPolygons;
        private System.Windows.Forms.Button buttonObjectTypesXml;
        private System.Windows.Forms.TextBox textBoxObjectTypesXml;
        private System.Windows.Forms.Button buttonClearObjectTypes;
        private System.Windows.Forms.CheckBox checkBoxDepthBuffer;
        private System.Windows.Forms.GroupBox groupBoxAdvancedOptions;
        private System.Windows.Forms.GroupBox groupBoxExportOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExportOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScale;
        private System.Windows.Forms.Label labelScaleDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelObjectTypes;
        private System.Windows.Forms.Label labelExportDescription;
        private System.Windows.Forms.Label labelObjectTypesDescription;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxReviewExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReviewExport;
        private System.Windows.Forms.RichTextBox richTextBoxLaunchTip;
    }
}

