namespace WhoWantsToBeAMillionaire
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            pictureBox1 = new PictureBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            lblQuestion = new Label();
            lstLevel = new ListBox();
            groupBox1 = new GroupBox();
            btnChange = new Button();
            btnMistake = new Button();
            btnCall = new Button();
            btnFF = new Button();
            btnHelp = new Button();
            label1 = new Label();
            lblSum = new Label();
            lblUser = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnA
            // 
            btnA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnA.BackColor = Color.White;
            btnA.Enabled = false;
            btnA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnA.ForeColor = Color.Black;
            btnA.Location = new Point(12, 517);
            btnA.Name = "btnA";
            btnA.Size = new Size(237, 65);
            btnA.TabIndex = 1;
            btnA.Tag = "1";
            btnA.Text = "A: ";
            btnA.TextAlign = ContentAlignment.MiddleLeft;
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnAnswer_Click;
            // 
            // btnB
            // 
            btnB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnB.BackColor = Color.White;
            btnB.Enabled = false;
            btnB.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnB.ForeColor = Color.Black;
            btnB.Location = new Point(255, 517);
            btnB.Name = "btnB";
            btnB.Size = new Size(237, 65);
            btnB.TabIndex = 2;
            btnB.Tag = "2";
            btnB.Text = "B: ";
            btnB.TextAlign = ContentAlignment.MiddleLeft;
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnAnswer_Click;
            // 
            // btnC
            // 
            btnC.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnC.BackColor = Color.White;
            btnC.Enabled = false;
            btnC.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.ForeColor = Color.Black;
            btnC.Location = new Point(12, 588);
            btnC.Name = "btnC";
            btnC.Size = new Size(237, 65);
            btnC.TabIndex = 3;
            btnC.Tag = "3";
            btnC.Text = "C: ";
            btnC.TextAlign = ContentAlignment.MiddleLeft;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnAnswer_Click;
            // 
            // btnD
            // 
            btnD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnD.BackColor = Color.White;
            btnD.Enabled = false;
            btnD.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnD.ForeColor = Color.Black;
            btnD.Location = new Point(255, 588);
            btnD.Name = "btnD";
            btnD.Size = new Size(237, 65);
            btnD.TabIndex = 4;
            btnD.Tag = "4";
            btnD.Text = "D: ";
            btnD.TextAlign = ContentAlignment.MiddleLeft;
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnAnswer_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.ForeColor = Color.Black;
            lblQuestion.Location = new Point(12, 385);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(480, 124);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "Добро пожаловать";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstLevel
            // 
            lstLevel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lstLevel.BackColor = Color.White;
            lstLevel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstLevel.ForeColor = Color.Black;
            lstLevel.FormattingEnabled = true;
            lstLevel.ItemHeight = 25;
            lstLevel.Items.AddRange(new object[] { "3 000 000", "1 500 000", "800 000", "400 000", "200 000", "100 000", "50 000", "25 000", "15 000", "10 000", "5 000", "3 000", "2 000", "1 000", "500" });
            lstLevel.Location = new Point(498, 12);
            lstLevel.Name = "lstLevel";
            lstLevel.Size = new Size(247, 379);
            lstLevel.TabIndex = 6;
            lstLevel.TabStop = false;
            lstLevel.MouseDown += lstLevel_MouseDown;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(btnChange);
            groupBox1.Controls.Add(btnMistake);
            groupBox1.Controls.Add(btnCall);
            groupBox1.Controls.Add(btnFF);
            groupBox1.Controls.Add(btnHelp);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(498, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 256);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подсказки";
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.White;
            btnChange.Enabled = false;
            btnChange.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.Black;
            btnChange.Location = new Point(6, 210);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(235, 40);
            btnChange.TabIndex = 9;
            btnChange.Text = "Замена вопроса";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnMistake
            // 
            btnMistake.BackColor = Color.White;
            btnMistake.Enabled = false;
            btnMistake.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMistake.ForeColor = Color.Black;
            btnMistake.Location = new Point(6, 164);
            btnMistake.Name = "btnMistake";
            btnMistake.Size = new Size(235, 40);
            btnMistake.TabIndex = 8;
            btnMistake.Text = "Право на ошибку";
            btnMistake.UseVisualStyleBackColor = false;
            btnMistake.Click += btnMistake_Click;
            // 
            // btnCall
            // 
            btnCall.BackColor = Color.White;
            btnCall.Enabled = false;
            btnCall.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCall.ForeColor = Color.Black;
            btnCall.Location = new Point(6, 118);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(235, 40);
            btnCall.TabIndex = 7;
            btnCall.Text = "Звонок другу";
            btnCall.UseVisualStyleBackColor = false;
            btnCall.Click += btnCall_Click;
            // 
            // btnFF
            // 
            btnFF.BackColor = Color.White;
            btnFF.Enabled = false;
            btnFF.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFF.ForeColor = Color.Black;
            btnFF.Location = new Point(6, 72);
            btnFF.Name = "btnFF";
            btnFF.Size = new Size(235, 40);
            btnFF.TabIndex = 6;
            btnFF.Text = "50 на 50";
            btnFF.UseVisualStyleBackColor = false;
            btnFF.Click += btnFF_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.White;
            btnHelp.Enabled = false;
            btnHelp.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelp.ForeColor = Color.Black;
            btnHelp.Location = new Point(6, 26);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(235, 40);
            btnHelp.TabIndex = 5;
            btnHelp.Text = "Помощь зала";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 8;
            label1.Text = "Несгораемая сумма:";
            // 
            // lblSum
            // 
            lblSum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSum.ForeColor = Color.Black;
            lblSum.Location = new Point(181, 41);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(311, 21);
            lblSum.TabIndex = 9;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(70, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(422, 21);
            lblUser.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 10;
            label3.Text = "Игрок:";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 661);
            Controls.Add(lblUser);
            Controls.Add(label3);
            Controls.Add(lblSum);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(lstLevel);
            Controls.Add(lblQuestion);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(772, 641);
            Name = "Game";
            Text = "Кто хочет стать миллионером?";
            FormClosed += Game_FormClosed;
            Shown += Game_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label lblQuestion;
        private ListBox lstLevel;
        private GroupBox groupBox1;
        private Button btnChange;
        private Button btnMistake;
        private Button btnCall;
        private Button btnFF;
        private Button btnHelp;
        private Label label1;
        private Label lblSum;
        private Label lblUser;
        private Label label3;
    }
}