namespace ConsoleApp1
{
    public class Quiz : IQuiz1, IQuiz2, IQuiz3
    {
        public bool IsIQuiz1()=> true;

        public bool IsIQuiz2() => true;

        public bool IsIQuiz3() => true;
    }
}