using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int var;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            
            var = rnd.Next(0, 3);

        }

        private void StoneBtn_Click(object sender, EventArgs e)
        {
            check_result(0);
        }

        private void check_result(int user_result)
        {
            if (var == 0)
            {
                stoneBtn.BackColor = Color.Aqua;
            }
            else if (var == 1)
            {
                scissorsBtn.BackColor = Color.Aqua;
            }
            else if (var == 2)
            {
                paperBtn.BackColor = Color.Aqua;
            }

            if (user_result == var)
            {
                richTextBox1.Text = "Ничья";
            } 
            else if (user_result == 0 && var == 1)
            {
                richTextBox1.Text = "Ты выйграл!";
            }
            else if (user_result == 0 && var == 2)
            {
                richTextBox1.Text = "Ты проиграл!";
            }
            else if (user_result == 1 && var == 2)
            {
                richTextBox1.Text = "Ты выйграл!";
            }
            else if (user_result == 1 && var == 0)
            {
                richTextBox1.Text = "Ты проиграл!";
            }
            else if (user_result == 2 && var == 0)
            {
                richTextBox1.Text = "Ты выйграл!";
            }
            else if (user_result == 2 && var == 1)
            {
                richTextBox1.Text = "Ты проиграл!";
            }
        }

        private void ScissorsBtn_Click(object sender, EventArgs e)
        {
            check_result(1);
        }

        private void PaperBtn_Click(object sender, EventArgs e)
        {
            check_result(2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var = rnd.Next(0, 3);
            stoneBtn.BackColor = Color.Transparent;
            scissorsBtn.BackColor = Color.Transparent;
            paperBtn.BackColor = Color.Transparent;
            richTextBox1.Text = "";
        }
    }
}
