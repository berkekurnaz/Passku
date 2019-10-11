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
    public partial class FrmCreateAnnouncement : Form
    {
        public FrmCreateAnnouncement()
        {
            InitializeComponent();
        }

        AnnouncementRepository announcementRepository;

        private void FrmCreateAnnouncement_Load(object sender, EventArgs e)
        {
            announcementRepository = new AnnouncementRepository("Announcements");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 3 && txtDescription.Text.Length > 3)
            {
                
                var dialogResult = MessageBox.Show("Do you want to add this announcement", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Announcement announcement = new Announcement();
                    announcement.Title = txtTitle.Text;
                    announcement.Date = dtpDate.Value.ToShortDateString();
                    announcement.Description = txtDescription.Text;
                    try
                    {
                        announcementRepository.Add(announcement);
                        MessageBox.Show("Announcement Successfully Added");
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
    }
}
