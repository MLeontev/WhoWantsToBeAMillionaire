using WhoWantsToBeAMillionaire.Models;
using WhoWantsToBeAMillionaire.Services;

namespace WhoWantsToBeAMillionaire.Forms
{
    public partial class Settings : Form
    {
        public string Name { get; private set; }

        public List<int> SelectedIndexes { get; private set; }

        public int SelectedSum { get; private set; }

        public MainMenu Menu { get; private set; }

        public User User { get; private set; }

        private UsersService usersService;

        public Settings(MainMenu mainMenu)
        {
            InitializeComponent();

            usersService = new UsersService();

            Menu = mainMenu;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbName.Text))
            {
                if (lstLevel.SelectedItem != null)
                {
                    string selectedItemText = lstLevel.SelectedItem.ToString().Replace(" ", "");
                    SelectedSum = int.Parse(selectedItemText);

                    SelectedIndexes = new();
                    int selectedCount = 0;
                    for (int i = 0; i < lbHints.Items.Count; i++)
                    {
                        if (lbHints.GetItemChecked(i))
                        {
                            SelectedIndexes.Add(i);
                            selectedCount++;
                        }
                    }

                    if (SelectedIndexes.Count != 3)
                    {
                        MessageBox.Show("Выберите три подсказки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.User = usersService.CreateUser(tbName.Text);
                        buttonClicked = true;
                        Close();

                        Game game = new Game(this.User, SelectedSum, SelectedIndexes, Menu);
                        game.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите несгораемую сумму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool buttonClicked = false;

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!buttonClicked)
            {
                Menu.Show();
            }
        }
    }
}
