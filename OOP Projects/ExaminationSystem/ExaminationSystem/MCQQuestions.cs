using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQQuestions : QuestionBase
    {
        public override string Header { get; } = "MCQ Question";

        public MCQQuestions(string _body = "", double _marks = 0):base(_body, _marks)
        {
            AnswerList = new Answers[3];
        }

        public override string ToString()
        {
            return $"{Header}     Marks({Marks})\n {Body}\n" +
                  $"1.{AnswerList[0].AnswerText}\t\t 2.{AnswerList[1].AnswerText} \t\t {AnswerList[2].AnswerText}";
        }

        public static MCQQuestions AddMCQQuestions()
        {
            MCQQuestions questions = new MCQQuestions();
            Console.WriteLine(questions.Header);
            Console.WriteLine("Please Enter The Body of Question:");
            questions.Body = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks of Question:");
            questions.Marks = double.Parse(Console.ReadLine());


            for (int i = 0; i < questions.AnswerList?.Length; i++)
            {
                questions.AnswerList[i] = new Answers();
                Console.WriteLine($"Please Enter The Choice Number {i + 1}");
                questions.AnswerList[i].AnswerText = Console.ReadLine();
                questions.AnswerList[i].AnswerId = i + 1;
            }
            questions.RightAnswer = new Answers();
            string answer = "";
            do
            {
                Console.WriteLine($"Please Enter The Right Answer For the Question");
                answer = Console.ReadLine();
            } while (!(answer is string));
            questions.RightAnswer.AnswerText = answer;
            return questions;
        }
    }
}
