using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> PossibleAnswers { get; set; }
        public string CorrectAnswer { get; internal set; }
        public string UserAnswer { get; set; }

        public MultipleChoiceQuestion(string text, List<string> possibleAnswers, string correctAnswer)
            : base(text)
        {
            this.PossibleAnswers = possibleAnswers;
            this.CorrectAnswer = correctAnswer;
        }

        public MultipleChoiceQuestion(string text, string correctAnswer)
            : base(text)
        {
            this.CorrectAnswer = correctAnswer;
        }

        public override void Display()
        {
            var question = this.Text + Environment.NewLine;
            for (var i = 0; i < this.PossibleAnswers.Count; i++)
            {
                question += String.Format("{0} - {1}{2}", i, this.PossibleAnswers[i], Environment.NewLine);
            }
            Console.WriteLine(question);
            string key = Console.ReadLine();
            int answerIndex = Convert.ToInt32(key);
            this.UserAnswer = this.PossibleAnswers[answerIndex];
        }

        public override bool IsCorrect()
        {
            return this.CorrectAnswer == this.UserAnswer;
        }
    }
}