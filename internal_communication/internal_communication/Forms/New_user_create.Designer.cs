namespace internal_communication
{
    partial class New_user_create
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
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.connection1_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.postion_txtbx = new System.Windows.Forms.TextBox();
            this.name_txbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deluser_txtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Confirm_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(12, 403);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(449, 96);
            this.Confirm_btn.TabIndex = 6;
            this.Confirm_btn.Text = "CREATE";
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // connection1_lbl
            // 
            this.connection1_lbl.AutoSize = true;
            this.connection1_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection1_lbl.Location = new System.Drawing.Point(794, 162);
            this.connection1_lbl.Name = "connection1_lbl";
            this.connection1_lbl.Size = new System.Drawing.Size(208, 29);
            this.connection1_lbl.TabIndex = 7;
            this.connection1_lbl.Text = "Connection state";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ID_txtbx);
            this.groupBox1.Controls.Add(this.name_txbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password_txtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.postion_txtbx);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 306);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Position";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ID_txtbx
            // 
            this.ID_txtbx.Location = new System.Drawing.Point(261, 210);
            this.ID_txtbx.Name = "ID_txtbx";
            this.ID_txtbx.Size = new System.Drawing.Size(128, 35);
            this.ID_txtbx.TabIndex = 17;
            this.ID_txtbx.TextChanged += new System.EventHandler(this.ID_txtbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "User ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // postion_txtbx
            // 
            this.postion_txtbx.Location = new System.Drawing.Point(261, 97);
            this.postion_txtbx.Name = "postion_txtbx";
            this.postion_txtbx.Size = new System.Drawing.Size(128, 35);
            this.postion_txtbx.TabIndex = 13;
            this.postion_txtbx.TextChanged += new System.EventHandler(this.postion_txtbx_TextChanged);
            // 
            // name_txbx
            // 
            this.name_txbx.Location = new System.Drawing.Point(48, 97);
            this.name_txbx.Name = "name_txbx";
            this.name_txbx.Size = new System.Drawing.Size(114, 35);
            this.name_txbx.TabIndex = 12;
            this.name_txbx.TextChanged += new System.EventHandler(this.name_txbx_TextChanged);
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(48, 210);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(113, 35);
            this.password_txtbx.TabIndex = 11;
            this.password_txtbx.TextChanged += new System.EventHandler(this.password_txtbx_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deluser_txtbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(502, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 201);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // deluser_txtbx
            // 
            this.deluser_txtbx.Location = new System.Drawing.Point(61, 93);
            this.deluser_txtbx.Name = "deluser_txtbx";
            this.deluser_txtbx.Size = new System.Drawing.Size(321, 35);
            this.deluser_txtbx.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(176, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "User ID";
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.del_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(502, 403);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(449, 96);
            this.del_btn.TabIndex = 20;
            this.del_btn.Text = "DELETE";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // New_user_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::internal_communication.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 645);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connection1_lbl);
            this.Controls.Add(this.Confirm_btn);
            this.DoubleBuffered = true;
            this.Name = "New_user_create";
            this.Text = "New_user_create";
            this.Load += new System.EventHandler(this.New_user_create_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label connection1_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox postion_txtbx;
        private System.Windows.Forms.TextBox name_txbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox deluser_txtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button del_btn;
    }
}