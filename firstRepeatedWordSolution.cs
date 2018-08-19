// Complete the firstRepeatedWord function below. Nexient hackerrank question - passed
        static string firstRepeatedWord(string s)
        {
            foreach(string word in s.Split(' '))
            {
                int count = 0;

                for(int i = 0; i < s.Split(' ').Length; ++i)
                {
                    if(word == s.Split(' ')[i])
                    {
                        ++count;

                        if(count == 2)
                        {
                            return word;
                        }
                    }
                }
            }

            return "no duplicate words";
        }