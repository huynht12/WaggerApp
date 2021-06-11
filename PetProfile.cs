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
    public partial class PetProfile : Form
    {
        string[] pet;

        public PetProfile(string petName)
        {
            InitializeComponent();
            pet = File.ReadAllLines(@".\" + petName + ".txt");
            label1.Text = petName;
            pictureBox1.BackgroundImage = Image.FromFile(@".\" + petName + ".jpg");
            pictureBox1.Refresh();
        }

        private void PetProfile_Load(object sender, EventArgs e)
        {  
            for (int i = 1; i < pet.Length-1; i++)
            {
                switch (i)
                {
                    case 1:
                        if (pet[i] == "1")
                            label2.Text = "Male";
                        else
                            label2.Text = "Female";
                        break;
                    case 2:
                        switch (pet[i])
                        {
                            case "1":
                                if (pet[0] == "1")
                                    label3.Text = "Puppy";
                                else
                                    label3.Text = "Kitten";
                                break;
                            case "2":
                                label3.Text = "Adolescence";
                                break;
                            case "3":
                                label3.Text = "Adult";
                                break;
                            case "4":
                                label3.Text = "Senior";
                                break;
                        }
                        break;
                    case 3:
                        switch (pet[i])
                        {
                            case "1":
                                label4.Text = "Small";
                                break;
                            case "2":
                                label4.Text = "Medium";
                                break;
                            case "3":
                                label4.Text = "Large";
                                break;
                            case "4":
                                label4.Text = "Extra Large";
                                break;
                        }
                        break;
                    case 4:
                        switch (pet[i])
                        {
                            case "0":
                                label5.Text = "Good with all other Family Members";
                                break;
                            case "1":
                                label5.Text = "Good with small children";
                                break;
                            case "2":
                                label5.Text = "Good with dogs";
                                break;
                            case "3":
                                label5.Text = "Good with cats";
                                break;
                            case "4":
                                label5.Text = "Good with children and dogs";
                                break;
                            case "5":
                                label5.Text = "Good with children and cats";
                                break;
                            case "6":
                                label5.Text = "Good with dogs and cats";
                                break;
                            case "7":
                                label5.Text = "Not good with other family pets or kids";
                                break;
                        }
                        break;
                    case 5:
                        if (pet[i] == "1")
                            label6.Text = "House-Trained";
                        else
                            label6.Text = "Need More Training";
                        break;
                    case 6:
                        label7.Text = pet[i] + " miles away.";
                        break;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email sendEmail = new Email();
            sendEmail.ShowDialog();
            this.Close();
        }
    }
}
