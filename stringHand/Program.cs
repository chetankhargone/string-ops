namespace stringHand
{
    #region Using
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToString();
            //Console.WriteLine(input);

            StringHandler obj = new StringHandler();
             obj.PrintSortedString(input);
            Console.ReadLine();
            
        }
    }

    public class StringHandler
    {
        private string _output = string.Empty;

        public void PrintDuplicateChars(string input)
        {
            var arr = input.ToCharArray();
            var dict = new Dictionary<char, int>();
            foreach(var ele in arr)
            {
                if(dict.ContainsKey(ele))
                {
                    dict[ele]++;
                }
                else
                {
                    dict.Add(ele,1);
                }
            }

            foreach(var item in dict)
            {
                if(item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        public void PrintNonRepeatedChar(string input)
        {
            var arr = input.ToCharArray();
            var dict = new Dictionary<char, int>();

            foreach(var ele in arr)
            {
                if(dict.ContainsKey(ele))
                {
                    dict[ele]++;
                }
                else
                {
                    dict.Add(ele, 1);
                }

                }

            foreach(var item in dict)
            {
                if(item.Value == 1)
                {
                    Console.Write(item.Key);
                    break;
                }
            }
            
        }

        public void PrintRepeatedChars(string input)
        {
            var arr = input.ToCharArray();
            var dict = new Dictionary<char, int>();
            foreach(var ele in arr)
            {
                if(dict.ContainsKey(ele))
                {
                    dict[ele]++;
                }
                else
                {
                    dict.Add(ele,1);
                }
            }

            foreach(var item in dict)
            {
                if(item.Value  > 1)
                {
                    Console.WriteLine(item.Key + " repeats " + item.Value);
                    break;
                }
            }
        }

        public void PrintReverseString(string input)
        {
            var arr = input.ToLower().ToCharArray();
            var charArr = new List<char>();
            StringBuilder opString = new StringBuilder();
            foreach(var ele in arr)
            {
                charArr.Add(ele);
            }
                
            for(var i=charArr.Count-1; i >= 0; i--)
            {
                opString.Append(charArr[i]);
            }

            Console.WriteLine(opString);
        }

        public void PrintVowelConsanant(string input)
        {
            string vowels = "aeiou";

            var arr = input.ToLower().ToCharArray();
            var dict = new Dictionary<char, int>();
            foreach(var ele in arr)
            {
                if(vowels.IndexOf(ele) >= 0)
                {
                    if(dict.ContainsKey(ele))
                    {
                        dict[ele]++;
                    }
                    else
                    {
                        dict.Add(ele,1);
                    }
                   
                }
                
            }

            foreach(var item in dict)
            {
                if(item.Value > 1)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
            

        }

        public void PrintCharOccurence(string input)
        {
            var arr = input.ToLower().ToCharArray();
            var dict = new Dictionary<char, int>();

            foreach(var ele in arr)
            {
                if(dict.ContainsKey(ele))
                {
                    dict[ele]++;
                }
                else
                {
                    dict.Add(ele,1);
                }
            }

            foreach(var item in dict)
            {
                if(item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        public void PrintStringToInt(string input)
        {
            var arr = input.ToLower().ToCharArray();
            var dict = new List<int>();
            var _num=0;
            foreach(var ele in arr)
            {
                int num;
               if(int.TryParse(ele.ToString(),out num))
                {
                    dict.Add(num);
                }
            }

            if(int.TryParse(string.Join(",", dict).Replace(",","").Trim(), out _num))
            {
                Console.WriteLine(_num.ToString());
            }

            

        }

        public void CheckIfStringPalindrome(string input)
        {
            var arr = input.ToLower().ToCharArray();
            var dict = new List<char>();

            for(var i =input.Length-1; i >= 0; i--)
            {
                dict.Add(arr[i]);
            }

            _output = string.Join(",", dict).Replace(",", "").Trim();

            if(input.ToLower() == _output)
            {
                Console.Write("String is palindrome " + _output);
            }
            else
            {
                Console.Write("No !! Sorryy");
            }
        }

        public void RemoveDupChars(string input)
        {
            var arr = input.ToLower().ToCharArray();
            var dict = new Dictionary<char, int>();

            foreach(var ele in arr)
            {
                if(dict.ContainsKey(ele))
                {
                    dict[ele]++;
                }
                else
                {
                    dict.Add(ele, 1);
                }
            }

            _output = string.Join(",", dict.Keys).Replace(",", "").Trim();

            Console.WriteLine(_output);
        }

        public void PrintHighestOccurChar(string input)
        {
            var arr = input.ToLower().ToCharArray();
            var dict = new Dictionary<char, int>();

            foreach(var ele in arr)
            {
                if(dict.ContainsKey(ele))
                {
                    dict[ele]++;
                }
                else
                {
                    dict.Add(ele, 1);
                }
            }

            int temp = 0;
            string ch =string.Empty;
            foreach(var item in dict)
            {
                if(item.Value > temp)
                {
                    temp = item.Value;
                    ch = item.Key.ToString();
                }
            }

            Console.WriteLine(ch + " occurs " + temp);
        }

        public void PrintSortedString(string input)
        {
            var arr = input.ToLower().ToCharArray();
            char temp;
            for(var i =0; i < arr.Length-1; i++)
            {
                for(var j = i+1; j < arr.Length; j++)
                {
                    if((int)arr[i] > (int)arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                 }

              }

             Console.WriteLine(arr);
        }
    }
}
