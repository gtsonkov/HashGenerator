namespace HashGenerator
{
    partial class HashGenerator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashGenerator));
            this.SelectFileLbl = new System.Windows.Forms.Label();
            this.FileNameLbl = new System.Windows.Forms.Label();
            this.FileSizeLbl = new System.Windows.Forms.Label();
            this.FileHashLbl = new System.Windows.Forms.Label();
            this.CheksumTypeLbl = new System.Windows.Forms.Label();
            this.ComaperLbl = new System.Windows.Forms.Label();
            this.SelectFileTxt = new System.Windows.Forms.TextBox();
            this.FileSizeShow = new System.Windows.Forms.Label();
            this.FileNameShow = new System.Windows.Forms.Label();
            this.UseMD5 = new System.Windows.Forms.RadioButton();
            this.UseSha512 = new System.Windows.Forms.RadioButton();
            this.FileHashTxt = new System.Windows.Forms.TextBox();
            this.ComapreHashTxt = new System.Windows.Forms.TextBox();
            this.BroweseBtn = new System.Windows.Forms.Button();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.OKLbl = new System.Windows.Forms.Label();
            this.NoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFileLbl
            // 
            this.SelectFileLbl.AutoSize = true;
            this.SelectFileLbl.Location = new System.Drawing.Point(44, 99);
            this.SelectFileLbl.Name = "SelectFileLbl";
            this.SelectFileLbl.Size = new System.Drawing.Size(53, 13);
            this.SelectFileLbl.TabIndex = 0;
            this.SelectFileLbl.Text = "Select file";
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Location = new System.Drawing.Point(44, 154);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(52, 13);
            this.FileNameLbl.TabIndex = 1;
            this.FileNameLbl.Text = "File name";
            // 
            // FileSizeLbl
            // 
            this.FileSizeLbl.AutoSize = true;
            this.FileSizeLbl.Location = new System.Drawing.Point(44, 186);
            this.FileSizeLbl.Name = "FileSizeLbl";
            this.FileSizeLbl.Size = new System.Drawing.Size(44, 13);
            this.FileSizeLbl.TabIndex = 2;
            this.FileSizeLbl.Text = "File size";
            // 
            // FileHashLbl
            // 
            this.FileHashLbl.AutoSize = true;
            this.FileHashLbl.Location = new System.Drawing.Point(44, 250);
            this.FileHashLbl.Name = "FileHashLbl";
            this.FileHashLbl.Size = new System.Drawing.Size(51, 13);
            this.FileHashLbl.TabIndex = 4;
            this.FileHashLbl.Text = "File Hash";
            // 
            // CheksumTypeLbl
            // 
            this.CheksumTypeLbl.AutoSize = true;
            this.CheksumTypeLbl.Location = new System.Drawing.Point(44, 218);
            this.CheksumTypeLbl.Name = "CheksumTypeLbl";
            this.CheksumTypeLbl.Size = new System.Drawing.Size(74, 13);
            this.CheksumTypeLbl.TabIndex = 3;
            this.CheksumTypeLbl.Text = "Cheksum type";
            // 
            // ComaperLbl
            // 
            this.ComaperLbl.AutoSize = true;
            this.ComaperLbl.Location = new System.Drawing.Point(44, 282);
            this.ComaperLbl.Name = "ComaperLbl";
            this.ComaperLbl.Size = new System.Drawing.Size(77, 13);
            this.ComaperLbl.TabIndex = 5;
            this.ComaperLbl.Text = "Comaper Hash";
            // 
            // SelectFileTxt
            // 
            this.SelectFileTxt.Location = new System.Drawing.Point(137, 96);
            this.SelectFileTxt.Name = "SelectFileTxt";
            this.SelectFileTxt.Size = new System.Drawing.Size(534, 20);
            this.SelectFileTxt.TabIndex = 6;
            // 
            // FileSizeShow
            // 
            this.FileSizeShow.AutoSize = true;
            this.FileSizeShow.Location = new System.Drawing.Point(134, 186);
            this.FileSizeShow.Name = "FileSizeShow";
            this.FileSizeShow.Size = new System.Drawing.Size(44, 13);
            this.FileSizeShow.TabIndex = 8;
            this.FileSizeShow.Text = "File size";
            // 
            // FileNameShow
            // 
            this.FileNameShow.AutoSize = true;
            this.FileNameShow.Location = new System.Drawing.Point(134, 154);
            this.FileNameShow.Name = "FileNameShow";
            this.FileNameShow.Size = new System.Drawing.Size(52, 13);
            this.FileNameShow.TabIndex = 7;
            this.FileNameShow.Text = "File name";
            // 
            // UseMD5
            // 
            this.UseMD5.Checked = true;
            this.UseMD5.Location = new System.Drawing.Point(141, 215);
            this.UseMD5.Name = "UseMD5";
            this.UseMD5.Size = new System.Drawing.Size(104, 24);
            this.UseMD5.TabIndex = 9;
            this.UseMD5.TabStop = true;
            this.UseMD5.Text = "MD5";
            this.UseMD5.UseVisualStyleBackColor = true;
            this.UseMD5.Click += new System.EventHandler(this.UseMD5_Click);
            // 
            // UseSha512
            // 
            this.UseSha512.AutoSize = true;
            this.UseSha512.Location = new System.Drawing.Point(244, 215);
            this.UseSha512.Name = "UseSha512";
            this.UseSha512.Size = new System.Drawing.Size(68, 17);
            this.UseSha512.TabIndex = 10;
            this.UseSha512.Text = "SHA-512";
            this.UseSha512.UseVisualStyleBackColor = true;
            this.UseSha512.Click += new System.EventHandler(this.UseSha512_Click);
            // 
            // FileHashTxt
            // 
            this.FileHashTxt.Location = new System.Drawing.Point(137, 242);
            this.FileHashTxt.Name = "FileHashTxt";
            this.FileHashTxt.Size = new System.Drawing.Size(534, 20);
            this.FileHashTxt.TabIndex = 11;
            // 
            // ComapreHashTxt
            // 
            this.ComapreHashTxt.Location = new System.Drawing.Point(137, 276);
            this.ComapreHashTxt.Name = "ComapreHashTxt";
            this.ComapreHashTxt.Size = new System.Drawing.Size(534, 20);
            this.ComapreHashTxt.TabIndex = 12;
            // 
            // BroweseBtn
            // 
            this.BroweseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BroweseBtn.Location = new System.Drawing.Point(709, 96);
            this.BroweseBtn.Name = "BroweseBtn";
            this.BroweseBtn.Size = new System.Drawing.Size(75, 22);
            this.BroweseBtn.TabIndex = 13;
            this.BroweseBtn.Text = "Browse";
            this.BroweseBtn.UseVisualStyleBackColor = true;
            this.BroweseBtn.Click += new System.EventHandler(this.BroweseBtn_Click);
            // 
            // CompareBtn
            // 
            this.CompareBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CompareBtn.Location = new System.Drawing.Point(709, 276);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(75, 22);
            this.CompareBtn.TabIndex = 15;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CopyBtn.Location = new System.Drawing.Point(709, 240);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(75, 22);
            this.CopyBtn.TabIndex = 16;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // OKLbl
            // 
            this.OKLbl.AutoSize = true;
            this.OKLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKLbl.ForeColor = System.Drawing.Color.Lime;
            this.OKLbl.Location = new System.Drawing.Point(674, 260);
            this.OKLbl.Name = "OKLbl";
            this.OKLbl.Size = new System.Drawing.Size(33, 20);
            this.OKLbl.TabIndex = 17;
            this.OKLbl.Text = "OK";
            this.OKLbl.Visible = false;
            // 
            // NoLbl
            // 
            this.NoLbl.AutoSize = true;
            this.NoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoLbl.ForeColor = System.Drawing.Color.Red;
            this.NoLbl.Location = new System.Drawing.Point(677, 260);
            this.NoLbl.Name = "NoLbl";
            this.NoLbl.Size = new System.Drawing.Size(31, 20);
            this.NoLbl.TabIndex = 18;
            this.NoLbl.Text = "No";
            this.NoLbl.Visible = false;
            // 
            // HashGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(819, 385);
            this.Controls.Add(this.NoLbl);
            this.Controls.Add(this.OKLbl);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.BroweseBtn);
            this.Controls.Add(this.ComapreHashTxt);
            this.Controls.Add(this.FileHashTxt);
            this.Controls.Add(this.UseSha512);
            this.Controls.Add(this.UseMD5);
            this.Controls.Add(this.FileSizeShow);
            this.Controls.Add(this.FileNameShow);
            this.Controls.Add(this.SelectFileTxt);
            this.Controls.Add(this.ComaperLbl);
            this.Controls.Add(this.FileHashLbl);
            this.Controls.Add(this.CheksumTypeLbl);
            this.Controls.Add(this.FileSizeLbl);
            this.Controls.Add(this.FileNameLbl);
            this.Controls.Add(this.SelectFileLbl);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HashGenerator";
            this.Text = "Hash Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFileLbl;
        private System.Windows.Forms.Label FileNameLbl;
        private System.Windows.Forms.Label FileSizeLbl;
        private System.Windows.Forms.Label FileHashLbl;
        private System.Windows.Forms.Label CheksumTypeLbl;
        private System.Windows.Forms.Label ComaperLbl;
        private System.Windows.Forms.TextBox SelectFileTxt;
        private System.Windows.Forms.Label FileSizeShow;
        private System.Windows.Forms.Label FileNameShow;
        private System.Windows.Forms.RadioButton UseMD5;
        private System.Windows.Forms.RadioButton UseSha512;
        private System.Windows.Forms.TextBox FileHashTxt;
        private System.Windows.Forms.TextBox ComapreHashTxt;
        private System.Windows.Forms.Button BroweseBtn;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Label OKLbl;
        private System.Windows.Forms.Label NoLbl;
    }
}

