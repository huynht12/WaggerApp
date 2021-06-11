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
    public partial class LogIn : Form
    {

        string[] users;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //load a file of all existing users
            //write users & password in container string
            try
            {
                //using (var sr = new StreamReader("Users.txt"))
                    users = File.ReadAllLines(@".\Users.txt");
                    //Console.WriteLine(users);
                    //sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //Login
        //checks for match in username & password
        private void button1_Click(object sender, EventArgs e)
        {
            bool error = true;
            label4.Text = string.Empty;
            string username = textBox1.Text;
            string password = textBox2.Text;
            for (int i = 0; i < users.Length; i += 4)
            {
                if (username.Equals(users[i], StringComparison.OrdinalIgnoreCase) && password.Equals(users[i+1], StringComparison.Ordinal))
                {
                    error = false;
                    String[] login = File.ReadAllLines(@".\" + username + " Profile.txt");
                    if(login[6]== "1")
                    {
                        Preferences pref = new Preferences(login[1], 1);
                        //this.Hide();
                        pref.ShowDialog();
                       // this.Show();
                    }
                    MainPage mainPage = new MainPage(login[1]);
                    this.Hide();
                    mainPage.ShowDialog();  
                }
            }
            if (error)
            {
                label4.Text = "Username or Password is invalid, Please try again.";
            }
            

        }

        //Register
        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        //Exit
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
