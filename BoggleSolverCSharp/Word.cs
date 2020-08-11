using System;
namespace BoggleSolverCSharp
{
    public class Word
    {
        public string text { get; set; }
        public int score { get; set; }

        public Word(string text_in)
        {
            text = text_in;

            // Assign a score to the word based on its length
            int len = text.Length;

            if (len < 5)
            {
                score = 1;
            }
            else if (len == 5)
            {
                score = 2;
            }
            else if (len == 6)
            {
                score = 3;
            }
            else if (len == 7)
            {
                score = 5;
            }
            else
            {
                score = 11;
            }
        }
    }
}
