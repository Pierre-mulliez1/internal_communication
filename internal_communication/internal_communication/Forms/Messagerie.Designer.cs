namespace internal_communication
{
    partial class Messagerie
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
            this.label1 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.input_txtbx = new System.Windows.Forms.RichTextBox();
            this.message_lstbx = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.sender_chckbx = new System.Windows.Forms.CheckBox();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.undo_btn = new System.Windows.Forms.Button();
            this.subject_grpbx = new System.Windows.Forms.GroupBox();
            this.subj_id_lbl = new System.Windows.Forms.Label();
            this.subjnme_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.subject_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(306, 154);
            this.label1.TabIndex = 18;
            this.label1.Text = "Messagerie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.send_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.Location = new System.Drawing.Point(489, 645);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(133, 120);
            this.send_btn.TabIndex = 21;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // input_txtbx
            // 
            this.input_txtbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_txtbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_txtbx.ForeColor = System.Drawing.Color.Ivory;
            this.input_txtbx.Location = new System.Drawing.Point(25, 645);
            this.input_txtbx.Name = "input_txtbx";
            this.input_txtbx.Size = new System.Drawing.Size(458, 120);
            this.input_txtbx.TabIndex = 20;
            this.input_txtbx.Text = "Your message";
            this.input_txtbx.TextChanged += new System.EventHandler(this.input_txtbx_TextChanged);
            // 
            // message_lstbx
            // 
            this.message_lstbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.message_lstbx.ForeColor = System.Drawing.Color.White;
            this.message_lstbx.FormattingEnabled = true;
            this.message_lstbx.ItemHeight = 20;
            this.message_lstbx.Location = new System.Drawing.Point(25, 295);
            this.message_lstbx.Name = "message_lstbx";
            this.message_lstbx.Size = new System.Drawing.Size(736, 344);
            this.message_lstbx.TabIndex = 19;
            this.message_lstbx.SelectedIndexChanged += new System.EventHandler(this.message_lstbx_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.back_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(873, 655);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(143, 110);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(871, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 110);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back to Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.sender_chckbx);
            this.groupBox1.Controls.Add(this.search_txtbx);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(25, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 120);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search message";
            // 
            // search_btn
            // 
            this.search_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_btn.Location = new System.Drawing.Point(416, 34);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(175, 80);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // sender_chckbx
            // 
            this.sender_chckbx.AutoSize = true;
            this.sender_chckbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sender_chckbx.Location = new System.Drawing.Point(133, 83);
            this.sender_chckbx.Name = "sender_chckbx";
            this.sender_chckbx.Size = new System.Drawing.Size(147, 31);
            this.sender_chckbx.TabIndex = 1;
            this.sender_chckbx.Text = "By sender";
            this.sender_chckbx.UseVisualStyleBackColor = true;
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(6, 34);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(393, 35);
            this.search_txtbx.TabIndex = 0;
            // 
            // undo_btn
            // 
            this.undo_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.undo_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo_btn.Location = new System.Drawing.Point(628, 644);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(133, 120);
            this.undo_btn.TabIndex = 25;
            this.undo_btn.Text = "Undo";
            this.undo_btn.UseVisualStyleBackColor = false;
            // 
            // subject_grpbx
            // 
            this.subject_grpbx.AutoSize = true;
            this.subject_grpbx.BackColor = System.Drawing.Color.DimGray;
            this.subject_grpbx.Controls.Add(this.subj_id_lbl);
            this.subject_grpbx.Controls.Add(this.subjnme_lbl);
            this.subject_grpbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_grpbx.ForeColor = System.Drawing.Color.Red;
            this.subject_grpbx.Location = new System.Drawing.Point(25, 10);
            this.subject_grpbx.Name = "subject_grpbx";
            this.subject_grpbx.Size = new System.Drawing.Size(280, 153);
            this.subject_grpbx.TabIndex = 28;
            this.subject_grpbx.TabStop = false;
            this.subject_grpbx.Text = "Active subject";
            // 
            // subj_id_lbl
            // 
            this.subj_id_lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subj_id_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subj_id_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subj_id_lbl.ForeColor = System.Drawing.Color.Black;
            this.subj_id_lbl.Location = new System.Drawing.Point(23, 87);
            this.subj_id_lbl.Name = "subj_id_lbl";
            this.subj_id_lbl.Size = new System.Drawing.Size(227, 35);
            this.subj_id_lbl.TabIndex = 29;
            this.subj_id_lbl.Text = "Active subject id";
            this.subj_id_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subjnme_lbl
            // 
            this.subjnme_lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subjnme_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subjnme_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjnme_lbl.ForeColor = System.Drawing.Color.Black;
            this.subjnme_lbl.Location = new System.Drawing.Point(23, 43);
            this.subjnme_lbl.Name = "subjnme_lbl";
            this.subjnme_lbl.Size = new System.Drawing.Size(227, 35);
            this.subjnme_lbl.TabIndex = 28;
            this.subjnme_lbl.Text = "Active subject";
            this.subjnme_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Messagerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::internal_communication.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 774);
            this.Controls.Add(this.subject_grpbx);
            this.Controls.Add(this.undo_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.input_txtbx);
            this.Controls.Add(this.message_lstbx);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Messagerie";
            this.Text = "Messagerie";
            this.Load += new System.EventHandler(this.Messagerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.subject_grpbx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.RichTextBox input_txtbx;
        private System.Windows.Forms.ListBox message_lstbx;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox search_txtbx;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.CheckBox sender_chckbx;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.GroupBox subject_grpbx;
        private System.Windows.Forms.Label subj_id_lbl;
        private System.Windows.Forms.Label subjnme_lbl;
    }
}