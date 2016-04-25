namespace RGB_MultyBit_Calculator {
    partial class RGB {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGB));
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.RedUpDown = new System.Windows.Forms.NumericUpDown();
            this.GreenUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlueUpDown = new System.Windows.Forms.NumericUpDown();
            this.RGBcolorPanel = new System.Windows.Forms.Panel();
            this.txtHexBox = new System.Windows.Forms.TextBox();
            this.RGBUpDown = new System.Windows.Forms.NumericUpDown();
            this.RGBBar = new System.Windows.Forms.TrackBar();
            this.HighRGB = new System.Windows.Forms.RadioButton();
            this.LowRGB = new System.Windows.Forms.RadioButton();
            this.BtnColor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHexBoxNot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(79, 37);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(300, 45);
            this.RedBar.TabIndex = 0;
            this.RedBar.TickFrequency = 5;
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(79, 88);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(300, 45);
            this.GreenBar.TabIndex = 1;
            this.GreenBar.TickFrequency = 5;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(79, 139);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(300, 45);
            this.BlueBar.TabIndex = 2;
            this.BlueBar.TickFrequency = 5;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // RedUpDown
            // 
            this.RedUpDown.BackColor = System.Drawing.Color.Red;
            this.RedUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RedUpDown.Location = new System.Drawing.Point(12, 37);
            this.RedUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedUpDown.Name = "RedUpDown";
            this.RedUpDown.Size = new System.Drawing.Size(60, 26);
            this.RedUpDown.TabIndex = 3;
            this.RedUpDown.Tag = "RED";
            this.RedUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RedUpDown.ValueChanged += new System.EventHandler(this.RedUpDown_ValueChanged);
            // 
            // GreenUpDown
            // 
            this.GreenUpDown.BackColor = System.Drawing.Color.Green;
            this.GreenUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GreenUpDown.Location = new System.Drawing.Point(13, 88);
            this.GreenUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenUpDown.Name = "GreenUpDown";
            this.GreenUpDown.Size = new System.Drawing.Size(60, 26);
            this.GreenUpDown.TabIndex = 4;
            this.GreenUpDown.Tag = "GREEN";
            this.GreenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GreenUpDown.ValueChanged += new System.EventHandler(this.GreenUpDown_ValueChanged);
            // 
            // BlueUpDown
            // 
            this.BlueUpDown.BackColor = System.Drawing.Color.Blue;
            this.BlueUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BlueUpDown.ForeColor = System.Drawing.Color.White;
            this.BlueUpDown.Location = new System.Drawing.Point(13, 139);
            this.BlueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueUpDown.Name = "BlueUpDown";
            this.BlueUpDown.Size = new System.Drawing.Size(60, 26);
            this.BlueUpDown.TabIndex = 5;
            this.BlueUpDown.Tag = "BLUE";
            this.BlueUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlueUpDown.ValueChanged += new System.EventHandler(this.BlueUpDown_ValueChanged);
            // 
            // RGBcolorPanel
            // 
            this.RGBcolorPanel.Location = new System.Drawing.Point(385, 56);
            this.RGBcolorPanel.Name = "RGBcolorPanel";
            this.RGBcolorPanel.Size = new System.Drawing.Size(120, 26);
            this.RGBcolorPanel.TabIndex = 6;
            // 
            // txtHexBox
            // 
            this.txtHexBox.BackColor = System.Drawing.Color.White;
            this.txtHexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHexBox.Location = new System.Drawing.Point(385, 101);
            this.txtHexBox.Name = "txtHexBox";
            this.txtHexBox.ReadOnly = true;
            this.txtHexBox.Size = new System.Drawing.Size(120, 26);
            this.txtHexBox.TabIndex = 7;
            this.txtHexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RGBUpDown
            // 
            this.RGBUpDown.BackColor = System.Drawing.Color.White;
            this.RGBUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RGBUpDown.ForeColor = System.Drawing.Color.Black;
            this.RGBUpDown.Hexadecimal = true;
            this.RGBUpDown.Location = new System.Drawing.Point(12, 190);
            this.RGBUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.RGBUpDown.Name = "RGBUpDown";
            this.RGBUpDown.Size = new System.Drawing.Size(60, 23);
            this.RGBUpDown.TabIndex = 8;
            this.RGBUpDown.Tag = "RED";
            this.RGBUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RGBUpDown.ValueChanged += new System.EventHandler(this.RGBUpDown_ValueChanged);
            // 
            // RGBBar
            // 
            this.RGBBar.Location = new System.Drawing.Point(79, 190);
            this.RGBBar.Maximum = 65535;
            this.RGBBar.Name = "RGBBar";
            this.RGBBar.Size = new System.Drawing.Size(300, 45);
            this.RGBBar.TabIndex = 9;
            this.RGBBar.TickFrequency = 1285;
            this.RGBBar.Scroll += new System.EventHandler(this.RGBBar_Scroll);
            // 
            // HighRGB
            // 
            this.HighRGB.AutoSize = true;
            this.HighRGB.Checked = true;
            this.HighRGB.Location = new System.Drawing.Point(391, 178);
            this.HighRGB.Name = "HighRGB";
            this.HighRGB.Size = new System.Drawing.Size(103, 17);
            this.HighRGB.TabIndex = 10;
            this.HighRGB.TabStop = true;
            this.HighRGB.Text = "Using High RGB";
            this.HighRGB.UseVisualStyleBackColor = true;
            // 
            // LowRGB
            // 
            this.LowRGB.AutoSize = true;
            this.LowRGB.Location = new System.Drawing.Point(391, 201);
            this.LowRGB.Name = "LowRGB";
            this.LowRGB.Size = new System.Drawing.Size(101, 17);
            this.LowRGB.TabIndex = 11;
            this.LowRGB.Text = "Using Low RGB";
            this.LowRGB.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnColor.Location = new System.Drawing.Point(385, 27);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(120, 23);
            this.BtnColor.TabIndex = 12;
            this.BtnColor.Text = "Colors";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtHexBoxNot
            // 
            this.txtHexBoxNot.BackColor = System.Drawing.Color.White;
            this.txtHexBoxNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtHexBoxNot.Location = new System.Drawing.Point(385, 146);
            this.txtHexBoxNot.Name = "txtHexBoxNot";
            this.txtHexBoxNot.ReadOnly = true;
            this.txtHexBoxNot.Size = new System.Drawing.Size(120, 26);
            this.txtHexBoxNot.TabIndex = 14;
            this.txtHexBoxNot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inverted RGB-565";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Normal RGB-565";
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHexBoxNot);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.LowRGB);
            this.Controls.Add(this.HighRGB);
            this.Controls.Add(this.RGBBar);
            this.Controls.Add(this.RGBUpDown);
            this.Controls.Add(this.txtHexBox);
            this.Controls.Add(this.RGBcolorPanel);
            this.Controls.Add(this.BlueUpDown);
            this.Controls.Add(this.GreenUpDown);
            this.Controls.Add(this.RedUpDown);
            this.Controls.Add(this.BlueBar);
            this.Controls.Add(this.GreenBar);
            this.Controls.Add(this.RedBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RGB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Multy Bit Calculator";
            this.Load += new System.EventHandler(this.RGB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.NumericUpDown RedUpDown;
        private System.Windows.Forms.NumericUpDown GreenUpDown;
        private System.Windows.Forms.NumericUpDown BlueUpDown;
        private System.Windows.Forms.Panel RGBcolorPanel;
        private System.Windows.Forms.TextBox txtHexBox;
        private System.Windows.Forms.NumericUpDown RGBUpDown;
        private System.Windows.Forms.TrackBar RGBBar;
        private System.Windows.Forms.RadioButton HighRGB;
        private System.Windows.Forms.RadioButton LowRGB;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHexBoxNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}