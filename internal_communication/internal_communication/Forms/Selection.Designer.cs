namespace internal_communication
{
    partial class project_selection_form
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
            this.project_list = new System.Windows.Forms.ListBox();
            this.interrogation_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.position_lbl = new System.Windows.Forms.Label();
            this.logoff_btn = new System.Windows.Forms.Button();
            this.user_lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.project_txtbx = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.byyear_chckbx = new System.Windows.Forms.CheckBox();
            this.notification_lstbx = new System.Windows.Forms.ListBox();
            this.subject_listbx = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Create_btn = new System.Windows.Forms.Button();
            this.del_subj_btn = new System.Windows.Forms.Button();
            this.subj_btn = new System.Windows.Forms.Button();
            this.work_btn = new System.Windows.Forms.Button();
            this.Messagerie_btn = new System.Windows.Forms.Button();
            this.file_btn = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // project_list
            // 
            this.project_list.BackColor = System.Drawing.SystemColors.MenuText;
            this.project_list.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.project_list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_list.ForeColor = System.Drawing.Color.White;
            this.project_list.FormattingEnabled = true;
            this.project_list.ItemHeight = 27;
            this.project_list.Location = new System.Drawing.Point(12, 194);
            this.project_list.Name = "project_list";
            this.project_list.Size = new System.Drawing.Size(307, 436);
            this.project_list.TabIndex = 3;
            this.project_list.SelectedIndexChanged += new System.EventHandler(this.project_list_SelectedIndexChanged);
            // 
            // interrogation_btn
            // 
            this.interrogation_btn.AutoSize = true;
            this.interrogation_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.interrogation_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interrogation_btn.ForeColor = System.Drawing.Color.Maroon;
            this.interrogation_btn.Location = new System.Drawing.Point(276, 130);
            this.interrogation_btn.Name = "interrogation_btn";
            this.interrogation_btn.Size = new System.Drawing.Size(195, 93);
            this.interrogation_btn.TabIndex = 17;
            this.interrogation_btn.Text = " HELP ";
            this.interrogation_btn.UseVisualStyleBackColor = false;
            this.interrogation_btn.Click += new System.EventHandler(this.interrogation_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.position_lbl);
            this.groupBox2.Controls.Add(this.logoff_btn);
            this.groupBox2.Controls.Add(this.user_lbl);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 186);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logged in";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // position_lbl
            // 
            this.position_lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.position_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.position_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_lbl.ForeColor = System.Drawing.Color.Black;
            this.position_lbl.Location = new System.Drawing.Point(6, 68);
            this.position_lbl.Name = "position_lbl";
            this.position_lbl.Size = new System.Drawing.Size(268, 33);
            this.position_lbl.TabIndex = 3;
            this.position_lbl.Text = "Position";
            this.position_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoff_btn
            // 
            this.logoff_btn.Location = new System.Drawing.Point(7, 104);
            this.logoff_btn.Name = "logoff_btn";
            this.logoff_btn.Size = new System.Drawing.Size(267, 43);
            this.logoff_btn.TabIndex = 1;
            this.logoff_btn.Text = "Log off";
            this.logoff_btn.UseVisualStyleBackColor = true;
            this.logoff_btn.Click += new System.EventHandler(this.logoff_btn_Click);
            // 
            // user_lbl
            // 
            this.user_lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.user_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.Color.Black;
            this.user_lbl.Location = new System.Drawing.Point(6, 35);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(268, 33);
            this.user_lbl.TabIndex = 0;
            this.user_lbl.Text = "user";
            this.user_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.user_lbl.Click += new System.EventHandler(this.user_lbl_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.project_txtbx);
            this.groupBox3.Controls.Add(this.find_btn);
            this.groupBox3.Controls.Add(this.byyear_chckbx);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(298, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 184);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // project_txtbx
            // 
            this.project_txtbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.project_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_txtbx.ForeColor = System.Drawing.Color.White;
            this.project_txtbx.Location = new System.Drawing.Point(0, 34);
            this.project_txtbx.Name = "project_txtbx";
            this.project_txtbx.Size = new System.Drawing.Size(590, 30);
            this.project_txtbx.TabIndex = 31;
            // 
            // find_btn
            // 
            this.find_btn.AutoSize = true;
            this.find_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.find_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.ForeColor = System.Drawing.Color.Black;
            this.find_btn.Location = new System.Drawing.Point(6, 66);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(386, 51);
            this.find_btn.TabIndex = 29;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click_1);
            // 
            // byyear_chckbx
            // 
            this.byyear_chckbx.BackColor = System.Drawing.Color.LightGray;
            this.byyear_chckbx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byyear_chckbx.ForeColor = System.Drawing.Color.Black;
            this.byyear_chckbx.Location = new System.Drawing.Point(398, 66);
            this.byyear_chckbx.Name = "byyear_chckbx";
            this.byyear_chckbx.Padding = new System.Windows.Forms.Padding(20);
            this.byyear_chckbx.Size = new System.Drawing.Size(212, 73);
            this.byyear_chckbx.TabIndex = 30;
            this.byyear_chckbx.Text = "By project year";
            this.byyear_chckbx.UseVisualStyleBackColor = false;
            // 
            // notification_lstbx
            // 
            this.notification_lstbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.notification_lstbx.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.notification_lstbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_lstbx.ForeColor = System.Drawing.Color.White;
            this.notification_lstbx.FormattingEnabled = true;
            this.notification_lstbx.ItemHeight = 27;
            this.notification_lstbx.Location = new System.Drawing.Point(9, 52);
            this.notification_lstbx.Name = "notification_lstbx";
            this.notification_lstbx.Size = new System.Drawing.Size(1099, 85);
            this.notification_lstbx.TabIndex = 28;
            // 
            // subject_listbx
            // 
            this.subject_listbx.BackColor = System.Drawing.Color.White;
            this.subject_listbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_listbx.ForeColor = System.Drawing.SystemColors.MenuText;
            this.subject_listbx.FormattingEnabled = true;
            this.subject_listbx.ItemHeight = 27;
            this.subject_listbx.Location = new System.Drawing.Point(325, 197);
            this.subject_listbx.Name = "subject_listbx";
            this.subject_listbx.Size = new System.Drawing.Size(327, 517);
            this.subject_listbx.TabIndex = 30;
            this.subject_listbx.SelectedIndexChanged += new System.EventHandler(this.subject_listbx_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.BackColor = System.Drawing.Color.DimGray;
            this.groupBox4.Controls.Add(this.notification_lstbx);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(28, 764);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1121, 176);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notification center";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DimGray;
            this.groupBox5.Controls.Add(this.delete_btn);
            this.groupBox5.Controls.Add(this.Create_btn);
            this.groupBox5.Controls.Add(this.del_subj_btn);
            this.groupBox5.Controls.Add(this.subj_btn);
            this.groupBox5.Controls.Add(this.work_btn);
            this.groupBox5.Controls.Add(this.Messagerie_btn);
            this.groupBox5.Controls.Add(this.file_btn);
            this.groupBox5.Controls.Add(this.interrogation_btn);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(658, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 514);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Features";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.delete_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Maroon;
            this.delete_btn.Location = new System.Drawing.Point(276, 386);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(195, 91);
            this.delete_btn.TabIndex = 35;
            this.delete_btn.Text = "Delete project";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Create_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Create_btn.Location = new System.Drawing.Point(276, 288);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(195, 92);
            this.Create_btn.TabIndex = 20;
            this.Create_btn.Text = "Create project";
            this.Create_btn.UseVisualStyleBackColor = false;
            this.Create_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // del_subj_btn
            // 
            this.del_subj_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.del_subj_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_subj_btn.ForeColor = System.Drawing.Color.Maroon;
            this.del_subj_btn.Location = new System.Drawing.Point(19, 382);
            this.del_subj_btn.Name = "del_subj_btn";
            this.del_subj_btn.Size = new System.Drawing.Size(188, 93);
            this.del_subj_btn.TabIndex = 34;
            this.del_subj_btn.Text = "Delete suject";
            this.del_subj_btn.UseVisualStyleBackColor = false;
            this.del_subj_btn.Click += new System.EventHandler(this.del_subj_btn_Click);
            // 
            // subj_btn
            // 
            this.subj_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subj_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subj_btn.ForeColor = System.Drawing.Color.Maroon;
            this.subj_btn.Location = new System.Drawing.Point(19, 288);
            this.subj_btn.Name = "subj_btn";
            this.subj_btn.Size = new System.Drawing.Size(188, 88);
            this.subj_btn.TabIndex = 34;
            this.subj_btn.Text = "Add subject";
            this.subj_btn.UseVisualStyleBackColor = false;
            this.subj_btn.Click += new System.EventHandler(this.subj_btn_Click);
            // 
            // work_btn
            // 
            this.work_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.work_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_btn.ForeColor = System.Drawing.Color.Maroon;
            this.work_btn.Location = new System.Drawing.Point(19, 35);
            this.work_btn.Name = "work_btn";
            this.work_btn.Size = new System.Drawing.Size(188, 90);
            this.work_btn.TabIndex = 28;
            this.work_btn.Text = "My work load";
            this.work_btn.UseVisualStyleBackColor = false;
            // 
            // Messagerie_btn
            // 
            this.Messagerie_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Messagerie_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagerie_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Messagerie_btn.Location = new System.Drawing.Point(19, 131);
            this.Messagerie_btn.Name = "Messagerie_btn";
            this.Messagerie_btn.Size = new System.Drawing.Size(188, 93);
            this.Messagerie_btn.TabIndex = 27;
            this.Messagerie_btn.Text = "Messagerie";
            this.Messagerie_btn.UseVisualStyleBackColor = false;
            this.Messagerie_btn.Click += new System.EventHandler(this.Messagerie_btn_Click);
            // 
            // file_btn
            // 
            this.file_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.file_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_btn.ForeColor = System.Drawing.Color.Maroon;
            this.file_btn.Location = new System.Drawing.Point(276, 35);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(195, 89);
            this.file_btn.TabIndex = 26;
            this.file_btn.Text = "View files";
            this.file_btn.UseVisualStyleBackColor = false;
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(12, 625);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(307, 86);
            this.Next.TabIndex = 34;
            this.Next.Text = "NEXT";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // project_selection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::internal_communication.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1602, 1050);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.subject_listbx);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.project_list);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "project_selection_form";
            this.Text = "project select";
            this.Load += new System.EventHandler(this.project_selection_form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox project_list;
        private System.Windows.Forms.Button interrogation_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logoff_btn;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox project_txtbx;
        private System.Windows.Forms.CheckBox byyear_chckbx;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Label position_lbl;
        private System.Windows.Forms.ListBox notification_lstbx;
        private System.Windows.Forms.ListBox subject_listbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button work_btn;
        private System.Windows.Forms.Button Messagerie_btn;
        private System.Windows.Forms.Button file_btn;
        private System.Windows.Forms.Button subj_btn;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button del_subj_btn;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button delete_btn;
    }
}

