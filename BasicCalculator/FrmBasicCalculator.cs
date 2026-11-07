using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            // Populate the dropdown with operators
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
            cbOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, total = 0;

            // Validate that inputs are properly formatted numbers
            if (float.TryParse(txtNum1.Text, out num1) && float.TryParse(txtNum2.Text, out num2))
            {
                string operation = cbOperator.Text;

                switch (operation)
                {
                    case "+":
                        total = BasicComputation.Addition(num1, num2);
                        break;
                    case "-":
                        total = BasicComputation.Subtraction(num1, num2);
                        break;
                    case "*":
                        total = BasicComputation.Multiplication(num1, num2);
                        break;
                    case "/":
                        total = BasicComputation.Division(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Please select a valid operator.");
                        return;
                }

                lblTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}