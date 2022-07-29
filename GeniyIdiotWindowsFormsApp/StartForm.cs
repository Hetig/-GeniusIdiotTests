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
    public partial class StartForm : Form
    {
        public static string UserName;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartOkButton_Click(object sender, EventArgs e)
        {
            UserName = userNameTextBox.Text;
            var mainForm = new MainForm(); 
            this.Hide();
            mainForm.ShowDialog(); 
            this.Close();
        }        
    }
}
