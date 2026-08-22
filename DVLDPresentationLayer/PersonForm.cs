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
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void personControl1_Load(object sender, EventArgs e)
        {
            personControl1.OnCloseClick += PersonControl1_OnCloseClick;
        }

        private void PersonControl1_OnCloseClick()
        {
            this.Close();
        }
    }
}
