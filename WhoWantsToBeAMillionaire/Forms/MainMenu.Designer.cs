namespace WhoWantsToBeAMillionaire.Forms
{
    partial class MainMenu
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
            btnStartGame = new Button();
            label1 = new Label();
            btnRating = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartGame.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartGame.Location = new Point(12, 120);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(264, 55);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Играть";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 88);
            label1.TabIndex = 1;
            label1.Text = "Кто хочет стать миллионером?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRating
            // 
            btnRating.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRating.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRating.Location = new Point(12, 181);
            btnRating.Name = "btnRating";
            btnRating.Size = new Size(264, 55);
            btnRating.TabIndex = 1;
            btnRating.Text = "Рейтинг";
            btnRating.UseVisualStyleBackColor = true;
            btnRating.Click += btnRating_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(12, 242);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(264, 55);
            btnClose.TabIndex = 2;
            btnClose.Text = "Выход";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 312);
            Controls.Add(btnClose);
            Controls.Add(btnRating);
            Controls.Add(label1);
            Controls.Add(btnStartGame);
            MinimumSize = new Size(307, 351);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartGame;
        private Label label1;
        private Button btnRating;
        private Button btnClose;
    }
}