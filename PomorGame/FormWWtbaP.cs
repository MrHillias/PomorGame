using PomorGame.Properties;

namespace PomorGame
{
    public partial class FormWWtbaP : Form
    {
        string dir = "C:\\Users\\Ilya\\Desktop\\Pics\\";
        Random random = new Random();
        int counter = 0; //Счетчик правильных ответов
        List<int> listEasy = new List<int>();
        EasyQuestions easy;
        string curAns;//Текущая сложность
        bool correctAnswer = false;
        int randomNumber;//Номер вопроса
        int correctAns;
        int shiningCounter = 0;
        Button curBtn;
        Button ansBtn;
        public FormWWtbaP()
        {
            InitializeComponent();
            this.Shown += shown;
        }

        private void shown(object? sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(0, 249, 247, 205); // Устанавливаем прозрачный фон кнопки
            buttonBack.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            btnNextQuestion.BackColor = Color.FromArgb(255, 224, 222, 184); // Устанавливаем прозрачный фон кнопки
            btnNextQuestion.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            easy = new EasyQuestions();
            curBtn = new Button();
            ansBtn = new Button();
            defaultButtons();
            correctAns = 0;
            label0.Font = new Font(label0.Font, FontStyle.Bold);
            printQuestion("easy");
        }

        private void managePanels(bool onePic)
        {
            if (onePic)
            {
                panelPic1.Visible = false;
                panelPic2.Visible = false;
                panelPic3.Visible = false;
                panelPic4.Visible = false;
                panelBig.Visible = true;
            }
            else
            {
                panelPic1.Visible = true;
                panelPic2.Visible = true;
                panelPic3.Visible = true;
                panelPic4.Visible = true;
                panelBig.Visible = false;
            }
        }

        private void defaultButtons()
        {
            btnNextQuestion.Enabled = false;
            buttonAns1.BackColor = Color.FromArgb(0, Color.Transparent); // Устанавливаем прозрачный фон кнопки
            buttonAns1.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            buttonAns2.BackColor = Color.FromArgb(0, Color.Transparent); // Устанавливаем прозрачный фон кнопки
            buttonAns2.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            buttonAns3.BackColor = Color.FromArgb(0, Color.Transparent); // Устанавливаем прозрачный фон кнопки
            buttonAns3.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            buttonAns4.BackColor = Color.FromArgb(0, Color.Transparent); // Устанавливаем прозрачный фон кнопки
            buttonAns4.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
        }

        private void printQuestion(string category)
        {
            labelQuestionNumber.Text = "Вопрос " + (counter + 1);
            if (timer.Enabled) { timer.Stop(); }
            if (counter < 8)
            {
                randomNumber = random.Next(0, easy.questions.Count);
                if (!listEasy.Contains(randomNumber))
                {
                    int randomPos = random.Next(1, 5);
                    listEasy.Add(randomNumber);//Номер вопроса, чтобы больше его не выводить
                    managePanels(easy.questions[randomNumber].OnePicture);
                    labelQuestion.Text = easy.questions[randomNumber].Quest;
                    switch (randomPos)
                    {
                        case 2:
                            ansBtn = buttonAns4;
                            buttonAns1.Text = easy.questions[randomNumber].Ans2;
                            buttonAns2.Text = easy.questions[randomNumber].Ans3;
                            buttonAns3.Text = easy.questions[randomNumber].Ans4;
                            buttonAns4.Text = easy.questions[randomNumber].Ans1;
                            if (easy.questions[randomNumber].OnePicture)
                            {
                                panelBig.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelBig.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            else
                            {
                                panelPic1.BackgroundImage = easy.questions[randomNumber].Pics[1]; // Загружаем изображение из файла
                                panelPic1.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic2.BackgroundImage = easy.questions[randomNumber].Pics[2]; // Загружаем изображение из файла
                                panelPic2.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic3.BackgroundImage = easy.questions[randomNumber].Pics[3]; // Загружаем изображение из файла
                                panelPic3.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic4.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelPic4.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            break;
                        case 3:
                            ansBtn = buttonAns3;
                            buttonAns1.Text = easy.questions[randomNumber].Ans3;
                            buttonAns2.Text = easy.questions[randomNumber].Ans4;
                            buttonAns3.Text = easy.questions[randomNumber].Ans1;
                            buttonAns4.Text = easy.questions[randomNumber].Ans2;
                            if (easy.questions[randomNumber].OnePicture)
                            {
                                panelBig.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelBig.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            else
                            {
                                panelPic1.BackgroundImage = easy.questions[randomNumber].Pics[2]; // Загружаем изображение из файла
                                panelPic1.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic2.BackgroundImage = easy.questions[randomNumber].Pics[3]; // Загружаем изображение из файла
                                panelPic2.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic3.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelPic3.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic4.BackgroundImage = easy.questions[randomNumber].Pics[1]; // Загружаем изображение из файла
                                panelPic4.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            break;
                        case 4:
                            ansBtn = buttonAns2;
                            buttonAns1.Text = easy.questions[randomNumber].Ans4;
                            buttonAns2.Text = easy.questions[randomNumber].Ans1;
                            buttonAns3.Text = easy.questions[randomNumber].Ans2;
                            buttonAns4.Text = easy.questions[randomNumber].Ans3;
                            if (easy.questions[randomNumber].OnePicture)
                            {
                                panelBig.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelBig.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            else
                            {
                                panelPic1.BackgroundImage = easy.questions[randomNumber].Pics[3]; // Загружаем изображение из файла
                                panelPic1.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic2.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelPic2.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic3.BackgroundImage = easy.questions[randomNumber].Pics[1]; // Загружаем изображение из файла
                                panelPic3.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic4.BackgroundImage = easy.questions[randomNumber].Pics[2]; // Загружаем изображение из файла
                                panelPic4.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            break;
                        default:
                            ansBtn = buttonAns1;
                            buttonAns1.Text = easy.questions[randomNumber].Ans1;
                            buttonAns2.Text = easy.questions[randomNumber].Ans2;
                            buttonAns3.Text = easy.questions[randomNumber].Ans3;
                            buttonAns4.Text = easy.questions[randomNumber].Ans4;
                            if (easy.questions[randomNumber].OnePicture)
                            {
                                panelBig.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelBig.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            else
                            {
                                panelPic1.BackgroundImage = easy.questions[randomNumber].Pics[0]; // Загружаем изображение из файла
                                panelPic1.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic2.BackgroundImage = easy.questions[randomNumber].Pics[1]; // Загружаем изображение из файла
                                panelPic2.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic3.BackgroundImage = easy.questions[randomNumber].Pics[2]; // Загружаем изображение из файла
                                panelPic3.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                                panelPic4.BackgroundImage = easy.questions[randomNumber].Pics[3]; // Загружаем изображение из файла
                                panelPic4.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размерам Panel
                            }
                            break;
                    }
                }
                else
                {
                    printQuestion(category);
                }
            }
            else
            {

                buttonFinish.BackColor = Color.FromArgb(0, Color.Transparent); // Устанавливаем прозрачный фон кнопки
                buttonFinish.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
                labelQuestionNumber.Visible = false;
                //MessageBox.Show("Вы прошли игру! Вы набрали " + correctAns + " правильных ответов!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelVIctory.Show();
                switch (correctAns)
                {
                    case 0:
                        labelRightAns.Text += " " + correctAns + " вопросов";
                        break;
                    case 1:
                        labelRightAns.Text += " " + correctAns + " вопрос";
                        break;
                    case 2:
                        labelRightAns.Text += " " + correctAns + " вопроса";
                        break;
                    case 3:
                        labelRightAns.Text += " " + correctAns + " вопроса";
                        break;
                    case 4:
                        labelRightAns.Text += " " + correctAns + " вопроса";
                        break;
                    case 5:
                        labelRightAns.Text += " " + correctAns + " вопросов";
                        break;
                    case 6:
                        labelRightAns.Text += " " + correctAns + " вопросов";
                        break;
                    case 7:
                        labelRightAns.Text += " " + correctAns + " вопросов";
                        break;
                    case 8:
                        labelRightAns.Text += " " + correctAns + " вопросов";
                        break;
                }
                if (correctAns <= 3)
                    labelResult.Text = "Вы только начинаете изучать культуру поморов. Надеемся, что эта игра позволила вам узнать много нового! До встречи!";
                else if (correctAns <= 6)
                    labelResult.Text = "Ваши знания впечатляют. Видно, что вы не в первый раз посещаете музей";
                else
                    labelResult.Text = "Потрясающе! Вы, вероятно, либо помор, либо работник музея!";
                //btnBackToGames();
            }
        }

        private void btnBackToGames()
        {
            this.Controls.Clear();
            curBtn = null;
            ansBtn = null;
            random = null;
            easy = null;
            listEasy = null;
            this.Shown -= shown;
            this.Close();
        }

        private void btnBackToGames(object sender, EventArgs e)
        {
            btnBackToGames();
        }

        private void btnAnsClick(object sender, EventArgs e)
        {
            defaultButtons();
            btnNextQuestion.Enabled = true;
            Button btn = (Button)sender;
            curBtn = btn;
            btn.BackColor = Color.FromArgb(50, Color.Gray); // Устанавливаем прозрачный фон кнопки
            btn.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль кнопки
            curAns = btn.Text;
            btn = null;
        }

        private void btnNext(object sender, EventArgs e)
        {
            btnNextQuestion.Enabled = false;
            if (curAns == easy.questions[randomNumber].RealAns)
            {
                colorLabel(true);
                correctAnswer = true;
                timer.Start();
            }
            else
            {
                colorLabel(false);
                correctAnswer = false;
                timer.Start();
            }
            counter++;
        }

        private void colorLabel(bool v)
        {
            switch (counter)
            {
                case 0:
                    if (v) { label0.ForeColor = Color.Green; correctAns++; }
                    else { label0.ForeColor = Color.Red; }
                    label0.Font = new Font(label0.Font, FontStyle.Bold);
                    break;

                case 1:
                    if (v) { label1.ForeColor = Color.Green; correctAns++; }
                    else { label1.ForeColor = Color.Red; }
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                    break;

                case 2:
                    if (v) { label2.ForeColor = Color.Green; correctAns++; }
                    else { label2.ForeColor = Color.Red; }
                    label2.Font = new Font(label2.Font, FontStyle.Bold);
                    break;

                case 3:
                    if (v) { label3.ForeColor = Color.Green; correctAns++; }
                    else { label3.ForeColor = Color.Red; }
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    break;

                case 4:
                    if (v) { label4.ForeColor = Color.Green; correctAns++; }
                    else { label4.ForeColor = Color.Red; }
                    label4.Font = new Font(label4.Font, FontStyle.Bold);
                    break;

                case 5:
                    if (v) { label5.ForeColor = Color.Green; correctAns++; }
                    else { label5.ForeColor = Color.Red; }
                    label5.Font = new Font(label5.Font, FontStyle.Bold);
                    break;

                case 6:
                    if (v) { label6.ForeColor = Color.Green; correctAns++; }
                    else { label6.ForeColor = Color.Red; }
                    label6.Font = new Font(label6.Font, FontStyle.Bold);
                    break;

                case 7:
                    if (v) { label7.ForeColor = Color.Green; correctAns++; }
                    else { label7.ForeColor = Color.Red; }
                    label7.Font = new Font(label7.Font, FontStyle.Bold);
                    break;
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (correctAnswer)
            {
                curBtn.BackColor = curBtn.BackColor == Color.Green ? Color.FromArgb(0, Color.Transparent) : Color.Green;
            }
            else
            {
                curBtn.BackColor = curBtn.BackColor == Color.Red ? Color.FromArgb(0, Color.Transparent) : Color.Red;
                ansBtn.BackColor = Color.Green;
            }
            shiningCounter++;
            if (shiningCounter > 5)
            {
                shiningCounter = 0;
                defaultButtons();
                printQuestion("easy");
            }
        }
    }
}
