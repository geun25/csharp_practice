using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_9
{
    class Calendar
    {
        //EndDate 필요 -> 31, 30, 28
        //1월부터 12월
        int[] Month31 = new int[] { 1, 3, 5, 7, 8, 10, 12 };
        int[] Month30 = new int[] { 4, 6, 9, 11 };
        int CurrentDay;

        public void PrintCalendar()
        {
            for(int i=1; i<=12; i++)
            {
                PrintHeader(i);
                PrintMonth(i);
                PrintFooter();
            }
        }

        private void PrintHeader(int month)
        {
            Console.WriteLine($"{month}월");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(string.Format("{0, -4}{1, -4}{2, -4}{3, -4}{4, -4}{5, -4}{6, -4}", 
                "일","월", "화","수", "목", "금", "토"));
        }

        private void PrintFooter()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
        }

        public void PrintMonth(int month)
        {
            int endDate;
            if (Month31.Contains(month)) endDate = 31;
            else if (Month30.Contains(month)) endDate = 30;
            else endDate = 28;
            PrintSpace(CurrentDay);
            for (int i = 1; i <= endDate; i++)
                PrintDate(i);
        }

        public void PrintDate(int date)
        {
            Console.Write(string.Format("{0, -5:N0}", date));
            CurrentDay++;
            if (CurrentDay == 7)
            {
                CurrentDay = 0;
                Console.WriteLine();
            }
        }

        private void PrintSpace(int times)
        {
            for (int i=0; i < times; i++)            
                Console.Write(string.Format("{0, -5:N0}", " "));            
        }     
    }
}
