using System;


    class Entry
    {
        private string _current_date;
        private string _prompt;
        private string _response;

        public Entry(string current_date, string prompt, string response)
        {
            _current_date = current_date;
            _prompt = prompt;
            _response = response;
        }

        public string GetFormattedEntry()
        {
            return $"{_current_date}: {_prompt}? {_response}";
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"{_current_date}# {_prompt}# {_response}");
        }
    }

