using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yesno
{
    public partial class Form1 : Form
    {

        private Engine engine;

        public Form1()
        {
            InitializeComponent();

            engine = new Engine(this);
        }

        private void btGetAnswer_Click(object sender, EventArgs e)
        {
            bool answer = engine.getProb();

            if (answer == true)
                btAnswer.Text = "YES!";
            else
                btAnswer.Text = "NO!";

            btAnswer.ForeColor = System.Drawing.Color.White;
        }
    }
}
