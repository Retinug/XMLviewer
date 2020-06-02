using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace XMLviewer
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView.Columns.Clear();

                XmlReader xmlReader = XmlReader.Create(openFileDialog.FileName, new XmlReaderSettings());
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(xmlReader);
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataSet dataSet = (DataSet)dataGridView.DataSource;
                dataSet.WriteXml(saveFileDialog.FileName);
            }
        }        
    }
}
