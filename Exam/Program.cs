using ExaminationSystem.ExamsClasses;
using ExaminationSystem.QuestionsClasses;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Typ of Exam (1 For Pratical  , 2 for Final )");
            //bool typ = int.TryParse(Console.ReadLine(), out int resulttype);
            //if (resulttype == 1)
            //{

            //    PracticalExam P1 = new PracticalExam();
            //    Console.WriteLine("Pleas enter time of exam ( 30m to 180m )");

            //    bool time = int.TryParse(Console.ReadLine(), out int resulttime);
            //    if (resulttime >= 30 && resulttime <= 180)
            //    {
            //        P1._timeofexam = resulttime;

            //        Console.WriteLine("Pleas enter number of question");
            //        bool number = int.TryParse(Console.ReadLine(), out int resulnumber);
            //        //P1._numofquestion = resulnumber;

            //        for (int i = 0; i < resulnumber; i++)
            //        {
            //            Console.WriteLine($"Enter header of question {i + 1}");
            //            string header = Console.ReadLine()!;

            //            Console.WriteLine($"Enter mark of question {i + 1}");
            //            bool mark = double.TryParse(Console.ReadLine(), out double resultmark);

            //            List<Answer> answer = new List<Answer>();
            //            Console.WriteLine($"Enter Choices of question {i + 1}");
            //            for (int j = 0; j < 4; j++)
            //            {
            //                Console.WriteLine($"Enter Choice {j + 1}");
            //                string text = Console.ReadLine()!;
            //                Answer answer1 = new Answer(j + 1, text);
            //                answer.Add(answer1);
            //            }
            //            Console.WriteLine($"Enter right answer of question {i + 1}");
            //            bool reightq = int.TryParse(Console.ReadLine()!, out int reightqnumber);

            //            McqQusetion mcq = new McqQusetion(header, answer, reightqnumber, resultmark);
            //            P1._questions.Add(mcq);
            //        }

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
            
            //Console.Clear();
            //subject?._exam?.ShowExam();
            
            //        string yorn = Console.ReadLine()!;
            //        if (yorn == "Y")
            //        {
            //            double graed = 0;

            //            for (int k = 0; k < P1._questions.Count; k++)
            //            {
            //                var q = P1._questions[k];
            //                Console.WriteLine($"Q {k + 1} : {q._heder}");
            //                foreach (var answer2 in q._ans)
            //                {
            //                    Console.WriteLine($"{answer2._ansid} : {answer2._anstext}");
            //                }
            //                int isrightans = 0;

            //                Console.WriteLine($"Enter your Answer for Q {k + 1}");
            //                bool isright = int.TryParse(Console.ReadLine()!, out isrightans);
            //                q._useranswer = isrightans;
            //                if(isrightans>=1&&isrightans<=4)
            //                {
            //                    if (isrightans == q._corectanswer)
            //                    {
            //                        graed += (double)q._mark!;

            //                    }
            //                    else
            //                        graed += (double)((double)q._mark! - q._mark!);
            //                }
            //                else
            //                    Console.WriteLine("Invilid Answer");

                           

            //            }
            //            Console.Clear();

            //            for (int t = 0; t < P1._questions.Count; t++)
            //            {
            //                var q = P1._questions[t];
            //                Console.WriteLine($"Q {t + 1} : {q._heder} \n corect answer number : {q._ans[q._corectanswer - 1]._anstext} \n yor ans : {q._ans[q._useranswer-1]._anstext}");
            //            }

                       
            //            Console.WriteLine($" Youer TotalMark is : {graed}");


            //        }
            //        else
            //        {
            //            Console.WriteLine("Thanks for you");
            //            return;
            //        }

            //    }

            //    else
            //    {
            //        Console.WriteLine("Time out!!");
            //        return;
            //    }


            //}
            //Typ.2




         
        }
    }
}
