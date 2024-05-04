namespace ConverterApp
{
    partial class GR2Pane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gr2ModeTabControl = new System.Windows.Forms.TabControl();
            gr2SingleFileTab = new System.Windows.Forms.TabPage();
            lblOutputPath = new System.Windows.Forms.Label();
            saveOutputBtn = new System.Windows.Forms.Button();
            inputPath = new System.Windows.Forms.TextBox();
            lblSrcPath = new System.Windows.Forms.Label();
            inputFileBrowseBtn = new System.Windows.Forms.Button();
            loadInputBtn = new System.Windows.Forms.Button();
            outputPath = new System.Windows.Forms.TextBox();
            outputFileBrowserBtn = new System.Windows.Forms.Button();
            gr2BatchTab = new System.Windows.Forms.TabPage();
            gr2BatchProgressLabel = new System.Windows.Forms.Label();
            gr2BatchInputBrowseBtn = new System.Windows.Forms.Button();
            gr2BatchOutputBrowseBtn = new System.Windows.Forms.Button();
            gr2BatchProgressBar = new System.Windows.Forms.ProgressBar();
            label23 = new System.Windows.Forms.Label();
            gr2BatchInputFormat = new System.Windows.Forms.ComboBox();
            label22 = new System.Windows.Forms.Label();
            gr2BatchOutputFormat = new System.Windows.Forms.ComboBox();
            label21 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            gr2BatchConvertBtn = new System.Windows.Forms.Button();
            gr2BatchInputDir = new System.Windows.Forms.TextBox();
            label20 = new System.Windows.Forms.Label();
            gr2BatchOutputDir = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flipMeshes = new System.Windows.Forms.CheckBox();
            flipSkeletons = new System.Windows.Forms.CheckBox();
            flipUVs = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            exportableObjects = new System.Windows.Forms.ListView();
            exportableName = new System.Windows.Forms.ColumnHeader();
            exportableType = new System.Windows.Forms.ColumnHeader();
            filterUVs = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            conformCopySkeletons = new System.Windows.Forms.CheckBox();
            meshProxy = new System.Windows.Forms.CheckBox();
            meshCloth = new System.Windows.Forms.CheckBox();
            meshRigid = new System.Windows.Forms.CheckBox();
            applyBasisTransforms = new System.Windows.Forms.CheckBox();
            conformantGR2BrowseBtn = new System.Windows.Forms.Button();
            conformantGR2Path = new System.Windows.Forms.TextBox();
            conformToOriginal = new System.Windows.Forms.CheckBox();
            buildDummySkeleton = new System.Windows.Forms.CheckBox();
            resourceFormats = new ExportItemSelection();
            label1 = new System.Windows.Forms.Label();
            gr2OutputDirDlg = new System.Windows.Forms.FolderBrowserDialog();
            gr2InputDirDlg = new System.Windows.Forms.FolderBrowserDialog();
            conformSkeletonFileDlg = new System.Windows.Forms.OpenFileDialog();
            outputFileDlg = new System.Windows.Forms.SaveFileDialog();
            inputFileDlg = new System.Windows.Forms.OpenFileDialog();
            filterVertices = new System.Windows.Forms.CheckBox();
            gr2ModeTabControl.SuspendLayout();
            gr2SingleFileTab.SuspendLayout();
            gr2BatchTab.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gr2ModeTabControl
            // 
            gr2ModeTabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gr2ModeTabControl.Controls.Add(gr2SingleFileTab);
            gr2ModeTabControl.Controls.Add(gr2BatchTab);
            gr2ModeTabControl.Location = new System.Drawing.Point(8, 10);
            gr2ModeTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2ModeTabControl.Name = "gr2ModeTabControl";
            gr2ModeTabControl.SelectedIndex = 0;
            gr2ModeTabControl.Size = new System.Drawing.Size(1035, 183);
            gr2ModeTabControl.TabIndex = 38;
            // 
            // gr2SingleFileTab
            // 
            gr2SingleFileTab.Controls.Add(lblOutputPath);
            gr2SingleFileTab.Controls.Add(saveOutputBtn);
            gr2SingleFileTab.Controls.Add(inputPath);
            gr2SingleFileTab.Controls.Add(lblSrcPath);
            gr2SingleFileTab.Controls.Add(inputFileBrowseBtn);
            gr2SingleFileTab.Controls.Add(loadInputBtn);
            gr2SingleFileTab.Controls.Add(outputPath);
            gr2SingleFileTab.Controls.Add(outputFileBrowserBtn);
            gr2SingleFileTab.Location = new System.Drawing.Point(4, 24);
            gr2SingleFileTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2SingleFileTab.Name = "gr2SingleFileTab";
            gr2SingleFileTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2SingleFileTab.Size = new System.Drawing.Size(1027, 155);
            gr2SingleFileTab.TabIndex = 0;
            gr2SingleFileTab.Text = "Single File";
            gr2SingleFileTab.UseVisualStyleBackColor = true;
            // 
            // lblOutputPath
            // 
            lblOutputPath.AutoSize = true;
            lblOutputPath.Location = new System.Drawing.Point(7, 53);
            lblOutputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new System.Drawing.Size(94, 15);
            lblOutputPath.TabIndex = 29;
            lblOutputPath.Text = "Output file path:";
            // 
            // saveOutputBtn
            // 
            saveOutputBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            saveOutputBtn.Enabled = false;
            saveOutputBtn.Location = new System.Drawing.Point(841, 70);
            saveOutputBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            saveOutputBtn.Name = "saveOutputBtn";
            saveOutputBtn.Size = new System.Drawing.Size(164, 27);
            saveOutputBtn.TabIndex = 34;
            saveOutputBtn.Text = "Export";
            saveOutputBtn.UseVisualStyleBackColor = true;
            saveOutputBtn.Click += saveOutputBtn_Click;
            // 
            // inputPath
            // 
            inputPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            inputPath.Location = new System.Drawing.Point(10, 22);
            inputPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            inputPath.Name = "inputPath";
            inputPath.Size = new System.Drawing.Size(768, 23);
            inputPath.TabIndex = 25;
            // 
            // lblSrcPath
            // 
            lblSrcPath.AutoSize = true;
            lblSrcPath.Location = new System.Drawing.Point(7, 3);
            lblSrcPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSrcPath.Name = "lblSrcPath";
            lblSrcPath.Size = new System.Drawing.Size(84, 15);
            lblSrcPath.TabIndex = 26;
            lblSrcPath.Text = "Input file path:";
            // 
            // inputFileBrowseBtn
            // 
            inputFileBrowseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            inputFileBrowseBtn.Location = new System.Drawing.Point(777, 21);
            inputFileBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            inputFileBrowseBtn.Name = "inputFileBrowseBtn";
            inputFileBrowseBtn.Size = new System.Drawing.Size(48, 25);
            inputFileBrowseBtn.TabIndex = 27;
            inputFileBrowseBtn.Text = "...";
            inputFileBrowseBtn.UseVisualStyleBackColor = true;
            inputFileBrowseBtn.Click += inputFileBrowseBtn_Click;
            // 
            // loadInputBtn
            // 
            loadInputBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            loadInputBtn.Location = new System.Drawing.Point(841, 21);
            loadInputBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            loadInputBtn.Name = "loadInputBtn";
            loadInputBtn.Size = new System.Drawing.Size(164, 27);
            loadInputBtn.TabIndex = 31;
            loadInputBtn.Text = "Import";
            loadInputBtn.UseVisualStyleBackColor = true;
            loadInputBtn.Click += loadInputBtn_Click;
            // 
            // outputPath
            // 
            outputPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            outputPath.Location = new System.Drawing.Point(10, 72);
            outputPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            outputPath.Name = "outputPath";
            outputPath.Size = new System.Drawing.Size(768, 23);
            outputPath.TabIndex = 28;
            // 
            // outputFileBrowserBtn
            // 
            outputFileBrowserBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            outputFileBrowserBtn.Location = new System.Drawing.Point(777, 70);
            outputFileBrowserBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            outputFileBrowserBtn.Name = "outputFileBrowserBtn";
            outputFileBrowserBtn.Size = new System.Drawing.Size(48, 25);
            outputFileBrowserBtn.TabIndex = 30;
            outputFileBrowserBtn.Text = "...";
            outputFileBrowserBtn.UseVisualStyleBackColor = true;
            outputFileBrowserBtn.Click += outputFileBrowserBtn_Click;
            // 
            // gr2BatchTab
            // 
            gr2BatchTab.Controls.Add(gr2BatchProgressLabel);
            gr2BatchTab.Controls.Add(gr2BatchInputBrowseBtn);
            gr2BatchTab.Controls.Add(gr2BatchOutputBrowseBtn);
            gr2BatchTab.Controls.Add(gr2BatchProgressBar);
            gr2BatchTab.Controls.Add(label23);
            gr2BatchTab.Controls.Add(gr2BatchInputFormat);
            gr2BatchTab.Controls.Add(label22);
            gr2BatchTab.Controls.Add(gr2BatchOutputFormat);
            gr2BatchTab.Controls.Add(label21);
            gr2BatchTab.Controls.Add(label19);
            gr2BatchTab.Controls.Add(gr2BatchConvertBtn);
            gr2BatchTab.Controls.Add(gr2BatchInputDir);
            gr2BatchTab.Controls.Add(label20);
            gr2BatchTab.Controls.Add(gr2BatchOutputDir);
            gr2BatchTab.Location = new System.Drawing.Point(4, 24);
            gr2BatchTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchTab.Name = "gr2BatchTab";
            gr2BatchTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchTab.Size = new System.Drawing.Size(1027, 155);
            gr2BatchTab.TabIndex = 1;
            gr2BatchTab.Text = "Batch";
            gr2BatchTab.UseVisualStyleBackColor = true;
            // 
            // gr2BatchProgressLabel
            // 
            gr2BatchProgressLabel.AutoSize = true;
            gr2BatchProgressLabel.Location = new System.Drawing.Point(96, 102);
            gr2BatchProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gr2BatchProgressLabel.Name = "gr2BatchProgressLabel";
            gr2BatchProgressLabel.Size = new System.Drawing.Size(0, 15);
            gr2BatchProgressLabel.TabIndex = 49;
            // 
            // gr2BatchInputBrowseBtn
            // 
            gr2BatchInputBrowseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gr2BatchInputBrowseBtn.Location = new System.Drawing.Point(959, 20);
            gr2BatchInputBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchInputBrowseBtn.Name = "gr2BatchInputBrowseBtn";
            gr2BatchInputBrowseBtn.Size = new System.Drawing.Size(48, 27);
            gr2BatchInputBrowseBtn.TabIndex = 37;
            gr2BatchInputBrowseBtn.Text = "...";
            gr2BatchInputBrowseBtn.UseVisualStyleBackColor = true;
            gr2BatchInputBrowseBtn.Click += GR2BatchInputBrowseBtn_Click;
            // 
            // gr2BatchOutputBrowseBtn
            // 
            gr2BatchOutputBrowseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gr2BatchOutputBrowseBtn.Location = new System.Drawing.Point(959, 69);
            gr2BatchOutputBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchOutputBrowseBtn.Name = "gr2BatchOutputBrowseBtn";
            gr2BatchOutputBrowseBtn.Size = new System.Drawing.Size(48, 27);
            gr2BatchOutputBrowseBtn.TabIndex = 40;
            gr2BatchOutputBrowseBtn.Text = "...";
            gr2BatchOutputBrowseBtn.UseVisualStyleBackColor = true;
            gr2BatchOutputBrowseBtn.Click += GR2BatchOutputBrowseBtn_Click;
            // 
            // gr2BatchProgressBar
            // 
            gr2BatchProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gr2BatchProgressBar.Location = new System.Drawing.Point(10, 120);
            gr2BatchProgressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchProgressBar.Name = "gr2BatchProgressBar";
            gr2BatchProgressBar.Size = new System.Drawing.Size(817, 27);
            gr2BatchProgressBar.TabIndex = 47;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(7, 102);
            label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(55, 15);
            label23.TabIndex = 48;
            label23.Text = "Progress:";
            // 
            // gr2BatchInputFormat
            // 
            gr2BatchInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            gr2BatchInputFormat.FormattingEnabled = true;
            gr2BatchInputFormat.Items.AddRange(new object[] { "GR2", "DAE" });
            gr2BatchInputFormat.Location = new System.Drawing.Point(10, 22);
            gr2BatchInputFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchInputFormat.Name = "gr2BatchInputFormat";
            gr2BatchInputFormat.Size = new System.Drawing.Size(78, 23);
            gr2BatchInputFormat.TabIndex = 46;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(7, 3);
            label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(77, 15);
            label22.TabIndex = 45;
            label22.Text = "Input format:";
            // 
            // gr2BatchOutputFormat
            // 
            gr2BatchOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            gr2BatchOutputFormat.FormattingEnabled = true;
            gr2BatchOutputFormat.Items.AddRange(new object[] { "GR2", "DAE" });
            gr2BatchOutputFormat.Location = new System.Drawing.Point(10, 72);
            gr2BatchOutputFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchOutputFormat.Name = "gr2BatchOutputFormat";
            gr2BatchOutputFormat.Size = new System.Drawing.Size(78, 23);
            gr2BatchOutputFormat.TabIndex = 44;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(7, 53);
            label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(87, 15);
            label21.TabIndex = 43;
            label21.Text = "Output format:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(92, 53);
            label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(98, 15);
            label19.TabIndex = 39;
            label19.Text = "Output directory:";
            // 
            // gr2BatchConvertBtn
            // 
            gr2BatchConvertBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gr2BatchConvertBtn.Location = new System.Drawing.Point(844, 120);
            gr2BatchConvertBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchConvertBtn.Name = "gr2BatchConvertBtn";
            gr2BatchConvertBtn.Size = new System.Drawing.Size(164, 27);
            gr2BatchConvertBtn.TabIndex = 42;
            gr2BatchConvertBtn.Text = "Convert";
            gr2BatchConvertBtn.UseVisualStyleBackColor = true;
            gr2BatchConvertBtn.Click += GR2BatchConvertBtn_Click;
            // 
            // gr2BatchInputDir
            // 
            gr2BatchInputDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gr2BatchInputDir.Location = new System.Drawing.Point(96, 22);
            gr2BatchInputDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchInputDir.Name = "gr2BatchInputDir";
            gr2BatchInputDir.Size = new System.Drawing.Size(865, 23);
            gr2BatchInputDir.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(92, 3);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(88, 15);
            label20.TabIndex = 36;
            label20.Text = "Input directory:";
            // 
            // gr2BatchOutputDir
            // 
            gr2BatchOutputDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gr2BatchOutputDir.Location = new System.Drawing.Point(96, 72);
            gr2BatchOutputDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gr2BatchOutputDir.Name = "gr2BatchOutputDir";
            gr2BatchOutputDir.Size = new System.Drawing.Size(865, 23);
            gr2BatchOutputDir.TabIndex = 38;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox2.Controls.Add(filterVertices);
            groupBox2.Controls.Add(flipMeshes);
            groupBox2.Controls.Add(flipSkeletons);
            groupBox2.Controls.Add(flipUVs);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(exportableObjects);
            groupBox2.Controls.Add(filterUVs);
            groupBox2.Location = new System.Drawing.Point(8, 201);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(461, 517);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Export Options";
            // 
            // flipMeshes
            // 
            flipMeshes.AutoSize = true;
            flipMeshes.Checked = true;
            flipMeshes.CheckState = System.Windows.Forms.CheckState.Checked;
            flipMeshes.Location = new System.Drawing.Point(220, 52);
            flipMeshes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flipMeshes.Name = "flipMeshes";
            flipMeshes.Size = new System.Drawing.Size(144, 19);
            flipMeshes.TabIndex = 26;
            flipMeshes.Text = "X-flip meshes (D:OS 2)";
            flipMeshes.UseVisualStyleBackColor = true;
            // 
            // flipSkeletons
            // 
            flipSkeletons.AutoSize = true;
            flipSkeletons.Location = new System.Drawing.Point(220, 25);
            flipSkeletons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flipSkeletons.Name = "flipSkeletons";
            flipSkeletons.Size = new System.Drawing.Size(153, 19);
            flipSkeletons.TabIndex = 25;
            flipSkeletons.Text = "X-flip skeletons (D:OS 2)";
            flipSkeletons.UseVisualStyleBackColor = true;
            // 
            // flipUVs
            // 
            flipUVs.AutoSize = true;
            flipUVs.Checked = true;
            flipUVs.CheckState = System.Windows.Forms.CheckState.Checked;
            flipUVs.Location = new System.Drawing.Point(13, 25);
            flipUVs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flipUVs.Name = "flipUVs";
            flipUVs.Size = new System.Drawing.Size(68, 19);
            flipUVs.TabIndex = 23;
            flipUVs.Text = "Flip UVs";
            flipUVs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 103);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 15);
            label2.TabIndex = 22;
            label2.Text = "Select subobjects for export:";
            // 
            // exportableObjects
            // 
            exportableObjects.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            exportableObjects.CheckBoxes = true;
            exportableObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { exportableName, exportableType });
            exportableObjects.Enabled = false;
            exportableObjects.FullRowSelect = true;
            exportableObjects.Location = new System.Drawing.Point(13, 124);
            exportableObjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            exportableObjects.Name = "exportableObjects";
            exportableObjects.Size = new System.Drawing.Size(434, 373);
            exportableObjects.TabIndex = 21;
            exportableObjects.UseCompatibleStateImageBehavior = false;
            exportableObjects.View = System.Windows.Forms.View.Details;
            // 
            // exportableName
            // 
            exportableName.Text = "Name";
            exportableName.Width = 230;
            // 
            // exportableType
            // 
            exportableType.Text = "Type";
            exportableType.Width = 130;
            // 
            // filterUVs
            // 
            filterUVs.AutoSize = true;
            filterUVs.Location = new System.Drawing.Point(13, 52);
            filterUVs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            filterUVs.Name = "filterUVs";
            filterUVs.Size = new System.Drawing.Size(75, 19);
            filterUVs.TabIndex = 16;
            filterUVs.Text = "Filter UVs";
            filterUVs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(conformCopySkeletons);
            groupBox1.Controls.Add(meshProxy);
            groupBox1.Controls.Add(meshCloth);
            groupBox1.Controls.Add(meshRigid);
            groupBox1.Controls.Add(applyBasisTransforms);
            groupBox1.Controls.Add(conformantGR2BrowseBtn);
            groupBox1.Controls.Add(conformantGR2Path);
            groupBox1.Controls.Add(conformToOriginal);
            groupBox1.Controls.Add(buildDummySkeleton);
            groupBox1.Controls.Add(resourceFormats);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(488, 201);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(555, 517);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "GR2 Export Options";
            // 
            // conformCopySkeletons
            // 
            conformCopySkeletons.AutoSize = true;
            conformCopySkeletons.Enabled = false;
            conformCopySkeletons.Location = new System.Drawing.Point(284, 105);
            conformCopySkeletons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            conformCopySkeletons.Name = "conformCopySkeletons";
            conformCopySkeletons.Size = new System.Drawing.Size(102, 19);
            conformCopySkeletons.TabIndex = 29;
            conformCopySkeletons.Text = "Copy Skeleton";
            conformCopySkeletons.UseVisualStyleBackColor = true;
            // 
            // meshProxy
            // 
            meshProxy.AutoSize = true;
            meshProxy.Location = new System.Drawing.Point(284, 78);
            meshProxy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            meshProxy.Name = "meshProxy";
            meshProxy.Size = new System.Drawing.Size(134, 19);
            meshProxy.TabIndex = 29;
            meshProxy.Text = "(D:OS 2) Mesh Proxy";
            meshProxy.UseVisualStyleBackColor = true;
            // 
            // meshCloth
            // 
            meshCloth.AutoSize = true;
            meshCloth.Location = new System.Drawing.Point(284, 52);
            meshCloth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            meshCloth.Name = "meshCloth";
            meshCloth.Size = new System.Drawing.Size(101, 19);
            meshCloth.TabIndex = 28;
            meshCloth.Text = "(D:OS 2) Cloth";
            meshCloth.UseVisualStyleBackColor = true;
            // 
            // meshRigid
            // 
            meshRigid.AutoSize = true;
            meshRigid.Location = new System.Drawing.Point(284, 25);
            meshRigid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            meshRigid.Name = "meshRigid";
            meshRigid.Size = new System.Drawing.Size(99, 19);
            meshRigid.TabIndex = 27;
            meshRigid.Text = "(D:OS 2) Rigid";
            meshRigid.UseVisualStyleBackColor = true;
            // 
            // applyBasisTransforms
            // 
            applyBasisTransforms.AutoSize = true;
            applyBasisTransforms.Checked = true;
            applyBasisTransforms.CheckState = System.Windows.Forms.CheckState.Checked;
            applyBasisTransforms.Location = new System.Drawing.Point(19, 25);
            applyBasisTransforms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            applyBasisTransforms.Name = "applyBasisTransforms";
            applyBasisTransforms.Size = new System.Drawing.Size(111, 19);
            applyBasisTransforms.TabIndex = 26;
            applyBasisTransforms.Text = "Convert to Y-up";
            applyBasisTransforms.UseVisualStyleBackColor = true;
            // 
            // conformantGR2BrowseBtn
            // 
            conformantGR2BrowseBtn.Enabled = false;
            conformantGR2BrowseBtn.Location = new System.Drawing.Point(489, 126);
            conformantGR2BrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            conformantGR2BrowseBtn.Name = "conformantGR2BrowseBtn";
            conformantGR2BrowseBtn.Size = new System.Drawing.Size(48, 27);
            conformantGR2BrowseBtn.TabIndex = 25;
            conformantGR2BrowseBtn.Text = "...";
            conformantGR2BrowseBtn.UseVisualStyleBackColor = true;
            conformantGR2BrowseBtn.Click += conformantSkeletonBrowseBtn_Click;
            // 
            // conformantGR2Path
            // 
            conformantGR2Path.Enabled = false;
            conformantGR2Path.Location = new System.Drawing.Point(18, 128);
            conformantGR2Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            conformantGR2Path.Name = "conformantGR2Path";
            conformantGR2Path.Size = new System.Drawing.Size(472, 23);
            conformantGR2Path.TabIndex = 24;
            // 
            // conformToOriginal
            // 
            conformToOriginal.AutoSize = true;
            conformToOriginal.Enabled = false;
            conformToOriginal.Location = new System.Drawing.Point(18, 105);
            conformToOriginal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            conformToOriginal.Name = "conformToOriginal";
            conformToOriginal.Size = new System.Drawing.Size(158, 19);
            conformToOriginal.TabIndex = 23;
            conformToOriginal.Text = "Conform to original GR2:";
            conformToOriginal.UseVisualStyleBackColor = true;
            conformToOriginal.Click += conformToSkeleton_CheckedChanged;
            // 
            // buildDummySkeleton
            // 
            buildDummySkeleton.AutoSize = true;
            buildDummySkeleton.Checked = true;
            buildDummySkeleton.CheckState = System.Windows.Forms.CheckState.Checked;
            buildDummySkeleton.Location = new System.Drawing.Point(18, 78);
            buildDummySkeleton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buildDummySkeleton.Name = "buildDummySkeleton";
            buildDummySkeleton.Size = new System.Drawing.Size(152, 19);
            buildDummySkeleton.TabIndex = 22;
            buildDummySkeleton.Text = "Create dummy skeleton";
            buildDummySkeleton.UseVisualStyleBackColor = true;
            // 
            // resourceFormats
            // 
            resourceFormats.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            resourceFormats.FullRowSelect = true;
            resourceFormats.Location = new System.Drawing.Point(18, 185);
            resourceFormats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            resourceFormats.Name = "resourceFormats";
            resourceFormats.Size = new System.Drawing.Size(518, 312);
            resourceFormats.TabIndex = 16;
            resourceFormats.UseCompatibleStateImageBehavior = false;
            resourceFormats.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 160);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 15);
            label1.TabIndex = 15;
            label1.Text = "Customize resource formats:";
            // 
            // conformSkeletonFileDlg
            // 
            conformSkeletonFileDlg.Filter = "Granny GR2|*.gr2;*.lsm";
            conformSkeletonFileDlg.Title = "Select Conforming Skeleton File";
            // 
            // outputFileDlg
            // 
            outputFileDlg.Filter = "COLLADA/GR2 files|*.dae;*.gr2;*.lsm";
            outputFileDlg.Title = "Select Output File";
            // 
            // inputFileDlg
            // 
            inputFileDlg.Filter = "COLLADA/GR2 files|*.dae;*.gr2;*.lsm";
            inputFileDlg.Title = "Select Input File";
            // 
            // filterVertices
            // 
            filterVertices.AutoSize = true;
            filterVertices.Checked = true;
            filterVertices.CheckState = System.Windows.Forms.CheckState.Checked;
            filterVertices.Location = new System.Drawing.Point(13, 79);
            filterVertices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            filterVertices.Name = "filterVertices";
            filterVertices.Size = new System.Drawing.Size(95, 19);
            filterVertices.TabIndex = 27;
            filterVertices.Text = "Filter vertices";
            filterVertices.UseVisualStyleBackColor = true;
            // 
            // GR2Pane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gr2ModeTabControl);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "GR2Pane";
            Size = new System.Drawing.Size(1051, 727);
            gr2ModeTabControl.ResumeLayout(false);
            gr2SingleFileTab.ResumeLayout(false);
            gr2SingleFileTab.PerformLayout();
            gr2BatchTab.ResumeLayout(false);
            gr2BatchTab.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl gr2ModeTabControl;
        private System.Windows.Forms.TabPage gr2SingleFileTab;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button saveOutputBtn;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Label lblSrcPath;
        private System.Windows.Forms.Button inputFileBrowseBtn;
        private System.Windows.Forms.Button loadInputBtn;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Button outputFileBrowserBtn;
        private System.Windows.Forms.TabPage gr2BatchTab;
        private System.Windows.Forms.Label gr2BatchProgressLabel;
        private System.Windows.Forms.Button gr2BatchInputBrowseBtn;
        private System.Windows.Forms.Button gr2BatchOutputBrowseBtn;
        private System.Windows.Forms.ProgressBar gr2BatchProgressBar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox gr2BatchInputFormat;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox gr2BatchOutputFormat;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button gr2BatchConvertBtn;
        private System.Windows.Forms.TextBox gr2BatchInputDir;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox gr2BatchOutputDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox filterUVs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox applyBasisTransforms;
        private System.Windows.Forms.Button conformantGR2BrowseBtn;
        private System.Windows.Forms.TextBox conformantGR2Path;
        private System.Windows.Forms.CheckBox conformToOriginal;
        private System.Windows.Forms.CheckBox buildDummySkeleton;
        private System.Windows.Forms.FolderBrowserDialog gr2OutputDirDlg;
        private System.Windows.Forms.FolderBrowserDialog gr2InputDirDlg;
        private System.Windows.Forms.OpenFileDialog conformSkeletonFileDlg;
        private System.Windows.Forms.SaveFileDialog outputFileDlg;
        private System.Windows.Forms.OpenFileDialog inputFileDlg;
        private System.Windows.Forms.CheckBox flipUVs;
        internal System.Windows.Forms.CheckBox flipMeshes;
        internal System.Windows.Forms.CheckBox flipSkeletons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView exportableObjects;
        private System.Windows.Forms.ColumnHeader exportableName;
        private System.Windows.Forms.ColumnHeader exportableType;
        private ExportItemSelection resourceFormats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox conformCopySkeletons;
        private System.Windows.Forms.CheckBox meshProxy;
        private System.Windows.Forms.CheckBox meshCloth;
        private System.Windows.Forms.CheckBox meshRigid;
        internal System.Windows.Forms.CheckBox filterVertices;
    }
}
