using MongoDB.Driver;
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
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        AnnouncementRepository announcementRepository;
        ContactRepository contactRepository;
        ReportRepository reportRepository;
        UserRepository userRepository;


        private void FrmMain_Load(object sender, EventArgs e)
        {
            announcementRepository = new AnnouncementRepository("Announcements");
            contactRepository = new ContactRepository("Contacts");
            reportRepository = new ReportRepository("Reports");
            userRepository = new UserRepository("Users");

            FillDataToDataGridView();
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            FillDataToDataGridView();
        }

        void FillDataToDataGridView()
        {
            dgwAnnouncements.DataSource = announcementRepository.GetAll();
            dgwMessages.DataSource = contactRepository.GetAll();
            dgwReports.DataSource = reportRepository.GetAll();

            lblCountAnnouncements.Text = "Announcements Count : " + announcementRepository.GetAll().Count.ToString();
            lblCountMessages.Text = "Messages Count : " + contactRepository.GetAll().Count.ToString();
            lblCountReports.Text = "Reports Count : " + reportRepository.GetAll().Count.ToString();
            lblCountMembers.Text = "Members Count : " + userRepository.GetAll().Count.ToString();

        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            FrmCreateAnnouncement frmCreateAnnouncement = new FrmCreateAnnouncement();
            frmCreateAnnouncement.Show();
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.Show();
        }

        private void dgwAnnouncements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number = dgwAnnouncements.SelectedCells[0].RowIndex;

                string title = dgwAnnouncements.Rows[number].Cells["Title"].Value.ToString();
                string date = dgwAnnouncements.Rows[number].Cells["Date"].Value.ToString();
                string descrription = dgwAnnouncements.Rows[number].Cells["Description"].Value.ToString();
                string id = dgwAnnouncements.Rows[number].Cells["Id"].Value.ToString();
                FrmDetailAnnouncement frmDetailAnnouncement = new FrmDetailAnnouncement(id, title, date, descrription);
                frmDetailAnnouncement.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void dgwReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number = dgwReports.SelectedCells[0].RowIndex;

                string title = dgwReports.Rows[number].Cells["Title"].Value.ToString();
                string content = dgwReports.Rows[number].Cells["Content"].Value.ToString();
                string date = dgwReports.Rows[number].Cells["Date"].Value.ToString();
                string userId = dgwReports.Rows[number].Cells["UserId"].Value.ToString();
                string id = dgwReports.Rows[number].Cells["Id"].Value.ToString();
                FrmDetailReport frmDetailReport = new FrmDetailReport(title, content, date, userId, id);
                frmDetailReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

        private void dgwMessages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int number = dgwMessages.SelectedCells[0].RowIndex;

                string firstName = dgwMessages.Rows[number].Cells["FirstName"].Value.ToString();
                string lastName = dgwMessages.Rows[number].Cells["LastName"].Value.ToString();
                string email = dgwMessages.Rows[number].Cells["Email"].Value.ToString();
                string subject = dgwMessages.Rows[number].Cells["Subject"].Value.ToString();
                string message = dgwMessages.Rows[number].Cells["Message"].Value.ToString();
                string date = dgwMessages.Rows[number].Cells["Date"].Value.ToString();
                string id = dgwMessages.Rows[number].Cells["Id"].Value.ToString();
                FrmDetailContact frmDetailContact = new FrmDetailContact(firstName, lastName, email, subject, message, date, id);
                frmDetailContact.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

    }
}
