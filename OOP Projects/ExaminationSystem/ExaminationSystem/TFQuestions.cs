using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestions : QuestionBase
    {
        public override string Header { get; } = "True Or False Question";

        public TFQuestions(string _body = "", double _marks=0) : base(_body, _marks)
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers("True", 1);
            AnswerList[1] = new Answers("False", 2);
        }

        public override string ToString()
        {
            return $"{Header}      Marks:{Marks}\n {Body}" +
                   $"1.{AnswerList[0].AnswerText}\t\t 2.{AnswerList[1].AnswerText}";
        }

        public static TFQuestions AddTFQuestions()
        {
            TFQuestions questoin = new TFQuestions();
            Console.WriteLine(questoin.Header);
            Console.WriteLine("Please Enter The Body of Question:");
            questoin.body = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks of Question:");
            questoin.marks = double.Parse(Console.ReadLine()); 
            questoin.RightAnswer = new Answers();
            int id;
            do
            {
                Console.WriteLine("Please Enter The Right Answer For The Questions [1 For True and 0 For False.]");
            } while (!int.TryParse(Console.ReadLine(), out id) || id < 1 || id > 2);
            questoin.RightAnswer.AnswerId = id;
            questoin.RightAnswer.AnswerText = questoin[id].AnswerText;

            return questoin;
        }
    }
}
