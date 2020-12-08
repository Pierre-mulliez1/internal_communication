namespace internal_communication
{
    partial class usercreation_psw
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
            this.psw_txtbx = new System.Windows.Forms.TextBox();
            this.nxt_btn = new System.Windows.Forms.Button();
            this.bck_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authetification\'s password required";
            // 
            // psw_txtbx
            // 
            this.psw_txtbx.Location = new System.Drawing.Point(196, 122);
            this.psw_txtbx.Name = "psw_txtbx";
            this.psw_txtbx.PasswordChar = '*';
            this.psw_txtbx.Size = new System.Drawing.Size(327, 26);
            this.psw_txtbx.TabIndex = 1;
            // 
            // nxt_btn
            // 
            this.nxt_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nxt_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxt_btn.Location = new System.Drawing.Point(625, 297);
            this.nxt_btn.Name = "nxt_btn";
            this.nxt_btn.Size = new System.Drawing.Size(131, 59);
            this.nxt_btn.TabIndex = 2;
            this.nxt_btn.Text = "NEXT";
            this.nxt_btn.UseVisualStyleBackColor = false;
            this.nxt_btn.Click += new System.EventHandler(this.nxt_btn_Click);
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bck_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bck_btn.Location = new System.Drawing.Point(484, 297);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(131, 59);
            this.bck_btn.TabIndex = 3;
            this.bck_btn.Text = "BACK";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // usercreation_psw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 368);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.nxt_btn);
            this.Controls.Add(this.psw_txtbx);
            this.Controls.Add(this.label1);
            this.Name = "usercreation_psw";
            this.Text = "usercreation_psw";
            this.Load += new System.EventHandler(this.usercreation_psw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox psw_txtbx;
        private System.Windows.Forms.Button nxt_btn;
        private System.Windows.Forms.Button bck_btn;
    }
}