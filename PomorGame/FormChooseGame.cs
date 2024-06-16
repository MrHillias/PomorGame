using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PomorGame
{
    public partial class FormChooseGame : Form
    {
        Form formWWtbaP;
        Form formMemoria;
        Form formCooking;
        int inactivityTime = 0;
        bool musicOn = true;
        public FormChooseGame()
        {
            InitializeComponent();
            formWWtbaP = new FormWWtbaP();
            formMemoria = new FormMemory();
            formCooking = new FormCookingChoice();
            formWWtbaP.FormClosed += FormWWtbaP_FormClosed;
            formMemoria.FormClosed += FormMemoria_FormClosed;
            formCooking.FormClosed += FormCooking_FormClosed;

            button1.Click += (sender, e) =>
            {

                if (musicOn)
                {
                    button1.Text = "Звук выкл";
                    Music.MusicOff();
                    musicOn = false;
                    //sp.Stop();
                }
                else
                {
                    button1.Text = "Звук вкл";
                    Music.MusicOn();
                    musicOn = true;
                    //sp.PlayLooping();
                }
            };
            //GraphicsPath graphicsPath = new GraphicsPath();
            //graphicsPath.AddEllipse(1, 1, button2.Width - 1, button2.Height - 1);
            //button2.Region = new Region(graphicsPath);

            //Rectangle rect = new Rectangle();
            //rect.Width = button2.Width; rect.Height = button2.Height;
            //button2.DrawRoundedRectangle(Color.AliceBlue,rect,1,DrawRoundedBorder.RoundedCorners.All);

            buttonWWtbaP.BackColor = Color.FromArgb(249, 247, 205);
            button1.BackColor = Color.FromArgb(249, 247, 205);
            button2.BackColor = Color.FromArgb(249, 247, 205);
            button3.BackColor = Color.FromArgb(249, 247, 205);
            buttonBack.BackColor = Color.FromArgb(249, 247, 205);

            panelWWtbaP.Hide();
            panelMemoria.Hide();
            panelCooking.Hide();

            timer.Start();
        }

        private void FormCooking_FormClosed(object? sender, FormClosedEventArgs e)
        {
            timer.Start();
            panelCooking.Hide();
            formCooking.Dispose();
            formCooking = new FormCookingChoice();
            formCooking.FormClosed += FormCooking_FormClosed;
        }

        private void FormMemoria_FormClosed(object? sender, FormClosedEventArgs e)
        {
            timer.Start();
            panelMemoria.Hide();
            formMemoria.Dispose();
            formMemoria = new FormMemory();
            formMemoria.FormClosed += FormMemoria_FormClosed;
        }

        private void FormWWtbaP_FormClosed(object? sender, FormClosedEventArgs e)
        {
            timer.Start();
            panelWWtbaP.Hide();
            formWWtbaP.Dispose();
            formWWtbaP = new FormWWtbaP();
            formWWtbaP.FormClosed += FormWWtbaP_FormClosed;
        }

        private void btnBackToMainScreen(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenWWtbaP(object sender, EventArgs e)
        {
            timer.Stop();
            formWWtbaP.TopLevel = false;
            formWWtbaP.FormBorderStyle = FormBorderStyle.None;
            formWWtbaP.Dock = DockStyle.Fill; // заполняет Panel всей доступной площадью

            panelWWtbaP.Show();
            panelWWtbaP.Controls.Add(formWWtbaP);
            panelWWtbaP.Dock = DockStyle.Fill;
            formWWtbaP.Show();

        }

        private void btnOpenMemoria(object sender, EventArgs e)
        {
            timer.Stop();
            formMemoria.TopLevel = false;
            formMemoria.FormBorderStyle = FormBorderStyle.None;
            formMemoria.Dock = DockStyle.Fill; // заполняет Panel всей доступной площадью

            panelMemoria.Show();
            panelMemoria.Controls.Add(formMemoria);
            panelMemoria.Dock = DockStyle.Fill;
            formMemoria.Show();
        }

        private void btnOpenCooking(object sender, EventArgs e)
        {
            timer.Stop();
            formCooking.TopLevel = false;
            formCooking.FormBorderStyle = FormBorderStyle.None;
            formCooking.Dock = DockStyle.Fill; // заполняет Panel всей доступной площадью

            panelCooking.Show();
            panelCooking.Controls.Add(formCooking);
            panelCooking.Dock = DockStyle.Fill;
            formCooking.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            inactivityTime++;
            if (inactivityTime == 20)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inactivityTime = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            inactivityTime = 0;
        }
    }
}
