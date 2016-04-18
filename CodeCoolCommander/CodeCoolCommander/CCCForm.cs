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
        private ListView selectedListView;
        DriveInfo[] drives;
        public static DirectoryInfo[] dirs;
        public static FileInfo[] files;
        private bool start = true;
        bool firstMsgBox = true;
        private int listViewSelectedItemLeft;
        private int listViewSelectedItemRight;
        private string pathLeft;

        public CCCForm()
        {
            InitializeComponent();
            listViewFilesLeft.MultiSelect = false;
            listViewFilesRight.MultiSelect = false;
            
        }

        private void CCCForm_Load(object sender, EventArgs e)
        {
            drives = FileHandler.GetAllDrives();
            fillComboboxs();
            fillListView(comboBoxDrivesLeft.Text, listViewFilesLeft);
            fillListView(comboBoxDrivesRight.Text, listViewFilesRight);
            listViewFilesLeft.Items[0].Selected = true;
        }

        private void fillComboboxs()
        {
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
            listView.Items.Clear();
            dirs = FileHandler.GetAllDirectories(filePath);
            files = FileHandler.GetAllFiles(filePath);
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
            string fileSize = "";
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

        private void listViewFilesLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!start)
            {
                selectedListView = listViewFilesLeft;
                try
                {
                    listViewSelectedItemLeft = listViewFilesLeft.SelectedIndices[0];

                }
                catch (Exception)
                {
                }

                
                pathLeft = FileHandler.getSelectedItemPath(listViewSelectedItemLeft);
                // for debug MessageBox.Show(listViewSelectedItemLeft.ToString());
                filePathLeft.Text = pathLeft;
                firstMsgBox = !firstMsgBox;
                
            }
            start = false;

        }

        private void listViewFilesRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedListView = listViewFilesRight;
        }

        private void comboBoxDrivesLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListView(comboBoxDrivesLeft.Text, listViewFilesLeft);
        }

        private void comboBoxDrivesRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListView(comboBoxDrivesRight.Text, listViewFilesRight);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {

        }

        private void listViewFilesRight_DoubleClick(object sender, EventArgs e)
        {
        }

        private void listViewFilesLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewSelectedItemLeft + 1 > dirs.Length)
            {
                MessageBox.Show("Please select a directory!");
            }
            else
            {
                files = FileHandler.GetAllFiles(pathLeft);
                dirs = FileHandler.GetAllDirectories(pathLeft);
                listViewFilesLeft.Items.Clear();
                if (dirs != null)
                {
                    foreach (DirectoryInfo dir in dirs)
                    {
                        listViewFilesLeft.Items.Add(dir.ToString());
                    }
                }
                if (files != null)
                {
                    foreach (FileInfo file in files)
                    {
                        listViewFilesLeft.Items.Add(file.ToString());
                    }
                }
            }
        }
    }
}
