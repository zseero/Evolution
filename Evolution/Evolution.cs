using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Evolution : Form
    {
        public Evolution()
        {
            InitializeComponent();
        }

        public static List<int> nums = new List<int>();
        public static int defaultnum = 100;//default number of starting citizens
        public static int defaultamt = 3000;//default number of average citizens
        public static int startingnum = defaultnum;//number of starting citizens
        public static int citizens = defaultamt; //ammount of average citizens
        public static int fittest = 1;    //numer of the fittest
        public static int range = 1;      //range of fittest surival benefits
        public static int babyrange = 1;  //range of mutation
        public static int babychange = 3; //chance of mutation
        public static int counter = 0;    //counts the number of times you click evolve

        public string print(List<int> list)
        {
            string myout = "";
            foreach (int i in list)
            {
                myout = myout + i.ToString();
            }
            return myout;
        }

        public void adjustbar()
        {
            int amt = 0;
            foreach (int num in nums)
            {
                if (num == fittest)
                    amt++;
            }
            double percent = ((double) amt) / ((double) nums.Count());
            percent = Math.Round(percent, 2);
            int value = (int) (percent * 100);
            evolvedbar.Value = value;
            percentbox.Text = value.ToString() + "%";
        }

        public void setthefittest()
        {
            if (counter > 100)
            {
                counter = 0;
                Random random = new Random();
                fittest = fittest + (random.Next(4) + 2);
                if (fittest <= 0)
                    fittest = fittest + 9;
                else if (fittest >= 10)
                    fittest = fittest - 9;
            }
            thefittest.Text = fittest.ToString();
            clicksleft.Text = (100 - counter).ToString();
        }

        public void Start()
        {
            Random random = new Random();
            for (int i = 0; i < startingnum; i++)
            {
                int num = random.Next(8) + 1;
                nums.Add(num);
            }
            fittest = random.Next(8) + 1;
        }

        public bool kill(int i)
        {
            Random random = new Random();
            if (i == fittest)
            {
                if (random.Next(9) == 0)
                {
                    return true;
                }
            }
            else if (i >= fittest - range && i <= fittest + range)
            {
                if (random.Next(4) == 0)
                {
                    return true;
                }
            }
            else
            {
                if (random.Next(2) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Evolve()
        {
            Random random = new Random();
            List<int> newlist = nums;
            for (int ind = 0; ind < nums.Count(); ind++)
            {
                int i = newlist[ind];
                int babies;
                if (newlist.Count() > citizens)
                {
                    babies = random.Next(1);
                    babyrange = 1;
                }
                else
                {
                    babies = random.Next(2);
                    babyrange = 2;
                }
                bool dead = kill(i);

                if (dead)
                {
                    newlist.Remove(i);
                    babies = 0;
                }

                for (int index = 0; index < babies; index++)
                {
                    int baby = i;
                    if (random.Next(babychange) == 0)
                        baby = baby + (random.Next(babyrange) - (babyrange / 2));
                    if (baby <= 0)
                        baby = baby + 9;
                    else if (baby >= 10)
                        baby = baby - 9;
                    newlist.Add(baby);
                }
            }
            nums = newlist;
        }

        private void evolve_Click(object sender, EventArgs e)
        {
            counter++;
            if (output.Text.Equals(""))
                Start();
            else
                Evolve();
            output.Text = print(nums);
            setthefittest();
            adjustbar();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            output.Text = "";
            nums = new List<int>();
            startingnum = defaultnum;
            startingnumbers.Text = defaultnum.ToString();
            citizens = defaultamt;
            amt.Text = defaultamt.ToString();
            clicksleft.Text = "100";
            counter = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int newnum;
            try
            {
                int tempnum = Int32.Parse(startingnumbers.Text);
                if (tempnum > 0)
                    newnum = tempnum;
                else
                    throw new Exception();
            }
            catch { newnum = defaultnum; startingnumbers.Text = defaultnum.ToString(); }
            startingnum = newnum;
        }

        private void amt_TextChanged(object sender, EventArgs e)
        {
            int newamt;
            try
            {
                int tempamt = Int32.Parse(amt.Text);
                if (tempamt > 0)
                    newamt = tempamt;
                else
                    throw new Exception();
            }
            catch { newamt = defaultnum; startingnumbers.Text = defaultnum.ToString(); }
            citizens = newamt;
        }
    }
}
