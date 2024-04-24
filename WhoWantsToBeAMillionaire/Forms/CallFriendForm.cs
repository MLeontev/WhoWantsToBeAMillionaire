namespace WhoWantsToBeAMillionaire.Forms
{
    public partial class CallFriendForm : Form
    {
        private int time = 30;
        private int correct;

        public CallFriendForm(int correct)
        {
            InitializeComponent();
            this.correct = correct;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CallFriendForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Tick;
            timer1.Start();
            UpdateTime();
        }

        private void Tick(object? sender, EventArgs e)
        {
            time--;
            UpdateTime();

            if (time == 0)
            {
                timer1.Stop();
                tbNumber.Enabled = false;
                btnVerify.Enabled = false;
                MessageBox.Show("Вы не успели");
                Close();
            }
        }

        private void UpdateTime()
        {
            lblTimer.Text = time.ToString();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string number = new string(tbNumber.Text.Where(char.IsDigit).ToArray());
            if (number.Length != 11)
            {
                MessageBox.Show("Неправильный номер телефона.");
            }
            else
            {
                List<string> answers = new List<string> { "A", "B", "C", "D" };
                lblAnswer.Text = answers[correct - 1];
                btnClose.Enabled = true;
                timer1.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
