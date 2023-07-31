using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spy_Sploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = String.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int shit_aids_fuck = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shit_aids_fuck = shit_aids_fuck + 1;

            if (shit_aids_fuck == 1)
            {
                panel1.BackColor = Color.FromArgb(20, 20, 20);
                panel2.BackColor = Color.FromArgb(12, 12, 12);
                button3.BackColor = Color.FromArgb(20, 20, 20);
                button2.BackColor = Color.FromArgb(20, 20, 20);
                button4.BackColor = Color.FromArgb(20, 20, 20);
                button5.BackColor = Color.FromArgb(20, 20, 20);
                button8.BackColor = Color.FromArgb(20, 20, 20);
                button6.BackColor = Color.FromArgb(20, 20, 20);
                button1.BackColor = Color.FromArgb(20, 20, 20);
                this.BackColor = Color.FromArgb(20, 20, 20);
                fastColoredTextBox1.BackColor = Color.FromArgb(20, 20, 20);
                fastColoredTextBox1.IndentBackColor = Color.FromArgb(20, 20, 20);

                button3.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                button2.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                button4.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                button5.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                button8.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                button6.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                button1.FlatAppearance.BorderColor = Color.FromArgb(12, 12, 12);
                fastColoredTextBox1.ServiceLinesColor = Color.FromArgb(12, 12, 12);
                pictureBox2.Image = Spy_Sploit.Properties.Resources.piajauerd;
                pictureBox2.Refresh();
            }
            if (shit_aids_fuck == 2)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button2.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button1.BackColor = Color.White;
                this.BackColor = Color.White;
                fastColoredTextBox1.BackColor = Color.White;
                fastColoredTextBox1.IndentBackColor = Color.WhiteSmoke;

                button3.FlatAppearance.BorderColor = Color.Silver;
                button2.FlatAppearance.BorderColor = Color.Silver;
                button4.FlatAppearance.BorderColor = Color.Silver;
                button5.FlatAppearance.BorderColor = Color.Silver;
                button8.FlatAppearance.BorderColor = Color.Silver;
                button6.FlatAppearance.BorderColor = Color.Silver;
                button1.FlatAppearance.BorderColor = Color.Silver;
                fastColoredTextBox1.ServiceLinesColor = Color.Silver;
                pictureBox2.Image = Spy_Sploit.Properties.Resources.sol;
                pictureBox2.Refresh();
                shit_aids_fuck = 0;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_3(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged_4(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
// GUI by str4nd, code by xanderdk/Ryan Gosling. discord.gg/dV2MmY5vw6