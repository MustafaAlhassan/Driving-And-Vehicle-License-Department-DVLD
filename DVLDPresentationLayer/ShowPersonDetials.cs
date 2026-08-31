using System.Windows.Forms;

namespace DVLDPresentationLayer
{

    public partial class ShowPersonDetials : Form
    {
        private int _PersonID;

        public ShowPersonDetials(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            personInformationCard1.OnCloseClick += PersonInformationCard1_OnCloseClick;

            personInformationCard1.LoadData(_PersonID);
        }
        private void PersonInformationCard1_OnCloseClick()
        {
            this.Close();
        }
    }
}
