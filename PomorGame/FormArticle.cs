using PomorGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomorGame
{
    public partial class FormArticle : Form
    {
        Dictionary<string, Bitmap> bitmapDictionary;
        public FormArticle(string Pic)
        {
            InitializeComponent();
            bitmapDictionary = new Dictionary<string, Bitmap>();
            fillBitmap();
            pictureBox1.Image = bitmapDictionary[Pic];
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            articleSet(Pic);
            button1.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
            button1.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            panel1.AutoScroll = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void fillBitmap()
        {
            bitmapDictionary.Add("Pjeksi.jpg", Resources.Pjeksi);
            bitmapDictionary.Add("Nosovik.jpg", Resources.Nosovik);
            bitmapDictionary.Add("Tues.jpg", Resources.Tues);
            bitmapDictionary.Add("Naplechnik.jpg", Resources.Naplechnik);
            bitmapDictionary.Add("Kibas.jpg", Resources.Kibas);
            bitmapDictionary.Add("Latka.jpg", Resources.Latka);
            bitmapDictionary.Add("Bratina.jpg", Resources.Bratina);
            bitmapDictionary.Add("Korob.jpg", Resources.Korob);
        }

        private void articleSet(string pic)
        {
            switch (pic)
            {
                case "Pjeksi.jpg":
                    label1.Text = "Пьексы";
                    label2.Text = "Пьексы – обувь из кожи оленя с загнутыми носами, за которые крепили болотные лыжи";
                    break;
                case "Nosovik.jpg":
                    label1.Text = "Носовик";
                    label2.Text = "Горшок с носиком называли рыльником или носовиком. Такие горшки служили для взбивания или для перетапливания коровьего масла. Для получения масла в горшок заливали снятые с молока сливки, сбивали мутовкой до образования комочка масла. Сыворотку сливали через носик в ушат на корм домашним животным. Масло вытаскивали, промывали и складывали в глиняный горшок или берестяной туес. Для перетапливания — горшок, наполненный маслом, с помощью ухвата ставился в хорошо протопленную печь. Растопленное масло сливалось через носик в деревянную кадку. Оставшаяся на дне маслянистая творожная масса шла на приготовление пирогов, блинов.";
                    break;
                case "Tues.jpg":
                    label1.Text = "Туес";
                    label2.Text = "Туес – предмет из бересты, иногда с крышкой и росписью для хранения сыпучих предметов";
                    break;
                case "Naplechnik.jpg":
                    label1.Text = "Наплечник";
                    label2.Text = "Наплечник - деревянный предмет, при помощи которого переносили ушаты с грузом";
                    break;
                case "Kibas.jpg":
                    label1.Text = "Кибас";
                    label2.Text = "Кибас - оплетенный берестой предмет, использовался для рыбалки";
                    break;
                case "Latka.jpg":
                    label1.Text = "Латка";
                    label2.Text = "Латка – предмет из металла, овальной формы с ручками для приготовления пищи";
                    break;
                case "Bratina.jpg":
                    label1.Text = "Братина";
                    label2.Text = "Братина — вид древнерусской ендовы. Они широко бытовала на Руси в XVI–XIX веках, встречалась в купеческом и крестьянском быту. Изготавливалась из меди или латуни иногда вырезалась из дерева. Представляла собой круглую в сечении невысокую чашу на поддоне со сливным носиком, иногда с ручкой. Деревянные братины украшали резьбой или росписью. Судя по историческим свидетельствам, ендову никогда не выставляли на стол, это скорее кухонный сосуд, который использовали для подачи алкогольных напитков (пива, браги, мёда, вина) на праздничный стол и их розлива по чаркам или стаканам. Хозяйка разливала напиток по стаканам и уносила ендову.";
                    break;
                case "Korob.jpg":
                    label1.Text = "Короб";
                    label2.Text = "Короб  - предмет из бересты или корня можжевельника (ели) с крышкой и застежкой -палочкой для хранения вещей в странствиях";
                    break;
            }
            /*
            if (pic == Resources.Pjeksi)
            {
                label1.Text = "Пьексы";
                label2.Text = "Пьексы – обувь из кожи оленя с загнутыми носами, за которые крепили болотные лыжи";
            }
            else if (pic == Resources.Nosovik)
            {
                label1.Text = "Носовик";
                label2.Text = "Горшок с носиком называли рыльником или носовиком. Такие горшки служили для взбивания или для перетапливания коровьего масла. Для получения масла в горшок заливали снятые с молока сливки, сбивали мутовкой до образования комочка масла. Сыворотку сливали через носик в ушат на корм домашним животным. Масло вытаскивали, промывали и складывали в глиняный горшок или берестяной туес. Для перетапливания — горшок, наполненный маслом, с помощью ухвата ставился в хорошо протопленную печь. Растопленное масло сливалось через носик в деревянную кадку. Оставшаяся на дне маслянистая творожная масса шла на приготовление пирогов, блинов.";
            }
            else if (pic == Resources.Tues)
            {
                label1.Text = "Туес";
                label2.Text = "Туес – предмет из бересты, иногда с крышкой и росписью для хранения сыпучих предметов";
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
