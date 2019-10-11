using MongoDB.Bson;
using Passku.ManagerApp.DataAccess;
using Passku.ManagerApp.Models;
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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        UserRepository userRepository;

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository("Users");

            FillDataGridView();
        }

        void FillDataGridView()
        {
            dgvUsers.DataSource = userRepository.GetAll();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 3 && txtPassword.Text.Length > 3)
            {

                var dialogResult = MessageBox.Show("Do you want to add this user ?", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ObjectId userId = new ObjectId(txtId.Text);

                    User user = new User();
                    user.Id = userId;
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    user.NameSurname = txtName.Text;
                    user.MailAdress = txtMail.Text;
                    user.CreatedDate = txtDate.Text;

                    try
                    {
                        userRepository.Add(user);
                        MessageBox.Show("User Successfully Added");
                        FillDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 3 && txtPassword.Text.Length > 3 && txtId.Text.Length > 3)
            {

                var dialogResult = MessageBox.Show("Do you want to update this user ?", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    User user = new User();
                    user.Id = new ObjectId(txtId.Text);
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    user.NameSurname = txtName.Text;
                    user.MailAdress = txtMail.Text;
                    user.CreatedDate = txtDate.Text;

                    try
                    {
                        userRepository.Update(txtId.Text, user);
                        MessageBox.Show("User Successfully Updated");
                        FillDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = dgvUsers.SelectedCells[0].RowIndex;

            try
            {
                txtUsername.Text = dgvUsers.Rows[number].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[number].Cells["Password"].Value.ToString();
                txtName.Text = dgvUsers.Rows[number].Cells["NameSurname"].Value.ToString();
                txtMail.Text = dgvUsers.Rows[number].Cells["MailAdress"].Value.ToString();
                txtDate.Text = dgvUsers.Rows[number].Cells["CreatedDate"].Value.ToString();
                txtId.Text = dgvUsers.Rows[number].Cells["Id"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
    }
}
