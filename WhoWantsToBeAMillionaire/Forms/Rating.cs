using WhoWantsToBeAMillionaire.Models;
using WhoWantsToBeAMillionaire.Services;

namespace WhoWantsToBeAMillionaire.Forms
{
    public partial class Rating : Form
    {
        UsersService usersService;

        public Rating()
        {
            InitializeComponent();

            usersService = new UsersService();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RefreshUsers()
        {
            List<User> users = usersService.GetTop();

            lstUsers.Items.Clear();

            foreach (var user in users)
            {
                lstUsers.Items.Add($"{user.Name} {user.Result}");
            }
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            usersService.DeleteUsers();
            RefreshUsers();
        }
    }
}
