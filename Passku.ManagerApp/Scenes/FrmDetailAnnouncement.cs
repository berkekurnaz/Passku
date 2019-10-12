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
    public partial class FrmDetailAnnouncement : Form
    {

        string Id;
        string title;
        string date;
        string description;

        public FrmDetailAnnouncement(string Id, string title, string date, string description)
        {
            InitializeComponent();
            this.Id = Id;
            this.title = title;
            this.date = date;
            this.description = description;
        }

        AnnouncementRepository announcementRepository;

        private void FrmDetailAnnouncement_Load(object sender, EventArgs e)
        {
            announcementRepository = new AnnouncementRepository("Announcements");

            txtTitle.Text = title;
            txtDate.Text = date;
            txtDescription.Text = description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 3 && txtDate.Text.Length > 3 && txtDescription.Text.Length > 3)
            {

                var dialogResult = MessageBox.Show("Do you want to update this announcement ?", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Announcement announcement = new Announcement();
                    announcement.Id = new ObjectId(Id);
                    announcement.Title = txtTitle.Text;
                    announcement.Date = txtDate.Text;
                    announcement.Description = txtDescription.Text;

                    try
                    {
                        announcementRepository.Update(Id, announcement);
                        MessageBox.Show("Announcement Successfully Updated");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you want to delete this announcement ?", "Information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    announcementRepository.Delete(Id);
                    MessageBox.Show("Announcement Successfully Deleted");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex);
                }
            }
        }
    }
}
