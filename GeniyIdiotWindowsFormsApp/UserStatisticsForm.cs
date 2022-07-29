using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class UserStatisticsForm : Form
    {
        public UserStatisticsForm()
        {
            InitializeComponent();
        }

        

        private void UserStatisticsForm_Load(object sender, EventArgs e)
        {
            var results = UsersResultStorage.GetAll();
            foreach (var result in results)
            {
                UserStatsDataGridView.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnosis);
            }
        }
    }
}
