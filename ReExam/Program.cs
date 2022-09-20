using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReExam
{
    /// <summary>
    /// Главный класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Начало работы программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = "../../CriticalPath.xlsx";
            FileReader fileReader = new FileReader();
            CriticalPath criticalPath = new CriticalPath();
            
            //Добавлен класс trace, выводящий содержимое считанного excel файла
            TextWriterTraceListener traceL = new TextWriterTraceListener(System.IO.File.CreateText("../../Output.txt"));
            Debug.Listeners.Add(traceL);
            string[,] dataArray = fileReader.ReadFile(path);
            for (int i = 0; i < dataArray.GetLength(0); i++)
            {
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    if (dataArray[i, j] != "")
                        Debug.WriteLine(dataArray[i, j]);
                }
            }
            Debug.Flush();
            criticalPath.GetCritPath(dataArray);
            Console.ReadLine();
        }
    }
}
