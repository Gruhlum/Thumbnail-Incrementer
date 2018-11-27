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
            this.NumericUDIncrement = new System.Windows.Forms.NumericUpDown();
            this.NumericUDFontSize = new System.Windows.Forms.NumericUpDown();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.NumericUDPositionX = new System.Windows.Forms.NumericUpDown();
            this.NumericUDPositionY = new System.Windows.Forms.NumericUpDown();
            this.BtnCenter = new System.Windows.Forms.Button();
            this.LabelFontSize = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelAnchor = new System.Windows.Forms.Label();
            this.PBSaved4 = new System.Windows.Forms.PictureBox();
            this.LabelXPos = new System.Windows.Forms.Label();
            this.LabelYPosition = new System.Windows.Forms.Label();
            this.CBFonts = new System.Windows.Forms.ComboBox();
            this.PBSaved3 = new System.Windows.Forms.PictureBox();
            this.PBSaved2 = new System.Windows.Forms.PictureBox();
            this.PBSaved1 = new System.Windows.Forms.PictureBox();
            this.PanelPictureBoxes = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.TBOutputPath = new System.Windows.Forms.TextBox();
            this.BtnChangeOutput = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved1)).BeginInit();
            this.PanelPictureBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(80, 200);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Select Image";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Enabled = false;
            this.BtnCreate.Location = new System.Drawing.Point(21, 354);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 22);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Save";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // PBSelect
            // 
            this.PBSelect.Location = new System.Drawing.Point(159, 104);
            this.PBSelect.Name = "PBSelect";
            this.PBSelect.Size = new System.Drawing.Size(384, 216);
            this.PBSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSelect.TabIndex = 3;
            this.PBSelect.TabStop = false;
            // 
            // NumericUDIncrement
            // 
            this.NumericUDIncrement.Location = new System.Drawing.Point(448, 358);
            this.NumericUDIncrement.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NumericUDIncrement.Name = "NumericUDIncrement";
            this.NumericUDIncrement.Size = new System.Drawing.Size(69, 20);
            this.NumericUDIncrement.TabIndex = 4;
            this.NumericUDIncrement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUDIncrement.ValueChanged += new System.EventHandler(this.NumericUDIncrement_ValueChanged);
            // 
            // NumericUDFontSize
            // 
            this.NumericUDFontSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUDFontSize.Location = new System.Drawing.Point(91, 140);
            this.NumericUDFontSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericUDFontSize.Name = "NumericUDFontSize";
            this.NumericUDFontSize.Size = new System.Drawing.Size(60, 20);
            this.NumericUDFontSize.TabIndex = 5;
            this.NumericUDFontSize.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.NumericUDFontSize.ValueChanged += new System.EventHandler(this.NumericUDFontSize_ValueChanged);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(11, 259);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(46, 23);
            this.BtnLeft.TabIndex = 13;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(109, 259);
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
            this.NumericUDPositionX.Location = new System.Drawing.Point(23, 314);
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
            this.NumericUDPositionX.Size = new System.Drawing.Size(62, 20);
            this.NumericUDPositionX.TabIndex = 15;
            this.NumericUDPositionX.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericUDPositionX.ValueChanged += new System.EventHandler(this.NumericUDPositionX_ValueChanged);
            // 
            // NumericUDPositionY
            // 
            this.NumericUDPositionY.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUDPositionY.Location = new System.Drawing.Point(91, 314);
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
            this.NumericUDPositionY.Size = new System.Drawing.Size(62, 20);
            this.NumericUDPositionY.TabIndex = 16;
            this.NumericUDPositionY.ValueChanged += new System.EventHandler(this.NumericUDPositionY_ValueChanged);
            // 
            // BtnCenter
            // 
            this.BtnCenter.Location = new System.Drawing.Point(60, 259);
            this.BtnCenter.Name = "BtnCenter";
            this.BtnCenter.Size = new System.Drawing.Size(46, 23);
            this.BtnCenter.TabIndex = 17;
            this.BtnCenter.Text = "Center";
            this.BtnCenter.UseVisualStyleBackColor = true;
            this.BtnCenter.Click += new System.EventHandler(this.BtnCenter_Click);
            // 
            // LabelFontSize
            // 
            this.LabelFontSize.AutoSize = true;
            this.LabelFontSize.Location = new System.Drawing.Point(34, 143);
            this.LabelFontSize.Name = "LabelFontSize";
            this.LabelFontSize.Size = new System.Drawing.Size(51, 13);
            this.LabelFontSize.TabIndex = 18;
            this.LabelFontSize.Text = "Font Size";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(398, 360);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(44, 13);
            this.LabelNumber.TabIndex = 19;
            this.LabelNumber.Text = "Number";
            // 
            // LabelAnchor
            // 
            this.LabelAnchor.AutoSize = true;
            this.LabelAnchor.Location = new System.Drawing.Point(56, 243);
            this.LabelAnchor.Name = "LabelAnchor";
            this.LabelAnchor.Size = new System.Drawing.Size(54, 13);
            this.LabelAnchor.TabIndex = 20;
            this.LabelAnchor.Text = "Text Align";
            // 
            // PBSaved4
            // 
            this.PBSaved4.Location = new System.Drawing.Point(405, 3);
            this.PBSaved4.Name = "PBSaved4";
            this.PBSaved4.Size = new System.Drawing.Size(128, 72);
            this.PBSaved4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved4.TabIndex = 25;
            this.PBSaved4.TabStop = false;
            this.PBSaved4.Click += new System.EventHandler(this.PBSaved_Click);
            // 
            // LabelXPos
            // 
            this.LabelXPos.AutoSize = true;
            this.LabelXPos.Location = new System.Drawing.Point(20, 298);
            this.LabelXPos.Name = "LabelXPos";
            this.LabelXPos.Size = new System.Drawing.Size(54, 13);
            this.LabelXPos.TabIndex = 26;
            this.LabelXPos.Text = "X Position";
            // 
            // LabelYPosition
            // 
            this.LabelYPosition.AutoSize = true;
            this.LabelYPosition.Location = new System.Drawing.Point(89, 298);
            this.LabelYPosition.Name = "LabelYPosition";
            this.LabelYPosition.Size = new System.Drawing.Size(54, 13);
            this.LabelYPosition.TabIndex = 27;
            this.LabelYPosition.Text = "Y Position";
            // 
            // CBFonts
            // 
            this.CBFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFonts.Location = new System.Drawing.Point(10, 173);
            this.CBFonts.Name = "CBFonts";
            this.CBFonts.Size = new System.Drawing.Size(145, 21);
            this.CBFonts.TabIndex = 28;
            this.CBFonts.SelectedValueChanged += new System.EventHandler(this.CBFonts_SelectedValueChanged);
            // 
            // PBSaved3
            // 
            this.PBSaved3.Location = new System.Drawing.Point(271, 3);
            this.PBSaved3.Name = "PBSaved3";
            this.PBSaved3.Size = new System.Drawing.Size(128, 72);
            this.PBSaved3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved3.TabIndex = 29;
            this.PBSaved3.TabStop = false;
            this.PBSaved3.Click += new System.EventHandler(this.PBSaved_Click);
            // 
            // PBSaved2
            // 
            this.PBSaved2.Location = new System.Drawing.Point(137, 3);
            this.PBSaved2.Name = "PBSaved2";
            this.PBSaved2.Size = new System.Drawing.Size(128, 72);
            this.PBSaved2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved2.TabIndex = 30;
            this.PBSaved2.TabStop = false;
            this.PBSaved2.Click += new System.EventHandler(this.PBSaved_Click);
            // 
            // PBSaved1
            // 
            this.PBSaved1.Location = new System.Drawing.Point(3, 3);
            this.PBSaved1.Name = "PBSaved1";
            this.PBSaved1.Size = new System.Drawing.Size(128, 72);
            this.PBSaved1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSaved1.TabIndex = 31;
            this.PBSaved1.TabStop = false;
            this.PBSaved1.Click += new System.EventHandler(this.PBSaved_Click);
            // 
            // PanelPictureBoxes
            // 
            this.PanelPictureBoxes.Controls.Add(this.PBSaved3);
            this.PanelPictureBoxes.Controls.Add(this.PBSaved1);
            this.PanelPictureBoxes.Controls.Add(this.PBSaved4);
            this.PanelPictureBoxes.Controls.Add(this.PBSaved2);
            this.PanelPictureBoxes.Location = new System.Drawing.Point(10, 12);
            this.PanelPictureBoxes.Name = "PanelPictureBoxes";
            this.PanelPictureBoxes.Size = new System.Drawing.Size(537, 79);
            this.PanelPictureBoxes.TabIndex = 32;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(159, 323);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(0, 13);
            this.LabelName.TabIndex = 33;
            // 
            // TBOutputPath
            // 
            this.TBOutputPath.Enabled = false;
            this.TBOutputPath.Location = new System.Drawing.Point(97, 355);
            this.TBOutputPath.Name = "TBOutputPath";
            this.TBOutputPath.ReadOnly = true;
            this.TBOutputPath.Size = new System.Drawing.Size(236, 20);
            this.TBOutputPath.TabIndex = 34;
            this.TBOutputPath.Text = "Select Folder";
            // 
            // BtnChangeOutput
            // 
            this.BtnChangeOutput.Location = new System.Drawing.Point(333, 354);
            this.BtnChangeOutput.Name = "BtnChangeOutput";
            this.BtnChangeOutput.Size = new System.Drawing.Size(27, 22);
            this.BtnChangeOutput.TabIndex = 35;
            this.BtnChangeOutput.Text = "...";
            this.BtnChangeOutput.UseVisualStyleBackColor = true;
            this.BtnChangeOutput.Click += new System.EventHandler(this.BtnChangeOutput_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 387);
            this.Controls.Add(this.BtnChangeOutput);
            this.Controls.Add(this.TBOutputPath);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PanelPictureBoxes);
            this.Controls.Add(this.CBFonts);
            this.Controls.Add(this.LabelYPosition);
            this.Controls.Add(this.LabelXPos);
            this.Controls.Add(this.LabelAnchor);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelFontSize);
            this.Controls.Add(this.BtnCenter);
            this.Controls.Add(this.NumericUDPositionY);
            this.Controls.Add(this.NumericUDPositionX);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.NumericUDFontSize);
            this.Controls.Add(this.NumericUDIncrement);
            this.Controls.Add(this.PBSelect);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnSelect);
            this.Name = "MainControl";
            this.ShowIcon = false;
            this.Text = "Thumbnail++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainControl_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PBSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSaved1)).EndInit();
            this.PanelPictureBoxes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.PictureBox PBSelect;
        private System.Windows.Forms.NumericUpDown NumericUDIncrement;
        private System.Windows.Forms.NumericUpDown NumericUDFontSize;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.NumericUpDown NumericUDPositionX;
        private System.Windows.Forms.NumericUpDown NumericUDPositionY;
        private System.Windows.Forms.Button BtnCenter;
        private System.Windows.Forms.Label LabelFontSize;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelAnchor;
        private System.Windows.Forms.PictureBox PBSaved4;
        private System.Windows.Forms.Label LabelXPos;
        private System.Windows.Forms.Label LabelYPosition;
        private System.Windows.Forms.ComboBox CBFonts;
        private System.Windows.Forms.PictureBox PBSaved3;
        private System.Windows.Forms.PictureBox PBSaved2;
        private System.Windows.Forms.PictureBox PBSaved1;
        private System.Windows.Forms.Panel PanelPictureBoxes;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TBOutputPath;
        private System.Windows.Forms.Button BtnChangeOutput;
        private System.Windows.Forms.ToolTip ToolTip1;
    }
}

