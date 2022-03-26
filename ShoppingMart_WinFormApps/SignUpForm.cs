using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace ShoppingMart_WinFormApps
{
    public partial class SignUpForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBConnectionstring"].ConnectionString;
        string patternEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Insert Name !");
            }
            else
            {
                errorProviderName.Clear();
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSurname.Text) == true)
            {
                textBoxSurname.Focus();
                errorProviderSurname.SetError(this.textBoxSurname, "Insert Surname !");
            }
            else
            {
                errorProviderSurname.Clear();
            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxGender_Leave(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedItem == null)
            {
                comboBoxGender.Focus();
                errorProviderGender.SetError(this.comboBoxGender, "Please select Gender");
            }
            else
            {
                errorProviderGender.Clear();
            }
        }

        private void numericUpDownAge_Leave(object sender, EventArgs e)
        {
            if (numericUpDownAge.Value == 0)
            {
                numericUpDownAge.Focus();
                errorProviderAge.SetError(this.numericUpDownAge, "Please insert age");
            }

            else
            {
                errorProviderAge.Clear();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxEmail.Text, patternEmail) == false)
            {
                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Invalid email");
            }
            else
            {
                errorProviderEmail.Clear();
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddress.Text) == true)
            {
                textBoxAddress.Focus();
                errorProviderAddress.SetError(this.textBoxAddress, "Insert Address !");
            }
            else
            {
                errorProviderAddress.Clear();
            }
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPass.Text, patternPassword) == false)
            {
                textBoxPass.Focus();
                errorProviderPassword.SetError(this.textBoxPass, "Use Uppercase , Lowercase, Number , Symbols");
            }
            else
            {
                errorProviderPassword.Clear();
            }
        }

        private void textBoxCon_Pass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text != textBoxCon_Pass.Text)
            {
                textBoxCon_Pass.Focus();
                errorProviderConPass.SetError(this.textBoxCon_Pass, "Password is not match");
            }

            else
            {
                errorProviderConPass.Clear();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Insert ID !");
            }
          
            else if (string.IsNullOrEmpty(textBoxSurname.Text) == true)
            {
                textBoxSurname.Focus();
                errorProviderSurname.SetError(this.textBoxSurname, "Insert Surname !");
            }
            else if (comboBoxGender.SelectedItem == null)
            {
                comboBoxGender.Focus();
                errorProviderGender.SetError(this.comboBoxGender, "Please select Gender");
            }

            else if (numericUpDownAge.Value == 0)
            {
                numericUpDownAge.Focus();
                errorProviderAge.SetError(this.numericUpDownAge, "Please enter age");
            }

            else if (string.IsNullOrEmpty(textBoxAddress.Text) == true)
            {
                textBoxAddress.Focus();
                errorProviderSurname.SetError(this.textBoxAddress, "Insert Surname !");
            }

            else if (Regex.IsMatch(textBoxEmail.Text, patternEmail) == false)
            {
                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Invalid email");
            }

            else if (Regex.IsMatch(textBoxPass.Text, patternPassword) == false)
            {
                textBoxPass.Focus();
                errorProviderPassword.SetError(this.textBoxPass, "Use Uppercase , Lowercase, Number , Symbols");
            }
            else if (textBoxPass.Text != textBoxCon_Pass.Text)
            {
                textBoxCon_Pass.Focus();
                errorProviderConPass.SetError(this.textBoxCon_Pass, "Password is not match");
            }

            else
            {
                SqlConnection con = new SqlConnection(cs);
                string queryInsert = "insert into SignUp_Tbl values (@name ,@surname,@gender,@age,@address,@email,@pass)";

                SqlCommand sqlCommand = new SqlCommand(queryInsert, con);
               
                sqlCommand.Parameters.AddWithValue("@name", textBoxName.Text);
                sqlCommand.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                sqlCommand.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@age", numericUpDownAge.Value);
                sqlCommand.Parameters.AddWithValue("@address",textBoxAddress.Text);
                sqlCommand.Parameters.AddWithValue("@email", textBoxEmail.Text);
                sqlCommand.Parameters.AddWithValue("@pass", textBoxPass.Text);

                con.Open();
                int value = sqlCommand.ExecuteNonQuery();
                if (value >0)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your username is: " + textBoxName.Text + "\n\n" + "Your Password is :" + textBoxPass.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Registered Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();

            }
        }
    }
}
