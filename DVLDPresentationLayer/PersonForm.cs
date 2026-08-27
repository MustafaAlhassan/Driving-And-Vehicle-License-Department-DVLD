using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class PersonForm : Form
    {
        private int _PersonID;

        public PersonForm(int PersonID = -1)
        {
            InitializeComponent();
            
            _PersonID = PersonID;

            personControl1.OnCloseClick += PersonControl1_OnCloseClick;

            personControl1.LoadData(_PersonID);
        }

        private void PersonControl1_OnCloseClick()
        {
            this.Close();
        }
    }
}
