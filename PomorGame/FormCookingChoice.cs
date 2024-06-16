using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomorGame
{
    public partial class FormCookingChoice : Form
    {
        Form formCooking;
        public FormCookingChoice()
        {
            InitializeComponent();
            buttonBack.BackColor = Color.FromArgb(0, 249, 247, 205); // Устанавливаем прозрачный фон кнопки
            buttonBack.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            btnDish1.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
            btnDish1.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            btnDish2.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
            btnDish2.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            btnDish3.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
            btnDish3.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
        }

        private void FormCooking_FormClosed(object? sender, FormClosedEventArgs e)
        {
            panelCookingGame.Hide();
            formCooking.Dispose();
            formCooking = new FormCookingChoice();
            formCooking.FormClosed += FormCooking_FormClosed;
            //labelUha.Visible = true;
            //labelPorridge.Visible = true;
            //labelKolob.Visible = true;
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartCooking(object sender, EventArgs e)
        {
            Button btnStart = (Button)sender;
            if (btnStart.Name.Contains("1"))
            {
                formCooking = new FormCooking(1);
                //labelUha.Visible = false;
                //labelPorridge.Visible = false;
                //labelKolob.Visible = false;

            }
            else if (btnStart.Name.Contains("2"))
            {
                formCooking = new FormCooking(2);
                //labelUha.Visible = false;
                //labelPorridge.Visible = false;
                //labelKolob.Visible = false;
            }
            else
            {
                formCooking = new FormCooking(3);
                //labelUha.Visible = false;
                //labelPorridge.Visible = false;
                //labelKolob.Visible = false;
            }
            formCooking.FormClosed += FormCooking_FormClosed;
            panelCookingGame.Visible = true;
            formCooking.TopLevel = false;
            formCooking.FormBorderStyle = FormBorderStyle.None;
            formCooking.Dock = DockStyle.Fill; // заполняет Panel всей доступной площадью

            panelCookingGame.Show();
            panelCookingGame.Controls.Add(formCooking);
            panelCookingGame.Dock = DockStyle.Fill;
            formCooking.Show();
        }
    }
}
