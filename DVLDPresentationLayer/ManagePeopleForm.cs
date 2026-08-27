using DVLDBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLDPresentationLayer
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
        }

        DataTable dataTable;

        private void _RefreshPeopleList()
        {
            dataTable = clsPeople.GetAllPeople();

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

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            _RefreshPeopleList();
            FillComboBox();
        }

        private void _openPersonFormWithAndRefresh(int PersonID = -1)
        {
            PersonForm form = new PersonForm(PersonID);
            form.ShowDialog();
            _RefreshPeopleList();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _openPersonFormWithAndRefresh();
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

        private void SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be implemente later.", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PhoneNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be implemente later.", "Call", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            _openPersonFormWithAndRefresh();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow != null && dgvPeople.CurrentRow.Index >= 0)
            {
                if (int.TryParse(dgvPeople.CurrentRow.Cells["PersonID"].Value?.ToString(), out int selectedPersonID))
                {
                    _openPersonFormWithAndRefresh(selectedPersonID);
                }
                else
                {
                    MessageBox.Show("Person Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow != null && dgvPeople.CurrentRow.Index >= 0)
            {
                if (int.TryParse(dgvPeople.CurrentRow.Cells["PersonID"].Value?.ToString(), out int selectedPersonID))
                {
                    if (MessageBox.Show("Are you sure you want to delete Person [" + selectedPersonID + "]", "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (clsPeople.DeletePerson(selectedPersonID))
                        {
                            MessageBox.Show("Person Delete Successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshPeopleList();
                        } 
                        else
                        {
                            MessageBox.Show("Person was not Delete because it has data linked to it!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Person Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
