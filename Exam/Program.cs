using ExaminationSystem.ExamsClasses;
using ExaminationSystem.QuestionsClasses;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Subject subject = new Subject("101","C#");
            int resulttype;
            do
            {
                Console.WriteLine("Enter Type of Exam (1 For Practical, 2 for Final)");
            } while (!int.TryParse(Console.ReadLine(), out resulttype) || (resulttype != 1 && resulttype != 2));
            if(resulttype == 1)
            {
                subject.CreatPracticalExam();
            }
            if(resulttype == 2)
            {
                subject.CreatFinalExam();
            }
            
           



         
        }
    }
}
