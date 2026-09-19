using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.QuestionsClasses
{
    internal class McqQusetion : Questions
    {
        public McqQusetion(string? heder, List<Answer> ans, int corectans,double? mark) : base(heder, ans,corectans, mark) { }

        //public override void Body(string? body)
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Header(string? body)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
