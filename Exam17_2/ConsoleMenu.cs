using System;
using System.Collections.Generic;

namespace Exam17_2
{
    class ConsoleMenu
    {
        public List<MenuItem> MenuList { get; set; }

        public ConsoleMenu()
        {
            MenuList = new List<MenuItem>();
        }

        public void Show()
        {
            foreach (MenuItem item in MenuList)
                Console.WriteLine($"{item.MenuChar}, {item.MenuTitle}");
            Console.WriteLine();
        }

        public void Read()
        {
            Console.Write("메뉴선택: ");
            string retVal = Console.ReadLine(); // 1, 2, q
            foreach(MenuItem item in MenuList)
            {
                //if (item.MenuChar == retVal && item.KeypressDelegate != null)
                //item.KeyPressDelegate(this, new MenuKeyPressArgs(retVal)); //delegate 호출
                if (item.MenuChar == retVal)
                    item.CallEvent(this, retVal);                
            }
        }
    }
}
