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



    }
}
