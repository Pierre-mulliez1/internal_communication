namespace internal_communication.Forms
{
    partial class subject_create
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
            this.subject_txtbx = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subject_txtbx
            // 
            this.subject_txtbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.subject_txtbx.ForeColor = System.Drawing.SystemColors.Window;
            this.subject_txtbx.Location = new System.Drawing.Point(299, 142);
            this.subject_txtbx.Name = "subject_txtbx";
            this.subject_txtbx.Size = new System.Drawing.Size(380, 35);
            this.subject_txtbx.TabIndex = 0;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.create_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(299, 232);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(380, 99);
            this.create_btn.TabIndex = 1;
            this.create_btn.Text = "CREATE";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(30, 140);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(236, 46);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Subject name :";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.back_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(941, 470);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(273, 108);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            // 
            // subject_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::internal_communication.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 608);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.subject_txtbx);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "subject_create";
            this.Text = "subject_create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject_txtbx;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button back_btn;
    }
}