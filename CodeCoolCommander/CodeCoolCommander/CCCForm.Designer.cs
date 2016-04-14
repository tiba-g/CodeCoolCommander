using System;

namespace CodeCoolCommander.View
{
    partial class CCCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewFilesLeft = new System.Windows.Forms.ListView();
            this.listViewFilesRight = new System.Windows.Forms.ListView();
            this.comboBoxDrivesLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxDrivesRight = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonZip = new System.Windows.Forms.Button();
            this.buttonUnzip = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDencrypt = new System.Windows.Forms.Button();
            this.buttonAttribute = new System.Windows.Forms.Button();
            this.buttonOccupiedSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFilesLeft
            // 
            this.listViewFilesLeft.Location = new System.Drawing.Point(15, 44);
            this.listViewFilesLeft.Name = "listViewFilesLeft";
            this.listViewFilesLeft.Size = new System.Drawing.Size(453, 368);
            this.listViewFilesLeft.TabIndex = 0;
            this.listViewFilesLeft.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFilesRight
            // 
            this.listViewFilesRight.Location = new System.Drawing.Point(474, 44);
            this.listViewFilesRight.Name = "listViewFilesRight";
            this.listViewFilesRight.Size = new System.Drawing.Size(453, 368);
            this.listViewFilesRight.TabIndex = 1;
            this.listViewFilesRight.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxDrivesLeft
            // 
            this.comboBoxDrivesLeft.FormattingEnabled = true;
            this.comboBoxDrivesLeft.Location = new System.Drawing.Point(15, 17);
            this.comboBoxDrivesLeft.Name = "comboBoxDrivesLeft";
            this.comboBoxDrivesLeft.Size = new System.Drawing.Size(453, 21);
            this.comboBoxDrivesLeft.TabIndex = 2;
            // 
            // comboBoxDrivesRight
            // 
            this.comboBoxDrivesRight.FormattingEnabled = true;
            this.comboBoxDrivesRight.Location = new System.Drawing.Point(474, 17);
            this.comboBoxDrivesRight.Name = "comboBoxDrivesRight";
            this.comboBoxDrivesRight.Size = new System.Drawing.Size(453, 21);
            this.comboBoxDrivesRight.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(229, 418);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(581, 20);
            this.textBoxSearch.TabIndex = 4;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 421);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(196, 13);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "According by regular expression pattern:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(816, 415);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search F1";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 444);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(93, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy F2";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(114, 444);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(111, 23);
            this.buttonMove.TabIndex = 8;
            this.buttonMove.Text = "Move F3";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // buttonZip
            // 
            this.buttonZip.Location = new System.Drawing.Point(231, 444);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(111, 23);
            this.buttonZip.TabIndex = 9;
            this.buttonZip.Text = "Zip F3";
            this.buttonZip.UseVisualStyleBackColor = true;
            // 
            // buttonUnzip
            // 
            this.buttonUnzip.Location = new System.Drawing.Point(348, 444);
            this.buttonUnzip.Name = "buttonUnzip";
            this.buttonUnzip.Size = new System.Drawing.Size(111, 23);
            this.buttonUnzip.TabIndex = 10;
            this.buttonUnzip.Text = "Un Zip F4";
            this.buttonUnzip.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(465, 444);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(111, 23);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Encrypt F5";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDencrypt
            // 
            this.buttonDencrypt.Location = new System.Drawing.Point(582, 444);
            this.buttonDencrypt.Name = "buttonDencrypt";
            this.buttonDencrypt.Size = new System.Drawing.Size(111, 23);
            this.buttonDencrypt.TabIndex = 12;
            this.buttonDencrypt.Text = "Dencrypt F6";
            this.buttonDencrypt.UseVisualStyleBackColor = true;
            // 
            // buttonAttribute
            // 
            this.buttonAttribute.Location = new System.Drawing.Point(699, 444);
            this.buttonAttribute.Name = "buttonAttribute";
            this.buttonAttribute.Size = new System.Drawing.Size(111, 23);
            this.buttonAttribute.TabIndex = 13;
            this.buttonAttribute.Text = "File Attributes F7";
            this.buttonAttribute.UseVisualStyleBackColor = true;
            // 
            // buttonOccupiedSpace
            // 
            this.buttonOccupiedSpace.Location = new System.Drawing.Point(816, 444);
            this.buttonOccupiedSpace.Name = "buttonOccupiedSpace";
            this.buttonOccupiedSpace.Size = new System.Drawing.Size(111, 23);
            this.buttonOccupiedSpace.TabIndex = 14;
            this.buttonOccupiedSpace.Text = "Occupied Space F8";
            this.buttonOccupiedSpace.UseVisualStyleBackColor = true;
            // 
            // CCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(943, 472);
            this.Controls.Add(this.buttonOccupiedSpace);
            this.Controls.Add(this.buttonAttribute);
            this.Controls.Add(this.buttonDencrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonUnzip);
            this.Controls.Add(this.buttonZip);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxDrivesRight);
            this.Controls.Add(this.comboBoxDrivesLeft);
            this.Controls.Add(this.listViewFilesRight);
            this.Controls.Add(this.listViewFilesLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CCCForm";
            this.Text = "CodeCool Commander";
            this.Load += new System.EventHandler(this.CCCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFilesLeft;
        private System.Windows.Forms.ListView listViewFilesRight;
        private System.Windows.Forms.ComboBox comboBoxDrivesLeft;
        private System.Windows.Forms.ComboBox comboBoxDrivesRight;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonZip;
        private System.Windows.Forms.Button buttonUnzip;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDencrypt;
        private System.Windows.Forms.Button buttonAttribute;
        private System.Windows.Forms.Button buttonOccupiedSpace;
    }
}

