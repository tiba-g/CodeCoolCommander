using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCoolCommander
{
    public partial class TXTReader : Form
    {
        public TXTReader(string path)
        {
            InitializeComponent();
            try
            {
                richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't access file!");
            }
            
        }
    }
}
