using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gumb_bjezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBjezi_MouseEnter(object sender, EventArgs e)
        {
            int x = btnBjezi.Location.X;
            int y = btnBjezi.Location.Y;
            Random i = new Random();

            this.Controls.Remove(btnBjezi);
            btnBjezi.Location = new System.Drawing.Point(x+i.Next(-50,50), y+i.Next(-50,50));
            this.Controls.Add(btnBjezi);
        }
    }
}
