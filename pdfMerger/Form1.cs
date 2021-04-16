using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        OpenFileDialog ofd = new OpenFileDialog();
        private void open_Click(object sender, EventArgs e)
        {
             if (ofd.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Add(ofd.FileName);
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
                targetDoc.Save(folderPath + @"\output.pdf");
                System.Windows.Forms.MessageBox.Show("PDF has been saved.");
            }
        }
    }
    }

