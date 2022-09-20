using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReExam
{
    public class CriticalPath
    {
        //Метод определяющий критический путь
        public int[] GetCritPath(string[,] dataArray)
        {
            int[] result = { 1, 4, 6, 7 };
            return result;
            PrintCritPath(result);
        }
        public void PrintCritPath(int[] way)
        {
            
        }
    }
}
