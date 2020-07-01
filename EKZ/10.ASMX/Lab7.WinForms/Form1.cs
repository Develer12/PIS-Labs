using Lab7.WinForms.CatalogService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab7.WinForms
{
    public partial class Form1 : Form
    {
        WebServiceSoapClient _client;
        private IEnumerable<Record> _dataSet;
        private Record _selectedPhonebook;
        public Form1()
        {
            InitializeComponent();
            _client = new WebServiceSoapClient();
        }

        private void FormLoaded(object sender, EventArgs e)
        {
            ReloadDataSource();
        }

        private void SetEditFormEnable(bool enabled)
        {
            btnUpdate.Enabled = enabled;
            btnDelete.Enabled = enabled;
        }

        private void ReloadDataSource()
        {
            _dataSet = _client.GetDict().OrderBy(i => i.Id).ToList();
            gridView.DataSource = _dataSet;
            _selectedPhonebook = null;

            txtNameEdit.Text = string.Empty;
            txtPhoneEdit.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtName.Text = string.Empty;

            SetEditFormEnable(false);
        }

        private void gridView_OnRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            if (gridView.SelectedRows.Count == 0) return;

            _selectedPhonebook = (Record)gridView.SelectedRows[0].DataBoundItem;

            txtNameEdit.Text = _selectedPhonebook.FullName;
            txtPhoneEdit.Text = _selectedPhonebook.PhoneNumber;
            SetEditFormEnable(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _selectedPhonebook.FullName = txtNameEdit.Text;
            _selectedPhonebook.PhoneNumber = txtPhoneEdit.Text;

            _client.Update(_selectedPhonebook);

            ReloadDataSource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var phonebook = new Record
            {
                FullName = txtName.Text,
                PhoneNumber = txtPhone.Text
            };

            _client.AddDict(phonebook);

            ReloadDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPhonebook != null)
            {
                _client.Delete(_selectedPhonebook.Id);

                ReloadDataSource();
            }
        }
    }
}
