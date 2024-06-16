using PomorGame.Properties;
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
    public partial class FormMemory : Form
    {
        string dir = "C:\\Users\\Ilya\\Desktop\\Pics\\";
        List<int> ansOrder = new List<int>();//Новый мировой порядок пар
        List<Button> buttonList = new List<Button>();//Все кнопки на экране
        string prevChoice = "";
        bool firstClick = true;//первый клик
        bool corrAns = false;
        int rightQuestions = 0;
        public FormMemory()
        {
            InitializeComponent();
            this.Shown += shown;
        }

        private void shown(object? sender, EventArgs e)
        {
            //pictureBox1.BackColor = Color.FromArgb(249, 247, 205); 
            buttonBack.BackColor = Color.FromArgb(0, 249, 247, 205); // Устанавливаем прозрачный фон кнопки
            buttonBack.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            btnListFill();
            panelsSetUp();
            btnsOnOff(false);
            /*
             * Основная идея:
             * Пока что выводим 16 "карточек", имеем 16 отсортированных в случайном порядке чисел
             * Пары будут, соответственно, 1 и 16, 2 и 15, 3 и 14, т.е. в сумме 17
             */
            Random random = new Random();

            ansOrder = numbers.OrderBy(x => random.Next()).ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (ansOrder[i] > numbers[(numbers.Length) / 2 - 1])
                {
                    ansOrder[i] = ansOrder.Count + 1 - ansOrder[i];
                }
            }
            showAllButtons(true);
            timerFirstOpen.Start();
        }

        private void btnBackToMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnsClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int num = Convert.ToInt32(btn.Name.Substring(6));
            btn.Text = ansOrder[num - 1].ToString();
            Font font = new Font("Arial", 1, FontStyle.Regular);
            btn.Font = font;
            if (firstClick)
            {
                btn.Enabled = false;
                prevChoice = btn.Name;
                firstClick = false;
                btnColoring(ansOrder[num - 1], btn);
            }
            else
            {
                btnColoring(ansOrder[num - 1], btn);
                btnsOnOff(false);
                Button? foundButton = this.Controls.Find(prevChoice, true).FirstOrDefault() as Button;
                prevChoice += "/" + btn.Name;
                if (btn.Text == foundButton.Text)
                {
                    rightQuestions++;
                    labelHint.Visible = true;
                    corrAns = true;
                    startAnimation(ansOrder[num - 1]);
                    if (rightQuestions == 8)
                    {
                        panelFinish.Show();
                        buttonFinish.BackColor = Color.FromArgb(0, 249, 247, 205); // Устанавливаем прозрачный фон кнопки
                        buttonFinish.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
                    }
                }
                else
                {
                    corrAns = false;
                    //foundButton.Visible = true;
                    //foundButton.Enabled = true;
                    //btn.Visible = true;
                    //btn.Enabled = true;
                    //btn.Text = "?";
                    //foundButton.Text = "?";
                }
                firstClick = true;
                timer.Start();
            }
        }

        private void btnColoring(int num, Button btn)
        {
            switch (num)
            {
                case 1:
                    btn.BackgroundImage = Resources.Pjeksi;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    btn.BackgroundImage = Resources.Nosovik;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    btn.BackgroundImage = Resources.Tues;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    btn.BackgroundImage = Resources.Naplechnik;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 5:
                    btn.BackgroundImage = Resources.Kibas;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 6:
                    btn.BackgroundImage = Resources.Latka;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 7:
                    btn.BackgroundImage = Resources.Bratina;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 8:
                    btn.BackgroundImage = Resources.Korob;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                default:
                    break;
            }
        }

        private void startAnimation(int numPanel)
        {
            Panel curPanel;
            Color curColor;
            switch (numPanel)
            {
                case 1:
                    curPanel = panel1;
                    curPanel.BackgroundImage = Resources.Pjeksi;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Red;
                    break;
                case 2:
                    curPanel = panel2;
                    curPanel.BackgroundImage = Resources.Nosovik;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Blue;
                    break;
                case 3:
                    curPanel = panel3;
                    curPanel.BackgroundImage = Resources.Tues;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Green;
                    break;
                case 4:
                    curPanel = panel4;
                    curPanel.BackgroundImage = Resources.Naplechnik;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Red;
                    break;
                case 5:
                    curPanel = panel5;
                    curPanel.BackgroundImage = Resources.Kibas;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Red;
                    break;
                case 6:
                    curPanel = panel6;
                    curPanel.BackgroundImage = Resources.Latka;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Red;
                    break;
                case 7:
                    curPanel = panel7;
                    curPanel.BackgroundImage = Resources.Bratina;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Red;
                    break;
                default:
                    curPanel = panel8;
                    curPanel.BackgroundImage = Resources.Korob;
                    curPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    curColor = Color.Red;
                    break;
            }
            curPanel.Visible = true;
            curPanel.BackColor = Color.FromArgb(0, curColor); // Увеличиваем прозрачность
            curPanel.Refresh(); // Обновляем Panel для отображения изменений
            timerAnimationPanel.Tick += (sender, e) =>
            {
                try
                {
                    curPanel.BackColor = Color.FromArgb(curPanel.BackColor.A + 25, curColor); // Увеличиваем прозрачность
                    curPanel.BackColor = Color.FromArgb(curPanel.BackColor.B + 25, curColor); // Увеличиваем прозрачность
                    curPanel.BackColor = Color.FromArgb(curPanel.BackColor.A + 25, curColor); // Увеличиваем прозрачность
                    curPanel.BackColor = Color.FromArgb(curPanel.BackColor.R + 25, curColor); // Увеличиваем прозрачность

                    curPanel.Refresh(); // Обновляем Panel для отображения изменений
                }
                catch
                {
                    curPanel.BackColor = Color.FromArgb(255, curColor); // Увеличиваем прозрачность

                    curPanel.Refresh(); // Обновляем Panel для отображения изменений
                    timerAnimationPanel.Stop();
                }
            };
            //timerAnimationPanel.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            String btn1 = prevChoice.Split('/')[0];
            String btn2 = prevChoice.Split('/')[1];
            Font font = new Font("Arial", 30, FontStyle.Regular);
            if (!corrAns)
            {
                Button? foundButton = this.Controls.Find(btn1, true).FirstOrDefault() as Button;
                foundButton.BackgroundImage = null;
                foundButton.Font = font;
                foundButton.Text = "?";
                foundButton = this.Controls.Find(btn2, true).FirstOrDefault() as Button;
                foundButton.BackgroundImage = null;
                foundButton.Font = font;
                foundButton.Text = "?";
            }
            else
            {
                Button? foundButton = this.Controls.Find(btn1, true).FirstOrDefault() as Button;
                foundButton.Dispose();
                foundButton = this.Controls.Find(btn2, true).FirstOrDefault() as Button;
                foundButton.Dispose();
            }
            timer.Stop();
            btnsOnOff(true);
        }

        private void btnsOnOff(bool on)
        {
            if (on)
            {
                foreach (Button btn in buttonList)
                {
                    btn.Enabled = true;
                }
            }
            else
            {
                foreach (Button btn in buttonList)
                {
                    btn.Enabled = false;
                }
            }
        }

        private void timerGameStart(object sender, EventArgs e)
        {
            showAllButtons(false);
            btnsOnOff(true);
            timerFirstOpen.Stop();
        }
        private void btnListFill()
        {
            buttonList.Add(btnAns1);
            buttonList.Add(btnAns2);
            buttonList.Add(btnAns3);
            buttonList.Add(btnAns4);
            buttonList.Add(btnAns5);
            buttonList.Add(btnAns6);
            buttonList.Add(btnAns7);
            buttonList.Add(btnAns8);
            buttonList.Add(btnAns9);
            buttonList.Add(btnAns10);
            buttonList.Add(btnAns11);
            buttonList.Add(btnAns12);
            buttonList.Add(btnAns13);
            buttonList.Add(btnAns14);
            buttonList.Add(btnAns15);
            buttonList.Add(btnAns16);
        }
        private void panelsSetUp()
        {
            panel1.BackColor = Color.FromArgb(0, Color.Transparent);
            panel2.BackColor = Color.FromArgb(0, Color.Blue);
            panel3.BackColor = Color.FromArgb(0, Color.Green);
            panel4.BackColor = Color.FromArgb(0, Color.Red);
            panel5.BackColor = Color.FromArgb(0, Color.Red);
            panel6.BackColor = Color.FromArgb(0, Color.Red);
            panel7.BackColor = Color.FromArgb(0, Color.Red);
            panel8.BackColor = Color.FromArgb(0, Color.Red);
        }

        private void showAllButtons(bool show)
        {
            foreach (Button btn in buttonList)
            {
                if (show)
                {
                    Font font = new Font("Arial", 1, FontStyle.Regular);
                    btn.Font = font;
                    btn.Text = ansOrder[buttonList.IndexOf(btn)].ToString();
                    switch (btn.Text)
                    {
                        case "1":
                            btn.BackgroundImage = Resources.Pjeksi;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "2":
                            btn.BackgroundImage = Resources.Nosovik;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "3":
                            btn.BackgroundImage = Resources.Tues;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "4":
                            btn.BackgroundImage = Resources.Naplechnik;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "5":
                            btn.BackgroundImage = Resources.Kibas;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "6":
                            btn.BackgroundImage = Resources.Latka;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "7":
                            btn.BackgroundImage = Resources.Bratina;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case "8":
                            btn.BackgroundImage = Resources.Korob;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Font font = new Font("Arial", 30, FontStyle.Regular);
                    btn.Font = font;
                    btn.Text = "?";
                    btn.BackgroundImage = null;
                }
            }
        }

        private void pnlShowArticle(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            char num = pnl.Name[5];
            switch (num)
            {
                case '1':
                    Form article = new FormArticle("Pjeksi.jpg");
                    article.StartPosition = FormStartPosition.CenterParent;
                    article.ShowDialog();
                    break;
                case '2':
                    Form article2 = new FormArticle("Nosovik.jpg");
                    article2.StartPosition = FormStartPosition.CenterParent;
                    article2.ShowDialog();
                    break;
                case '3':
                    Form article3 = new FormArticle("Tues.jpg");
                    article3.StartPosition = FormStartPosition.CenterParent;
                    article3.ShowDialog();
                    break;
                case '4':
                    Form article4 = new FormArticle("Naplechnik.jpg");
                    article4.StartPosition = FormStartPosition.CenterParent;
                    article4.ShowDialog();
                    break;
                case '5':
                    Form article5 = new FormArticle("Kibas.jpg");
                    article5.StartPosition = FormStartPosition.CenterParent;
                    article5.ShowDialog();
                    break;
                case '6':
                    Form article6 = new FormArticle("Latka.jpg");
                    article6.StartPosition = FormStartPosition.CenterParent;
                    article6.ShowDialog();
                    break;
                case '7':
                    Form article7 = new FormArticle("Bratina.jpg");
                    article7.StartPosition = FormStartPosition.CenterParent;
                    article7.ShowDialog();
                    break;
                case '8':
                    Form article8 = new FormArticle("Korob.jpg");
                    article8.StartPosition = FormStartPosition.CenterParent;
                    article8.ShowDialog();
                    break;
            }
        }
    }
}
