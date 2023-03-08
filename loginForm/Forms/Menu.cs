﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.form;

namespace loginForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private User _account;

        public User Source
        {
            get { return _account; }
            set { _account = value; }
        }

        private const int dp = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dp;
                return cp;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Visible = true;
            btn_show.Visible = false;
            btn_hide.Visible = true;
            gunaPanel1.Visible = false;
            gunaPanel1.Width = 204;
            gunaTransition1.ShowSync(gunaPanel1);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Visible = false;
            gunaPanel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            gunaPanel1.Width = 40;
            gunaTransition1.ShowSync(gunaPanel1);
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            BookForm bk = new BookForm();
            AddNewTab(bk);
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            BorrowerForm bw = new BorrowerForm();
            bw.Show();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            TransactionForm tf = new TransactionForm();
            tf.Show();
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }




        private void AddNewTab(Form frm)
        {

            TabPage tab = new TabPage(frm.Text);

            frm.TopLevel = false;

            frm.Parent = tab;

            frm.Visible = true;

            tabControl1.TabPages.Add(tab);

            frm.Location = new Point((tab.Width - frm.Width) / 2, (tab.Height - frm.Height) / 2);

            tabControl1.SelectedTab = tab;

        }

    }
}
