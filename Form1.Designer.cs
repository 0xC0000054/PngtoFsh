namespace PngtoFsh
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
            this.newfshbtn = new System.Windows.Forms.Button();
            this.newcompfshbtn = new System.Windows.Forms.Button();
            this.bmplbl = new System.Windows.Forms.Label();
            this.bmpfnlbl = new System.Windows.Forms.Label();
            this.alphafnlbl = new System.Windows.Forms.Label();
            this.alphalbl = new System.Windows.Forms.Label();
            this.fshtypelbl = new System.Windows.Forms.Label();
            this.bmptype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newfshbtn
            // 
            this.newfshbtn.AllowDrop = true;
            this.newfshbtn.Location = new System.Drawing.Point(12, 86);
            this.newfshbtn.Name = "newfshbtn";
            this.newfshbtn.Size = new System.Drawing.Size(75, 23);
            this.newfshbtn.TabIndex = 1;
            this.newfshbtn.Text = "New fsh ";
            this.newfshbtn.UseVisualStyleBackColor = true;
            this.newfshbtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.newfshbtn_DragDrop);
            this.newfshbtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.newfshbtn_DragEnter);
            // 
            // newcompfshbtn
            // 
            this.newcompfshbtn.AllowDrop = true;
            this.newcompfshbtn.Location = new System.Drawing.Point(93, 86);
            this.newcompfshbtn.Name = "newcompfshbtn";
            this.newcompfshbtn.Size = new System.Drawing.Size(120, 23);
            this.newcompfshbtn.TabIndex = 3;
            this.newcompfshbtn.Text = "New Compressed fsh";
            this.newcompfshbtn.UseVisualStyleBackColor = true;
            this.newcompfshbtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.newcompfshbtn_DragDrop);
            this.newcompfshbtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.newcompfsh_DragEnter);
            // 
            // bmplbl
            // 
            this.bmplbl.AutoSize = true;
            this.bmplbl.Location = new System.Drawing.Point(12, 13);
            this.bmplbl.Name = "bmplbl";
            this.bmplbl.Size = new System.Drawing.Size(42, 13);
            this.bmplbl.TabIndex = 4;
            this.bmplbl.Text = "Bitmap:";
            // 
            // bmpfnlbl
            // 
            this.bmpfnlbl.AutoSize = true;
            this.bmpfnlbl.Location = new System.Drawing.Point(61, 12);
            this.bmpfnlbl.Name = "bmpfnlbl";
            this.bmpfnlbl.Size = new System.Drawing.Size(0, 13);
            this.bmpfnlbl.TabIndex = 5;
            // 
            // alphafnlbl
            // 
            this.alphafnlbl.AutoSize = true;
            this.alphafnlbl.Location = new System.Drawing.Point(61, 25);
            this.alphafnlbl.Name = "alphafnlbl";
            this.alphafnlbl.Size = new System.Drawing.Size(0, 13);
            this.alphafnlbl.TabIndex = 7;
            // 
            // alphalbl
            // 
            this.alphalbl.AutoSize = true;
            this.alphalbl.Location = new System.Drawing.Point(12, 26);
            this.alphalbl.Name = "alphalbl";
            this.alphalbl.Size = new System.Drawing.Size(37, 13);
            this.alphalbl.TabIndex = 6;
            this.alphalbl.Text = "Alpha:";
            // 
            // fshtypelbl
            // 
            this.fshtypelbl.AutoSize = true;
            this.fshtypelbl.Location = new System.Drawing.Point(12, 43);
            this.fshtypelbl.Name = "fshtypelbl";
            this.fshtypelbl.Size = new System.Drawing.Size(50, 13);
            this.fshtypelbl.TabIndex = 8;
            this.fshtypelbl.Text = "Fsh type:";
            // 
            // bmptype
            // 
            this.bmptype.AutoSize = true;
            this.bmptype.Location = new System.Drawing.Point(61, 43);
            this.bmptype.Name = "bmptype";
            this.bmptype.Size = new System.Drawing.Size(0, 13);
            this.bmptype.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 121);
            this.Controls.Add(this.bmptype);
            this.Controls.Add(this.fshtypelbl);
            this.Controls.Add(this.alphafnlbl);
            this.Controls.Add(this.alphalbl);
            this.Controls.Add(this.bmpfnlbl);
            this.Controls.Add(this.bmplbl);
            this.Controls.Add(this.newcompfshbtn);
            this.Controls.Add(this.newfshbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newfshbtn;
        private System.Windows.Forms.Button newcompfshbtn;
        private System.Windows.Forms.Label bmplbl;
        private System.Windows.Forms.Label bmpfnlbl;
        private System.Windows.Forms.Label alphafnlbl;
        private System.Windows.Forms.Label alphalbl;
        private System.Windows.Forms.Label fshtypelbl;
        private System.Windows.Forms.Label bmptype;
    }
}

