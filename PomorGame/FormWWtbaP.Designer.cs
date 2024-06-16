namespace PomorGame
{
    partial class FormWWtbaP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonBack = new Button();
            panel1 = new Panel();
            labelQuestion = new Label();
            buttonAns1 = new Button();
            buttonAns2 = new Button();
            buttonAns4 = new Button();
            buttonAns3 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label0 = new Label();
            panelPic1 = new Panel();
            panelBig = new Panel();
            imageList1 = new ImageList(components);
            panelPic2 = new Panel();
            panelPic3 = new Panel();
            panelPic4 = new Panel();
            btnNextQuestion = new Button();
            timer = new System.Windows.Forms.Timer(components);
            labelQuestionNumber = new Label();
            panelVIctory = new Panel();
            buttonFinish = new Button();
            labelResult = new Label();
            labelRightAns = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelVIctory.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(44, 648);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += btnBackToGames;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(labelQuestion);
            panel1.Location = new Point(61, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 178);
            panel1.TabIndex = 1;
            // 
            // labelQuestion
            // 
            labelQuestion.Dock = DockStyle.Fill;
            labelQuestion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestion.Location = new Point(0, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(582, 178);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "-";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAns1
            // 
            buttonAns1.BackColor = Color.Transparent;
            buttonAns1.Location = new Point(61, 302);
            buttonAns1.Name = "buttonAns1";
            buttonAns1.Size = new Size(246, 75);
            buttonAns1.TabIndex = 3;
            buttonAns1.UseVisualStyleBackColor = false;
            buttonAns1.Click += btnAnsClick;
            // 
            // buttonAns2
            // 
            buttonAns2.BackColor = Color.Transparent;
            buttonAns2.Location = new Point(404, 302);
            buttonAns2.Name = "buttonAns2";
            buttonAns2.Size = new Size(239, 75);
            buttonAns2.TabIndex = 3;
            buttonAns2.UseVisualStyleBackColor = false;
            buttonAns2.Click += btnAnsClick;
            // 
            // buttonAns4
            // 
            buttonAns4.BackColor = Color.Transparent;
            buttonAns4.Location = new Point(404, 453);
            buttonAns4.Name = "buttonAns4";
            buttonAns4.Size = new Size(239, 75);
            buttonAns4.TabIndex = 3;
            buttonAns4.UseVisualStyleBackColor = false;
            buttonAns4.Click += btnAnsClick;
            // 
            // buttonAns3
            // 
            buttonAns3.BackColor = Color.Transparent;
            buttonAns3.Location = new Point(61, 453);
            buttonAns3.Name = "buttonAns3";
            buttonAns3.Size = new Size(246, 75);
            buttonAns3.TabIndex = 3;
            buttonAns3.UseVisualStyleBackColor = false;
            buttonAns3.Click += btnAnsClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label0);
            panel2.Location = new Point(75, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 77);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(490, 15);
            label7.Name = "label7";
            label7.Size = new Size(33, 45);
            label7.TabIndex = 0;
            label7.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(425, 15);
            label6.Name = "label6";
            label6.Size = new Size(33, 45);
            label6.TabIndex = 0;
            label6.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(360, 15);
            label5.Name = "label5";
            label5.Size = new Size(33, 45);
            label5.TabIndex = 0;
            label5.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(295, 15);
            label4.Name = "label4";
            label4.Size = new Size(33, 45);
            label4.TabIndex = 0;
            label4.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(230, 15);
            label3.Name = "label3";
            label3.Size = new Size(33, 45);
            label3.TabIndex = 0;
            label3.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 15);
            label2.Name = "label2";
            label2.Size = new Size(33, 45);
            label2.TabIndex = 0;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 15);
            label1.Name = "label1";
            label1.Size = new Size(33, 45);
            label1.TabIndex = 0;
            label1.Text = "-";
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label0.Location = new Point(35, 15);
            label0.Name = "label0";
            label0.Size = new Size(33, 45);
            label0.TabIndex = 0;
            label0.Text = "-";
            // 
            // panelPic1
            // 
            panelPic1.Location = new Point(711, 127);
            panelPic1.Name = "panelPic1";
            panelPic1.Size = new Size(248, 178);
            panelPic1.TabIndex = 5;
            // 
            // panelBig
            // 
            panelBig.Location = new Point(714, 115);
            panelBig.Name = "panelBig";
            panelBig.Size = new Size(520, 374);
            panelBig.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panelPic2
            // 
            panelPic2.Location = new Point(981, 127);
            panelPic2.Name = "panelPic2";
            panelPic2.Size = new Size(248, 178);
            panelPic2.TabIndex = 5;
            // 
            // panelPic3
            // 
            panelPic3.Location = new Point(711, 323);
            panelPic3.Name = "panelPic3";
            panelPic3.Size = new Size(248, 178);
            panelPic3.TabIndex = 5;
            // 
            // panelPic4
            // 
            panelPic4.Location = new Point(981, 323);
            panelPic4.Name = "panelPic4";
            panelPic4.Size = new Size(248, 178);
            panelPic4.TabIndex = 5;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Enabled = false;
            btnNextQuestion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextQuestion.Location = new Point(807, 563);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(329, 57);
            btnNextQuestion.TabIndex = 6;
            btnNextQuestion.Text = "Следующий вопрос";
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNext;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_tick;
            // 
            // labelQuestionNumber
            // 
            labelQuestionNumber.AutoSize = true;
            labelQuestionNumber.BackColor = Color.Transparent;
            labelQuestionNumber.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestionNumber.Location = new Point(260, 42);
            labelQuestionNumber.Name = "labelQuestionNumber";
            labelQuestionNumber.Size = new Size(112, 47);
            labelQuestionNumber.TabIndex = 7;
            labelQuestionNumber.Text = "label8";
            // 
            // panelVIctory
            // 
            panelVIctory.BackColor = Color.Transparent;
            panelVIctory.Controls.Add(buttonFinish);
            panelVIctory.Controls.Add(labelResult);
            panelVIctory.Controls.Add(labelRightAns);
            panelVIctory.Controls.Add(label8);
            panelVIctory.Location = new Point(44, 49);
            panelVIctory.Name = "panelVIctory";
            panelVIctory.Size = new Size(1190, 577);
            panelVIctory.TabIndex = 8;
            panelVIctory.Visible = false;
            // 
            // buttonFinish
            // 
            buttonFinish.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinish.Location = new Point(460, 424);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(204, 61);
            buttonFinish.TabIndex = 3;
            buttonFinish.Text = "Выход";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += btnBackToGames;
            // 
            // labelResult
            // 
            labelResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(261, 221);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(519, 158);
            labelResult.TabIndex = 2;
            labelResult.Text = "labelResult";
            // 
            // labelRightAns
            // 
            labelRightAns.AutoSize = true;
            labelRightAns.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelRightAns.Location = new Point(261, 169);
            labelRightAns.Name = "labelRightAns";
            labelRightAns.Size = new Size(523, 32);
            labelRightAns.TabIndex = 1;
            labelRightAns.Text = "Вы прошли викторину, правильно ответив на";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(427, 57);
            label8.Name = "label8";
            label8.Size = new Size(278, 50);
            label8.TabIndex = 0;
            label8.Text = "Результаты!";
            // 
            // FormWWtbaP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GameBorder1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1274, 711);
            Controls.Add(panelVIctory);
            Controls.Add(labelQuestionNumber);
            Controls.Add(panelBig);
            Controls.Add(btnNextQuestion);
            Controls.Add(panelPic4);
            Controls.Add(panelPic2);
            Controls.Add(panelPic3);
            Controls.Add(panelPic1);
            Controls.Add(panel2);
            Controls.Add(buttonAns3);
            Controls.Add(buttonAns4);
            Controls.Add(buttonAns2);
            Controls.Add(buttonAns1);
            Controls.Add(panel1);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormWWtbaP";
            Text = "FormWWtbaP";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelVIctory.ResumeLayout(false);
            panelVIctory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Panel panel1;
        private Label labelQuestion;
        private Button buttonAns1;
        private Button buttonAns2;
        private Button buttonAns4;
        private Button buttonAns3;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label0;
        private Panel panelPic1;
        private ImageList imageList1;
        private Panel panelPic2;
        private Panel panelPic3;
        private Panel panelPic4;
        private Button btnNextQuestion;
        private Panel panelBig;
        private System.Windows.Forms.Timer timer;
        private Label labelQuestionNumber;
        private Panel panelVIctory;
        private Button buttonFinish;
        private Label labelResult;
        private Label labelRightAns;
        private Label label8;
    }
}