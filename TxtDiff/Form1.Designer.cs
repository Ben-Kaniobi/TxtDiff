namespace WindowsFormsApplication1
{
    partial class frm_TxtDiff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TxtDiff));
            this.spl_Texts = new System.Windows.Forms.SplitContainer();
            this.txt_A = new System.Windows.Forms.RichTextBox();
            this.txt_B = new System.Windows.Forms.RichTextBox();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.btn_comp = new System.Windows.Forms.CheckBox();
            this.txt_comp = new System.Windows.Forms.RichTextBox();
            this.chb_wordwrap = new System.Windows.Forms.CheckBox();
            this.btn_file_A = new System.Windows.Forms.Button();
            this.btn_file_B = new System.Windows.Forms.Button();
            this.ofd_FileBrowser = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.spl_Texts)).BeginInit();
            this.spl_Texts.Panel1.SuspendLayout();
            this.spl_Texts.Panel2.SuspendLayout();
            this.spl_Texts.SuspendLayout();
            this.SuspendLayout();
            // 
            // spl_Texts
            // 
            this.spl_Texts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spl_Texts.IsSplitterFixed = true;
            this.spl_Texts.Location = new System.Drawing.Point(12, 33);
            this.spl_Texts.Name = "spl_Texts";
            // 
            // spl_Texts.Panel1
            // 
            this.spl_Texts.Panel1.Controls.Add(this.txt_A);
            // 
            // spl_Texts.Panel2
            // 
            this.spl_Texts.Panel2.Controls.Add(this.txt_B);
            this.spl_Texts.Size = new System.Drawing.Size(400, 151);
            this.spl_Texts.SplitterDistance = 199;
            this.spl_Texts.SplitterWidth = 2;
            this.spl_Texts.TabIndex = 0;
            // 
            // txt_A
            // 
            this.txt_A.DetectUrls = false;
            this.txt_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_A.Location = new System.Drawing.Point(0, 0);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(199, 151);
            this.txt_A.TabIndex = 6;
            this.txt_A.Text = "";
            this.txt_A.TextChanged += new System.EventHandler(this.txt_A_TextChanged);
            this.txt_A.GotFocus += new System.EventHandler(this.txt_A_GotFocus);
            // 
            // txt_B
            // 
            this.txt_B.DetectUrls = false;
            this.txt_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_B.Location = new System.Drawing.Point(0, 0);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(199, 151);
            this.txt_B.TabIndex = 7;
            this.txt_B.Text = "";
            this.txt_B.TextChanged += new System.EventHandler(this.txt_B_TextChanged);
            this.txt_B.GotFocus += new System.EventHandler(this.txt_B_GotFocus);
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(9, 9);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(38, 13);
            this.lbl_A.TabIndex = 1;
            this.lbl_A.Text = "Text A";
            // 
            // lbl_B
            // 
            this.lbl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(374, 9);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(38, 13);
            this.lbl_B.TabIndex = 1;
            this.lbl_B.Text = "Text B";
            // 
            // btn_comp
            // 
            this.btn_comp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_comp.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_comp.Enabled = false;
            this.btn_comp.Location = new System.Drawing.Point(173, 4);
            this.btn_comp.Name = "btn_comp";
            this.btn_comp.Size = new System.Drawing.Size(76, 23);
            this.btn_comp.TabIndex = 3;
            this.btn_comp.Text = "Compare";
            this.btn_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_comp.UseVisualStyleBackColor = true;
            this.btn_comp.CheckedChanged += new System.EventHandler(this.btn_comp_CheckedChanged);
            this.btn_comp.GotFocus += new System.EventHandler(this.btn_comp_GotFocus);
            // 
            // txt_comp
            // 
            this.txt_comp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_comp.BackColor = System.Drawing.SystemColors.Window;
            this.txt_comp.DetectUrls = false;
            this.txt_comp.Enabled = false;
            this.txt_comp.Location = new System.Drawing.Point(12, 33);
            this.txt_comp.Name = "txt_comp";
            this.txt_comp.ReadOnly = true;
            this.txt_comp.Size = new System.Drawing.Size(400, 151);
            this.txt_comp.TabIndex = 5;
            this.txt_comp.Text = "";
            this.txt_comp.Visible = false;
            this.txt_comp.GotFocus += new System.EventHandler(this.txt_comp_GotFocus);
            // 
            // chb_wordwrap
            // 
            this.chb_wordwrap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chb_wordwrap.AutoSize = true;
            this.chb_wordwrap.Checked = true;
            this.chb_wordwrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_wordwrap.Location = new System.Drawing.Point(173, 190);
            this.chb_wordwrap.Name = "chb_wordwrap";
            this.chb_wordwrap.Size = new System.Drawing.Size(78, 17);
            this.chb_wordwrap.TabIndex = 6;
            this.chb_wordwrap.Text = "WordWrap";
            this.chb_wordwrap.UseVisualStyleBackColor = true;
            this.chb_wordwrap.CheckedChanged += new System.EventHandler(this.chb_wordwrap_CheckedChanged);
            // 
            // btn_file_A
            // 
            this.btn_file_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_file_A.Location = new System.Drawing.Point(12, 190);
            this.btn_file_A.Name = "btn_file_A";
            this.btn_file_A.Size = new System.Drawing.Size(75, 23);
            this.btn_file_A.TabIndex = 7;
            this.btn_file_A.Text = "File A";
            this.btn_file_A.UseVisualStyleBackColor = true;
            this.btn_file_A.Click += new System.EventHandler(this.btn_file_A_Click);
            // 
            // btn_file_B
            // 
            this.btn_file_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_file_B.Location = new System.Drawing.Point(337, 190);
            this.btn_file_B.Name = "btn_file_B";
            this.btn_file_B.Size = new System.Drawing.Size(75, 23);
            this.btn_file_B.TabIndex = 7;
            this.btn_file_B.Text = "File B";
            this.btn_file_B.UseVisualStyleBackColor = true;
            this.btn_file_B.Click += new System.EventHandler(this.btn_file_B_Click);
            // 
            // ofd_FileBrowser
            // 
            this.ofd_FileBrowser.Filter = "All files|*.*";
            this.ofd_FileBrowser.InitialDirectory = "%USERPROFILE%\\Desktop";
            this.ofd_FileBrowser.Multiselect = true;
            this.ofd_FileBrowser.Title = "Select a text file X";
            this.ofd_FileBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileBrowser_FileOk);
            // 
            // frm_TxtDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 225);
            this.Controls.Add(this.btn_file_B);
            this.Controls.Add(this.btn_file_A);
            this.Controls.Add(this.chb_wordwrap);
            this.Controls.Add(this.txt_comp);
            this.Controls.Add(this.btn_comp);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.spl_Texts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(440, 177);
            this.Name = "frm_TxtDiff";
            this.Text = "TxtDiff";
            this.spl_Texts.Panel1.ResumeLayout(false);
            this.spl_Texts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_Texts)).EndInit();
            this.spl_Texts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spl_Texts;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.CheckBox btn_comp;
        private System.Windows.Forms.RichTextBox txt_comp;
        private System.Windows.Forms.RichTextBox txt_A;
        private System.Windows.Forms.RichTextBox txt_B;
        private System.Windows.Forms.CheckBox chb_wordwrap;
        private System.Windows.Forms.Button btn_file_A;
        private System.Windows.Forms.Button btn_file_B;
        private System.Windows.Forms.OpenFileDialog ofd_FileBrowser;

    }
}

