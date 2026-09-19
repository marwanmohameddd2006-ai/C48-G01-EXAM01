using ExaminationSystem.ExamsClasses;
using ExaminationSystem.QuestionsClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem
{
    public class Subject
    {

        public string? _subid { get; set; } = null;
        public string? _subname { get; set; } = null;
        public Exams? _exam { get; set; }
        public Subject(string? subid, string? subname)
        {
            _subid = subid;
            _subname = subname;
        }

        public void CreatPracticalExam()
        {


            int resulttime;
            do
            {
                Console.WriteLine("Please enter time of exam (30m to 180m)");
            } while (!int.TryParse(Console.ReadLine(), out resulttime) || resulttime < 30 || resulttime > 180);



            int resulnumber;
            do
            {
                Console.WriteLine("Please enter number of questions");
            } while (!int.TryParse(Console.ReadLine(), out resulnumber) || resulnumber <= 0);


            PracticalExam P1 = new PracticalExam(resulnumber, resulttime);
            _exam = P1;

            Console.Clear();

            for (int i = 0; i < resulnumber; i++)
            {
                string header;
                do
                {
                    Console.WriteLine($"Enter header of question_{i + 1}");
                    header = Console.ReadLine()!;
                } while (string.IsNullOrWhiteSpace(header));

                double resultmark;
                do
                {
                    Console.WriteLine($"Enter mark of question_{i + 1}");
                } while (!double.TryParse(Console.ReadLine(), out resultmark) || resultmark <= 0);

                List<Answer> answer = new List<Answer>();
                Console.WriteLine($"Enter Choices of question_{i + 1}");

                for (int j = 0; j < 4; j++)
                {
                    string text;
                    do
                    {
                        Console.WriteLine($"Enter Choice_{j + 1}");
                        text = Console.ReadLine()!;
                    } while (string.IsNullOrWhiteSpace(text));

                    Answer answer1 = new Answer(j + 1, text);
                    answer.Add(answer1);
                }

                int reightqnumber;
                do
                {
                    Console.WriteLine($"Enter right answer of question_{i + 1} (1 to 4)");
                } while (!int.TryParse(Console.ReadLine()!, out reightqnumber) || reightqnumber < 1 || reightqnumber > 4);

                McqQusetion mcq = new McqQusetion(header, answer, reightqnumber, resultmark);
                P1._questions.Add(mcq);
                Console.Clear();
            }

            Console.Clear();
            P1.ShowExam();


        }

        public void CreatFinalExam()
        {

            int resulttime;
            do
            {
                Console.WriteLine("Please enter time of exam (30m to 180m)");
            } while (!int.TryParse(Console.ReadLine(), out resulttime) || resulttime < 30 || resulttime > 180);



            int resulnumber;
            do
            {
                Console.WriteLine("Please enter number of questions");
            } while (!int.TryParse(Console.ReadLine(), out resulnumber) || resulnumber <= 0);


            FinalExam f1 = new FinalExam(resulnumber, resulttime);
            _exam = f1;

            Console.Clear();

            for (int i = 0; i < resulnumber; i++)
            {
                int TypeQuestionOfFinal;
                do
                {
                    Console.WriteLine($"Enter Type of Question_{i+1} (1 For T/F , 2 for MCQ)");
                } while (!int.TryParse(Console.ReadLine(), out TypeQuestionOfFinal) || (TypeQuestionOfFinal != 1 && TypeQuestionOfFinal != 2));
                Console.Clear();
                

                if(TypeQuestionOfFinal == 1)
                {
                    string header;
                    do
                    {
                        Console.WriteLine($"Enter header of question_{i + 1}");
                        header = Console.ReadLine()!;
                    } while (string.IsNullOrWhiteSpace(header));
                    double resultmark;
                    do
                    {
                        Console.WriteLine($"Enter mark of question_{i + 1}");
                    } while (!double.TryParse(Console.ReadLine(), out resultmark) || resultmark <= 0);
                  
                    List<Answer> answer = new List<Answer>();
                    Console.WriteLine($"Enter Choices of question_{i + 1}");
                    for (int j = 0; j < 2; j++)
                    {
                        string text;
                        do
                        {
                            Console.WriteLine($"Enter Choice_{j + 1}");
                            text = Console.ReadLine()!.ToUpper();
                        } while (string.IsNullOrWhiteSpace(text));

                        Answer answer1 = new Answer(j + 1, text);
                        answer.Add(answer1);
                    }
                    int reightqnumber;
                    do
                    {
                        Console.WriteLine($"Enter right answer of question_{i + 1} (1 for T , 2 for F)");
                    } while (!int.TryParse(Console.ReadLine()!, out reightqnumber) || reightqnumber < 1 || reightqnumber > 2);

                    TFQusetion tf = new TFQusetion(header ,answer,reightqnumber,resultmark);
                    f1._questions.Add(tf);

                }
                if (TypeQuestionOfFinal == 2)
                {
                    string header;
                    do
                    {
                        Console.WriteLine($"Enter header of question_{i + 1}");
                        header = Console.ReadLine()!;
                    } while (string.IsNullOrWhiteSpace(header));

                    double resultmark;
                    do
                    {
                        Console.WriteLine($"Enter mark of question_{i + 1}");
                    } while (!double.TryParse(Console.ReadLine(), out resultmark) || resultmark <= 0);

                    List<Answer> answer = new List<Answer>();
                    Console.WriteLine($"Enter Choices of question_{i + 1}");

                    for (int j = 0; j < 4; j++)
                    {
                        string text;
                        do
                        {
                            Console.WriteLine($"Enter Choice_{j + 1}");
                            text = Console.ReadLine()!;
                        } while (string.IsNullOrWhiteSpace(text));

                        Answer answer1 = new Answer(j + 1, text);
                        answer.Add(answer1);
                    }

                    int reightqnumber;
                    do
                    {
                        Console.WriteLine($"Enter right answer of question_{i + 1} (1 to 4)");
                    } while (!int.TryParse(Console.ReadLine()!, out reightqnumber) || reightqnumber < 1 || reightqnumber > 4);

                    McqQusetion mcq = new McqQusetion(header, answer, reightqnumber, resultmark);
                    f1._questions.Add(mcq);
                    Console.Clear();
                }

               
            }

            Console.Clear();
            f1.ShowExam();


        }


    }
}






