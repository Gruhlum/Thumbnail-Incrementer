namespace Thumbnail__
{
    partial class MainControl
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.PBSelect = new System.Windows.Forms.PictureBox();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.NumericUDPositionX = new System.Windows.Forms.NumericUpDown();
            this.NumericUDPositionY = new System.Windows.Forms.NumericUpDown();
            this.BtnCenter = new System.Windows.Forms.Button();
            this.PBSaved4 = new System.Windows.Forms.PictureBox();
            this.LabelXPos = new System.Windows.Forms.Label();
            this.LabelYPosition = new System.Windows.Forms.Label();
            this.PBSaved3 = new System.Windows.Forms.PictureBox();
            this.PBSaved2 = new System.Windows.Forms.PictureBox();
            this.PBSaved1 = new System.Windows.Forms.PictureBox();
            this.PanelPictureBoxes = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.TBOutputPath = new System.Windows.Forms.TextBox();
            this.BtnChangeOutput = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LabelBorderSize = new System.Windows.Forms.Label();
            this.LabelBorderColor = new System.Windows.Forms.Label();
            this.BtnBorderColor = new System.Windows.Forms.Button();
            this.NumericUDBorderSize = new System.Windows.Forms.NumericUpDown();
            this.GBBorder = new System.Windows.Forms.GroupBox();
            this.GBPosition = new System.Windows.Forms.GroupBox();
            this.GBAlignment = new System.Windows.Forms.GroupBox();
            this.GBFont = new System.Windows.Forms.GroupBox();
            this.CBFonts = new System.Windows.Forms.ComboBox();
            this.BtnFontColor = new System.Windows.Forms.Button();
            this.LabelFontColor = new System.Windows.Forms.Label();
            this.LabelFontSize = new System.Windows.Forms.Label();
            this.NumericUDFontSize = new System.Windows.Forms.NumericUpDown();
            this.NumericUDIncrement = new System.Windows.Forms.NumericUpDown();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.GBLastThumbnails = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBEnding = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved1)).BeginInit();
            this.PanelPictureBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDBorderSize)).BeginInit();
            this.GBBorder.SuspendLayout();
            this.GBPosition.SuspendLayout();
            this.GBAlignment.SuspendLayout();
            this.GBFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDIncrement)).BeginInit();
            this.GBLastThumbnails.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(10, 113);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(150, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Select Image";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Enabled = false;
            this.BtnCreate.Location = new System.Drawing.Point(169, 357);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(82, 22);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PBSelect
            // 
            this.PBSelect.Location = new System.Drawing.Point(169, 113);
            this.PBSelect.MaximumSize = new System.Drawing.Size(384, 216);
            this.PBSelect.Name = "PBSelect";
            this.PBSelect.Size = new System.Drawing.Size(384, 216);
            this.PBSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSelect.TabIndex = 3;
            this.PBSelect.TabStop = false;
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(6, 17);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(46, 23);
            this.BtnLeft.TabIndex = 13;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(98, 17);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(46, 23);
            this.BtnRight.TabIndex = 14;
            this.BtnRight.Text = "Right";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // NumericUDPositionX
            // 
            this.NumericUDPositionX.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUDPositionX.Location = new System.Drawing.Point(20, 19);
            this.NumericUDPositionX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumericUDPositionX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumericUDPositionX.Name = "NumericUDPositionX";
            this.NumericUDPositionX.Size = new System.Drawing.Size(50, 20);
            this.NumericUDPositionX.TabIndex = 15;
            this.NumericUDPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUDPositionX.ValueChanged += new System.EventHandler(this.NumericUDPositionX_ValueChanged);
            // 
            // NumericUDPositionY
            // 
            this.NumericUDPositionY.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUDPositionY.Location = new System.Drawing.Point(94, 19);
            this.NumericUDPositionY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumericUDPositionY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumericUDPositionY.Name = "NumericUDPositionY";
            this.NumericUDPositionY.Size = new System.Drawing.Size(50, 20);
            this.NumericUDPositionY.TabIndex = 16;
            this.NumericUDPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUDPositionY.ValueChanged += new System.EventHandler(this.NumericUDPositionY_ValueChanged);
            // 
            // BtnCenter
            // 
            this.BtnCenter.Location = new System.Drawing.Point(52, 17);
            this.BtnCenter.Name = "BtnCenter";
            this.BtnCenter.Size = new System.Drawing.Size(46, 23);
            this.BtnCenter.TabIndex = 17;
            this.BtnCenter.Text = "Center";
            this.BtnCenter.UseVisualStyleBackColor = true;
            this.BtnCenter.Click += new System.EventHandler(this.BtnCenter_Click);
            // 
            // PBSaved4
            // 
            this.PBSaved4.Location = new System.Drawing.Point(405, 3);
            this.PBSaved4.Name = "PBSaved4";
            this.PBSaved4.Size = new System.Drawing.Size(128, 72);
            this.PBSaved4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved4.TabIndex = 25;
            this.PBSaved4.TabStop = false;
            this.PBSaved4.Click += new System.EventHandler(this.PBSavedThumbnails_Click);
            // 
            // LabelXPos
            // 
            this.LabelXPos.AutoSize = true;
            this.LabelXPos.Location = new System.Drawing.Point(6, 22);
            this.LabelXPos.Name = "LabelXPos";
            this.LabelXPos.Size = new System.Drawing.Size(14, 13);
            this.LabelXPos.TabIndex = 26;
            this.LabelXPos.Text = "X";
            // 
            // LabelYPosition
            // 
            this.LabelYPosition.AutoSize = true;
            this.LabelYPosition.Location = new System.Drawing.Point(80, 22);
            this.LabelYPosition.Name = "LabelYPosition";
            this.LabelYPosition.Size = new System.Drawing.Size(14, 13);
            this.LabelYPosition.TabIndex = 27;
            this.LabelYPosition.Text = "Y";
            // 
            // PBSaved3
            // 
            this.PBSaved3.Location = new System.Drawing.Point(271, 3);
            this.PBSaved3.Name = "PBSaved3";
            this.PBSaved3.Size = new System.Drawing.Size(128, 72);
            this.PBSaved3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved3.TabIndex = 29;
            this.PBSaved3.TabStop = false;
            this.PBSaved3.Click += new System.EventHandler(this.PBSavedThumbnails_Click);
            // 
            // PBSaved2
            // 
            this.PBSaved2.Location = new System.Drawing.Point(137, 3);
            this.PBSaved2.Name = "PBSaved2";
            this.PBSaved2.Size = new System.Drawing.Size(128, 72);
            this.PBSaved2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved2.TabIndex = 30;
            this.PBSaved2.TabStop = false;
            this.PBSaved2.Click += new System.EventHandler(this.PBSavedThumbnails_Click);
            // 
            // PBSaved1
            // 
            this.PBSaved1.Location = new System.Drawing.Point(3, 3);
            this.PBSaved1.Name = "PBSaved1";
            this.PBSaved1.Size = new System.Drawing.Size(128, 72);
            this.PBSaved1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved1.TabIndex = 31;
            this.PBSaved1.TabStop = false;
            this.PBSaved1.Click += new System.EventHandler(this.PBSavedThumbnails_Click);
            // 
            // PanelPictureBoxes
            // 
            this.PanelPictureBoxes.Controls.Add(this.PBSaved3);
            this.PanelPictureBoxes.Controls.Add(this.PBSaved1);
            this.PanelPictureBoxes.Controls.Add(this.PBSaved4);
            this.PanelPictureBoxes.Controls.Add(this.PBSaved2);
            this.PanelPictureBoxes.Location = new System.Drawing.Point(3, 14);
            this.PanelPictureBoxes.Name = "PanelPictureBoxes";
            this.PanelPictureBoxes.Size = new System.Drawing.Size(537, 79);
            this.PanelPictureBoxes.TabIndex = 32;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(170, 334);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(89, 13);
            this.LabelName.TabIndex = 33;
            this.LabelName.Text = "Nothing Selected";
            this.LabelName.DoubleClick += new System.EventHandler(this.LabelName_DoubleClick);
            // 
            // TBOutputPath
            // 
            this.TBOutputPath.Enabled = false;
            this.TBOutputPath.Location = new System.Drawing.Point(253, 358);
            this.TBOutputPath.Name = "TBOutputPath";
            this.TBOutputPath.ReadOnly = true;
            this.TBOutputPath.Size = new System.Drawing.Size(232, 20);
            this.TBOutputPath.TabIndex = 34;
            this.TBOutputPath.Text = "Select Folder";
            // 
            // BtnChangeOutput
            // 
            this.BtnChangeOutput.Location = new System.Drawing.Point(525, 357);
            this.BtnChangeOutput.Name = "BtnChangeOutput";
            this.BtnChangeOutput.Size = new System.Drawing.Size(28, 22);
            this.BtnChangeOutput.TabIndex = 35;
            this.BtnChangeOutput.Text = "...";
            this.BtnChangeOutput.UseVisualStyleBackColor = true;
            this.BtnChangeOutput.Click += new System.EventHandler(this.BtnChangeOutput_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // LabelBorderSize
            // 
            this.LabelBorderSize.AutoSize = true;
            this.LabelBorderSize.Location = new System.Drawing.Point(67, 22);
            this.LabelBorderSize.Name = "LabelBorderSize";
            this.LabelBorderSize.Size = new System.Drawing.Size(27, 13);
            this.LabelBorderSize.TabIndex = 42;
            this.LabelBorderSize.Text = "Size";
            // 
            // LabelBorderColor
            // 
            this.LabelBorderColor.AutoSize = true;
            this.LabelBorderColor.Location = new System.Drawing.Point(6, 22);
            this.LabelBorderColor.Name = "LabelBorderColor";
            this.LabelBorderColor.Size = new System.Drawing.Size(31, 13);
            this.LabelBorderColor.TabIndex = 41;
            this.LabelBorderColor.Text = "Color";
            // 
            // BtnBorderColor
            // 
            this.BtnBorderColor.BackColor = System.Drawing.Color.White;
            this.BtnBorderColor.Location = new System.Drawing.Point(38, 19);
            this.BtnBorderColor.Name = "BtnBorderColor";
            this.BtnBorderColor.Size = new System.Drawing.Size(20, 20);
            this.BtnBorderColor.TabIndex = 40;
            this.BtnBorderColor.UseVisualStyleBackColor = false;
            this.BtnBorderColor.Click += new System.EventHandler(this.BtnBorderColor_Click);
            // 
            // NumericUDBorderSize
            // 
            this.NumericUDBorderSize.Location = new System.Drawing.Point(94, 19);
            this.NumericUDBorderSize.Name = "NumericUDBorderSize";
            this.NumericUDBorderSize.Size = new System.Drawing.Size(50, 20);
            this.NumericUDBorderSize.TabIndex = 39;
            this.NumericUDBorderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUDBorderSize.ValueChanged += new System.EventHandler(this.NumericUDBorderSize_ValueChanged);
            // 
            // GBBorder
            // 
            this.GBBorder.Controls.Add(this.LabelBorderColor);
            this.GBBorder.Controls.Add(this.LabelBorderSize);
            this.GBBorder.Controls.Add(this.NumericUDBorderSize);
            this.GBBorder.Controls.Add(this.BtnBorderColor);
            this.GBBorder.Enabled = false;
            this.GBBorder.Location = new System.Drawing.Point(10, 310);
            this.GBBorder.Name = "GBBorder";
            this.GBBorder.Size = new System.Drawing.Size(150, 44);
            this.GBBorder.TabIndex = 39;
            this.GBBorder.TabStop = false;
            this.GBBorder.Text = "Text Outline";
            // 
            // GBPosition
            // 
            this.GBPosition.Controls.Add(this.NumericUDPositionY);
            this.GBPosition.Controls.Add(this.NumericUDPositionX);
            this.GBPosition.Controls.Add(this.LabelXPos);
            this.GBPosition.Controls.Add(this.LabelYPosition);
            this.GBPosition.Enabled = false;
            this.GBPosition.Location = new System.Drawing.Point(10, 214);
            this.GBPosition.Name = "GBPosition";
            this.GBPosition.Size = new System.Drawing.Size(150, 44);
            this.GBPosition.TabIndex = 40;
            this.GBPosition.TabStop = false;
            this.GBPosition.Text = "Position";
            // 
            // GBAlignment
            // 
            this.GBAlignment.Controls.Add(this.BtnCenter);
            this.GBAlignment.Controls.Add(this.BtnRight);
            this.GBAlignment.Controls.Add(this.BtnLeft);
            this.GBAlignment.Enabled = false;
            this.GBAlignment.Location = new System.Drawing.Point(10, 262);
            this.GBAlignment.Name = "GBAlignment";
            this.GBAlignment.Size = new System.Drawing.Size(150, 44);
            this.GBAlignment.TabIndex = 41;
            this.GBAlignment.TabStop = false;
            this.GBAlignment.Text = "Alignment";
            // 
            // GBFont
            // 
            this.GBFont.Controls.Add(this.CBFonts);
            this.GBFont.Controls.Add(this.BtnFontColor);
            this.GBFont.Controls.Add(this.LabelFontColor);
            this.GBFont.Controls.Add(this.LabelFontSize);
            this.GBFont.Controls.Add(this.NumericUDFontSize);
            this.GBFont.Enabled = false;
            this.GBFont.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBFont.Location = new System.Drawing.Point(10, 141);
            this.GBFont.Name = "GBFont";
            this.GBFont.Size = new System.Drawing.Size(150, 68);
            this.GBFont.TabIndex = 38;
            this.GBFont.TabStop = false;
            this.GBFont.Text = "Font";
            // 
            // CBFonts
            // 
            this.CBFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFonts.Location = new System.Drawing.Point(6, 16);
            this.CBFonts.Name = "CBFonts";
            this.CBFonts.Size = new System.Drawing.Size(138, 21);
            this.CBFonts.TabIndex = 28;
            this.CBFonts.SelectedValueChanged += new System.EventHandler(this.CBFonts_SelectedValueChanged);
            // 
            // BtnFontColor
            // 
            this.BtnFontColor.BackColor = System.Drawing.Color.White;
            this.BtnFontColor.Location = new System.Drawing.Point(38, 43);
            this.BtnFontColor.Name = "BtnFontColor";
            this.BtnFontColor.Size = new System.Drawing.Size(20, 20);
            this.BtnFontColor.TabIndex = 36;
            this.BtnFontColor.UseVisualStyleBackColor = false;
            this.BtnFontColor.Click += new System.EventHandler(this.BtnFontColor_Click);
            // 
            // LabelFontColor
            // 
            this.LabelFontColor.AutoSize = true;
            this.LabelFontColor.Location = new System.Drawing.Point(6, 46);
            this.LabelFontColor.Name = "LabelFontColor";
            this.LabelFontColor.Size = new System.Drawing.Size(31, 13);
            this.LabelFontColor.TabIndex = 37;
            this.LabelFontColor.Text = "Color";
            // 
            // LabelFontSize
            // 
            this.LabelFontSize.AutoSize = true;
            this.LabelFontSize.Location = new System.Drawing.Point(67, 46);
            this.LabelFontSize.Name = "LabelFontSize";
            this.LabelFontSize.Size = new System.Drawing.Size(27, 13);
            this.LabelFontSize.TabIndex = 38;
            this.LabelFontSize.Text = "Size";
            // 
            // NumericUDFontSize
            // 
            this.NumericUDFontSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUDFontSize.Location = new System.Drawing.Point(94, 43);
            this.NumericUDFontSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericUDFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUDFontSize.Name = "NumericUDFontSize";
            this.NumericUDFontSize.Size = new System.Drawing.Size(50, 20);
            this.NumericUDFontSize.TabIndex = 5;
            this.NumericUDFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUDFontSize.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.NumericUDFontSize.ValueChanged += new System.EventHandler(this.NumericUDFontSize_ValueChanged);
            // 
            // NumericUDIncrement
            // 
            this.NumericUDIncrement.Enabled = false;
            this.NumericUDIncrement.Location = new System.Drawing.Point(104, 359);
            this.NumericUDIncrement.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumericUDIncrement.Name = "NumericUDIncrement";
            this.NumericUDIncrement.Size = new System.Drawing.Size(50, 20);
            this.NumericUDIncrement.TabIndex = 42;
            this.NumericUDIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUDIncrement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUDIncrement.ValueChanged += new System.EventHandler(this.NumericUDIncrement_ValueChanged);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(60, 362);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(44, 13);
            this.LabelNumber.TabIndex = 43;
            this.LabelNumber.Text = "Number";
            // 
            // GBLastThumbnails
            // 
            this.GBLastThumbnails.Controls.Add(this.PanelPictureBoxes);
            this.GBLastThumbnails.Location = new System.Drawing.Point(10, 5);
            this.GBLastThumbnails.Name = "GBLastThumbnails";
            this.GBLastThumbnails.Size = new System.Drawing.Size(543, 100);
            this.GBLastThumbnails.TabIndex = 44;
            this.GBLastThumbnails.TabStop = false;
            this.GBLastThumbnails.Text = "Recently Used";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TBEnding
            // 
            this.TBEnding.Location = new System.Drawing.Point(487, 358);
            this.TBEnding.Name = "TBEnding";
            this.TBEnding.Size = new System.Drawing.Size(37, 20);
            this.TBEnding.TabIndex = 46;
            this.TBEnding.Text = ".png";
            this.TBEnding.TextChanged += new System.EventHandler(this.TBEnding_TextChanged);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 390);
            this.Controls.Add(this.TBEnding);
            this.Controls.Add(this.GBLastThumbnails);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.NumericUDIncrement);
            this.Controls.Add(this.GBFont);
            this.Controls.Add(this.GBAlignment);
            this.Controls.Add(this.GBPosition);
            this.Controls.Add(this.GBBorder);
            this.Controls.Add(this.BtnChangeOutput);
            this.Controls.Add(this.TBOutputPath);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PBSelect);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainControl";
            this.ShowIcon = false;
            this.Text = "Thumbnail++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainControl_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PBSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved1)).EndInit();
            this.PanelPictureBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDBorderSize)).EndInit();
            this.GBBorder.ResumeLayout(false);
            this.GBBorder.PerformLayout();
            this.GBPosition.ResumeLayout(false);
            this.GBPosition.PerformLayout();
            this.GBAlignment.ResumeLayout(false);
            this.GBFont.ResumeLayout(false);
            this.GBFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDIncrement)).EndInit();
            this.GBLastThumbnails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.PictureBox PBSelect;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.NumericUpDown NumericUDPositionX;
        private System.Windows.Forms.NumericUpDown NumericUDPositionY;
        private System.Windows.Forms.Button BtnCenter;
        private System.Windows.Forms.PictureBox PBSaved4;
        private System.Windows.Forms.Label LabelXPos;
        private System.Windows.Forms.Label LabelYPosition;
        private System.Windows.Forms.PictureBox PBSaved3;
        private System.Windows.Forms.PictureBox PBSaved2;
        private System.Windows.Forms.PictureBox PBSaved1;
        private System.Windows.Forms.Panel PanelPictureBoxes;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TBOutputPath;
        private System.Windows.Forms.Button BtnChangeOutput;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LabelBorderSize;
        private System.Windows.Forms.Label LabelBorderColor;
        private System.Windows.Forms.Button BtnBorderColor;
        private System.Windows.Forms.NumericUpDown NumericUDBorderSize;
        private System.Windows.Forms.GroupBox GBBorder;
        private System.Windows.Forms.GroupBox GBPosition;
        private System.Windows.Forms.GroupBox GBAlignment;
        private System.Windows.Forms.GroupBox GBFont;
        private System.Windows.Forms.ComboBox CBFonts;
        private System.Windows.Forms.Button BtnFontColor;
        private System.Windows.Forms.Label LabelFontColor;
        private System.Windows.Forms.Label LabelFontSize;
        private System.Windows.Forms.NumericUpDown NumericUDFontSize;
        private System.Windows.Forms.NumericUpDown NumericUDIncrement;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.GroupBox GBLastThumbnails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TBEnding;
    }
}

