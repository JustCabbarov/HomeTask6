using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

namespace Home_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Trim

            //Console.WriteLine("Write Word");
            //string Word = Console.ReadLine();
            //TrimMethod(Word);
            #endregion
            #region SubString
            //Console.WriteLine("Enter Sentence");
            //string Imput = Console.ReadLine();
            //Console.WriteLine("Enter Start Index ");
            //int StartIndex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Contunied Time");
            //int ContuniedTime = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(SubString(Imput, StartIndex, ContuniedTime));
            #endregion
            #region Replace
            //Console.WriteLine("Add Sentence");
            //string MainSentence = Console.ReadLine();
            //Console.WriteLine("Add Old Word");
            //string OldWord = Console.ReadLine();
            //Console.WriteLine("Add Replace Word");
            //string ReplaceWord = Console.ReadLine();
            //ReplaceMethod(MainSentence, OldWord, ReplaceWord);


            #endregion
            #region Password
            //Console.WriteLine("Add Password");
            //string password=Console.ReadLine();
            //Console.WriteLine(ValidatePassword(password));
            #endregion


        }




        // 1. ValidatePassword(string password) - methodunuz olur, parametr olaraq qebul edilməsi stringin uzunlugu minimum 8, böyük hərflə başlamalı,
        //minimum minimum 1 rəqəm olmalı və 1 xarakter(hərf və ya rəqəm olmayan: misal?, !, @) olmalıdır.
        //Bu hallar ödənirsə doğru, ödənmirsə yalan qaytarmalıdır.
        #region Password
        //static bool ValidatePassword(string password)
        //{
        //       if (password.Length < 8)
        //        return false;

        //    if (!char.IsUpper(password[0]))
        //        return false;

        //    bool Digit = false;
        //    bool SpecialChar = false;

        //    foreach (char c in password)
        //    {
        //        if (char.IsDigit(c))
        //        {

        //            Digit = true;
        //        }
        //        if (!char.IsLetterOrDigit(c))
        //        {
        //            SpecialChar = true;

        //        }
        //    }

        //     return Digit && SpecialChar;
        //}
        #endregion








        // 2.String`in Replace(), Substring(), Trim() metodlarını xüsusi şəkildə yazmaq.
        //  fərdi sizin xüsusi yazdığınız metodlarla stringin metodları eyni işi görməlidir.



        #region Trim Method
        //static void TrimMethod(string imput)
        //{
        //    string resulte = "";
        //    foreach (char Letter in imput)
        //    {
        //        if (!char.IsLetter(Letter))
        //        {
        //            continue;
        //        }
        //        else if (char.IsLetter(Letter))
        //        {
        //            resulte += Letter;
        //        }
        //        if (Letter < imput.Length - 1)
        //        {
        //            resulte += " ";
        //        }
        //    }
        //    Console.WriteLine(resulte);
        //}
        #endregion
        #region SubString Method
        //static string SubString(string ImputWord, int StartIndex, int ContuniedTime)
        //{
        //    string resulte = "";
        //    int Time = StartIndex + ContuniedTime;
        //    for (int i = StartIndex; i <= Time; i++)
        //    {
        //        resulte += ImputWord[i];
        //        if (Time > ImputWord.Length - 1)
        //        {
        //            Console.WriteLine("This Index is not exsist");
        //            break;

        //        }
        //    }
        //    return resulte;
        //}

        #endregion
        #region Replace Method
        //static void ReplaceMethod(string MainSentence, string OldWord, string Replaceword)
        //{
        //    string[] Words = MainSentence.Split(' ');
        //    string resulte = "";
        //    for (int i = 0; i < Words.Length; i++)
        //    {
        //        if (Words[i] == OldWord)
        //        {
        //            Words[i] = Replaceword;
        //        }
        //        resulte += Words[i];
        //        if (i < Words.Length - 1)
        //        {
        //            resulte += " ";
        //        }
        //    }
        //    Console.WriteLine(resulte);
        #endregion



































    }


}


    

