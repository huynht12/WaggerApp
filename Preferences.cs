using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace WaggerApp
{
    public partial class Preferences : Form
    {

        string[] prefs;
        int[] choice = new int[7];
        string user;

        public Preferences(String username, int firstTime)
        {
            InitializeComponent();
            if (firstTime == 1)
            {
                user = username;
                button2.Visible = false;
                button1.Location = new Point (159, 606);
                label1.Text = "This is your first time logging in, Please take a moment filling our your prefences below.";
            }
            else
            {
                prefs = File.ReadAllLines(@".\" + username + " Preferences.txt");
                for (int i = 0; i < prefs.Length; i++)
                {
                    choice[i] = Int32.Parse(prefs[i]);
                }
                user = username;
                label1.Text = "Feel free to change your preferences below, press 'save' when you are done.";
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            if (!(choice == null))
            {
                for (int k = 0; k < choice.Length; k++)
                {
                    switch (k)
                    {
                        case 0:
                            switch (choice[k])
                            {
                                //Dogs and/or Cats
                                case 0:
                                    label3.BackColor = Color.LightBlue;
                                    label4.BackColor = Color.LightBlue;
                                    break;
                                //Dogs
                                case 1:
                                    label3.BackColor = Color.LightBlue;
                                    break;
                                //Cats
                                case 2:
                                    label4.BackColor = Color.LightBlue;
                                    break;
                            }
                            break;
                        case 1:
                            switch (choice[k])
                            {
                                //Male and/or Female
                                case 0:
                                    label5.BackColor = Color.LightBlue;
                                    label6.BackColor = Color.LightBlue;
                                    break;
                                //Male
                                case 1:
                                    label6.BackColor = Color.LightBlue;
                                    break;
                                //Female
                                case 2:
                                    label5.BackColor = Color.LightBlue;
                                    break;
                            }
                            break;
                        case 2:
                            switch (choice[k])
                            {
                                //Any Age
                                case 0:
                                    label11.BackColor = Color.LightBlue;
                                    label9.BackColor = Color.LightBlue;
                                    label8.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Baby
                                case 1:
                                    label11.BackColor = Color.LightBlue;
                                    break;
                                //Adolescence
                                case 2:
                                    label9.BackColor = Color.LightBlue;
                                    break;
                                //Adult
                                case 3:
                                    label8.BackColor = Color.LightBlue;
                                    break;
                                //Senior
                                case 4:
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Baby & Adolescence
                                case 5:
                                    label11.BackColor = Color.LightBlue;
                                    label9.BackColor = Color.LightBlue;
                                    break;
                                //Baby & Adult
                                case 6:
                                    label11.BackColor = Color.LightBlue;
                                    label8.BackColor = Color.LightBlue;
                                    break;
                                //Baby & Senior
                                case 7:
                                    label11.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Adolescence & Adult
                                case 8:
                                    label9.BackColor = Color.LightBlue;
                                    label8.BackColor = Color.LightBlue;
                                    break;
                                //Adolescence & Senior
                                case 9:
                                    label9.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Adult & Senior
                                case 10:
                                    label8.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Baby, Adolescence, Adult
                                case 11:
                                    label11.BackColor = Color.LightBlue;
                                    label9.BackColor = Color.LightBlue;
                                    label8.BackColor = Color.LightBlue;
                                    break;
                                //Baby, Adolescence, Senior
                                case 12:
                                    label11.BackColor = Color.LightBlue;
                                    label9.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Baby, Adult, Senior
                                case 13:
                                    label11.BackColor = Color.LightBlue;
                                    label8.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                                //Adolescence, Adult, Senior
                                case 14:
                                    label9.BackColor = Color.LightBlue;
                                    label8.BackColor = Color.LightBlue;
                                    label12.BackColor = Color.LightBlue;
                                    break;
                            }
                            break;
                        case 3:
                            switch (choice[k])
                            {
                                //All Sizes
                                case 0:
                                    label14.BackColor = Color.LightBlue;
                                    label16.BackColor = Color.LightBlue;
                                    label15.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Smalls
                                case 1:
                                    label14.BackColor = Color.LightBlue;
                                    break;
                                //Mediums
                                case 2:
                                    label16.BackColor = Color.LightBlue;
                                    break;
                                //Larges
                                case 3:
                                    label15.BackColor = Color.LightBlue;
                                    break;
                                //Extras
                                case 4:
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Smalls & Mediums
                                case 5:
                                    label15.BackColor = Color.LightBlue;
                                    label16.BackColor = Color.LightBlue;
                                    break;
                                //Smalls & Larges
                                case 6:
                                    label14.BackColor = Color.LightBlue;
                                    label15.BackColor = Color.LightBlue;
                                    break;
                                //Smalls & Extras
                                case 7:
                                    label14.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Mediums & Larges
                                case 8:
                                    label16.BackColor = Color.LightBlue;
                                    label15.BackColor = Color.LightBlue;
                                    break;
                                //Mediums & Extras
                                case 9:
                                    label16.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Larges & Extras
                                case 10:
                                    label15.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Smalls, Mediums, Larges
                                case 11:
                                    label14.BackColor = Color.LightBlue;
                                    label16.BackColor = Color.LightBlue;
                                    label15.BackColor = Color.LightBlue;
                                    break;
                                //Smalls, Mediums, Extras
                                case 12:
                                    label14.BackColor = Color.LightBlue;
                                    label16.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Smalls, Larges, Extras
                                case 13:
                                    label14.BackColor = Color.LightBlue;
                                    label15.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                                //Mediums, Larges, Extras
                                case 14:
                                    label16.BackColor = Color.LightBlue;
                                    label15.BackColor = Color.LightBlue;
                                    label13.BackColor = Color.LightBlue;
                                    break;
                            }
                            break;
                        case 4:
                            switch (choice[k])
                            {
                                //Doesn't matter
                                case 0:
                                    label21.BackColor = Color.White;
                                    label19.BackColor = Color.White;
                                    label18.BackColor = Color.White;
                                    break;
                                //Just Kids
                                case 1:
                                    label21.BackColor = Color.LightBlue;
                                    break;
                                //Just Dogs
                                case 2:
                                    label19.BackColor = Color.LightBlue;
                                    break;
                                //Just Cats
                                case 3:
                                    label18.BackColor = Color.LightBlue;
                                    break;
                                //Kids & Dogs
                                case 4:
                                    label21.BackColor = Color.LightBlue;
                                    label19.BackColor = Color.LightBlue;
                                    break;
                                //Kids & Cats
                                case 5:
                                    label21.BackColor = Color.LightBlue;
                                    label18.BackColor = Color.LightBlue;
                                    break;
                                //Dogs & Cats
                                case 6:
                                    label19.BackColor = Color.LightBlue;
                                    label18.BackColor = Color.LightBlue;
                                    break;
                                //Any Family Member
                                case 7:
                                    label21.BackColor = Color.LightBlue;
                                    label19.BackColor = Color.LightBlue;
                                    label18.BackColor = Color.LightBlue;
                                    break;
                            }
                            break;
                        case 5:
                            switch (choice[k])
                            {
                                //House-trained or need more training
                                case 0:
                                    label23.BackColor = Color.LightBlue;
                                    label22.BackColor = Color.LightBlue;
                                    break;
                                //House-trained only
                                case 1:
                                    label23.BackColor = Color.LightBlue;
                                    break;
                                //Need more training
                                case 2:
                                    label22.BackColor = Color.LightBlue;
                                    break;
                            }
                            break;
                        case 6:
                            trackBar1.Value = choice[k];
                            label26.Text = choice[k].ToString();
                            break;
                    }

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.White)
            {
                label3.BackColor = Color.LightBlue;
            }
            else
            {
                label3.BackColor = Color.White;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.BackColor == Color.White)
            {
                label4.BackColor = Color.LightBlue;
            }
            else
            {
                label4.BackColor = Color.White;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.BackColor == Color.White)
            {
                label6.BackColor = Color.LightBlue;
            }
            else
            {
                label6.BackColor = Color.White;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.BackColor == Color.White)
            {
                label5.BackColor = Color.LightBlue;
            }
            else
            {
                label5.BackColor = Color.White;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (label11.BackColor == Color.White)
            {
                label11.BackColor = Color.LightBlue;
            }
            else
            {
                label11.BackColor = Color.White;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.BackColor == Color.White)
            {
                label9.BackColor = Color.LightBlue;
            }
            else
            {
                label9.BackColor = Color.White;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.BackColor == Color.White)
            {
                label8.BackColor = Color.LightBlue;
            }
            else
            {
                label8.BackColor = Color.White;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (label12.BackColor == Color.White)
            {
                label12.BackColor = Color.LightBlue;
            }
            else
            {
                label12.BackColor = Color.White;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (label14.BackColor == Color.White)
            {
                label14.BackColor = Color.LightBlue;
            }
            else
            {
                label14.BackColor = Color.White;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (label16.BackColor == Color.White)
            {
                label16.BackColor = Color.LightBlue;
            }
            else
            {
                label16.BackColor = Color.White;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (label15.BackColor == Color.White)
            {
                label15.BackColor = Color.LightBlue;
            }
            else
            {
                label15.BackColor = Color.White;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (label13.BackColor == Color.White)
            {
                label13.BackColor = Color.LightBlue;
            }
            else
            {
                label13.BackColor = Color.White;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (label21.BackColor == Color.White)
            {
                label21.BackColor = Color.LightBlue;
            }
            else
            {
                label21.BackColor = Color.White;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (label19.BackColor == Color.White)
            {
                label19.BackColor = Color.LightBlue;
            }
            else
            {
                label19.BackColor = Color.White;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (label18.BackColor == Color.White)
            {
                label18.BackColor = Color.LightBlue;
            }
            else
            {
                label18.BackColor = Color.White;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (label23.BackColor == Color.White)
            {
                label23.BackColor = Color.LightBlue;
            }
            else
            {
                label23.BackColor = Color.White;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (label22.BackColor == Color.White)
            {
                label22.BackColor = Color.LightBlue;
            }
            else
            {
                label22.BackColor = Color.White;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label26.Text = trackBar1.Value.ToString();
        }

        //Save
        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var sw = new StreamWriter(@".\" + user + " Preferences.txt", false, Encoding.ASCII))
            {
                sw.WriteLine(PetTypeCheck());
                sw.WriteLine(GenderCheck());
                sw.WriteLine(AgeCheck());
                sw.WriteLine(SizeCheck());
                sw.WriteLine(SocialCheck());
                sw.WriteLine(TrainingCheck());
                sw.WriteLine(trackBar1.Value);
                sw.Close();
            }
            string[] change = File.ReadAllLines(@".\" + user + " Profile.txt");
            //no longer firstime user;
            change[6] = 0.ToString();
            using (var cw = new StreamWriter(@".\" + user + " Profile.txt", false, Encoding.ASCII))
            {
                for (int j = 0; j < change.Length; j++)
                {
                    cw.WriteLine(change[j]);
                }
                cw.Close();
            }
            this.Close();
        }

        private int PetTypeCheck()
        {
            if (label3.BackColor == Color.LightBlue && label4.BackColor == Color.White)
            {
                return 1;
            }
            else if (label3.BackColor == Color.White && label4.BackColor == Color.LightBlue)
            {
                return 2;
            }
            else
                return 0;
        }
        private int GenderCheck()
        {
            if (label6.BackColor == Color.LightBlue && label5.BackColor == Color.White)
            {
                return 1;
            }
            else if (label6.BackColor == Color.White && label5.BackColor == Color.LightBlue)
            {
                return 2;
            }
            else
                return 0;
        }
        private int AgeCheck()
        {
            if (label11.BackColor == Color.LightBlue && label9.BackColor == Color.LightBlue)
            {
                if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.White)
                {
                    return 11;
                }
                else if (label8.BackColor == Color.White && label12.BackColor == Color.LightBlue)
                {
                    return 12;
                }
                else if (label8.BackColor == Color.White && label12.BackColor == Color.White)
                {
                    return 5;
                }
                return 0;
            }
            else if (label11.BackColor == Color.White && label9.BackColor == Color.White)
            {
                if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.White)
                {
                    return 3;
                }
                else if (label8.BackColor == Color.White && label12.BackColor == Color.LightBlue)
                {
                    return 4;
                }
                else if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.LightBlue)
                {
                    return 10;
                }
                return 0;
            }
            else if (label11.BackColor == Color.LightBlue && label9.BackColor == Color.White)
            {
                if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.White)
                {
                    return 6;
                }
                else if (label8.BackColor == Color.White && label12.BackColor == Color.LightBlue)
                {
                    return 7;
                }
                else if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.LightBlue)
                {
                    return 13;
                }
                return 1;
            }
            else if (label11.BackColor == Color.White && label9.BackColor == Color.LightBlue)
            {
                if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.White)
                {
                    return 8;
                }
                else if (label8.BackColor == Color.White && label12.BackColor == Color.LightBlue)
                {
                    return 9;
                }
                else if (label8.BackColor == Color.LightBlue && label12.BackColor == Color.LightBlue)
                {
                    return 14;
                }
                return 2;
            }
            else
                return 0;
        }
        private int SizeCheck()
        {
            if (label14.BackColor == Color.LightBlue && label16.BackColor == Color.LightBlue)
            {
                if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.White)
                {
                    return 11;
                }
                else if (label15.BackColor == Color.White && label13.BackColor == Color.LightBlue)
                {
                    return 12;
                }
                else if (label15.BackColor == Color.White && label13.BackColor == Color.White)
                {
                    return 5;
                }
                return 0;
            }
            else if (label14.BackColor == Color.White && label16.BackColor == Color.White)
            {
                if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.White)
                {
                    return 3;
                }
                else if (label15.BackColor == Color.White && label13.BackColor == Color.LightBlue)
                {
                    return 4;
                }
                else if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.LightBlue)
                {
                    return 10;
                }
                return 0;
            }
            else if (label14.BackColor == Color.LightBlue && label16.BackColor == Color.White)
            {
                if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.White)
                {
                    return 6;
                }
                else if (label15.BackColor == Color.White && label13.BackColor == Color.LightBlue)
                {
                    return 7;
                }
                else if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.LightBlue)
                {
                    return 13;
                }
                return 1;
            }
            else if (label14.BackColor == Color.White && label16.BackColor == Color.LightBlue)
            {
                if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.White)
                {
                    return 8;
                }
                else if (label15.BackColor == Color.White && label13.BackColor == Color.LightBlue)
                {
                    return 9;
                }
                else if (label15.BackColor == Color.LightBlue && label13.BackColor == Color.LightBlue)
                {
                    return 14;
                }
                return 2;
            }
            else
                return 0;
        }
        private int SocialCheck ()
        {
            if (label21.BackColor == Color.LightBlue && label19.BackColor == Color.White)
            {
                if (label18.BackColor == Color.LightBlue)
                {
                    return 5;
                }
                return 1;
            }
            else if (label21.BackColor == Color.LightBlue && label19.BackColor == Color.LightBlue)
            {
                if (label18.BackColor == Color.LightBlue)
                {
                    return 7;
                }
                return 4;
            }
            else if (label21.BackColor == Color.White && label19.BackColor == Color.LightBlue)
            {
                if (label18.BackColor == Color.LightBlue)
                {
                    return 6;
                }
                return 2;
            }
            else if (label18.BackColor == Color.LightBlue)
            {
                return 3;
            }
            return 0;
        }
        private int TrainingCheck()
        {
            if (label23.BackColor == Color.LightBlue && label22.BackColor == Color.White)
            {
                return 1;
            }
            else if (label23.BackColor == Color.White && label22.BackColor == Color.LightBlue)
            {
                return 2;
            }
            else
                return 0;
        }
    }
}
