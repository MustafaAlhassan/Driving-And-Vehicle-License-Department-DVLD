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

        public void FillDataGridViewFromDatatable(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgvPeople.Columns["ImagePath"].Visible = false;
            dgvPeople.Columns["Address"].Visible = false;
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
            FillDataGridViewFromDatatable(dgvPeople, dataTable);
            FillComboBox(cmbFilter, dataTable);
            UpdateRecordNumber(dataTable);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
