using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> files = FileManager.Source;
            FileManager.FileMoveEventHandler += FileManager_FileMoveEventHandler;
            foreach(string file in files)
            {
                lbox_src.Items.Add(file);
            }
        }

        private void FileManager_FileMoveEventHandler(object sender, FileMovedEventArgs e)
        {
            MovedFile(e.FileName);
        }

        delegate void MovedDele(string fn);
        private void MovedFile(string fn)
        {
            if(lbox_dst.InvokeRequired)
            {
                MovedDele dele = MovedFile;
                object[] objs = new object[] { fn };

                lbox_dst.BeginInvoke(dele, objs);
            }
            else
            {
                lbox_dst.Items.Add(fn);
                lbox_src.Items.Remove(fn);
            }          
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            FileManager.MoveStartAsync();
        }
    }
}
