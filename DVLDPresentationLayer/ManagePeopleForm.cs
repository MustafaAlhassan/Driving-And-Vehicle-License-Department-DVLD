using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLDPresentationLayer
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleList()
        {
            DataTable dataTable = clsPeople.GetAllPeople();
            dgvPeople.DataSource = dataTable;
            dgvPeople.Columns["ImagePath"].Visible = false;
            dgvPeople.Columns["Address"].Visible = false;
            UpdateRecordNumber(dataTable);
        }

        public void FillComboBox(ComboBox dgv, DataTable dt)
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("None");

            foreach (DataColumn column in dt.Columns)
            {
                cmbFilter.Items.Add(column.ColumnName);
            }

            if (cmbFilter.Items.Count > 0)
                cmbFilter.SelectedIndex = 0;
        }

        public void UpdateRecordNumber(DataTable dt)
        {
            lblRecordsNumber.Text = "# Records: " + dt.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = clsPeople.GetAllPeople();
            _RefreshPeopleList();
            FillComboBox(cmbFilter, dataTable);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PersonForm form = new PersonForm();
            form.ShowDialog();
            _RefreshPeopleList();
        }
    }
}
