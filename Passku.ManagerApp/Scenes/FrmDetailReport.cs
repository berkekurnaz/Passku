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
    public partial class FrmDetailReport : Form
    {

        string title;
        string content;
        string date;
        string userId;
        string id;

        public FrmDetailReport(string title, string content, string date, string userId, string id)
        {
            InitializeComponent();
            this.title = title;
            this.content = content;
            this.date = date;
            this.userId = userId;
            this.id = id;
        }

        ReportRepository reportRepository;

        private void FrmDetailReport_Load(object sender, EventArgs e)
        {
            reportRepository = new ReportRepository("Reports");
            txtTitle.Text = title;
            txtDescription.Text = content;
            txtDate.Text = date;
            txtUserId.Text = userId;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you want to delete this report ?", "Information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    reportRepository.Delete(id);
                    MessageBox.Show("Report Successfully Deleted");
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
