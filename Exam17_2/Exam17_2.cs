using System;

namespace Exam17_2
{
    class Exam17_2
    {
        ConsoleMenu Menu;
        public Exam17_2()
        {
            Menu = new ConsoleMenu();
        }

        public void Run()
        {
            CreateMenu();
            while(true)
            {
                Menu.Show();
                Menu.Read();
            }
        } 

        private void CreateMenu()
        {
            MenuItem item = new MenuItem("1", "Menu_Title_1");
            item.MenuKeyPressEventHandler += Menu_1_Callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("2", "Menu_Title_2");
            item.MenuKeyPressEventHandler += Menu_2_Callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("q", "프로그램 종료");
            item.MenuKeyPressEventHandler += Quit_Callback;
            Menu.MenuList.Add(item);
        }


        private void Menu_1_Callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu_1_Callback() 호출됨 sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }

        private void Menu_2_Callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu_2_Callback() 호출됨 sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }
        
        private void Quit_Callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu_1_Callback() 호출됨 sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
            Console.WriteLine("bye...");
            Environment.Exit(0);
        }
    }
}
