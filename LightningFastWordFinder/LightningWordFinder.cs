using System;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string longestWord = String.Empty;

            int currentWordStart = 0;
            int currentWordLength = 0;
            int biggestWordLength = 0;
            int textLength = text.Length;
            for (int i = 0; i < textLength; ++i)
            {
                if (text[i] < 65 ||
                    text[i] > 122 ||
                   (text[i] > 90 && text[i] < 97))
                {
                    if (currentWordLength > biggestWordLength)
                    {
                        string word = text.Substring(currentWordStart, currentWordLength);
                        if (word.Length > longestWord.Length)
                        {
                            longestWord = word;
                            biggestWordLength = currentWordLength;
                        }
                    }
                    currentWordLength = 0;
                    currentWordStart = i + 1;
                    continue;
                }
                ++currentWordLength;
            }
            return longestWord;
        }
    }
}
