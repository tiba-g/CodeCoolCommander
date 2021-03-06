﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
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
        public static DirectoryInfo[] dirsLeft;
        public static FileInfo[] filesLeft;
        public static DirectoryInfo[] dirsRight;
        public static FileInfo[] filesRight;
        private bool start = true;
        bool firstMsgBox = true;
        private int listViewSelectedItemLeft;
        private int listViewSelectedItemRight;
        private string pathLeft;
        private string pathRight;
        private static bool leftSelected;

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
            fillListView(comboBoxDrivesLeft.Text, listViewFilesLeft, true);
            fillListView(comboBoxDrivesRight.Text, listViewFilesRight, false);
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

        private void fillListView(string filePath, ListView listView, bool isLeft)
        {
            listView.Items.Clear();
            if (isLeft)
            {
                dirsLeft = FileHandler.GetAllDirectories(filePath);
                filesLeft = FileHandler.GetAllFiles(filePath);
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;
                if (dirsLeft != null)
                {
                    foreach (var dir in dirsLeft)
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
                if (dirsLeft != null)
                {
                    foreach (var file in filesLeft)
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
            else
            {
                dirsRight = FileHandler.GetAllDirectories(filePath);
                filesRight = FileHandler.GetAllFiles(filePath);
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;
                if (dirsRight != null)
                {
                    foreach (var dir in dirsRight)
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
                if (dirsRight != null)
                {
                    foreach (var file in filesRight)
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

        private void listViewFilesLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftSelected = true;
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
                pathLeft = FileHandler.GetSelectedItemPath(listViewSelectedItemLeft, false);
                // for debug MessageBox.Show(listViewSelectedItemLeft.ToString());
                filePathLeft.Text = pathLeft;
            }
            start = false;

        }

        private void listViewFilesRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftSelected = false;
            if (!start)
            {
                selectedListView = listViewFilesRight;
                try
                {
                    listViewSelectedItemRight = listViewFilesRight.SelectedIndices[0];
                }
                catch (Exception)
                {
                }
                pathRight = FileHandler.GetSelectedItemPath(listViewSelectedItemRight, true);
                // for debug MessageBox.Show(listViewSelectedItemLeft.ToString());
                filePathRight.Text = pathRight;
            }
            start = false;
        }

        private void comboBoxDrivesLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListView(comboBoxDrivesLeft.Text, listViewFilesLeft, true);
        }

        private void comboBoxDrivesRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListView(comboBoxDrivesRight.Text, listViewFilesRight, false);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (leftSelected)
            {
                string fileName = Path.GetFileName(filePathLeft.Text);
                if (FileHandler.CopyFile(filePathLeft.Text, filePathRight.Text + "\\" + fileName, true))
                {
                    MessageBox.Show("Copy was successfull");
                }
            }
            else
            {
                string fileName = Path.GetFileName(filePathRight.Text);
                if (FileHandler.CopyFile(filePathRight.Text, filePathLeft.Text + "\\" + fileName, true))
                {
                    MessageBox.Show("Copy was successfull");
                }
            }
        }

        private void listViewFilesRight_DoubleClick(object sender, EventArgs e)
        {
        }

        private void listViewFilesLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewSelectedItemLeft + 1 > dirsLeft.Length)
            {
                if (Path.GetExtension(filePathLeft.Text) == ".txt")
                {
                    Form txtForm = new TXTReader(filePathLeft.Text);
                    txtForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a directory!");
                }
            }
            else
            {
                filesLeft = FileHandler.GetAllFiles(pathLeft);
                dirsLeft = FileHandler.GetAllDirectories(pathLeft);
                listViewFilesLeft.Items.Clear();
                if (dirsLeft != null)
                {
                    foreach (DirectoryInfo dir in dirsLeft)
                    {
                        listViewFilesLeft.Items.Add(dir.ToString());
                    }
                }
                if (filesLeft != null)
                {
                    foreach (FileInfo file in filesLeft)
                    {
                        listViewFilesLeft.Items.Add(file.ToString());
                    }
                }
            }
        }

        private void listViewFilesRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewSelectedItemRight + 1 > dirsRight.Length)
            {
                if (Path.GetExtension(filePathRight.Text) == ".txt")
                {
                    Form txtForm = new TXTReader(filePathRight.Text);
                    txtForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a directory!");
                }
            }
            else
            {
                filesRight = FileHandler.GetAllFiles(pathRight);
                dirsRight = FileHandler.GetAllDirectories(pathRight);
                listViewFilesRight.Items.Clear();
                if (dirsRight != null)
                {
                    foreach (DirectoryInfo dir in dirsRight)
                    {
                        listViewFilesRight.Items.Add(dir.ToString());
                    }
                }
                if (filesRight != null)
                {
                    foreach (FileInfo file in filesRight)
                    {
                        listViewFilesRight.Items.Add(file.ToString());
                    }
                }
            }
        }

        private void buttonOpenText_Click(object sender, EventArgs e)
        {
            string path;
            if (leftSelected)
            {
                path = filePathLeft.Text;
            }
            else
            {
                path = filePathRight.Text;
            }
            if (Path.GetExtension(path) == ".txt")
            {
                Form txtForm = new TXTReader(path);
                txtForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a txt file");
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (leftSelected)
            {
                string fileName = Path.GetFileName(filePathLeft.Text);
                if (FileHandler.MoveFile(filePathLeft.Text, filePathRight.Text + "\\" + fileName))
                {
                    MessageBox.Show("Move was successfull");
                }
            }
            else
            {
                string fileName = Path.GetFileName(filePathRight.Text);
                if (FileHandler.MoveFile(filePathRight.Text, filePathLeft.Text + "\\" + fileName))
                {
                    MessageBox.Show("Move was successfull");
                }
            }
        }
    }
}
