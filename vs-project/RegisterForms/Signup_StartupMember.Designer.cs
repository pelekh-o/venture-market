﻿namespace code.RegisterForms
{
    partial class Signup_StartupMember
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBx_Startups = new System.Windows.Forms.ComboBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.rchTxtBx_About = new System.Windows.Forms.RichTextBox();
            this.txt_Twitter = new System.Windows.Forms.TextBox();
            this.txt_Skype = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.chckBx_IsCEO = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.venture_MarketDataSet = new code.Venture_MarketDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new code.Venture_MarketDataSetTableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venture_MarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Startup";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBx_Startups);
            this.panel1.Controls.Add(this.btn_Finish);
            this.panel1.Controls.Add(this.rchTxtBx_About);
            this.panel1.Controls.Add(this.txt_Twitter);
            this.panel1.Controls.Add(this.txt_Skype);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.txt_City);
            this.panel1.Controls.Add(this.txt_Country);
            this.panel1.Controls.Add(this.chckBx_IsCEO);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 345);
            this.panel1.TabIndex = 2;
            // 
            // cmbBx_Startups
            // 
            this.cmbBx_Startups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_Startups.FormattingEnabled = true;
            this.cmbBx_Startups.Location = new System.Drawing.Point(119, 54);
            this.cmbBx_Startups.Name = "cmbBx_Startups";
            this.cmbBx_Startups.Size = new System.Drawing.Size(134, 21);
            this.cmbBx_Startups.TabIndex = 14;
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(253, 281);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 38);
            this.btn_Finish.TabIndex = 13;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.button1_Click);
            // 
            // rchTxtBx_About
            // 
            this.rchTxtBx_About.Location = new System.Drawing.Point(118, 204);
            this.rchTxtBx_About.Name = "rchTxtBx_About";
            this.rchTxtBx_About.Size = new System.Drawing.Size(400, 62);
            this.rchTxtBx_About.TabIndex = 12;
            this.rchTxtBx_About.Text = "";
            // 
            // txt_Twitter
            // 
            this.txt_Twitter.Location = new System.Drawing.Point(383, 151);
            this.txt_Twitter.Name = "txt_Twitter";
            this.txt_Twitter.Size = new System.Drawing.Size(135, 20);
            this.txt_Twitter.TabIndex = 11;
            // 
            // txt_Skype
            // 
            this.txt_Skype.Location = new System.Drawing.Point(383, 107);
            this.txt_Skype.Name = "txt_Skype";
            this.txt_Skype.Size = new System.Drawing.Size(135, 20);
            this.txt_Skype.TabIndex = 11;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(118, 165);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(135, 20);
            this.txt_Phone.TabIndex = 11;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(118, 130);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(135, 20);
            this.txt_City.TabIndex = 11;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(118, 94);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(135, 20);
            this.txt_Country.TabIndex = 10;
            // 
            // chckBx_IsCEO
            // 
            this.chckBx_IsCEO.AutoSize = true;
            this.chckBx_IsCEO.Location = new System.Drawing.Point(394, 50);
            this.chckBx_IsCEO.Name = "chckBx_IsCEO";
            this.chckBx_IsCEO.Size = new System.Drawing.Size(44, 17);
            this.chckBx_IsCEO.TabIndex = 9;
            this.chckBx_IsCEO.Text = "Yes";
            this.chckBx_IsCEO.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Are you CEO?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "About ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Twitter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Skype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country";
            // 
            // venture_MarketDataSet
            // 
            this.venture_MarketDataSet.DataSetName = "Venture_MarketDataSet";
            this.venture_MarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.venture_MarketDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Signup_StartupMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panel1);
            this.Name = "Signup_StartupMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup Member Sign Up - Venture Market";
            this.Load += new System.EventHandler(this.Signup_StartupMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venture_MarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchTxtBx_About;
        private System.Windows.Forms.TextBox txt_Twitter;
        private System.Windows.Forms.TextBox txt_Skype;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.CheckBox chckBx_IsCEO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.ComboBox cmbBx_Startups;
        private Venture_MarketDataSet venture_MarketDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Venture_MarketDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}