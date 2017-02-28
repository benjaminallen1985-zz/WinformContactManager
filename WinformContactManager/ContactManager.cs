using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformContactManager
{
    public partial class contactForm : Form
    {
        public contactForm()
        {
            InitializeComponent();
        }

        private void OnShowAboutBox(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Manager App version 0.00001\n          Written By Benjamin Allen", "About");
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._bndContactList.EndEdit();
            this._taContactsAdapterManager.UpdateAll(this._contactManagerDataSet);

        }

        private void contactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactManagerDBDataSet.Contacts' table. You can move, or remove it, as needed.
            this._taContacts.Fill(this._contactManagerDataSet.Contacts);

        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
