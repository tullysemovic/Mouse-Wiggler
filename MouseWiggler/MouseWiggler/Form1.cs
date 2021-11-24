using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace MouseWiggler
{
    public partial class Form1 : Form
    {
        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        const int MYACTION_HOTKEY_ID = 1;


        Boolean isWiggling = false;
        Boolean tracker = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Wiggle_ClickAsync(object sender, EventArgs e)
        {
            if (isWiggling)
            {
                isWiggling = false;
            }
            else
            {
                isWiggling = true;
                Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 50);

            }

            this.Cursor = new Cursor(Cursor.Current.Handle);

            await Task.Run(() => Wiggle());
        }

        private void Wiggle()
        {
            while (isWiggling)
            {

                Random random = new Random();

                new Point(Cursor.Position.X, Cursor.Position.Y);
                if (tracker)
                {
                    Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y);
                    tracker = false;
                }
                else
                {
                    Cursor.Position = new Point(Cursor.Position.X - 10, Cursor.Position.Y);
                    tracker = true;
                }

                LeftMouseClick(Cursor.Position.X, Cursor.Position.Y);


                Thread.Sleep(2000);
            }

        }


        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
    }
}
