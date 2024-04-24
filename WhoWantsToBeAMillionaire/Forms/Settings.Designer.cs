namespace WhoWantsToBeAMillionaire.Forms
{
    partial class Settings
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
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            lbHints = new CheckedListBox();
            label3 = new Label();
            lstLevel = new ListBox();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 10;
            label1.Text = "Введите имя:";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(120, 18);
            tbName.Name = "tbName";
            tbName.Size = new Size(335, 29);
            tbName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(265, 56);
            label2.Name = "label2";
            label2.Size = new Size(190, 21);
            label2.TabIndex = 12;
            label2.Text = "Выберите три подсказки:";
            // 
            // lbHints
            // 
            lbHints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbHints.FormattingEnabled = true;
            lbHints.Items.AddRange(new object[] { "Помощь зала", "50 на 50", "Звонок другу", "Право на ошибку", "Замена вопроса" });
            lbHints.Location = new Point(265, 80);
            lbHints.Name = "lbHints";
            lbHints.Size = new Size(190, 124);
            lbHints.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(232, 21);
            label3.TabIndex = 14;
            label3.Text = "Выберите несгораемую сумму:";
            // 
            // lstLevel
            // 
            lstLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstLevel.FormattingEnabled = true;
            lstLevel.ItemHeight = 21;
            lstLevel.Items.AddRange(new object[] { "3 000 000", "1 500 000", "800 000", "400 000", "200 000", "100 000", "50 000", "25 000", "15 000", "10 000", "5 000", "3 000", "2 000", "1 000", "500" });
            lstLevel.Location = new Point(12, 80);
            lstLevel.Name = "lstLevel";
            lstLevel.Size = new Size(232, 319);
            lstLevel.TabIndex = 13;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelect.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelect.Location = new Point(12, 422);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(447, 41);
            btnSelect.TabIndex = 15;
            btnSelect.Text = "Начать игру";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 475);
            Controls.Add(btnSelect);
            Controls.Add(label3);
            Controls.Add(lstLevel);
            Controls.Add(label2);
            Controls.Add(lbHints);
            Controls.Add(tbName);
            Controls.Add(label1);
            Name = "Settings";
            Text = "Настройка игры";
            FormClosed += Settings_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Label label2;
        private CheckedListBox lbHints;
        private Label label3;
        private ListBox lstLevel;
        private Button btnSelect;
    }
}