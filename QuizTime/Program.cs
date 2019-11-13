using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameAnswers = new List<string>() { "Mailman The Game", "Death Stranding", "UPS Simulator" };
            var doGames = new MultipleChoiceQuestion("Best deliveryman simulator?", gameAnswers, "Death Stranding");

            var classAnswers = new List<string>() { "Warrior", "Mage", "Herbalist" };
            var doClass = new MultipleChoiceQuestion("Favorite Class?", classAnswers, "Herbalist");

            var trueOrFalse = new TrueFalseQuestion("Is my car red?", "True");

            var questions = new List<Question>() { doGames, doClass, trueOrFalse };
            foreach (Question question in questions)
            {
                question.Display();
                Console.WriteLine("Correct? " + question.IsCorrect());
            }

        }
    }
}