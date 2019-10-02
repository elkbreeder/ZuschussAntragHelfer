namespace ZuschussAntragHelfer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonstigesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.radioButtonSurename = new System.Windows.Forms.RadioButton();
            this.radioButtonForname = new System.Windows.Forms.RadioButton();
            this.checkBoxTutor = new System.Windows.Forms.CheckBox();
            this.checkBoxNight = new System.Windows.Forms.CheckBox();
            this.textBoxNight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.sonstigesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // sonstigesToolStripMenuItem
            // 
            this.sonstigesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.sonstigesToolStripMenuItem.Name = "sonstigesToolStripMenuItem";
            this.sonstigesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.sonstigesToolStripMenuItem.Text = "Sonstiges";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(254, 249);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(96, 31);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Auswählen";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(12, 189);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(78, 17);
            this.labelInformation.TabIndex = 3;
            this.labelInformation.Text = "Information";
            // 
            // radioButtonSurename
            // 
            this.radioButtonSurename.AutoSize = true;
            this.radioButtonSurename.Checked = true;
            this.radioButtonSurename.Location = new System.Drawing.Point(15, 31);
            this.radioButtonSurename.Name = "radioButtonSurename";
            this.radioButtonSurename.Size = new System.Drawing.Size(189, 21);
            this.radioButtonSurename.TabIndex = 6;
            this.radioButtonSurename.TabStop = true;
            this.radioButtonSurename.Text = "Bei Nachnamen sortieren";
            this.radioButtonSurename.UseVisualStyleBackColor = false;
            this.radioButtonSurename.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonForname
            // 
            this.radioButtonForname.AutoSize = true;
            this.radioButtonForname.Location = new System.Drawing.Point(15, 58);
            this.radioButtonForname.Name = "radioButtonForname";
            this.radioButtonForname.Size = new System.Drawing.Size(178, 21);
            this.radioButtonForname.TabIndex = 7;
            this.radioButtonForname.Text = "Bei Vornamen sortieren";
            this.radioButtonForname.UseVisualStyleBackColor = false;
            this.radioButtonForname.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // checkBoxTutor
            // 
            this.checkBoxTutor.AutoSize = true;
            this.checkBoxTutor.Location = new System.Drawing.Point(15, 105);
            this.checkBoxTutor.Name = "checkBoxTutor";
            this.checkBoxTutor.Size = new System.Drawing.Size(196, 21);
            this.checkBoxTutor.TabIndex = 8;
            this.checkBoxTutor.Text = "Betreuer (Alter auslassen)";
            this.checkBoxTutor.UseVisualStyleBackColor = true;
            // 
            // checkBoxNight
            // 
            this.checkBoxNight.AutoSize = true;
            this.checkBoxNight.Location = new System.Drawing.Point(15, 145);
            this.checkBoxNight.Name = "checkBoxNight";
            this.checkBoxNight.Size = new System.Drawing.Size(197, 21);
            this.checkBoxNight.TabIndex = 9;
            this.checkBoxNight.Text = "Übernachtungen ausfüllen";
            this.checkBoxNight.UseVisualStyleBackColor = true;
            this.checkBoxNight.CheckedChanged += new System.EventHandler(this.checkBoxNight_CheckedChanged);
            // 
            // textBoxNight
            // 
            this.textBoxNight.Enabled = false;
            this.textBoxNight.Location = new System.Drawing.Point(254, 144);
            this.textBoxNight.Name = "textBoxNight";
            this.textBoxNight.Size = new System.Drawing.Size(64, 22);
            this.textBoxNight.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(15, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNight);
            this.Controls.Add(this.checkBoxNight);
            this.Controls.Add(this.checkBoxTutor);
            this.Controls.Add(this.radioButtonForname);
            this.Controls.Add(this.radioButtonSurename);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zuschuss Helfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.RadioButton radioButtonSurename;
        private System.Windows.Forms.RadioButton radioButtonForname;
        private System.Windows.Forms.CheckBox checkBoxTutor;
        private System.Windows.Forms.CheckBox checkBoxNight;
        private System.Windows.Forms.TextBox textBoxNight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sonstigesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

