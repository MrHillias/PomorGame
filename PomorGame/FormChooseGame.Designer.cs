namespace PomorGame
{
    partial class FormChooseGame
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
            buttonWWtbaP = new Button();
            button2 = new Button();
            button3 = new Button();
            panelWWtbaP = new Panel();
            panelMemoria = new Panel();
            panelCooking = new Panel();
            pictureBox1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Location = new Point(35, 666);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += btnBackToMainScreen;
            // 
            // buttonWWtbaP
            // 
            buttonWWtbaP.BackColor = Color.Transparent;
            buttonWWtbaP.FlatStyle = FlatStyle.Flat;
            buttonWWtbaP.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWWtbaP.Location = new Point(327, 182);
            buttonWWtbaP.Name = "buttonWWtbaP";
            buttonWWtbaP.Size = new Size(601, 81);
            buttonWWtbaP.TabIndex = 1;
            buttonWWtbaP.Text = "Викторина";
            buttonWWtbaP.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonWWtbaP.UseVisualStyleBackColor = false;
            buttonWWtbaP.Click += btnOpenWWtbaP;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(327, 326);
            button2.Name = "button2";
            button2.Size = new Size(601, 81);
            button2.TabIndex = 1;
            button2.Text = "Мемория";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnOpenMemoria;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(327, 474);
            button3.Name = "button3";
            button3.Size = new Size(601, 81);
            button3.TabIndex = 1;
            button3.Text = "Поморская кухня";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnOpenCooking;
            // 
            // panelWWtbaP
            // 
            panelWWtbaP.Location = new Point(59, 97);
            panelWWtbaP.Name = "panelWWtbaP";
            panelWWtbaP.Size = new Size(200, 100);
            panelWWtbaP.TabIndex = 2;
            // 
            // panelMemoria
            // 
            panelMemoria.Location = new Point(59, 241);
            panelMemoria.Name = "panelMemoria";
            panelMemoria.Size = new Size(200, 100);
            panelMemoria.TabIndex = 2;
            // 
            // panelCooking
            // 
            panelCooking.Location = new Point(59, 389);
            panelCooking.Name = "panelCooking";
            panelCooking.Size = new Size(200, 100);
            panelCooking.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.SecondaryAnimated;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1924, 1061);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(1171, 29);
            button1.Name = "button1";
            button1.Size = new Size(78, 36);
            button1.TabIndex = 0;
            button1.Text = "Звук вкл";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormChooseGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(button1);
            Controls.Add(panelCooking);
            Controls.Add(panelMemoria);
            Controls.Add(panelWWtbaP);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonWWtbaP);
            Controls.Add(buttonBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormChooseGame";
            Text = "FormChooseGame";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private Button buttonWWtbaP;
        private Button button2;
        private Button button3;
        private Panel panelWWtbaP;
        private Panel panelMemoria;
        private Panel panelCooking;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private Button button1;
    }
}