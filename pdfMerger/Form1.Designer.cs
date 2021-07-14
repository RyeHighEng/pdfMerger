
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
            this.merge = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(44, 33);
            this.open.Margin = new System.Windows.Forms.Padding(4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(123, 28);
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
            // merge
            // 
            this.merge.Location = new System.Drawing.Point(175, 33);
            this.merge.Margin = new System.Windows.Forms.Padding(4);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(127, 28);
            this.merge.TabIndex = 3;
            this.merge.Text = "Merge PDF\'s";
            this.merge.UseVisualStyleBackColor = true;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(310, 33);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(117, 28);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear Items";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(976, 436);
            this.listBox1.TabIndex = 5;
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(753, 36);
            this.up.Margin = new System.Windows.Forms.Padding(4);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(117, 28);
            this.up.TabIndex = 6;
            this.up.Text = "Move Up";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(878, 36);
            this.down.Margin = new System.Windows.Forms.Padding(4);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(117, 28);
            this.down.TabIndex = 7;
            this.down.Text = "Move Down";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PDF Merger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
    }
}

