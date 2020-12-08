namespace internal_communication
{
    partial class login_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.User_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.nxt_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.connection_lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // User_txtbx
            // 
            this.User_txtbx.Location = new System.Drawing.Point(225, 119);
            this.User_txtbx.Name = "User_txtbx";
            this.User_txtbx.Size = new System.Drawing.Size(156, 35);
            this.User_txtbx.TabIndex = 2;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(225, 201);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.PasswordChar = '*';
            this.password_txtbx.Size = new System.Drawing.Size(156, 35);
            this.password_txtbx.TabIndex = 3;
            this.password_txtbx.TextChanged += new System.EventHandler(this.password_txtbx_TextChanged);
            // 
            // nxt_btn
            // 
            this.nxt_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nxt_btn.Location = new System.Drawing.Point(586, 325);
            this.nxt_btn.Name = "nxt_btn";
            this.nxt_btn.Size = new System.Drawing.Size(183, 95);
            this.nxt_btn.TabIndex = 4;
            this.nxt_btn.Text = "NEXT";
            this.nxt_btn.UseVisualStyleBackColor = false;
            this.nxt_btn.Click += new System.EventHandler(this.nxt_btn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to Messaginf !";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(122, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 95);
            this.button1.TabIndex = 6;
            this.button1.Text = "HELP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connection_lbl
            // 
            this.connection_lbl.AutoSize = true;
            this.connection_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connection_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_lbl.Location = new System.Drawing.Point(540, 119);
            this.connection_lbl.Name = "connection_lbl";
            this.connection_lbl.Size = new System.Drawing.Size(158, 34);
            this.connection_lbl.TabIndex = 7;
            this.connection_lbl.Text = "Connection";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(311, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 95);
            this.button2.TabIndex = 8;
            this.button2.Text = "CREATE | DELETE USER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::internal_communication.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.connection_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nxt_btn);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.User_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "login_form";
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Button nxt_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label connection_lbl;
        private System.Windows.Forms.Button button2;
    }
}