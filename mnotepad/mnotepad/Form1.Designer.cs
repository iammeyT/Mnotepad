namespace mnotepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newfilebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openfilebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.savefilebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copybtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pastebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deletebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.findbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fontbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.setingmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dark = new System.Windows.Forms.ToolStripMenuItem();
            this.light = new System.Windows.Forms.ToolStripMenuItem();
            this.alwayesontop = new System.Windows.Forms.ToolStripMenuItem();
            this.topon = new System.Windows.Forms.ToolStripMenuItem();
            this.topoff = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Maintxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.White;
            this.MenuBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu,
            this.editmenu,
            this.setingmenu});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuBar.Size = new System.Drawing.Size(784, 29);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // filemenu
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newfilebtn,
            this.openfilebtn,
            this.savefilebtn,
            this.saveasbtn,
            this.printbtn,
            this.exitbtn});
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(42, 25);
            this.filemenu.Text = "فایل";
            // 
            // newfilebtn
            // 
            this.newfilebtn.Image = global::mnotepad.Properties.Resources.Mac_Mini_DVD;
            this.newfilebtn.Name = "newfilebtn";
            this.newfilebtn.Size = new System.Drawing.Size(194, 36);
            this.newfilebtn.Text = "فایل جدید";
            this.newfilebtn.Click += new System.EventHandler(this.newfilebtn_Click);
            // 
            // openfilebtn
            // 
            this.openfilebtn.Image = global::mnotepad.Properties.Resources.Favorites_Folder_Black;
            this.openfilebtn.Name = "openfilebtn";
            this.openfilebtn.Size = new System.Drawing.Size(194, 36);
            this.openfilebtn.Text = "بازکردن";
            this.openfilebtn.Click += new System.EventHandler(this.openfilebtn_Click);
            // 
            // savefilebtn
            // 
            this.savefilebtn.Image = global::mnotepad.Properties.Resources.HD_tapa_pegatina_Black;
            this.savefilebtn.Name = "savefilebtn";
            this.savefilebtn.Size = new System.Drawing.Size(194, 36);
            this.savefilebtn.Text = "ذخیره";
            this.savefilebtn.Click += new System.EventHandler(this.savefilebtn_Click);
            // 
            // saveasbtn
            // 
            this.saveasbtn.Image = global::mnotepad.Properties.Resources.HD_DVD_2;
            this.saveasbtn.Name = "saveasbtn";
            this.saveasbtn.Size = new System.Drawing.Size(194, 36);
            this.saveasbtn.Text = "ذخیره به عنوان";
            this.saveasbtn.Click += new System.EventHandler(this.saveasbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.Image = global::mnotepad.Properties.Resources.Documents_Folder_Black;
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(194, 36);
            this.printbtn.Text = "چاپ";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(194, 36);
            this.exitbtn.Text = "خروج";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // editmenu
            // 
            this.editmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copybtn,
            this.pastebtn,
            this.deletebtn,
            this.findbtn,
            this.fontbtn});
            this.editmenu.Name = "editmenu";
            this.editmenu.Size = new System.Drawing.Size(62, 25);
            this.editmenu.Text = "ویرایش";
            // 
            // copybtn
            // 
            this.copybtn.Image = ((System.Drawing.Image)(resources.GetObject("copybtn.Image")));
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(194, 36);
            this.copybtn.Text = "کپی";
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // pastebtn
            // 
            this.pastebtn.Image = global::mnotepad.Properties.Resources.Documents_Folder_Black1;
            this.pastebtn.Name = "pastebtn";
            this.pastebtn.Size = new System.Drawing.Size(194, 36);
            this.pastebtn.Text = "چسباندن";
            this.pastebtn.Click += new System.EventHandler(this.pastebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Image = global::mnotepad.Properties.Resources.System_Folder_Alt;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(194, 36);
            this.deletebtn.Text = "حذف";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // findbtn
            // 
            this.findbtn.Image = global::mnotepad.Properties.Resources.Sites_Folder_Black;
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(194, 36);
            this.findbtn.Text = "یافتن";
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // fontbtn
            // 
            this.fontbtn.Image = global::mnotepad.Properties.Resources.Applications_Folder_Black;
            this.fontbtn.Name = "fontbtn";
            this.fontbtn.Size = new System.Drawing.Size(194, 36);
            this.fontbtn.Text = "فونت";
            this.fontbtn.Click += new System.EventHandler(this.fontbtn_Click);
            // 
            // setingmenu
            // 
            this.setingmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dark,
            this.light,
            this.alwayesontop,
            this.aboutbtn});
            this.setingmenu.Name = "setingmenu";
            this.setingmenu.Size = new System.Drawing.Size(63, 25);
            this.setingmenu.Text = "تنظیمات";
            // 
            // dark
            // 
            this.dark.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(185, 26);
            this.dark.Text = "حالت شب";
            this.dark.Click += new System.EventHandler(this.dark_Click);
            // 
            // light
            // 
            this.light.Checked = true;
            this.light.CheckState = System.Windows.Forms.CheckState.Checked;
            this.light.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(185, 26);
            this.light.Text = "حالت روز";
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // alwayesontop
            // 
            this.alwayesontop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topon,
            this.topoff});
            this.alwayesontop.Name = "alwayesontop";
            this.alwayesontop.Size = new System.Drawing.Size(185, 26);
            this.alwayesontop.Text = "نمایش روی صفحات";
            // 
            // topon
            // 
            this.topon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topon.Name = "topon";
            this.topon.Size = new System.Drawing.Size(117, 26);
            this.topon.Text = "روشن";
            this.topon.Click += new System.EventHandler(this.topon_Click);
            // 
            // topoff
            // 
            this.topoff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.topoff.Name = "topoff";
            this.topoff.Size = new System.Drawing.Size(117, 26);
            this.topoff.Text = "خاموش";
            this.topoff.Click += new System.EventHandler(this.topoff_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(185, 26);
            this.aboutbtn.Text = "در مورد من";
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // Maintxt
            // 
            this.Maintxt.AcceptsTab = true;
            this.Maintxt.BackColor = System.Drawing.SystemColors.Window;
            this.Maintxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Maintxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintxt.Location = new System.Drawing.Point(0, 29);
            this.Maintxt.Margin = new System.Windows.Forms.Padding(0);
            this.Maintxt.MaxLength = 327670;
            this.Maintxt.Multiline = true;
            this.Maintxt.Name = "Maintxt";
            this.Maintxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Maintxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Maintxt.Size = new System.Drawing.Size(784, 532);
            this.Maintxt.TabIndex = 1;
            this.Maintxt.TextChanged += new System.EventHandler(this.Maintxt_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Maintxt);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mnotepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem filemenu;
        private System.Windows.Forms.ToolStripMenuItem openfilebtn;
        private System.Windows.Forms.ToolStripMenuItem savefilebtn;
        private System.Windows.Forms.ToolStripMenuItem saveasbtn;
        private System.Windows.Forms.ToolStripMenuItem newfilebtn;
        private System.Windows.Forms.ToolStripMenuItem printbtn;
        private System.Windows.Forms.ToolStripMenuItem editmenu;
        private System.Windows.Forms.ToolStripMenuItem copybtn;
        private System.Windows.Forms.ToolStripMenuItem pastebtn;
        private System.Windows.Forms.ToolStripMenuItem deletebtn;
        private System.Windows.Forms.ToolStripMenuItem findbtn;
        private System.Windows.Forms.ToolStripMenuItem fontbtn;
        private System.Windows.Forms.ToolStripMenuItem setingmenu;
        private System.Windows.Forms.ToolStripMenuItem light;
        private System.Windows.Forms.ToolStripMenuItem alwayesontop;
        private System.Windows.Forms.ToolStripMenuItem dark;
        private System.Windows.Forms.ToolStripMenuItem topon;
        private System.Windows.Forms.ToolStripMenuItem topoff;
        private System.Windows.Forms.TextBox Maintxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutbtn;
        private System.Windows.Forms.ToolStripMenuItem exitbtn;
    }
}

