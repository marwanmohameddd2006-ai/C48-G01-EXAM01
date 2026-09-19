using ExaminationSystem.QuestionsClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExaminationSystem.ExamsClasses
{
    public abstract  class Exams
    {
        public int _numofquestion { get; set; }
        public int _timeofexam { get; set; }
        public List<Questions> _questions = new List<Questions>();

        protected Exams(int numofquestion, int timeofexam)
        {
            _numofquestion = numofquestion;
            _timeofexam = timeofexam;
        }

        public abstract void ShowExam();

       
    }
}
