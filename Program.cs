using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Training_For_Bank_System_Project_Using_C_
{
    internal class Program
    {
        public static string FileName = "File.txt";

        static List<string> Load_Data_FromFile_ToList()
        {
            List<string> MyList = new List<string>();
            StreamReader MyFile = new StreamReader(FileName);


            string Buffer = "";
            while ((Buffer = MyFile.ReadLine()) != null)
            {
                MyList.Add(Buffer);
            }


            MyFile.Close();
            return MyList;
        }
        static void Print_List_Data(List<string> MyList)
        {
            foreach (string Items in MyList)
            {
                Console.WriteLine(Items);
            }
        }
        static void Save_Records_List_ToFile(List<string> MyList)
        {
            //File.Delete(FileName);
            StreamWriter MyFile = new StreamWriter(FileName);

            foreach (string Items in MyList)
            {
                if (Items != "")
                {
                    MyFile.WriteLine(Items);
                }
            }

            MyFile.Close();
        }
        static void Delete_Line_FromFile(string FileName, string RecordLine)
        {
            List<string> Data = Load_Data_FromFile_ToList();
            File.Delete(FileName);

            StreamWriter MyFile = new StreamWriter(FileName);

            foreach (string strs in Data)
            {
                if (strs != RecordLine)
                {
                    MyFile.WriteLine(strs);
                }
            }

            MyFile.Close();
        }
        static void Add_Line_ToFile_DeleteOld(string NewLine)
        {
            StreamWriter MyFile = new StreamWriter(FileName);
            MyFile.WriteLine(NewLine);
            MyFile.Close();
        }
        static void Save_Line_ToFile_Increase(string NewLine)
        {
            List<string> MyList = Load_Data_FromFile_ToList();
            MyList.Add(NewLine);
            Save_Records_List_ToFile(MyList);
        }
        static void Print_Diractly_FromFile()
        {
            StreamReader MyFile = new StreamReader(FileName);

            string Buffer;
            while ((Buffer = MyFile.ReadLine()) != null)
            {
                Console.WriteLine(Buffer);
            }

            MyFile.Close();
        }
        static void UpDate_Record_FromFile(string OldRec, string NewRec)
        {
            List<string> Data = Load_Data_FromFile_ToList();

            for (int i = 0; i < Data.Count; i++)
            {
                if (Data[i] == OldRec)
                {
                    Data[i] = NewRec;
                    break;
                }
            }
            Save_Records_List_ToFile(Data);
        }


        static void Main(string[] args)
        {



            Console.ReadKey();
        }
    }
}
