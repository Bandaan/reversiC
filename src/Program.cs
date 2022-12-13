using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReversiC_Namespace.reversiC.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Form scherm = new Form();
            scherm.Text = "ReversiC";
            scherm.BackColor = Color.LightYellow;
            scherm.ClientSize = new Size(500, 500);

            Label tekst = new Label();
            scherm.Controls.Add(tekst);
            tekst.Location = new Point(100, 100);

            tekst.Text = Board.getGrootsteZwimpie();
            Board b = new Board(6, 6);

            b.getNumbers(); 


            // waarom doet github het niet


            Application.Run(scherm);
        }

    }

}