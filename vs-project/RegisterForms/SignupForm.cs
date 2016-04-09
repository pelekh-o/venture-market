﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace code
{
    public partial class SignInForm : Form
    {
        private DataClasses1DataContext vmDB;
        private User user;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        private RadioButton radioBtn = new RadioButton();
        public SignInForm()
        {
            InitializeComponent();
            rdBttn_AngelInvestor.Checked = true;
            rdBttn_InvManager.Checked = false;
            rdBttn_Startuper.Checked = false;
            rdBttn_CompanyMemeber.Checked = false;
        }
        
        private void btnTop_Login_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            vmDB = new DataClasses1DataContext();
            
            var usr = vmDB.Users.Where(u => u.Username.Equals(txt_Username.Text)).Select(u => u.Username);
            var mail = vmDB.Users.Where(u => u.Email.Equals(txt_Email.Text)).Select(u => u.Email);

            if(usr.Count() != 0)
            {
                logger.Info("User with choosen username is already registered[{0}]", txt_Username.Text);
                MessageBox.Show("User with username [" + txt_Username.Text + "] is already registered.\n"
                     + "Please choose another username.");
            }
            else if(mail.Count() != 0)
            {
                logger.Info("User with choosen mail is already registered[{0}]", txt_Email.Text);
                MessageBox.Show("User with mail [" + txt_Email.Text + "] is already registered.\n");
            }
            else if(txt_Password.Text == "" || txt_Password.TextLength < 6)
            {
                MessageBox.Show("Password is too short.\nMinimum length is 6 symbols");
            }
            else if (txt_Password.Text != txt_PasswordConfirm.Text)
            {
                MessageBox.Show("Passwords are not the same");
            }
            else
            {
                user = new User();
                user.Username = txt_Username.Text;
                user.Password = txt_Password.Text;
                user.Email = txt_Email.Text;
                user.FName = txt_FName.Text;
                user.LName = txt_LName.Text;
                user.RegDate = DateTime.Now;
                user.LoggedDate = DateTime.Now;
                vmDB.Users.InsertOnSubmit(user);
                try
                {
                    vmDB.SubmitChanges();
                    pnl_Sign_Role.Show();
                    pnl_Sign1.Hide();
                }
                catch(Exception ex)
                {
                    logger.Error(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_BackToSign1_Click(object sender, EventArgs e)
        {
            pnl_Sign_Role.Hide();
            pnl_Sign1.Show();
        }
        
        private void btn_NextToSpec_Click(object sender, EventArgs e)
        {
            if (rdBttn_AngelInvestor.Checked == true)
            {
                vmDB = new DataClasses1DataContext();
                RegisterForms.Signup_AngelInv s_ai = new RegisterForms.Signup_AngelInv(user);
                s_ai.Show();
                this.Hide();
            }
            else
            if (rdBttn_InvManager.Checked == true)
            {
                vmDB = new DataClasses1DataContext();
                RegisterForms.Signup_InvestManager s_im = new RegisterForms.Signup_InvestManager(user);                
                s_im.Show();
                this.Hide();
            }
            else
            if (rdBttn_Startuper.Checked == true)
            {
                vmDB = new DataClasses1DataContext();
                RegisterForms.Signup_StartupMember s_sm = new RegisterForms.Signup_StartupMember(user);
                s_sm.Show();
                this.Hide();
            }
            else
            if (rdBttn_CompanyMemeber.Checked == true)
            {
                vmDB = new DataClasses1DataContext();
                RegisterForms.Signup_CompanyMember s_cm = new RegisterForms.Signup_CompanyMember();
                
                s_cm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error!");
        }
    }
}