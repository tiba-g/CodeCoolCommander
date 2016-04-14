using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CodeCoolCommander.Controller;

namespace CodeCoolCommander.View
{
    public partial class CCCForm : Form
    {
        private const string accesDeniedDrives = "You have no permisson to acces the drives!";
        private const string accesDenied = "You have no permisson to this action!";
        const string caption = "Error";

        public CCCForm()
        {
            InitializeComponent();
            fillComboboxs();
        }


        private void CCCForm_Load(object sender, EventArgs e)
        {

        }

        private void fillComboboxs()
        {
            try
            {
                DriveInfo[] drives = FileHandler.GetAllDrives();
                foreach (var drive in drives)
                {
                    comboBoxDrivesRight.Items.Add(drive);
                    comboBoxDrivesLeft .Items.Add(drive);
                }
                comboBoxDrivesRight.Text = drives[0].Name;
                comboBoxDrivesLeft.Text = drives[0].Name;
            }
            catch (Exception)
            { 
                var result = MessageBox.Show(accesDeniedDrives, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Question);
            }
        }
    }
}
