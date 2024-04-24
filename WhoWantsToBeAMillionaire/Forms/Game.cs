using System.Media;
using WhoWantsToBeAMillionaire.Forms;
using WhoWantsToBeAMillionaire.Models;
using WhoWantsToBeAMillionaire.Services;
using Timer = System.Windows.Forms.Timer;

namespace WhoWantsToBeAMillionaire
{
    public partial class Game : Form
    {
        QuestionsService questionsService;
        Question currentQuestion;
        int level = 0;
        Random random = new Random();

        bool secondChance = false;

        Button[] answerButtons;
        Button[] helpButtons;

        int SelectedSum = 0;
        List<int> SelectedIndexes = new();

        MainMenu mainMenu;

        User currentUser;
        UsersService usersService;

        string soundPath = "C:\\Users\\MaxL\\source\\repos\\WhoWantsToBeAMillionaire\\WhoWantsToBeAMillionaire\\sounds\\";
        private SoundPlayer soundPlayer;

        public Game(User user, int selectedSum, List<int> selectedIndexes, MainMenu mainMenu)
        {
            InitializeComponent();

            questionsService = new QuestionsService();
            usersService = new UsersService();

            SelectedSum = selectedSum;
            lblSum.Text = selectedSum.ToString();

            answerButtons = new Button[] { btnA, btnB, btnC, btnD };

            helpButtons = new Button[] { btnHelp, btnFF, btnCall, btnMistake, btnChange };
            SelectedIndexes = selectedIndexes;

            this.mainMenu = mainMenu;

            currentUser = user;
            lblUser.Text = currentUser.Name;

            soundPlayer = new SoundPlayer();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Timer timer = new Timer();
        private void Game_Shown(object sender, EventArgs e)
        {
            level = 1;

            soundPlayer = new SoundPlayer(soundPath + "hello-new-punter-2008-long.wav");
            soundPlayer.Play();

            timer = new Timer();
            timer.Interval = 16000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            StartGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            timer.Stop();
            soundPlayer.Stop();

            foreach (int index in SelectedIndexes)
            {
                helpButtons[index].Enabled = true;
            }

            level = 0;
            secondChance = false;
            Next();
        }

        private void EndGame()
        {
            int winSum;
            if (level == 15)
            {
                MessageBox.Show("Вы выиграли 3 миллиона!");
                winSum = 3000000;
            }
            else if (SelectedSum == 0 || int.Parse(lstLevel.SelectedItem.ToString().Replace(" ", "")) < SelectedSum)
            {
                MessageBox.Show("Вы проиграли");
                winSum = 0;
            }
            else
            {
                MessageBox.Show($"Вы выиграли {SelectedSum} рублей");
                winSum = SelectedSum;
            }

            usersService.UpdateUser(currentUser, winSum);

            Close();
        }

        private void Next()
        {
            if (level == 15)
            {
                EndGame();
            }
            else
            {
                level++;
                GetQuestion(level);
                ShowQuestion(currentQuestion);
                lstLevel.SelectedIndex = lstLevel.Items.Count - level;
            }
        }

        private void GetQuestion(int level)
        {
            currentQuestion = questionsService.GetQuestion(level);
        }

        private async void ShowQuestion(Question qestion)
        {
            soundPlayer.Stop();

            foreach (Button btn in answerButtons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.White;
            }

            lblQuestion.Text = qestion.QuestionText;
            btnA.Text = "A:  " + qestion.Answer1;
            btnB.Text = "B:  " + qestion.Answer2;
            btnC.Text = "C:  " + qestion.Answer3;
            btnD.Text = "D:  " + qestion.Answer4;

            await Task.Delay(50);

            soundPlayer = new SoundPlayer(soundPath + "new_question.wav");
            soundPlayer.Play();
        }

        private async void btnAnswer_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;

            if (secondChance)
            {
                if (currentQuestion.RightAnswer == int.Parse(pressedButton.Tag.ToString()))
                {
                    pressedButton.BackColor = Color.Green;
                    await Task.Delay(50);
                    PlayCorrect();
                    Next();
                }
                else
                {
                    pressedButton.BackColor = Color.Red;
                    soundPlayer = new SoundPlayer(soundPath + "wrong.wav");
                    soundPlayer.Play();
                }
                secondChance = false;
            }

            else
            {
                if (currentQuestion.RightAnswer == int.Parse(pressedButton.Tag.ToString()))
                {
                    pressedButton.BackColor = Color.Green;
                    await Task.Delay(50);
                    PlayCorrect();
                    Next();
                }
                else
                {
                    pressedButton.BackColor = Color.Red;

                    foreach (Button btn in answerButtons)
                    {
                        if (int.Parse(btn.Tag.ToString()) == currentQuestion.RightAnswer)
                        {
                            btn.BackColor = Color.Green;
                        }
                    }
                    await Task.Delay(50);
                    PlayWrong();

                    EndGame();
                }
            }
        }

        private void PlayCorrect()
        {
            soundPlayer.Stop();
            soundPlayer = new SoundPlayer(soundPath + "correct.wav");
            soundPlayer.PlaySync();
        }

        private void PlayWrong()
        {
            soundPlayer.Stop();
            soundPlayer = new SoundPlayer(soundPath + "wrong.wav");
            soundPlayer.PlaySync();
        }


        private void lstLevel_MouseDown(object sender, MouseEventArgs e)
        {
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }

        private void btnFF_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPath + "hint.wav";
            soundPlayer.Play();

            int count = 0;
            while (count < 2)
            {
                int n = random.Next(4);
                int answer = int.Parse(answerButtons[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && answerButtons[n].Enabled)
                {
                    answerButtons[n].Enabled = false;
                    count++;
                }
            }

            btnFF.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPath + "hint.wav";
            soundPlayer.PlaySync();

            GetQuestion(level);
            ShowQuestion(currentQuestion);

            btnChange.Enabled = false;
        }

        private void btnMistake_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPath + "hint.wav";
            soundPlayer.Play();

            secondChance = true;
            btnMistake.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPath + "hint.wav";
            soundPlayer.Play();

            using (ChartDialog chartDialog = new ChartDialog(currentQuestion.RightAnswer))
            {
                chartDialog.ShowDialog();
            }

            btnHelp.Enabled = false;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPath + "hint.wav";
            soundPlayer.Play();

            using (CallFriendForm callFriendForm = new CallFriendForm(currentQuestion.RightAnswer))
            {
                callFriendForm.ShowDialog();
            }

            btnCall.Enabled = false;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            soundPlayer.Stop();
            mainMenu.Show();
        }

        
    }
}