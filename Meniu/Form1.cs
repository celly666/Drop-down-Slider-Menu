using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;




namespace Meniu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;   
            panelToolssubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if(panelMediaSubmenu.Visible==true )
                panelMediaSubmenu.Visible=false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolssubmenu.Visible == true)
                panelToolssubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2()); 
            //...
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void Btnplaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPlaylistSubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //...
            hideSubmenu();
        }

        private void btntools_Click(object sender, EventArgs e)
        {
            showSubmenu(panelToolssubmenu);
        }
         
        private void button15_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}