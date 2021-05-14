using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yesno
{
    class Engine
    {
        private Form1 form;

        Random rand = new Random();

        public Engine(Form1 form)
        {
            this.form = form;
        }

        public bool getProb()
        {
            double p = 0.5;

            double alpha = rand.NextDouble();

            if (alpha < p)
                return true;
            else
                return false;
        }
    }
}
