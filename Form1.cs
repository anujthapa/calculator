using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class frm_Calculator : Form
    {
        double result=0;
        string operationPerformed="";
        bool isOperation = false;
        public frm_Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_click(object sender, EventArgs e)
        {
            if (txtbox_display.Text == "0" || (isOperation))
            {
                txtbox_display.Clear();
            }
            Button btn = (Button)sender;
            if(btn.Text == ".")
            {
                if (!txtbox_display.Text.Contains("."))
                    txtbox_display.Text = txtbox_display.Text + btn.Text;
            }
            else{
               txtbox_display.Text = txtbox_display.Text + btn.Text;
                isOperation = false;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            result = Double.Parse(txtbox_display.Text);
            lbl_process.Text = result +" "+ operationPerformed;
            isOperation = true;
          

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbox_display.Text = "0";
        }

        private void btn_onoff_Click(object sender, EventArgs e)
        {
            txtbox_display.Text = "0";
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {

            switch (operationPerformed)
            {
                case "+":
                    txtbox_display.Text = (result + Double.Parse(txtbox_display.Text)).ToString();
                    break;
                case "-":
                    txtbox_display.Text = (result - Double.Parse(txtbox_display.Text)).ToString();
                    break;
                case "/":
                    txtbox_display.Text = (result / Double.Parse(txtbox_display.Text)).ToString();
                    break;
                case "*":
                    txtbox_display.Text = (result / Double.Parse(txtbox_display.Text)).ToString();
                    break;
                default:
                    break;

            }
        }

      
    }
}
