using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld.WinForm
{
    public partial class Form1 : Form
    {
        private const int SIZECIRCLE = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("Paint");
            const int startRow = 100;
            const int startColumn = 100;
            const int rows = 4;
            const int columns = 4;

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int columIndex = 0; columIndex < rows; columIndex++)
                {
                    int posX = startColumn + columIndex * 4 * SIZECIRCLE + ( rowIndex) * 4 * SIZECIRCLE/2;
                    int posY = startRow + rowIndex * 4 * SIZECIRCLE;
                    DrawCircle(e.Graphics, new Point(posX, posY));
                }
            }
        }

        void DrawCircle(Graphics g, Point centerPoint, int radius=SIZECIRCLE)
        {
            g.DrawEllipse(new Pen(Color.Black), new Rectangle(centerPoint.X- radius, centerPoint.Y- radius, 2* radius, 2* radius));
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Size changed");
            Invalidate();
        }
    }
}
