using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExaminationSystem.QuestionsClasses
{
    public abstract class Questions
    {

        public string? _heder { get; set; } = null; 

        //public string? _body { get; set; } = null; 
        public double? _mark { get; set; } = null;
        public int _corectanswer { get; set; } 
        public int _useranswer { get; set; }
        public Stopwatch ?_timeofque { get; set; }
        public List<Answer> _ans = new List<Answer>();
        public Questions(string? heder, List<Answer> ans, int corectanswer,double? mark)
        {
            _corectanswer = corectanswer;
            _heder = heder;
            _ans = ans;
            _mark = mark;
        }


    }
}
