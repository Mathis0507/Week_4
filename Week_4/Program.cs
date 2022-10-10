using System;
using System.Linq;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Menu :\n"
                                 + "1) Exercise 1 : Reverse_First_Last_Char_String()\n"
                                 + "2) Exercise 2 : Is_Sequence_In_Array()\n"
                                 + "3) Exercise 3 : Compressed_String()\n"
                                 + "4) Exercise 4 : Sorted_Character()\n"
                                 + "5) Exercise 5 : Armstrong_Number()\n"
                                 + "6) Exercise 6 : Number_Element_In_Array()\n"
                                 + "7) Exercise 7 : Factorial()\n"
                                 + "8) Exercise 8 : NumberOfBlanks()\n"
                                 + "9) Exercise 9 : TableOfPerson()\n"

                                 + "\n"
                                 + "Choose your option");
                string exo = Console.ReadLine();
                switch (exo)
                {
                    case "1":
                        Reverse_First_Last_Char_String();
                        break;
                    case "2":
                        Is_Sequence_In_Array();
                        break;
                    case "3":
                        Compressed_String();
                        break;
                    case "4":
                        Sorted_Character();
                        break;
                    case "5":
                        Armstrong_Number();
                        break;
                    case "6":
                        Number_Element_In_Array();
                        break;
                    case "7":
                        Factorial();
                        break;
                    case "8":
                        NumberOfBlanks();
                        break;
                    case "9":
                        TableOfPerson();
                        break;
            }
                Console.WriteLine("Choose Escape");

            Console.Read();
        }
        #region Reverse_Char
        static void Reverse_First_Last_Char_String()
        {
            Console.WriteLine("Choose a word");
            string word = Console.ReadLine();
            char stck = word[word.Length - 1];
            string result = stck + word.Substring(1, word.Length-2) + word[0];
            Console.WriteLine(result);
        }
        #endregion
        #region Sequence
        static bool Is_Sequence_In_Array()
        {
            bool result = false;
            Console.WriteLine("What is the size of the array ?");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the size of the sequence ?");
            int sizeSequence = Convert.ToInt32(Console.ReadLine());

            if (sizeSequence > sizeArray || sizeArray == 0 || sizeSequence == 0) result = false;
            else
            {
                int[] array = new int[sizeArray];
                int[] sequence = new int[sizeSequence];
                int cmpt = 0;
                Console.WriteLine("\nEnter the values of the array");
                for (int i = 0; i < sizeArray; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
                for (int i = 0; i < sizeArray; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine("\nEnter the values of the sequence");
                for (int i = 0; i < sizeSequence; i++)
                {
                    sequence[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("");
                for (int i = 0; i < sizeSequence; i++)
                {
                    Console.Write(sequence[i] + " ");
                }

                for(int i=0;i<sizeArray-sizeSequence;i++)
                {
                    for(int j=0;j<sizeSequence;j++)
                    {
                        if (array[i+j] == sequence[j])
                        {
                             result = true;
                            cmpt++;
                        }
                        else
                        {
                            result = false;
                            cmpt = 0;
                        }
                        if (cmpt != sizeSequence && result == true) result = false;
                            
                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
        #endregion
        #region ASCII_Character
        static int Ascii_Value(char chrtr)
        {
            int result = 0;
            result = Convert.ToInt32(chrtr);
            return result;
        }
        #endregion
        #region Sorted_Characters

        static char[] Sorted_Character()
        {
            Console.WriteLine("What is the size of the array ? ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[sizeArray];


            Console.WriteLine("What are the values of your array ? ");
            for(int i=0;i<sizeArray;i++)
            {
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(array[i] + " ");
            }
            char stck;
            for(int j=0;j<sizeArray;j++)
            {
                for(int i=0;i<sizeArray-1-j;i++)
                {
                    if(Ascii_Value(array[i]) < Ascii_Value(array[i+1]))
                    {
                        stck = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = stck;
                    }
                }

            }
            Console.WriteLine("");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            return array;
        }
        #endregion
        #region Compressed_String
        static string Compressed_String()
        {
            Console.WriteLine("Give your string");
            string word = Console.ReadLine();
            string result = Convert.ToString(word[0]);
            int cmpt = 1;
            for(int i=0;i<word.Length-1;i++)
            {
                if(word[i+1] == word[i])
                {
                    cmpt++;
                }
                else
                {
                    result += Convert.ToString(cmpt);
                    cmpt = 1;
                    result += Convert.ToString(word[i+1]);
                }
                
            }result += Convert.ToString(cmpt);
            Console.WriteLine(result);
            return result;
        }
        #endregion
        #region Armstrong_Number
        static void Armstrong_Number()
        {
            for(int i=0;i<1000;i++)
            {
                int sum = 0;
                string stck = Convert.ToString(i);
                for(int j=0;j<stck.Length;j++)
                {
                    sum += (int)Math.Pow(Convert.ToInt32(stck[j])-48,3);
                }
                if (sum == i)
                { 
                    Console.WriteLine(i + " is an Armstrong number"); 
                }
            }
        }
        #endregion
        #region Number_Element_In_Array
        static void Number_Element_In_Array()
        {
            Console.WriteLine("Choose the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[size];
            Console.WriteLine("Enter values");
            for(int l=0;l<size;l++)
            {
                array[l] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("");

            for (int l = 0; l < size; l++)
            {
                Console.Write(array[l]);
            }



            string control = Convert.ToString(array[0]);
            int total;
            bool present = false;

            total = array.Count(c => c == array[0]);
            Console.WriteLine("There are {0} times {1} in the array", total, array[0]);

            for (int i=1;i<size; i++)
            {
                for (int j = 0; j < control.Length; j++)
                {
                    if (array[i] == control[j]) present = true;
                }
                if (present) i++;
                else
                {
                    total = array.Count(c => c == array[i]);
                    Console.WriteLine("There are {0} times {1} in the array", total, array[i]);
                    control += array[i];
                }
                present = false;
            }
            Console.WriteLine("");
        }



        #endregion
        #region Factorial
        static void Factorial()
        {
            Console.WriteLine("What is your number ?");
            int number = Convert.ToInt32(Console.ReadLine());
            int total = 1;
            for(int i = number;i>=1;i--)
            {
                total *= i;
            }
            Console.WriteLine(total);
        }

        #endregion
        #region NumberOfBlanks
        static void NumberOfBlanks()
        {
            Console.WriteLine("Choose a sentence");
            string sentence = Console.ReadLine();
            int total;
            total = sentence.Count(c => c.Equals(' '));
            Console.WriteLine("There are {0} blanks in the sentence", total);
        }
        #endregion
        #region TableOfPerson
        static void TableOfPerson()
        {
            Person[] array = new Person[3];
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine("Choose a name");
                array[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
        }

        #endregion

    }
}
