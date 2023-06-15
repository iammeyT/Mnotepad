using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace mnotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dark_Click(object sender, EventArgs e)
        {
            if (dark.Checked = true)
            {
                Maintxt.BackColor = Color.Black;
                Maintxt.ForeColor = Color.White;
                light.Checked = false;
                MenuBar.BackColor = Color.Black;
                MenuBar.ForeColor = Color.White;
            }
        }
        private void light_Click(object sender, EventArgs e)
        {
            if (light.Checked = true)
            {
                Maintxt.BackColor = SystemColors.Window;
                Maintxt.ForeColor = Color.Black;
                dark.Checked = false;
            }
        }
        private void topon_Click(object sender, EventArgs e)
        {
            if (topon.Checked = true)
            {
                this.TopMost = true;
                topon.Checked = true;
                topoff.Checked = false;
            }
        }
        private void topoff_Click(object sender, EventArgs e)
        {
            if (topoff.Checked = true)
            {
                this.TopMost = false;
                topoff.Checked = true;
                topon.Checked = false;
            }
        }
        private void aboutbtn_Click(object sender, EventArgs e)
        {
            aboutform af = new aboutform();
            af.ShowDialog();
        }

        string forsaving = "";
        bool changed = false;
        DialogResult dr;

        private void newfilebtn_Click(object sender, EventArgs e)
        {
            if (Maintxt.Text != "")
            {

                dr = MessageBox.Show("?ایا میخواهید نوشته خود را ذخیره کنید", "توجه", MessageBoxButtons.YesNoCancel);


                if (dr == DialogResult.Yes)
                {
                    if (forsaving != null)
                    {
                        saveasbtn_Click(null, null);
                        Maintxt.Text = "";
                    }
                    else
                    {
                        savefilebtn_Click(null, null);
                        Maintxt.Text = "";
                    }
                }

                else if (dr == DialogResult.No)
                {
                    Maintxt.Text = "";
                    changed = false;

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("نوت پد خالی است میتوانید تایپ کنید", "خطا");
                Maintxt.Text = "";
            }
        }

        private void openfilebtn_Click(object sender, EventArgs e)
        {
            if (Maintxt.Text != "")
            {
                newfilebtn_Click(null, null);
                this.Text = openFileDialog1.SafeFileName;
            }
            else if (Maintxt.Text == "")
            {
                try
                {
                    openFileDialog1.Filter = "Text|*.txt";
                    openFileDialog1.Title = "Select text";
                    openFileDialog1.FileName = "";
                    openFileDialog1.ShowDialog();
                    Maintxt.Text = File.ReadAllText(openFileDialog1.FileName);
                    forsaving = openFileDialog1.FileName;
                    this.Text = openFileDialog1.SafeFileName;
                }
                catch
                {

                }
            }
        }

        private void savefilebtn_Click(object sender, EventArgs e)
        {
            if (Maintxt.Text == "")
            {
                MessageBox.Show("نوت پد خالی است", "خطا");
            }

            else
            {
                saveFileDialog1.Filter = "Text|*.txt";
                saveFileDialog1.Title = "save";
                if (forsaving == "")
                {
                    saveasbtn_Click(null, null);
                }
                else
                {
                    File.WriteAllText(forsaving, Maintxt.Text);
                }
            }
        }

        private void saveasbtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text|*.txt";
                saveFileDialog1.Title = "save";
                saveFileDialog1.ShowDialog();
                File.WriteAllText(saveFileDialog1.FileName, Maintxt.Text);
                forsaving = saveFileDialog1.FileName;
            }
            catch
            {

            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (Maintxt.Text == "")
            {
                Application.Exit();
            }
            else
            {
                openfilebtn_Click(null, null);
                Application.Exit();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Maintxt.SelectedText = "";
        }
        private void fontbtn_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Maintxt.Font = fontDialog1.Font;
        }

        private void Maintxt_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                if (Maintxt.Text != "")
                {
                    dr = MessageBox.Show("?ایا میخواهید نوشته خود را ذخیره کنید", "توجه", MessageBoxButtons.YesNoCancel);

                    if (dr == DialogResult.Yes)
                    {
                        if (forsaving != null)
                        {
                            saveasbtn_Click(null, null);
                            Maintxt.Text = "";
                        }
                        else
                        {
                            savefilebtn_Click(null, null);
                            Maintxt.Text = "";
                        }
                    }

                    else if (dr == DialogResult.No)
                    {
                        Maintxt.Text = "";
                        changed = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {

                }
            }
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Maintxt.SelectedText);
            }
            catch { }
        }

        private void pastebtn_Click(object sender, EventArgs e)
        {
            Clipboard.GetText();
            Maintxt.SelectedText = Clipboard.GetText();
        }


        private void setingmenu_MouseHover(object sender, EventArgs e)
        {
            setingmenu.BackColor = Color.Red;
        }
    }
}
