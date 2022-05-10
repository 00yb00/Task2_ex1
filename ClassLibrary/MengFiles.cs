using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class MengFiles
    {
        string src = @"D:\learning new things\lehavaLessons\files\";
         Task task1;
         Random random = new Random();
        public Task<string> CreateFile(int numberChars,int numberFiles)
        {
            string nameOfFile="";
            Task<string>t = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < numberFiles; i++)
                {               
                    System.Threading.Thread.Sleep(1000);
                    nameOfFile ="file"+ random.Next(1, 100000).ToString() + ".txt";
                    System.IO.File.WriteAllText(src+ nameOfFile, string.Concat(Enumerable.Repeat("*", numberChars)));
                }  return nameOfFile;
            });
            return t;
        }
        public void DeleteFile(string nameFile)
        {
            Task.Factory.StartNew(() =>
            {
                System.IO.File.Delete(src+nameFile);
            });
            
        }
        public void CreateThreads()
        {
            for (int i = 0; i < 5; i++)
            {
            CreateFile(10000000,10);
            }
        }
        public async void CreateAndDelete()
        {
           string FileName= await CreateFile(30000000, 1);
            DeleteFile(FileName);

        }
    }
}
