namespace internal_communication
{
    partial class del_confirm
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
            this.confirm_btn = new System.Windows.Forms.Button();
            this.del_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.LightGreen;
            this.confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(373, 176);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(183, 80);
            this.confirm_btn.TabIndex = 0;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // del_txtbx
            // 
            this.del_txtbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.del_txtbx.ForeColor = System.Drawing.Color.Lime;
            this.del_txtbx.Location = new System.Drawing.Point(123, 96);
            this.del_txtbx.Name = "del_txtbx";
            this.del_txtbx.Size = new System.Drawing.Size(433, 26);
            this.del_txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm deletion by typing \'YES\' and submit";
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.return_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(123, 176);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(161, 80);
            this.return_btn.TabIndex = 3;
            this.return_btn.Text = "Return ";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // del_confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 331);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_txtbx);
            this.Controls.Add(this.confirm_btn);
            this.Name = "del_confirm";
            this.Text = "del_confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox del_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_btn;
    }
}