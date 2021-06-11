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
    public partial class SavedPets : Form
    {
        string[] likedPets;
        string viewPet;

        public SavedPets(string user)
        {
            InitializeComponent();
            likedPets = File.ReadAllLines(@".\" + user + " Pets.txt");
            label1.Text = user + " Liked Pets";
        }

        private void SavedPets_Load(object sender, EventArgs e)
        {
            int x = 12;
            int y = -61;
            int bx = 168;

            for (int i = 0; i < likedPets.Length; i++)
            {
                PictureBox pb = new PictureBox();

                pb.BackgroundImage = Image.FromFile(@".\" + likedPets[i] + ".jpg");
                pb.BackgroundImageLayout = ImageLayout.Stretch;

                pb.Height = 150;
                pb.Width = 150;

                pb.Location = new Point(x, y + 156);


                this.Controls.Add(pb);

                Button dynamicButton = new Button();

                dynamicButton.Text = likedPets[i];
                dynamicButton.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                dynamicButton.TextAlign = ContentAlignment.MiddleLeft;

                dynamicButton.Height = 35;
                dynamicButton.Width = 200;

                dynamicButton.Location = new Point(bx, y + 156);
                y += 156;

                this.Controls.Add(dynamicButton);

                dynamicButton.Click += new EventHandler(DynamicButton_Click);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void DynamicButton_Click (object sender, EventArgs e)
        {
            
            this.Hide();
            PetProfile petProfile = new PetProfile((sender as Button).Text);
            petProfile.ShowDialog();
            this.Show();
            
        }
        
    }
}
