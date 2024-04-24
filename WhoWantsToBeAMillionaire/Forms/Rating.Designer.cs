namespace WhoWantsToBeAMillionaire.Forms
{
    partial class Rating
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
            label3 = new Label();
            lstUsers = new ListBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 11;
            label3.Text = "Топ 10 игроков:";
            // 
            // lstUsers
            // 
            lstUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 21;
            lstUsers.Location = new Point(12, 33);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(260, 235);
            lstUsers.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(12, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(261, 43);
            btnClear.TabIndex = 13;
            btnClear.Text = "Очистить рейтинг";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Rating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 335);
            Controls.Add(btnClear);
            Controls.Add(lstUsers);
            Controls.Add(label3);
            Name = "Rating";
            Text = "Rating";
            Load += Rating_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ListBox lstUsers;
        private Button btnClear;
    }
}