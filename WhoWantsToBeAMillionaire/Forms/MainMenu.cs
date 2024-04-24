namespace WhoWantsToBeAMillionaire.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.ShowDialog();
        }
    }
}
