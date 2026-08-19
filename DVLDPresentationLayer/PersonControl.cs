using DVLDPresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = Resources.person_boy;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = Resources.person_girl;
        }
    }
}
