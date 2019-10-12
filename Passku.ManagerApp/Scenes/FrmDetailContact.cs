using Passku.ManagerApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passku.ManagerApp.Scenes
{
    public partial class FrmDetailContact : Form
    {

        string firstName;
        string lastName;
        string email;
        string subject;
        string message;
        string date;
        string id;

        public FrmDetailContact(string firstName, string lastName, string email, string subject, string message, string date, string id)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.subject = subject;
            this.message = message;
            this.date = date;
            this.id = id;
        }

        ContactRepository contactRepository;

        private void FrmDetailContact_Load(object sender, EventArgs e)
        {
            contactRepository = new ContactRepository("Contacts");

            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtMail.Text = email;
            txtSubject.Text = subject;
            txtMessage.Text = message;
            txtDate.Text = date;
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you want to delete this message ?", "Information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    contactRepository.Delete(id);
                    MessageBox.Show("Message Successfully Deleted");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
