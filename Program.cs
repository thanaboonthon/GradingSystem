namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            Grading.GradeCalculator(score);
        }
    }
}