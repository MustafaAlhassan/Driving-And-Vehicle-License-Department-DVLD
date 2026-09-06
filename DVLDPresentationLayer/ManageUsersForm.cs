using DVLDBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        DataTable dataTable;

        private void _RefreshUsersList()
        {
            dataTable = clsUsers.GetAllUsers();

            if (dataTable == null)
            {
                MessageBox.Show("Failed to connect with Database",
                                "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvPeople.DataSource = dataTable;

            if (dgvPeople.Columns.Contains("ImagePath"))
                dgvPeople.Columns["ImagePath"].Visible = false;

            if (dgvPeople.Columns.Contains("Address"))
                dgvPeople.Columns["Address"].Visible = false;

            UpdateRecordNumber(dataTable);
        }

        public void FillComboBox()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("None");

            if (dataTable != null)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.ColumnName == "DateOfBirth")
                        continue;
                    if (column.ColumnName == "ImagePath")
                        continue;
                    if (column.ColumnName == "Address")
                        continue;
                    cmbFilter.Items.Add(column.ColumnName);
                }
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

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            _RefreshUsersList();
            FillComboBox();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilter.Text;

            if (selected == "None")
            {
                txtFilter.Visible = false;
                txtFilter.Clear();

                if (dataTable != null)
                {
                    dataTable.DefaultView.RowFilter = "";
                    UpdateRecordNumber(dataTable);
                }
            }
            else if (selected == "IsActive") 
            {
                txtFilter.Visible = false;
                txtFilter.Clear();

                cmbIsActive.Visible = true;
            }
            else
            {
                txtFilter.Visible = true;
                txtFilter.Clear();
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            if (string.IsNullOrWhiteSpace(txtFilter.Text) || cmbFilter.Text == "None")
            {
                dataTable.DefaultView.RowFilter = "";
                UpdateRecordNumber(dataTable.DefaultView.ToTable());
                return;
            }

            string columnName = cmbFilter.Text;
            string filterValue = txtFilter.Text.Trim();

            Type dataType = dataTable.Columns[columnName].DataType;

            if (dataType == typeof(int) || dataType == typeof(short) || dataType == typeof(long))
            {
                if (int.TryParse(filterValue, out int number))
                {
                    dataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, number);
                }
                else
                {
                    dataTable.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", columnName, filterValue.Replace("'", "''"));
            }
            UpdateRecordNumber(dataTable.DefaultView.ToTable());
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            string selectedValue = cmbIsActive.Text;

            if (selectedValue == "All")
            {
                dataTable.DefaultView.RowFilter = "";
            }
            else if (selectedValue == "Yes")
            {
                dataTable.DefaultView.RowFilter = "[IsActive] = true";
            }
            else if (selectedValue == "No")
            {
                dataTable.DefaultView.RowFilter = "[IsActive] = false";
            }

            UpdateRecordNumber(dataTable.DefaultView.ToTable());
        }
    }
}
