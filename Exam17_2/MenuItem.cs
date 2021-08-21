using System;

namespace Exam17_2
{
    class MenuItem
    {
        //public delegate void MenuKeyPressDelegate(object sender, EventArgs args); 
        public event EventHandler MenuKeyPressEventHandler;
        public string MenuChar { get; set; } // 1.
        public string MenuTitle { get; set; } // Menu 1
        //public MenuKeyPressDelegate KeypressDelegate { get; set; } // func(sender, args)

        //public MenuItem(string menu_char, string menu_title, MenuKeyPressDelegate dele)
        public MenuItem(string menu_char, string menu_title)
        {
            MenuChar = menu_char;
            MenuTitle = menu_title;
            //KeypressDelegate = dele;
        }

        public MenuItem() : this(null, null)
        {
        }

        public void CallEvent(object sender, string args)
        {
            if (MenuKeyPressEventHandler != null)
                MenuKeyPressEventHandler(sender, new MenuKeyPressArgs(args));
        }
    }
}
 