namespace WhoWantsToBeAMillionaire.Services
{
    public class Player
    {
        private string soundDirectory;
        private System.Media.SoundPlayer player;

        public Player(string soundDirectory)
        {
            this.soundDirectory = soundDirectory;
            player = new System.Media.SoundPlayer();
        }

        public void PlaySound(string soundFileName)
        {
            string soundFilePath = Path.Combine(soundDirectory, soundFileName);
            player.SoundLocation = soundFilePath;
            player.Play();
        }
    }
}
