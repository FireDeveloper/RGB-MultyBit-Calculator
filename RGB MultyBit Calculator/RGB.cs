using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RGB_MultyBit_Calculator {
    public partial class RGB : Form {
        public RGB() {
            InitializeComponent();
        }

        byte red = 0;
        byte green = 0;
        byte blue = 0;


        private void RGB_Load(object sender, EventArgs e) {
            setRGB();
        }

        private Int32 showHex(byte r, byte g, byte b) {
            int result = ((r / 8) << 11) | ((g / 4) << 5) | (b / 8);
            return Convert.ToInt32(result);
        }

        private Int32 showHexNot(byte r, byte g, byte b) {
            int R = ~r & 0x000000FF;
            int B = ~b & 0x000000FF;
            int G = ~g & 0x000000FF;
            int result = ((R / 8) << 11) | ((G / 4) << 5) | (B / 8);
            return Convert.ToInt32(result);
        }

        private void getRGB() {
            int rgb = RGBBar.Value;
            blue = Convert.ToByte((rgb & 0x1F) << 3);
            green = Convert.ToByte(((rgb >> 5) & 0x3F) << 2);
            red = Convert.ToByte(((rgb >> 11) & 0x1F) << 3);

            if (HighRGB.Checked) {
                blue = Convert.ToByte(blue | 0x7);
                green = Convert.ToByte(green | 0x3);
                red = Convert.ToByte(red | 0x7);
            }

            BlueBar.Value = blue;
            GreenBar.Value = green;
            RedBar.Value = red;

            RedUpDown.Value = red;
            GreenUpDown.Value = green;
            BlueUpDown.Value = blue;

            txtHexBox.Text = "0x" + showHex(red, green, blue).ToString("X").PadLeft(4, '0');
            RGBcolorPanel.BackColor = Color.FromArgb(red, green, blue);
            txtHexBoxNot.Text = "0x" + showHexNot(red, green, blue).ToString("X").PadLeft(4, '0');
        }

        private void setRGB() {

            red = Convert.ToByte(RedBar.Value);
            green = Convert.ToByte(GreenBar.Value);
            blue = Convert.ToByte(BlueBar.Value);

            RedUpDown.Value = red;
            GreenUpDown.Value = green;
            BlueUpDown.Value = blue;
            RGBUpDown.Value = showHex(red, green, blue);

            txtHexBox.Text = "0x" + showHex(red, green, blue).ToString("X").PadLeft(4, '0');
            RGBcolorPanel.BackColor = Color.FromArgb(red, green, blue);
            txtHexBoxNot.Text = "0x" + showHexNot(red, green, blue).ToString("X").PadLeft(4, '0');
        }

        private void RedBar_Scroll(object sender, EventArgs e) {
            setRGB();
        }

        private void GreenBar_Scroll(object sender, EventArgs e) {
            setRGB();
        }

        private void BlueBar_Scroll(object sender, EventArgs e) {
            setRGB();
        }

        private void RGBBar_Scroll(object sender, EventArgs e) {
            getRGB();
        }

        private void RedUpDown_ValueChanged(object sender, EventArgs e) {
            RedBar.Value = Convert.ToInt32(RedUpDown.Value);
            setRGB();
        }

        private void GreenUpDown_ValueChanged(object sender, EventArgs e) {
            GreenBar.Value = Convert.ToInt32(GreenUpDown.Value);
            setRGB();
        }

        private void BlueUpDown_ValueChanged(object sender, EventArgs e) {
            BlueBar.Value = Convert.ToInt32(BlueUpDown.Value);
            setRGB();
        }

        private void RGBUpDown_ValueChanged(object sender, EventArgs e) {
            RGBBar.Value = Convert.ToInt32(RGBUpDown.Value);
            getRGB();
        }

        private void BtnColor_Click(object sender, EventArgs e) {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.OK) {
                RedBar.Value = d.Color.R;
                GreenBar.Value = d.Color.G;
                BlueBar.Value = d.Color.B;
                setRGB();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            Form f = new AboutBox();
            f.ShowDialog();
        }

    }
}