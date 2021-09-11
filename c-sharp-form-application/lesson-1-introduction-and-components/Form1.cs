using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_1_introduction_and_components
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (txtFirstNumber.Text != null && txtFirstNumber.Text.Trim().Length > 0)
            {
                int firstNumber = Convert.ToInt32(txtFirstNumber.Text);
                int secondNumber = Convert.ToInt32(txtSecondNumber.Text);

                lblResult.Text = Convert.ToString(firstNumber + secondNumber);

                txtFirstNumber.Clear();
                txtSecondNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please enter in the required fields!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtText.Text != null && txtText.Text.Trim().Length > 0)
            {
                listTextList.Items.Add(txtText.Text);
                txtText.Clear();
            }
            else
            {
                MessageBox.Show("Please enter in the required field!");
            }
        }
    }
}
