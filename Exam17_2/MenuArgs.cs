using System;

namespace Exam17_2
{
    //class MenuArgs
    //{
    //}

    class MenuKeyPressArgs : EventArgs
    {
        public string MenuChar { get; set; }
        public MenuKeyPressArgs(string menu_char)
        {
            MenuChar = menu_char;
        }
    }
}
