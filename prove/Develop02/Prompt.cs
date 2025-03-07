using System;
using System.Collections.Generic;


    class Prompt
    {
        private static List<string> prompts = new List<string>
        {
            "What was the highlight of your day?",
            "What is something new you learned today?",
            "What are you grateful for today?",
            "Describe a moment that made you smile today."
        };

        public string GetPrompt()
        {
            Random rand = new Random();
            return prompts[rand.Next(prompts.Count)];
        }
    }

