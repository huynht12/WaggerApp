using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace WaggerApp
{
    public partial class Registration : Form
    {

        String[] users;

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //load a file of all existing users
            //write users & password in container string
            try
            {
                //using (var sr = new StreamReader("Users.txt"))
                    users = File.ReadAllLines("Users.txt");
                    //Console.WriteLine(users);
                    //sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //Back
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Register
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string email = textBox5.Text;
            bool error = false;
            for (int i = 0; i < users.Length; i += 4)
            {
                if (username.Equals(users[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Error: username already exist");
                    label8.Text = "Username already exist, Please choose a different one";
                    textBox3.Text = String.Empty;
                    error = true;
                    break;
                }
                if (email.Equals(users[i+2], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Error: email already been registered");
                    label9.Text = "The Email has already been registered, Please choose a different one";
                    textBox3.Text = String.Empty;
                    error = true;
                    break;
                }
            }


            if (textBox2.Text.Contains(" "))
            {
                label10.Text = "Username cannot contain spaces";
                error = true;
            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                label11.Text = "Please fill in all required fields";
                error = true;
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                label11.Text = "Please fill in all required fields";
                error = true;
            }
            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                label11.Text = "Please fill in all required fields";
                error = true;
            }
            else if (String.IsNullOrEmpty(textBox6.Text))
            {
                label11.Text = "Please fill in all required fields";
                error = true;
            }
            else if (!IsValidEmail(email))
            {
                Console.WriteLine("Error: invalid email");
                label9.Text = "Please enter a valid Email address";
                textBox3.Text = String.Empty;
                error = true;
            }
            if (!error)
            {
                try
                {
                    using (var sw = new StreamWriter(@".\Users.txt", true, Encoding.ASCII))
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            switch (k)
                            {
                                case 0:
                                    //new blank line
                                    sw.WriteLine("");
                                    break;
                                case 1:
                                    //Add username
                                    sw.WriteLine(textBox2.Text);
                                    break;
                                case 2:
                                    //Add Password
                                    sw.WriteLine(textBox3.Text);
                                    break;
                                case 3:
                                    //Add Email
                                    sw.WriteLine(textBox5.Text);
                                    break;
                            }
                        }
                        sw.Close();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                try
                {
                    using (var sw = new StreamWriter(@".\" + textBox2.Text + " Profile.txt", true, Encoding.ASCII))
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            switch (k)
                            {
                                case 0:
                                    //Add Full Name
                                    sw.WriteLine(textBox1.Text);
                                    break;
                                case 1:
                                    //Add Username
                                    sw.WriteLine(textBox2.Text);
                                    break;
                                case 2:
                                    //Add Password
                                    sw.WriteLine(textBox3.Text);
                                    break;
                                case 3:
                                    //Add Location
                                    sw.WriteLine(textBox4.Text);
                                    break;
                                case 4:
                                    //Add Email
                                    sw.WriteLine(textBox5.Text);
                                    break;
                                case 5:
                                    //Add Age
                                    sw.WriteLine(textBox6.Text);
                                    break;
                            }
                        }
                        sw.WriteLine(1);
                        sw.Close();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                RegistrationComplete comReg = new RegistrationComplete();
                comReg.ShowDialog();
                this.Close();
            }

        }

        //Check for Email validation
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //Full Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
        }

        //Username
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label8.Text = string.Empty;
        }

        //Password
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
        }        
        
        //Location
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
        }

        //Email
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label9.Text = string.Empty;
        }

        //Age
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
        }
    }
}