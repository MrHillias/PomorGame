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
    public partial class FormCooking : Form
    {
        int _chosenDish;
        private Point lastLocation;
        private bool isDragging = false;
        Panel curPanel;
        Point startingPoint;
        List<Panel> panelList;
        List<Point> startingPointList;
        List<PictureBox> pictureBoxList;
        public FormCooking(int ChosenDish)
        {
            InitializeComponent();
            buttonBack.BackColor = Color.FromArgb(0, 249, 247, 205); // Устанавливаем прозрачный фон кнопки
            buttonBack.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            demonstrateDish(ChosenDish);
        }

        private void demonstrateDish(int chosenDish)
        {
            _chosenDish = chosenDish;
            panelD1.Hide();
            panelD2.Hide();
            panelD3.Hide();
            switch (chosenDish)
            {
                case 1:
                    panelD1.BackgroundImage = Properties.Resources.Plate1;
                    panelD1.BackgroundImageLayout = ImageLayout.Stretch;
                    panelD1.Visible = true;
                    curPanel = panelD1;
                    //curPanel.Location = new Point(165, 117);
                    panelList = panelD1.Controls.OfType<Panel>().ToList();
                    buttonSetUp(1);
                    break;
                case 2:
                    panelD2.BackgroundImage = Properties.Resources.Plate1;
                    panelD2.BackgroundImageLayout = ImageLayout.Stretch;
                    panelD2.Visible = true;
                    curPanel = panelD2;
                    //curPanel.Location = new Point(165, 117);
                    panelList = panelD2.Controls.OfType<Panel>().ToList();
                    buttonSetUp(2);
                    break;
                default:
                    panelD3.BackgroundImage = Properties.Resources.Plate1;
                    panelD3.BackgroundImageLayout = ImageLayout.Stretch;
                    panelD3.Visible = true;
                    curPanel = panelD3;
                    //curPanel.Location = new Point(165, 117);
                    panelList = panelD3.Controls.OfType<Panel>().ToList();
                    buttonSetUp(3);
                    break;
            }
            foreach (var panel in panelList)
            {
                panel.Enabled = true;
                panel.Visible = true;
                panel.BackgroundImage = null;
            }
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureStartDragging(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location;
                PictureBox pb = (PictureBox)sender;
                pb.SuspendLayout();
                startingPoint.X = pb.Location.X;
                startingPoint.Y = pb.Location.Y;
            }
        }

        private void pictureMoving(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (isDragging)
            {
                pb.Left += e.X - lastLocation.X;
                pb.Top += e.Y - lastLocation.Y;
            }
        }

        private void pictureStopDragging(object sender, MouseEventArgs e)
        {
            isDragging = false;
            PictureBox pb = (PictureBox)sender;
            pb.ResumeLayout();
            Rectangle pictureBoxRect = new Rectangle(pb.Location, pb.Size);
            //foreach (Panel panel in panelList)
            //{
            Rectangle panelRect = new Rectangle(curPanel.Location, curPanel.Size);
            if (IntersectsWith(panelRect, pictureBoxRect))
            {
                //panel.BackgroundImage = pb.Image; 
                //panel.BackgroundImageLayout = ImageLayout.Stretch;
                //break;

                Point pictureBoxCenter = new Point(pb.Location.X, pb.Location.Y);

                Panel closestPanel = FindClosestPanel(pictureBoxCenter);
                closestPanel.BackgroundImage = pb.Image;
                closestPanel.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Enabled = false;
                pb.Visible = false;
                pictureBoxList.Remove(pb);
                panelList.Remove(closestPanel);
                if (panelList.Count == 0)
                {
                    checkAnswer();
                }
            }
            pb.Location = new Point(startingPoint.X, startingPoint.Y);

            //}
        }

        private void checkAnswer()
        {
            switch (_chosenDish)
            {
                case 1:
                    if (!(pictureBoxList.Contains(pictureBox5) && pictureBoxList.Contains(pictureBox6) && pictureBoxList.Contains(pictureBox8)))//568{
                    {
                        labelHint.Visible = true;
                        labelHint.Text = "Ингридиенты для ухи: вода, рыба и зелень";
                        demonstrateDish(1);
                    }
                    else
                    {
                        panelD1.BackgroundImage = Properties.Resources.Uha2;
                        panelDish11.Hide();
                        panelDish12.Hide();
                        panelDish13.Hide();
                        //labelIngrid.Hide();
                        labelIngrid.Text = "Вы приготовили уху!";
                        foreach (var item in pictureBoxList)
                        {
                            item.Hide();
                        }
                        panelInfo.Visible = true;
                        labelInfo.Text = text1;
                        buttonEnd.Visible = true;
                        buttonEnd.Enabled = true;
                        buttonEnd.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
                        buttonEnd.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
                    }
                    break;
                case 2:
                    if (!(pictureBoxList.Contains(pictureBox6) && pictureBoxList.Contains(pictureBox7) && pictureBoxList.Contains(pictureBox9)))//679{
                    {
                        labelHint.Visible = true;
                        labelHint.Text = "Ингридиенты для каши: пшено, вода, соль, сахар, масло";
                        demonstrateDish(2);
                    }
                    else
                    {
                        panelD2.BackgroundImage = Properties.Resources.Kasha1;
                        panelDish21.Hide();
                        panelDish22.Hide();
                        panelDish23.Hide();
                        panelDish24.Hide();
                        panelDish25.Hide();
                        //labelIngrid.Hide();
                        labelIngrid.Text = "Вы приготовили пшенку!";
                        foreach (var item in pictureBoxList)
                        {
                            item.Hide();
                        }
                        panelInfo.Visible = true;
                        labelInfo.Text = text2;
                        buttonEnd.Visible = true;
                        buttonEnd.Enabled = true;
                        buttonEnd.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
                        buttonEnd.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
                    }
                    break;
                case 3:
                    if (!(pictureBoxList.Contains(pictureBox1) && pictureBoxList.Contains(pictureBox3) && pictureBoxList.Contains(pictureBox6)
                        && pictureBoxList.Contains(pictureBox8) && pictureBoxList.Contains(pictureBox11)))//1 3 6 8 11{
                    {
                        labelHint.Visible = true;
                        labelHint.Text = "Ингридиенты для колобков: яйца, мука, молоко, масло, сахар, соль, сметана";
                        demonstrateDish(2);
                    }
                    else
                    {
                        panelD3.BackgroundImage = Properties.Resources.Kolobok2;
                        panelDish31.Hide();
                        panelDish32.Hide();
                        panelDish33.Hide();
                        panelDish34.Hide();
                        panelDish35.Hide();
                        panelDish36.Hide();
                        panelDish37.Hide();
                        //labelIngrid.Hide();
                        labelIngrid.Text = "Вы приготовили колобки!";
                        foreach (var item in pictureBoxList)
                        {
                            item.Hide();
                        }
                        panelInfo.Visible = true;
                        labelInfo.Text = text3;
                        buttonEnd.Visible = true;
                        buttonEnd.Enabled = true;
                        buttonEnd.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
                        buttonEnd.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
                    }
                    break;
            }
        }

        private Panel FindClosestPanel(Point pictureBoxCenter)
        {
            Panel closestPanel = null;
            double minDistance = double.MaxValue;

            foreach (Panel panel in panelList)
            {
                Point panelCenter = new Point(panel.Location.X + panel.Width, panel.Location.Y + panel.Height);
                double distance = CalculateDistance(pictureBoxCenter, panelCenter);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPanel = panel;
                }
            }

            return closestPanel;
        }

        static double CalculateDistance(Point point1, Point point2)
        {
            int dx = point1.X - point2.X;
            int dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private void buttonSetUp(int Dish)
        {
            Point pictureBoxCenter;
            pictureBoxList = new List<PictureBox>();
            startingPointList = new List<Point>();
            switch (Dish)
            {
                case 1:
                    pictureBox4.Visible = true;
                    pictureBoxList.Add(pictureBox4);
                    pictureBox5.Visible = true;
                    pictureBoxList.Add(pictureBox5);
                    pictureBox6.Visible = true;
                    pictureBoxList.Add(pictureBox6);
                    pictureBox7.Visible = true;
                    pictureBoxList.Add(pictureBox7);
                    pictureBox8.Visible = true;
                    pictureBoxList.Add(pictureBox8);
                    pictureBox9.Visible = true;
                    pictureBoxList.Add(pictureBox9);
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox4.Image = Properties.Resources.Grass;
                    pictureBox5.Image = Properties.Resources.Butter;
                    pictureBox6.Image = Properties.Resources.Flour;
                    pictureBox7.Image = Properties.Resources.Water;
                    pictureBox8.Image = Properties.Resources.Eggs;
                    pictureBox9.Image = Properties.Resources.Fish;
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBoxList.Add(pictureBox1);
                    pictureBox3.Visible = true;
                    pictureBoxList.Add(pictureBox3);
                    pictureBox4.Visible = true;
                    pictureBoxList.Add(pictureBox4);
                    pictureBox6.Visible = true;
                    pictureBoxList.Add(pictureBox6);
                    pictureBox7.Visible = true;
                    pictureBoxList.Add(pictureBox7);
                    pictureBox9.Visible = true;
                    pictureBoxList.Add(pictureBox9);
                    pictureBox10.Visible = true;
                    pictureBoxList.Add(pictureBox10);
                    pictureBox12.Visible = true;
                    pictureBoxList.Add(pictureBox12);
                    pictureBox1.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox12.Enabled = true;
                    pictureBox1.Image = Properties.Resources.Butter;
                    pictureBox3.Image = Properties.Resources.Salt;
                    pictureBox4.Image = Properties.Resources.Water;
                    pictureBox6.Image = Properties.Resources.Banana;
                    pictureBox7.Image = Properties.Resources.Fish;
                    pictureBox9.Image = Properties.Resources.Pork;
                    pictureBox10.Image = Properties.Resources.Sugar;
                    pictureBox12.Image = Properties.Resources.Millet;
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBoxList.Add(pictureBox1);
                    pictureBox2.Visible = true;
                    pictureBoxList.Add(pictureBox2);
                    pictureBox3.Visible = true;
                    pictureBoxList.Add(pictureBox3);
                    pictureBox4.Visible = true;
                    pictureBoxList.Add(pictureBox4);
                    pictureBox5.Visible = true;
                    pictureBoxList.Add(pictureBox5);
                    pictureBox6.Visible = true;
                    pictureBoxList.Add(pictureBox6);
                    pictureBox7.Visible = true;
                    pictureBoxList.Add(pictureBox7);
                    pictureBox8.Visible = true;
                    pictureBoxList.Add(pictureBox8);
                    pictureBox9.Visible = true;
                    pictureBoxList.Add(pictureBox9);
                    pictureBox10.Visible = true;
                    pictureBoxList.Add(pictureBox10);
                    pictureBox11.Visible = true;
                    pictureBoxList.Add(pictureBox11);
                    pictureBox12.Visible = true;
                    pictureBoxList.Add(pictureBox12);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    pictureBox1.Image = Properties.Resources.Grass;
                    pictureBox2.Image = Properties.Resources.Oil;
                    pictureBox3.Image = Properties.Resources.Fish;
                    pictureBox4.Image = Properties.Resources.Flour;
                    pictureBox5.Image = Properties.Resources.Milk;
                    pictureBox6.Image = Properties.Resources.Banana;
                    pictureBox7.Image = Properties.Resources.Sugar;
                    pictureBox8.Image = Properties.Resources.Pork;
                    pictureBox9.Image = Properties.Resources.Eggs;
                    pictureBox10.Image = Properties.Resources.SourCreme;
                    pictureBox11.Image = Properties.Resources.Apple;
                    pictureBox12.Image = Properties.Resources.Salt;
                    break;


            }
            foreach (var pictureBox in pictureBoxList)
            {
                pictureBoxCenter = new Point(pictureBox.Location.X, pictureBox.Location.Y);
                startingPointList.Add(pictureBoxCenter);
            }
        }

        bool IntersectsWith(Rectangle rect1, Rectangle rect2) { return rect1.IntersectsWith(rect2); }

        string text1 = "Уха рыбацкая - первая перемена за обедом. Рыбу подают на стол как амостоятельную вторую перемену. Уху хлебают, закусывая хлебом. «Ушка хлеба подбирушка». Обычно на уху брали навагу, окуня, у сёмги для ухи годится голова и хвост. Уху варили только из рыбы без добавления картофеля. Для густоты уху скали мукой, то есть добавляли прибойку - смесь приготовленная из муки и холодной воды. От этого она становилась «скусней». Уха бывает двойная, тройная. Их готовили тогда, когда помору удавалось добыть особо много рыбы. Первой в ухе варят мелкую рыбу, затем ее вынимают и закладывают вторую порцию рыбы. Эти две закладки рыбы не ели. В третий раз уже кладут ту рыбу, которую затем подают к столу.";
        string text2 = "Редким и лакомым блюдом была в Поморье - каша. Пшенная каша была обязательным блюдом в празднично-обрядовой пище.";
        string text3 = "Особым разнообразием отличается поморская стряпня. Это выпечка из хожалого и пресного теста с всевозможными начинками.\r\n\r\nИз пресного теста выпекали калачи, калитки, пироги и, конечно же, колобки или как иначе их называли колоба и подстаканники.\r\n\r\nУходя на промысел, поморы чаще всего брали именно калачи и колобки, так как, испеченные особым способом, они дольше хранились и не крошились. Для оставшихся дома, хозяйка же клала в тесто больше сдобы, тогда получались они более рассыпчатыми. Утром, теплые, только, что снятые с листа (противня), днем и вечером, чуть подсохшие, но все равно вкусные, колобки хороши были и с чаем, и с молоком, и с киселем.";

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movePictureOnClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.ResumeLayout();
            Rectangle pictureBoxRect = new Rectangle(pb.Location, pb.Size);
            //foreach (Panel panel in panelList)
            //{
            Rectangle panelRect = new Rectangle(curPanel.Location, curPanel.Size);
            //panel.BackgroundImage = pb.Image; 
            //panel.BackgroundImageLayout = ImageLayout.Stretch;
            //break;

            Point pictureBoxCenter = new Point(pb.Location.X, pb.Location.Y);

            Panel closestPanel = FindClosestPanel(pictureBoxCenter);
            closestPanel.BackgroundImage = pb.Image;
            closestPanel.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Enabled = false;
            pb.Visible = false;
            pictureBoxList.Remove(pb);
            panelList.Remove(closestPanel);
            if (panelList.Count == 0)
            {
                checkAnswer();
            }

            pb.Location = new Point(startingPoint.X, startingPoint.Y);
        }
    }
}
