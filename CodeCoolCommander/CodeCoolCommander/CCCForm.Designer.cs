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
            this.buttonOpenText = new System.Windows.Forms.Button();
            this.listViewFilesLeft = new System.Windows.Forms.ListView();
            this.columnHeaderNameL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExtL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSizeL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFilesRight = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.filePathLeft = new System.Windows.Forms.TextBox();
            this.filePathRight = new System.Windows.Forms.TextBox();
            this.leftUpButton = new System.Windows.Forms.Button();
            this.rightUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDrivesLeft
            // 
            this.comboBoxDrivesLeft.FormattingEnabled = true;
            this.comboBoxDrivesLeft.Location = new System.Drawing.Point(8, 16);
            this.comboBoxDrivesLeft.Name = "comboBoxDrivesLeft";
            this.comboBoxDrivesLeft.Size = new System.Drawing.Size(52, 21);
            this.comboBoxDrivesLeft.TabIndex = 2;
            this.comboBoxDrivesLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivesLeft_SelectedIndexChanged);
            // 
            // comboBoxDrivesRight
            // 
            this.comboBoxDrivesRight.FormattingEnabled = true;
            this.comboBoxDrivesRight.Location = new System.Drawing.Point(545, 16);
            this.comboBoxDrivesRight.Name = "comboBoxDrivesRight";
            this.comboBoxDrivesRight.Size = new System.Drawing.Size(56, 21);
            this.comboBoxDrivesRight.TabIndex = 3;
            this.comboBoxDrivesRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivesRight_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(210, 418);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(600, 20);
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
            this.buttonSearch.Size = new System.Drawing.Size(115, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search F1";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(8, 444);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(95, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy F2";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(109, 444);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(95, 23);
            this.buttonMove.TabIndex = 8;
            this.buttonMove.Text = "Move F3";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonZip
            // 
            this.buttonZip.Location = new System.Drawing.Point(210, 444);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(95, 23);
            this.buttonZip.TabIndex = 9;
            this.buttonZip.Text = "Zip F3";
            this.buttonZip.UseVisualStyleBackColor = true;
            // 
            // buttonUnzip
            // 
            this.buttonUnzip.Location = new System.Drawing.Point(311, 444);
            this.buttonUnzip.Name = "buttonUnzip";
            this.buttonUnzip.Size = new System.Drawing.Size(95, 23);
            this.buttonUnzip.TabIndex = 10;
            this.buttonUnzip.Text = "Un Zip F4";
            this.buttonUnzip.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(412, 444);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(95, 23);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Encrypt F5";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDencrypt
            // 
            this.buttonDencrypt.Location = new System.Drawing.Point(513, 444);
            this.buttonDencrypt.Name = "buttonDencrypt";
            this.buttonDencrypt.Size = new System.Drawing.Size(95, 23);
            this.buttonDencrypt.TabIndex = 12;
            this.buttonDencrypt.Text = "Dencrypt F6";
            this.buttonDencrypt.UseVisualStyleBackColor = true;
            // 
            // buttonAttribute
            // 
            this.buttonAttribute.Location = new System.Drawing.Point(614, 444);
            this.buttonAttribute.Name = "buttonAttribute";
            this.buttonAttribute.Size = new System.Drawing.Size(95, 23);
            this.buttonAttribute.TabIndex = 13;
            this.buttonAttribute.Text = "File Attributes F7";
            this.buttonAttribute.UseVisualStyleBackColor = true;
            // 
            // buttonOpenText
            // 
            this.buttonOpenText.Location = new System.Drawing.Point(715, 444);
            this.buttonOpenText.Name = "buttonOpenText";
            this.buttonOpenText.Size = new System.Drawing.Size(95, 23);
            this.buttonOpenText.TabIndex = 14;
            this.buttonOpenText.Text = "Open Text F8";
            this.buttonOpenText.UseVisualStyleBackColor = true;
            this.buttonOpenText.Click += new System.EventHandler(this.buttonOpenText_Click);
            // 
            // listViewFilesLeft
            // 
            this.listViewFilesLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNameL,
            this.columnHeaderExtL,
            this.columnHeaderSizeL,
            this.columnHeaderDateL});
            this.listViewFilesLeft.FullRowSelect = true;
            this.listViewFilesLeft.Location = new System.Drawing.Point(8, 44);
            this.listViewFilesLeft.Name = "listViewFilesLeft";
            this.listViewFilesLeft.Size = new System.Drawing.Size(531, 365);
            this.listViewFilesLeft.TabIndex = 0;
            this.listViewFilesLeft.UseCompatibleStateImageBehavior = false;
            this.listViewFilesLeft.View = System.Windows.Forms.View.Details;
            this.listViewFilesLeft.SelectedIndexChanged += new System.EventHandler(this.listViewFilesLeft_SelectedIndexChanged);
            this.listViewFilesLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFilesLeft_MouseDoubleClick);
            // 
            // columnHeaderNameL
            // 
            this.columnHeaderNameL.Text = "Name";
            this.columnHeaderNameL.Width = 200;
            // 
            // columnHeaderExtL
            // 
            this.columnHeaderExtL.Text = "Ext";
            this.columnHeaderExtL.Width = 50;
            // 
            // columnHeaderSizeL
            // 
            this.columnHeaderSizeL.Text = "Size";
            this.columnHeaderSizeL.Width = 110;
            // 
            // columnHeaderDateL
            // 
            this.columnHeaderDateL.Text = "Date";
            this.columnHeaderDateL.Width = 130;
            // 
            // listViewFilesRight
            // 
            this.listViewFilesRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewFilesRight.FullRowSelect = true;
            this.listViewFilesRight.Location = new System.Drawing.Point(545, 44);
            this.listViewFilesRight.Name = "listViewFilesRight";
            this.listViewFilesRight.Size = new System.Drawing.Size(528, 365);
            this.listViewFilesRight.TabIndex = 15;
            this.listViewFilesRight.UseCompatibleStateImageBehavior = false;
            this.listViewFilesRight.View = System.Windows.Forms.View.Details;
            this.listViewFilesRight.SelectedIndexChanged += new System.EventHandler(this.listViewFilesRight_SelectedIndexChanged);
            this.listViewFilesRight.DoubleClick += new System.EventHandler(this.listViewFilesRight_DoubleClick);
            this.listViewFilesRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFilesRight_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ext";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Occupied Space F9";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // filePathLeft
            // 
            this.filePathLeft.Location = new System.Drawing.Point(66, 17);
            this.filePathLeft.Name = "filePathLeft";
            this.filePathLeft.Size = new System.Drawing.Size(408, 20);
            this.filePathLeft.TabIndex = 17;
            // 
            // filePathRight
            // 
            this.filePathRight.Location = new System.Drawing.Point(607, 16);
            this.filePathRight.Name = "filePathRight";
            this.filePathRight.Size = new System.Drawing.Size(402, 20);
            this.filePathRight.TabIndex = 18;
            // 
            // leftUpButton
            // 
            this.leftUpButton.Location = new System.Drawing.Point(481, 17);
            this.leftUpButton.Name = "leftUpButton";
            this.leftUpButton.Size = new System.Drawing.Size(58, 20);
            this.leftUpButton.TabIndex = 19;
            this.leftUpButton.Text = "Up";
            this.leftUpButton.UseVisualStyleBackColor = true;
            // 
            // rightUpButton
            // 
            this.rightUpButton.Location = new System.Drawing.Point(1015, 15);
            this.rightUpButton.Name = "rightUpButton";
            this.rightUpButton.Size = new System.Drawing.Size(58, 20);
            this.rightUpButton.TabIndex = 20;
            this.rightUpButton.Text = "Up";
            this.rightUpButton.UseVisualStyleBackColor = true;
            // 
            // CCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1085, 472);
            this.Controls.Add(this.rightUpButton);
            this.Controls.Add(this.leftUpButton);
            this.Controls.Add(this.filePathRight);
            this.Controls.Add(this.filePathLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewFilesRight);
            this.Controls.Add(this.buttonOpenText);
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
            this.Controls.Add(this.listViewFilesLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CCCForm";
            this.Text = "CodeCool Commander";
            this.Load += new System.EventHandler(this.CCCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button buttonOpenText;
        private System.Windows.Forms.ListView listViewFilesLeft;
        private System.Windows.Forms.ColumnHeader columnHeaderNameL;
        private System.Windows.Forms.ColumnHeader columnHeaderExtL;
        private System.Windows.Forms.ColumnHeader columnHeaderSizeL;
        private System.Windows.Forms.ColumnHeader columnHeaderDateL;
        private System.Windows.Forms.ListView listViewFilesRight;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePathLeft;
        private System.Windows.Forms.TextBox filePathRight;
        private System.Windows.Forms.Button leftUpButton;
        private System.Windows.Forms.Button rightUpButton;
    }
}

