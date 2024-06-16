using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Security.Permissions;

namespace PomorGame
{
    public partial class Form1 : Form
    {
        Form formMenu;
        bool musicOn = true;
        float currentOpacity = 1.0f;
        bool isFadingOut = false;

        public Form1()
        {
            InitializeComponent();

            formMenu = new FormChooseGame();
            //panel1.BackColor = Color.Transparent;

            //buttonStart.BackColor = Color.FromArgb(0, Color.Beige); // ”станавливаем прозрачный фон кнопки
            //buttonStart.FlatStyle = FlatStyle.Flat; // ”станавливаем плоский стиль кнопки
            formMenu.FormClosed += FormMenuChooseGames_FormClosed;
            //sp = new SoundPlayer("C:\\Users\\Ilya\\Desktop\\SampleForMenu.wav");
            //sp.PlayLooping();
            Music.MusicOn();
        }

        private void FormMenuChooseGames_FormClosed(object? sender, FormClosedEventArgs e)
        {
            panelMenu.Hide();
            formMenu = new FormChooseGame();
            formMenu.FormClosed += FormMenuChooseGames_FormClosed;
        }

        private void openMenu(object sender, EventArgs e)
        {
            formMenu.TopLevel = false;
            formMenu.FormBorderStyle = FormBorderStyle.None;
            formMenu.Dock = DockStyle.Fill; // заполн€ет Panel всей доступной площадью

            panelMenu.Show();
            panelMenu.Controls.Add(formMenu);
            panelMenu.Dock = DockStyle.Fill;
            try
            {
                formMenu.Show();
            } catch
            {
                formMenu = new FormChooseGame();
                formMenu.FormClosed += FormMenuChooseGames_FormClosed; 
                formMenu.TopLevel = false;
                formMenu.FormBorderStyle = FormBorderStyle.None;
                formMenu.Dock = DockStyle.Fill; // заполн€ет Panel всей доступной площадью

                panelMenu.Show();
                panelMenu.Controls.Add(formMenu);
                panelMenu.Dock = DockStyle.Fill;
                formMenu.Show();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                currentOpacity -= 0.05f;
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // «апрещаем развертывание окна
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}