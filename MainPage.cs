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
    public partial class MainPage : Form
    {
        string[] userPrefs;
        string[] allPets;
        string[] petCheck;
        string[] usersPets;
        bool passFilter;
        string user;
        int index;

        public MainPage(string username)
        {
            InitializeComponent();
            user = username;
            FilterUpdate();
            //Console.WriteLine("show 1");
            for (index = 0; index < allPets.Length; index++)
            {
                //Console.WriteLine(index);
                //Console.WriteLine("show 2");
                petCheck = File.ReadAllLines(@".\" + allPets[index] + ".txt");
                if (petCheck[7] == "1")
                {
                    //Console.WriteLine("show 3");
                    pictureBox1.BackgroundImage = Image.FromFile(@".\" + allPets[index] + ".jpg");
                    label1.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Bold);
                    pictureBox1.Refresh();
                    label1.Text = allPets[index];
                    //Console.WriteLine("show 4");
                    break;
                }
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PetProfile currentPet = new PetProfile(allPets[index]);
            this.Hide();
            currentPet.ShowDialog();
            this.Show();
        }

        //liked pet to user's list
        private void button4_Click(object sender, EventArgs e)
        {

            if (index == allPets.Length - 1)
            {
                NoMorePet();
            }
            else
            {
                AddtoList();
                index++;
                NextPet();
            }

        }

        //Does not like Pet
        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(index);
            //Console.WriteLine(allPets.Length);
            if (index == allPets.Length - 1)
            {
                NoMorePet();
            }
            else
            {
                index++;
                NextPet();
            }
        }

        //Log Out
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //User Profile
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile userProfile = new UserProfile(user);
            userProfile.ShowDialog();
            FilterUpdate();
            this.Show();

        }

        private bool TypeCheck(string petType, string uPref)
        {
            if (petType.Equals(uPref) || uPref == "0")
            {
                return true;
            }
            else
                return false;
        }

        private bool GenderCheck(string gender, string uPref)
        {
            if (gender.Equals(uPref) || uPref == "0")
            {
                return true;
            }
            else
                return false;
        }

        private bool AgeCheck(int age, string uPref)
        {
            //string[] pass = new string[7];
            string[] baby = {"0", "1", "5", "6", "7", "11", "12", "13" };
            string[] adol = {"0", "2", "5", "8", "9", "11", "12", "14" };
            string[] adult = {"0", "3", "6", "8", "10", "11", "13", "14" };
            string[] senior = {"0", "4", "7", "9", "10", "12", "13", "14" };
            switch (age)
            {
                case 1:
                    if (Array.IndexOf(baby, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 2:
                    if (Array.IndexOf(adol, uPref) > -1)
                    {
                        //Console.WriteLine("true");
                        return true;
                    }
                    else
                        //Console.WriteLine("False");
                        return false;
                case 3:
                    if (Array.IndexOf(adult, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 4:
                    if (Array.IndexOf(senior, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
            }
            return true;
        }

        private bool SizeCheck(int size, string uPref)
        {
            //string[] pass = new string[7];
            string[] small = { "0", "1", "5", "6", "7", "11", "12", "13" };
            string[] medium = { "0", "2", "5", "8", "9", "11", "12", "14" };
            string[] large = { "0", "3", "6", "8", "10", "11", "13", "14" };
            string[] extra = { "0", "4", "7", "9", "10", "12", "13", "14" };
            switch (size)
            {
                case 1:
                    if (Array.IndexOf(small, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 2:
                    if (Array.IndexOf(medium, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 3:
                    if (Array.IndexOf(large, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 4:
                    if (Array.IndexOf(large, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
            }
            return true;
        }

        private bool SocialCheck(int social, string uPref)
        {
            //string[] pass = new string[7];
            string[] kids = { "0", "1", "4", "5"};
            string[] dogs = { "0", "2", "4", "6"};
            string[] cats = { "0", "3", "5", "6"};
            switch (social)
            {
                case 1:
                    if (Array.IndexOf(kids, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 2:
                    if (Array.IndexOf(dogs, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 3:
                    if (Array.IndexOf(cats, uPref) > -1)
                    {
                        return true;
                    }
                    else
                        return false;
                case 4:
                    if (uPref == "3")
                    {
                        return false;
                    }
                    else
                        return true;
                case 5:
                    if (uPref == "2")
                    {
                        return false;
                    }
                    else
                        return true;
                case 6:
                    if (uPref == "1")
                    {
                        return false;
                    }
                    else
                        return true;
                case 7:
                    if (uPref == "0")
                        return true;
                    else
                        return false;
            }
            return true;
        }

        private bool TrainingCheck(string training, string uPref)
        {
            if (training.Equals(uPref) || uPref == "0")
            {
                return true;
            }
            else
                return false;
        }

        private void FilterUpdate()
        {
            index = 0;
            userPrefs = File.ReadAllLines(@".\" + user + " Preferences.txt");
            allPets = File.ReadAllLines(@".\Pets.txt");
            if (File.Exists(@".\" + user + " Pets.txt"))
            {
                usersPets = File.ReadAllLines(@".\" + user + " Pets.txt");
            }
            else
                File.Create(@".\" + user + " Pets.txt");
            for (int i = 0; i < allPets.Length; i++)
            {
                passFilter = true;
                petCheck = File.ReadAllLines(@".\" + allPets[i] + ".txt");
                for (int j = 0; j < petCheck.Length - 1; j++)
                {
                    if (!passFilter)
                    {
                        //Console.WriteLine("Helollo");
                        break;
                    }
                    else if (usersPets.Contains(allPets[i]))
                    {
                        //Console.WriteLine("Heloo");
                        passFilter = false;
                        break;
                    }
                    switch (j)
                    {
                        case 0:
                            switch (petCheck[0])
                            {
                                case "1":
                                    passFilter = TypeCheck("1", userPrefs[j]);
                                    break;
                                case "2":
                                    passFilter = TypeCheck("2", userPrefs[j]);
                                    break;
                            }
                            break;
                        case 1:
                            switch (petCheck[1])
                            {
                                case "1":
                                    passFilter = GenderCheck("1", userPrefs[j]);
                                    break;
                                case "2":
                                    //Console.WriteLine("Check 1");
                                    passFilter = GenderCheck("2", userPrefs[j]);
                                    break;
                            }
                            break;
                        case 2:
                            switch (petCheck[2])
                            {
                                case "1":
                                    passFilter = AgeCheck(1, userPrefs[j]);
                                    break;
                                case "2":
                                    //Console.WriteLine("Check 2");
                                    passFilter = AgeCheck(2, userPrefs[j]);
                                    break;
                                case "3":
                                    passFilter = AgeCheck(3, userPrefs[j]);
                                    break;
                                case "4":
                                    passFilter = AgeCheck(4, userPrefs[j]);
                                    break;
                            }
                            break;
                        case 3:
                            switch (petCheck[3])
                            {
                                case "1":
                                    passFilter = SizeCheck(1, userPrefs[j]);
                                    break;
                                case "2":
                                    passFilter = SizeCheck(2, userPrefs[j]);
                                    break;
                                case "3":
                                    //Console.WriteLine("Check 3");
                                    passFilter = SizeCheck(3, userPrefs[j]);
                                    break;
                                case "4":
                                    passFilter = SizeCheck(4, userPrefs[j]);
                                    break;
                            }
                            break;
                        case 4:
                            switch (petCheck[4])
                            {
                                case "0":
                                    passFilter = true;
                                    break;
                                case "1":
                                    passFilter = SocialCheck(1, userPrefs[j]);
                                    break;
                                case "2":
                                    passFilter = SocialCheck(2, userPrefs[j]);
                                    break;
                                case "3":
                                    passFilter = SocialCheck(3, userPrefs[j]);
                                    break;
                                case "4":
                                    //Console.WriteLine("Check 4");
                                    passFilter = SocialCheck(4, userPrefs[j]);
                                    break;
                                case "5":
                                    passFilter = SocialCheck(5, userPrefs[j]);
                                    break;
                                case "6":
                                    passFilter = SocialCheck(6, userPrefs[j]);
                                    break;
                                case "7":
                                    passFilter = SocialCheck(7, userPrefs[j]);
                                    break;
                            }
                            break;
                        case 5:
                            switch (petCheck[5])
                            {
                                case "1":
                                    //Console.WriteLine("Check 6");
                                    passFilter = TrainingCheck("1", userPrefs[j]);
                                    break;
                                case "2":
                                    passFilter = TrainingCheck("2", userPrefs[j]);
                                    break;
                            }
                            break;
                        case 6:
                            int pet = Int32.Parse(petCheck[6]);
                            int user = Int32.Parse(userPrefs[j]);
                            //Console.WriteLine(pet);
                            //Console.WriteLine(user);
                            if (pet <= user)
                            {
                                passFilter = true;
                            }
                            else
                                passFilter = false;
                            break;
                    }
                }

                if (passFilter)
                {
                    petCheck[7] = "1";
                    File.WriteAllLines(@".\" + allPets[i] + ".txt", petCheck);
                }
                else
                {
                    //did not pass the filter check
                    petCheck[7] = "0";
                    File.WriteAllLines(@".\" + allPets[i] + ".txt", petCheck);
                }
            }
        }

        private void NextPet()
        {
            for (int i = index; i < allPets.Length; i++)
            {
                petCheck = File.ReadAllLines(@".\" + allPets[i] + ".txt");
                //Console.WriteLine(allPets[i]);
                if (petCheck[7] == "1")
                {
                    pictureBox1.BackgroundImage = Image.FromFile(@".\" + allPets[i] + ".jpg");
                    pictureBox1.Refresh();
                    label1.Text = allPets[i];
                    break;
                }
                if (i == allPets.Length - 1)
                {
                    NoMorePet();
                }
            }
        }

        private void NoMorePet()
        {
            label1.Text = "There are no more pets matching your criteria.\nPlease update your preferences in your profile.";
            label1.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            pictureBox1.BackgroundImage = Properties.Resources.Sad;
            pictureBox1.Refresh();
        }

        private void AddtoList ()
        {
            petCheck[7] = "0";
            File.WriteAllLines(@".\" + label1.Text + ".txt", petCheck);
            using (StreamWriter sw = File.AppendText(@".\" + user + " Pets.txt"))
            {
                sw.WriteLine(label1.Text);
            }
        }
    }
}
