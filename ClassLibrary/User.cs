namespace ClassLibrary
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnosis;
        public User(string name)
        {
            Name = name;
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }
    }
}
