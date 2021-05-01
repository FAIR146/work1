using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work1
{
    public partial class Form1 : Form
    {
        int numbers2 = 0;
        int numbers3 = 0;
        int result = 0;
        int numberNeZnayu = 0;
        int numberNeZnayu2 = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(1, 3 + 1);
            int number2 = random.Next(1, 3 + 1);
            int number3 = random.Next(1, 3 + 1);
            int number4 = random.Next(1, 3 + 1);
            int number5 = random.Next(1, 3 + 1);
            int number6 = random.Next(1, 3 + 1);
            int number7 = random.Next(1, 3 + 1);
            int number8 = random.Next(1, 3 + 1);
            int number9 = random.Next(1, 3 + 1);
            int number10 = random.Next(1, 3 + 1);
            labelNum1.Text = number1.ToString();
            labelNum2.Text = number2.ToString();
            labelNum3.Text = number2.ToString();
            labelNum4.Text = number4.ToString();
            labelNum5.Text = number5.ToString();
            labelNum6.Text = number6.ToString();
            labelNum7.Text = number7.ToString();
            labelNum8.Text = number8.ToString();
            labelNum9.Text = number9.ToString();
            labelNum10.Text = number10.ToString();

            if (number1 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number1 == 3)
                {
                    numbers3++;
                }
            }
            if (number2 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number2 == 3)
                {
                    numbers3++;
                }
            }
            if (number3 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number3 == 3)
                {
                    numbers3++;
                }
            }
            if (number4 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number4 == 3)
                {
                    numbers3++;
                }
            }
            if (number5 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number5 == 3)
                {
                    numbers3++;
                }
            }
            if (number6 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number6 == 3)
                {
                    numbers3++;
                }
            }
            if (number7 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number7 == 3)
                {
                    numbers3++;
                }
            }
            if (number8 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number8 == 3)
                {
                    numbers3++;
                }
            }
            if (number9 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number9 == 3)
                {
                    numbers3++;
                }
            }
            if (number10 == 2)
            {
                numbers2++;
            }
            else
            {
                if (number10 == 3)
                {
                    numbers3++;
                }
            }
            result = numbers2 - numbers3;
            labelNum11.Text = result.ToString();
            if (number2 == 3)
            {
                numberNeZnayu++;
            }
            if (number4 == 3)
            {
                numberNeZnayu++;
            }
            if (number6 == 3)
            {
                numberNeZnayu++;
            }
            if (number8 == 3)
            {
                numberNeZnayu++;
            }
            if (number10 == 3)
            {
                numberNeZnayu++;
            }
            labelNum12.Text = numberNeZnayu.ToString();

            if (number1 == 2)
            {
                numberNeZnayu2++;
            }
            if (number2 == 2)
            {
                numberNeZnayu2++;
            }
            if (number3 == 2)
            {
                numberNeZnayu2++;
            }
            if (number4 == 2)
            {
                numberNeZnayu2++;
            }
            if (number5 == 2)
            {
                numberNeZnayu2++;
            }
            labelNum13.Text = numberNeZnayu2.ToString();
        }
    }
}
