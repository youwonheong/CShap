﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAndControl
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "클릭";
            button.Left = 100;
            button.Top = 50;
            button.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("딸깍");
            }; //람다 이벤트 핸들러
            Program form = new Program();
            form.Text = "Form & Control";
            form.Height = 150;
            form.Controls.Add(button);
            Application.Run(form);
        }
    }
}
