using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_14_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------------
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new
            txtText.Text = "";
        }
        //---------------------------------------------------------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open
            MessageBox.Show("This is Open Menu!");
        }
        //---------------------------------------------------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save
            MessageBox.Show("This is Save Menu!");
        }
        //---------------------------------------------------------------------------------
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save as
            MessageBox.Show("This is Save As... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //page setup
            MessageBox.Show("This is Page Setup... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print
            MessageBox.Show("This is Print... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }
        //---------------------------------------------------------------------------------
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //undo
            txtText.Undo();
        }
        //---------------------------------------------------------------------------------
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cut
            txtText.Cut();
        }
        //---------------------------------------------------------------------------------
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //copy
            txtText.Copy();
        }
        //---------------------------------------------------------------------------------
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //paste
            txtText.Paste();
        }
        //---------------------------------------------------------------------------------
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete
            txtText.SelectedText = "";
        }
        //---------------------------------------------------------------------------------
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //find
            MessageBox.Show("This is Find... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //find next
            MessageBox.Show("This is Find Next Menu!");
        }
        //---------------------------------------------------------------------------------
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //replace
            MessageBox.Show("This is Replace... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //go to
            MessageBox.Show("This is Go To... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select all
            txtText.SelectAll();
        }
        //---------------------------------------------------------------------------------
        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //time/date
            txtText.SelectedText = DateTime.Now.ToString();
        }
        //---------------------------------------------------------------------------------
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wordwrap
            txtText.WordWrap = !txtText.WordWrap;
            wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
            statusBarToolStripMenuItem.Enabled = !statusBarToolStripMenuItem.Enabled;
        }
        //---------------------------------------------------------------------------------
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //font
            MessageBox.Show("This is Font... Menu!");
        }
        //---------------------------------------------------------------------------------
        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //status bar
            MessageBox.Show("This is Status Bar Menu!");
        }
        //---------------------------------------------------------------------------------
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //view help
            MessageBox.Show("This is View Help Menu!");
        }
        //---------------------------------------------------------------------------------
        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about notepad
            MessageBox.Show("This is About Notepad Menu!");
        }
        //---------------------------------------------------------------------------------
        private void farsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //farsi or english
            if (farsiToolStripMenuItem.Text=="F&arsi")
            {
                farsiToolStripMenuItem.Text = "&انگلیسی";
                this.RightToLeft = RightToLeft.Yes;
                fileToolStripMenuItem.Text = "&فایل";
                newToolStripMenuItem.Text = "&جدید";
                openToolStripMenuItem.Text = "&باز کردن فایل...";
                saveToolStripMenuItem.Text = "&ذخیره کردن";
                saveAsToolStripMenuItem.Text = "ذخیره &مجدد...";
                pageSetupToolStripMenuItem.Text = "&آماده سازی صفحه...";
                printToolStripMenuItem.Text = "&چاپ...";
                exitToolStripMenuItem.Text = "&خروج";
                editToolStripMenuItem.Text = "&ویرایش";
                undoToolStripMenuItem.Text = "&خنثی کردن عمل";
                cutToolStripMenuItem.Text = "&برش";
                copyToolStripMenuItem.Text = "&کپی";
                pasteToolStripMenuItem.Text = "&چسباندن";
                deleteToolStripMenuItem.Text = "&حذف";
                findToolStripMenuItem.Text = "&پیدا کردن...";
                findNextToolStripMenuItem.Text = "پیدا کردن ب&عدی";
                replaceToolStripMenuItem.Text = "&جایگزین...";
                goToToolStripMenuItem.Text = "&رفتن به...";
                selectAllToolStripMenuItem.Text = "&انتخاب همه";
                timeDateToolStripMenuItem.Text = "&تاریخ/زمان";
                formatToolStripMenuItem.Text = "&قالب بندی";
                wordWrapToolStripMenuItem.Text = "&شکستن خط";
                fontToolStripMenuItem.Text = "&فونت...";
                viewToolStripMenuItem.Text = "&نمایش";
                statusBarToolStripMenuItem.Text = "&نوار وضعیت";
                helpToolStripMenuItem.Text = "&راهنما";
                viewHelpToolStripMenuItem.Text = "&نمایش راهنما";
                aboutNotepadToolStripMenuItem.Text = "&درباره ی ویرایشگر";
            }
            else
            {
                farsiToolStripMenuItem.Text = "F&arsi";
                this.RightToLeft = RightToLeft.No;
                fileToolStripMenuItem.Text = "&File";
                newToolStripMenuItem.Text = "&New";
                openToolStripMenuItem.Text = "&Open...";
                saveToolStripMenuItem.Text = "&Save";
                saveAsToolStripMenuItem.Text = "Save &As...";
                pageSetupToolStripMenuItem.Text = "Page Set&up...";
                printToolStripMenuItem.Text = "&Print...";
                exitToolStripMenuItem.Text = "E&xit";
                editToolStripMenuItem.Text = "&Edit";
                undoToolStripMenuItem.Text = "&Undo";
                cutToolStripMenuItem.Text = "Cu&t";
                copyToolStripMenuItem.Text = "&Copy";
                pasteToolStripMenuItem.Text = "&Paste";
                deleteToolStripMenuItem.Text = "De&lete";
                findToolStripMenuItem.Text = "&Find...";
                findNextToolStripMenuItem.Text = "Find &Next";
                replaceToolStripMenuItem.Text = "&Replace...";
                goToToolStripMenuItem.Text = "&Go To...";
                selectAllToolStripMenuItem.Text = "Select &All";
                timeDateToolStripMenuItem.Text = "Time/&Date";
                formatToolStripMenuItem.Text = "F&ormat";
                wordWrapToolStripMenuItem.Text = "&WordWrap";
                fontToolStripMenuItem.Text = "&Font...";
                viewToolStripMenuItem.Text = "&View";
                statusBarToolStripMenuItem.Text = "&Status Bar";
                helpToolStripMenuItem.Text = "&Help";
                viewHelpToolStripMenuItem.Text = "View &Help";
                aboutNotepadToolStripMenuItem.Text = "&About Notepad";
            }
        }
        //---------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //load form
            undoToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.Enabled = false;
            findNextToolStripMenuItem.Enabled = false;
        }
        //---------------------------------------------------------------------------------
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            //textchange txtText
            undoToolStripMenuItem.Enabled = true;
            if (txtText.Text == "")
            {
                findNextToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
            }
            else//!=""
            {
                findNextToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
            }
        }
        //---------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer for enable or disable cut,copy and delete menu
            if (txtText.SelectedText.Length != 0)
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }
    }
}
