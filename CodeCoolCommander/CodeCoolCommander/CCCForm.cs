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
        }

        private void CCCForm_Load(object sender, EventArgs e)
        {
            fillComboboxs();
            fillListView(comboBoxDrivesLeft.Text, listViewFilesLeft);
            fillListView(comboBoxDrivesRight.Text, listViewFilesRight);
        }

        private void fillComboboxs()
        {
            DriveInfo[] drives = FileHandler.GetAllDrives();
            if (drives != null)
            {
                foreach (var drive in drives)
                {
                    comboBoxDrivesRight.Items.Add(drive);
                    comboBoxDrivesLeft.Items.Add(drive);
                }
                comboBoxDrivesRight.Text = drives[0].Name;
                comboBoxDrivesLeft.Text = drives[0].Name;
            }
            else
            {
                var result = MessageBox.Show(accesDeniedDrives, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Question);
            }
        }

        private void fillListView(string filePath, ListView listView)
        {
            DirectoryInfo[] dirs = FileHandler.GetAllDirectories(filePath);
            FileInfo[] files = FileHandler.GetAllFiles(filePath);
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            if (dirs != null)
            {
                foreach (var dir in dirs)
                {

                    item = new ListViewItem(dir.Name);
                    subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, dir.Extension),
                                                                    new ListViewItem.ListViewSubItem(item, "<DIR>"),
                                                                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString() + " " + dir.LastAccessTime.ToShortTimeString())
                    };
                    item.SubItems.AddRange(subItems);
                    listView.Items.Add(item);
                }
            }

            //long fileSize = FileHandler.GetDirectorySize(filePath);
            string fileSize = "1";
            if (dirs != null)
            {
                foreach (var file in files)
                {
                    item = new ListViewItem(file.Name);
                    subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, file.Extension),
                                                                    new ListViewItem.ListViewSubItem(item, fileSize.ToString()),
                                                                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString() + " " + file.LastAccessTime.ToShortTimeString())
                    };
                    item.SubItems.AddRange(subItems);
                    listView.Items.Add(item);
                }
            }
        }
    }
}
