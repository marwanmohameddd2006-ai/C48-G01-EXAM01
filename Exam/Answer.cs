using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem
{
    public class Answer
    {

        public int? _ansid { get; set; } = null;
        public string? _anstext { get; set; } = null;
        public Answer(int? ansid, string? anstext)
        {
            _ansid = ansid;
            _anstext = anstext;
        }
    }
}
