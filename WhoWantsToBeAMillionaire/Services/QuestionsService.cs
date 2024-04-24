using WhoWantsToBeAMillionaire.Models;

namespace WhoWantsToBeAMillionaire.Services
{
    public class QuestionsService
    {
        private MillionaireDBContext context;
        private Random random;

        public QuestionsService()
        {
            this.context = ContextProvider.GetDbContext();
            random = new Random();
        }

        public Question GetQuestion(int level)
        {
            List<Question> questions = context.Questions.Where(q => q.Level == level).ToList();
            int randomIndex = random.Next(0, questions.Count);
            Question randomQuestion = questions[randomIndex];
            return randomQuestion;
        }
    }
}
