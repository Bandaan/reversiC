using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReversiC
{
    class Program
    {
        static void Main(string[] args)
        {
            Form scherm = new Form();
            scherm.Text = "ReversiC";
            scherm.BackColor = Color.LightYellow;
            scherm.ClientSize = new Size(500, 500);


            Application.Run(scherm);
        }

    }

}