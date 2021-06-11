using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaggerApp
{
    public partial class UserProfile : Form
    {

        string[] userDetails;

        public UserProfile(string username)
        {
            InitializeComponent();
            userDetails = File.ReadAllLines(@".\" + username + " Profile.txt");
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            label1.Text = userDetails[1];
            label2.Text = "Name: " + userDetails[0];
            label3.Text = "Email: " + userDetails[4];
            label4.Text = "Location: " + userDetails[3];
            label5.Text = "Age: " + userDetails[5];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preferences userPref = new Preferences(userDetails[1], 0);
            this.Hide();
            userPref.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SavedPets likedPets = new SavedPets(userDetails[1]);
            this.Hide();
            likedPets.ShowDialog();
            this.Show();
        }
    }
}
