using System;
using System.IO;
using Newtonsoft.Json;
namespace fil_i_O
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string path1 = @"E:\bridgelabz\prac\fil_i_O\fil_i_O\frst.txt";

            // var data = File.CreateText(path1);
            //to creat file

            using (StreamWriter streamWriter = File.CreateText(path1)) 
            {

                streamWriter.WriteLine("hello");
            
            }


                if (!File.Exists(path1))
                {
                    Console.WriteLine(false);
                }
                else { Console.WriteLine(true); }

            using (StreamReader streamReader = File.OpenText(path1))
            {
                string s;
               while((s=streamReader.ReadLine())!=null){ Console.WriteLine(s); }
            
            }

            rajat rajat
            //    using (var sr1 = File.OpenText(path1))
            //    {
            //      string s1;
            //      while ((s1 = sr1.ReadLine()) != null)
            //      {
            //        Console.WriteLine(s1);
            //      }
            //     } 

            //using (var sw1 = File.CreateText(path1))
            //{
            //    sw1.WriteLine("hello");
            //    sw1.WriteLine("name");
            //    sw1.WriteLine("hello");
            //    sw1.WriteLine("name");
            //    sw1.WriteLine("name");



            //}
            //   File.AppendAllText(path1, "my data");

            //    using (var sr1 = File.OpenText(path1))
            //    {
            //      string s1;
            //      while ((s1 = sr1.ReadLine()) != null)
            //      {
            //        Console.WriteLine(s1);
            //      }
            //     }



        }



    }


    } 

//git branch -r | grep -v '\->' | sed "s,\x1B\[[0-9;]*[a-zA-Z],,g" | while read remote; do git branch --track "${remote#origin/}" "$remote"; done
//    git fetch --all
//	git pull --all



//     git log --pretty=format:'%D' HEAD ^ | grep 'origin/' | head - n1 | sed 's@origin/@@' | sed 's@,.*@@'