using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaggerApp
{
    public partial class RegistrationComplete : Form
    {
        public RegistrationComplete()
        {
            InitializeComponent();
        }

        //Continue
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
