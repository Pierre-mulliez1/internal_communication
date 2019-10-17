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
            this.label1 = new System.Windows.Forms.Label();
            this.find_btn = new System.Windows.Forms.Button();
            this.byyear_chckbx = new System.Windows.Forms.CheckBox();
            this.project_list = new System.Windows.Forms.ListBox();
            this.project_txtbx = new System.Windows.Forms.TextBox();
            this.go_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.nwnm_txtbx = new System.Windows.Forms.TextBox();
            this.nwcat_txtbx = new System.Windows.Forms.TextBox();
            this.nwyr_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(238, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your project?";
            // 
            // find_btn
            // 
            this.find_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.Location = new System.Drawing.Point(777, 9);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(203, 73);
            this.find_btn.TabIndex = 1;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // byyear_chckbx
            // 
            this.byyear_chckbx.AutoSize = true;
            this.byyear_chckbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.byyear_chckbx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byyear_chckbx.Location = new System.Drawing.Point(474, 7);
            this.byyear_chckbx.Name = "byyear_chckbx";
            this.byyear_chckbx.Padding = new System.Windows.Forms.Padding(20);
            this.byyear_chckbx.Size = new System.Drawing.Size(208, 73);
            this.byyear_chckbx.TabIndex = 2;
            this.byyear_chckbx.Text = "By project year";
            this.byyear_chckbx.UseVisualStyleBackColor = false;
            // 
            // project_list
            // 
            this.project_list.BackColor = System.Drawing.SystemColors.MenuText;
            this.project_list.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.project_list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_list.ForeColor = System.Drawing.Color.Lime;
            this.project_list.FormattingEnabled = true;
            this.project_list.ItemHeight = 27;
            this.project_list.Location = new System.Drawing.Point(12, 91);
            this.project_list.Name = "project_list";
            this.project_list.Size = new System.Drawing.Size(743, 328);
            this.project_list.TabIndex = 3;
            this.project_list.UseWaitCursor = true;
            this.project_list.SelectedIndexChanged += new System.EventHandler(this.project_list_SelectedIndexChanged);
            // 
            // project_txtbx
            // 
            this.project_txtbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.project_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_txtbx.ForeColor = System.Drawing.Color.Lime;
            this.project_txtbx.Location = new System.Drawing.Point(272, 33);
            this.project_txtbx.Name = "project_txtbx";
            this.project_txtbx.Size = new System.Drawing.Size(174, 30);
            this.project_txtbx.TabIndex = 4;
            // 
            // go_btn
            // 
            this.go_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_btn.Location = new System.Drawing.Point(761, 281);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(122, 150);
            this.go_btn.TabIndex = 5;
            this.go_btn.Text = "Go to project";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_btn.Location = new System.Drawing.Point(777, 91);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(203, 73);
            this.new_btn.TabIndex = 6;
            this.new_btn.Text = "New project";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // nwnm_txtbx
            // 
            this.nwnm_txtbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.nwnm_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwnm_txtbx.ForeColor = System.Drawing.Color.Lime;
            this.nwnm_txtbx.Location = new System.Drawing.Point(858, 170);
            this.nwnm_txtbx.Name = "nwnm_txtbx";
            this.nwnm_txtbx.Size = new System.Drawing.Size(122, 30);
            this.nwnm_txtbx.TabIndex = 7;
            // 
            // nwcat_txtbx
            // 
            this.nwcat_txtbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.nwcat_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwcat_txtbx.ForeColor = System.Drawing.Color.Lime;
            this.nwcat_txtbx.Location = new System.Drawing.Point(858, 242);
            this.nwcat_txtbx.Name = "nwcat_txtbx";
            this.nwcat_txtbx.Size = new System.Drawing.Size(122, 30);
            this.nwcat_txtbx.TabIndex = 8;
            // 
            // nwyr_txtbx
            // 
            this.nwyr_txtbx.BackColor = System.Drawing.SystemColors.MenuText;
            this.nwyr_txtbx.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwyr_txtbx.ForeColor = System.Drawing.Color.Lime;
            this.nwyr_txtbx.Location = new System.Drawing.Point(858, 206);
            this.nwyr_txtbx.Name = "nwyr_txtbx";
            this.nwyr_txtbx.Size = new System.Drawing.Size(122, 30);
            this.nwyr_txtbx.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(889, 281);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(126, 150);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "Delete project";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // project_selection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 461);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nwyr_txtbx);
            this.Controls.Add(this.nwcat_txtbx);
            this.Controls.Add(this.nwnm_txtbx);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.project_txtbx);
            this.Controls.Add(this.project_list);
            this.Controls.Add(this.byyear_chckbx);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.label1);
            this.Name = "project_selection_form";
            this.Text = "project select";
            this.Load += new System.EventHandler(this.project_selection_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.CheckBox byyear_chckbx;
        private System.Windows.Forms.ListBox project_list;
        private System.Windows.Forms.TextBox project_txtbx;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.TextBox nwnm_txtbx;
        private System.Windows.Forms.TextBox nwcat_txtbx;
        private System.Windows.Forms.TextBox nwyr_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button del_btn;
    }
}

