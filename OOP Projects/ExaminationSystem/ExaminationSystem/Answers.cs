﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answers
    {
        private string answerText;
        private int answerId;

        public string AnswerText
        {
            get { return answerText; }
            set { answerText = value; }
        }
        public int AnswerId
        {
            get { return answerId; }
            set { answerId = value; }
        }

        public Answers(string _answerText, int _answerId)   
        {
            answerText = _answerText;
            answerId = _answerId;
        }

        public Answers()
        {

        }
    }
}
