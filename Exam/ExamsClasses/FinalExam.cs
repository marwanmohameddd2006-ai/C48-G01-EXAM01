using ExaminationSystem.QuestionsClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExaminationSystem.ExamsClasses
{
    public class FinalExam : Exams
    {
        public FinalExam(int numofquestion, int timeofexam) : base(numofquestion, timeofexam)
        {
        }

        public override void ShowExam()
        {
            string yorn;
            do
            {
                Console.WriteLine("Do You Want Start Exam (Y | N)");
                yorn = Console.ReadLine()!;
                if ((yorn != "Y" && yorn != "y" && yorn != "N" && yorn != "n"))
                    Console.WriteLine("Invalid Input! Please enter 'Y' or 'N'");

            } while (string.IsNullOrWhiteSpace(yorn) || (yorn != "Y" && yorn != "y" && yorn != "N" && yorn != "n"));



            Console.Clear();

            if (yorn == "Y" || yorn == "y")
            {
                double graed = 0;

                for (int k = 0; k < _questions.Count; k++)
                {
                    var q = _questions[k];
                    Console.WriteLine($"Q_{k + 1} : {q._heder}");

                    foreach (var answer2 in q._ans)
                    {
                        Console.WriteLine($"{answer2._ansid} : {answer2._anstext}");
                    }

                    int isrightans=0;
                    Stopwatch sw = Stopwatch.StartNew();
                    if(q is McqQusetion)
                    {
                        do
                        {
                            Console.WriteLine($"Enter your Answer for Q_{k + 1} (1 to 4)");
                        } while (!int.TryParse(Console.ReadLine()!, out isrightans) || isrightans < 1 || isrightans > 4);
                    }
                    if(q is TFQusetion)
                    {
                        do
                        {
                            Console.WriteLine($"Enter your Answer for Q_{k + 1} (1 to 2)");
                        } while (!int.TryParse(Console.ReadLine()!, out isrightans) || isrightans < 1 || isrightans > 2);
                    }
                   sw.Stop();
                    q._timeofque = sw;
                    q._useranswer = isrightans;

                    if (isrightans == q._corectanswer)
                    {
                        graed += (double)q._mark!;
                    }
                    else
                    {
                        graed += (double)((double)q._mark! - q._mark!);
                    }
                }

                Console.Clear();
                Console.WriteLine("Final Exam Result");
                for (int t = 0; t < _questions.Count; t++)
                {
                    var q = _questions[t];
                    Console.WriteLine($"Q_{t + 1} : {q._heder} ----- Mark for q is ({q._mark})\n correct answer is : {q._ans[q._corectanswer - 1]._anstext} \n your ans : {q._ans[q._useranswer - 1]._anstext} \n You take time : {q._timeofque}");
                    Console.WriteLine("\n");
                }
                
                Console.WriteLine($" Youer TotalMark is : {graed}");
            }

            else if (yorn == "N" || yorn == "n")
            {
                Console.WriteLine("Thanks for you");
                return;
            }
        }
    }
}
