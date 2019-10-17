namespace internal_communication
{
    partial class view_project
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
            this.message_lstbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_txtbx = new System.Windows.Forms.RichTextBox();
            this.project_btn = new System.Windows.Forms.Button();
            this.file_btn = new System.Windows.Forms.Button();
            this.subject_listbx = new System.Windows.Forms.ListBox();
            this.subject_txtbx = new System.Windows.Forms.RichTextBox();
            this.subj_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.del_subj_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_lstbx
            // 
            this.message_lstbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.message_lstbx.ForeColor = System.Drawing.Color.Lime;
            this.message_lstbx.FormattingEnabled = true;
            this.message_lstbx.ItemHeight = 20;
            this.message_lstbx.Location = new System.Drawing.Point(451, 12);
            this.message_lstbx.Name = "message_lstbx";
            this.message_lstbx.Size = new System.Drawing.Size(546, 304);
            this.message_lstbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 27);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(158, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Messagerie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_txtbx
            // 
            this.input_txtbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_txtbx.ForeColor = System.Drawing.Color.DarkGreen;
            this.input_txtbx.Location = new System.Drawing.Point(451, 322);
            this.input_txtbx.Name = "input_txtbx";
            this.input_txtbx.Size = new System.Drawing.Size(439, 86);
            this.input_txtbx.TabIndex = 3;
            this.input_txtbx.Text = "Your message";
            // 
            // project_btn
            // 
            this.project_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_btn.Location = new System.Drawing.Point(29, 12);
            this.project_btn.Name = "project_btn";
            this.project_btn.Size = new System.Drawing.Size(178, 55);
            this.project_btn.TabIndex = 4;
            this.project_btn.Text = "Project selection";
            this.project_btn.UseVisualStyleBackColor = true;
            this.project_btn.Click += new System.EventHandler(this.project_btn_Click);
            // 
            // file_btn
            // 
            this.file_btn.BackColor = System.Drawing.Color.DarkRed;
            this.file_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.file_btn.Location = new System.Drawing.Point(29, 84);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(178, 61);
            this.file_btn.TabIndex = 5;
            this.file_btn.Text = "View files";
            this.file_btn.UseVisualStyleBackColor = false;
            // 
            // subject_listbx
            // 
            this.subject_listbx.FormattingEnabled = true;
            this.subject_listbx.ItemHeight = 20;
            this.subject_listbx.Location = new System.Drawing.Point(238, 110);
            this.subject_listbx.Name = "subject_listbx";
            this.subject_listbx.Size = new System.Drawing.Size(155, 144);
            this.subject_listbx.TabIndex = 6;
            // 
            // subject_txtbx
            // 
            this.subject_txtbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.subject_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_txtbx.ForeColor = System.Drawing.Color.DarkGreen;
            this.subject_txtbx.Location = new System.Drawing.Point(238, 260);
            this.subject_txtbx.Name = "subject_txtbx";
            this.subject_txtbx.Size = new System.Drawing.Size(160, 64);
            this.subject_txtbx.TabIndex = 8;
            this.subject_txtbx.Text = "Your subject";
            // 
            // subj_btn
            // 
            this.subj_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subj_btn.Location = new System.Drawing.Point(235, 330);
            this.subj_btn.Name = "subj_btn";
            this.subj_btn.Size = new System.Drawing.Size(163, 56);
            this.subj_btn.TabIndex = 9;
            this.subj_btn.Text = "Add subject";
            this.subj_btn.UseVisualStyleBackColor = true;
            this.subj_btn.Click += new System.EventHandler(this.subj_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.Location = new System.Drawing.Point(896, 322);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(101, 86);
            this.send_btn.TabIndex = 10;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            // 
            // del_subj_btn
            // 
            this.del_subj_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_subj_btn.Location = new System.Drawing.Point(235, 392);
            this.del_subj_btn.Name = "del_subj_btn";
            this.del_subj_btn.Size = new System.Drawing.Size(163, 56);
            this.del_subj_btn.TabIndex = 11;
            this.del_subj_btn.Text = "Delete suject";
            this.del_subj_btn.UseVisualStyleBackColor = true;
            // 
            // view_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 460);
            this.Controls.Add(this.del_subj_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.subj_btn);
            this.Controls.Add(this.subject_txtbx);
            this.Controls.Add(this.subject_listbx);
            this.Controls.Add(this.file_btn);
            this.Controls.Add(this.project_btn);
            this.Controls.Add(this.input_txtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message_lstbx);
            this.Name = "view_project";
            this.Text = "view_project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox message_lstbx;
        private System.Windows.Forms.RichTextBox input_txtbx;
        private System.Windows.Forms.Button project_btn;
        private System.Windows.Forms.Button file_btn;
        private System.Windows.Forms.ListBox subject_listbx;
        private System.Windows.Forms.RichTextBox subject_txtbx;
        private System.Windows.Forms.Button subj_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button del_subj_btn;
    }
}