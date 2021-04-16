
namespace pdfMerger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.merge = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(33, 27);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(92, 23);
            this.open.TabIndex = 1;
            this.open.Text = "Open File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 744;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(33, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(744, 293);
            this.comboBox1.TabIndex = 2;
            // 
            // merge
            // 
            this.merge.Location = new System.Drawing.Point(131, 27);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(95, 23);
            this.merge.TabIndex = 3;
            this.merge.Text = "Merge PDF\'s";
            this.merge.UseVisualStyleBackColor = true;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(232, 27);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(88, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear Items";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(341, 28);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(435, 20);
            this.fname.TabIndex = 5;
            this.fname.Text = "OutputName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox fname;
    }
}

