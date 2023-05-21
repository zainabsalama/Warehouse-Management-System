namespace Company_Project
{
    partial class Suppliers_Form
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.site_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.fax_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(174, 91);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Insert_btn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Insert_btn.Location = new System.Drawing.Point(272, 315);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(75, 33);
            this.Insert_btn.TabIndex = 2;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(181, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(310, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(443, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fax";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(537, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(650, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "WebSite";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(48, 91);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 8;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // site_txt
            // 
            this.site_txt.Location = new System.Drawing.Point(636, 91);
            this.site_txt.Name = "site_txt";
            this.site_txt.Size = new System.Drawing.Size(100, 20);
            this.site_txt.TabIndex = 9;
            this.site_txt.TextChanged += new System.EventHandler(this.site_txt_TextChanged);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(290, 210);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 20);
            this.phone_txt.TabIndex = 10;
            this.phone_txt.TextChanged += new System.EventHandler(this.phone_txt_TextChanged);
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(511, 91);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 11;
            this.email_txt.TextChanged += new System.EventHandler(this.email_txt_TextChanged);
            // 
            // fax_txt
            // 
            this.fax_txt.Location = new System.Drawing.Point(403, 210);
            this.fax_txt.Name = "fax_txt";
            this.fax_txt.Size = new System.Drawing.Size(100, 20);
            this.fax_txt.TabIndex = 12;
            this.fax_txt.TextChanged += new System.EventHandler(this.fax_txt_TextChanged);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_btn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Location = new System.Drawing.Point(422, 315);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 33);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Suppliers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.fax_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.site_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt);
            this.Name = "Suppliers_Form";
            this.Text = "Suppliers_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox site_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox fax_txt;
        private System.Windows.Forms.Button update_btn;
    }
}