using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace pdfMerger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PDF Merger by Chris Jarvis";
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        // creates a open file dialog box
        OpenFileDialog ofd = new OpenFileDialog();
        private void open_Click(object sender, EventArgs e)
        {
            //Set the open file dialog box for graphical files
            this.ofd.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PDF)|*.BMP;*.JPG;*.GIF;*.PDF|" +
        "All files (*.*)|*.*";
            //Set multi select option to be true
            this.ofd.Multiselect = true;
            this.ofd.Title = "Select Files to Merge";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in ofd.FileNames)
                {
                    comboBox1.Items.Add(file);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void merge_Click(object sender, EventArgs e)
        {
            List<string> pdfs = new List<string>();
            int i = 0;
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            SaveFileDialog sf = new SaveFileDialog();
            
            for (i = 0; i < comboBox1.Items.Count; i++)
            {
                pdfs.Add(comboBox1.GetItemText(comboBox1.Items[i]));
            }
            using (PdfDocument targetDoc = new PdfDocument())
            {
                foreach (string pdf in pdfs)
                {
                    using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (i = 0; i < pdfDoc.PageCount; i++)
                        {
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                }
                sf.InitialDirectory = folderPath;
                if(sf.ShowDialog() == DialogResult.OK)
                {
                    targetDoc.Save(sf.FileName + ".pdf");
                    System.Windows.Forms.MessageBox.Show("PDF has been saved.");
                }
                //targetDoc.Save(folderPath + @"\output.pdf");
                //System.Windows.Forms.MessageBox.Show("PDF has been saved.");

            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
        public void MoveUp()
        {
            MoveItem(-1);
        }

        public void MoveDown()
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (comboBox1.SelectedItem == null || comboBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = comboBox1.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= comboBox1.Items.Count)
                return; // Index out of range - nothing to do

            object selected = comboBox1.SelectedItem;

            // Removing removable element
            comboBox1.Items.Remove(selected);
            // Insert it in new position
            comboBox1.Items.Insert(newIndex, selected);
            // Restore selection
            comboBox1.SetSelected(newIndex, true);
        }

        private void up_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void down_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }
    }
    }

