namespace WhoWantsToBeAMillionaire.Forms
{
    partial class CallFriendForm
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
            tbNumber = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            btnVerify = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            label3 = new Label();
            lblAnswer = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // tbNumber
            // 
            tbNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumber.Location = new Point(12, 41);
            tbNumber.Mask = "+7 (000) 000-00-00";
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(267, 29);
            tbNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(193, 21);
            label1.TabIndex = 1;
            label1.Text = "Введите номер телефона:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 2;
            label2.Text = "Осталось времени:";
            // 
            // btnVerify
            // 
            btnVerify.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerify.Location = new Point(12, 168);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(165, 41);
            btnVerify.TabIndex = 1;
            btnVerify.Text = "Подтвердить";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.Location = new Point(163, 79);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(52, 21);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 4;
            label3.Text = "Ответ:";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.Location = new Point(73, 120);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 21);
            lblAnswer.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Enabled = false;
            btnClose.Location = new Point(183, 168);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 41);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // CallFriendForm
            // 
            AcceptButton = btnVerify;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(291, 221);
            Controls.Add(btnClose);
            Controls.Add(lblAnswer);
            Controls.Add(label3);
            Controls.Add(lblTimer);
            Controls.Add(btnVerify);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNumber);
            MinimumSize = new Size(307, 260);
            Name = "CallFriendForm";
            Text = "CallFriendForm";
            Load += CallFriendForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tbNumber;
        private Label label1;
        private Label label2;
        private Button btnVerify;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Label label3;
        private Label lblAnswer;
        private Button btnClose;
    }
}