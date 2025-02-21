namespace Klassenliste
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Albuen = new System.Windows.Forms.ListBox();
            this.label_error = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_listBox = new System.Windows.Forms.ListBox();
            this.search_comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_Artist = new System.Windows.Forms.CheckBox();
            this.check_Title = new System.Windows.Forms.CheckBox();
            this.check_Year = new System.Windows.Forms.CheckBox();
            this.chec_CatalogNr = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Albuen
            // 
            this.listBox_Albuen.FormattingEnabled = true;
            this.listBox_Albuen.Location = new System.Drawing.Point(153, 31);
            this.listBox_Albuen.Name = "listBox_Albuen";
            this.listBox_Albuen.Size = new System.Drawing.Size(498, 381);
            this.listBox_Albuen.TabIndex = 2;
            this.listBox_Albuen.SelectedIndexChanged += new System.EventHandler(this.listBox_Schueler_namen_SelectedIndexChanged);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(12, 358);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 56);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Album Liste speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 31);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(125, 52);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Album Liste laden";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(910, 29);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 19;
            this.search_button.Text = "Suche";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_listBox
            // 
            this.search_listBox.FormattingEnabled = true;
            this.search_listBox.Location = new System.Drawing.Point(690, 69);
            this.search_listBox.Name = "search_listBox";
            this.search_listBox.Size = new System.Drawing.Size(295, 342);
            this.search_listBox.TabIndex = 20;
            this.search_listBox.SelectedIndexChanged += new System.EventHandler(this.search_listBox_SelectedIndexChanged);
            // 
            // search_comboBox
            // 
            this.search_comboBox.FormattingEnabled = true;
            this.search_comboBox.Location = new System.Drawing.Point(690, 31);
            this.search_comboBox.Name = "search_comboBox";
            this.search_comboBox.Size = new System.Drawing.Size(214, 21);
            this.search_comboBox.TabIndex = 21;
            this.search_comboBox.SelectedIndexChanged += new System.EventHandler(this.search_comboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(991, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // check_Artist
            // 
            this.check_Artist.AutoSize = true;
            this.check_Artist.Location = new System.Drawing.Point(1046, 31);
            this.check_Artist.Name = "check_Artist";
            this.check_Artist.Size = new System.Drawing.Size(49, 17);
            this.check_Artist.TabIndex = 23;
            this.check_Artist.Text = "Artist";
            this.check_Artist.UseVisualStyleBackColor = true;
            this.check_Artist.CheckedChanged += new System.EventHandler(this.check_Artist_CheckedChanged);
            // 
            // check_Title
            // 
            this.check_Title.AutoSize = true;
            this.check_Title.Checked = true;
            this.check_Title.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Title.Location = new System.Drawing.Point(1046, 55);
            this.check_Title.Name = "check_Title";
            this.check_Title.Size = new System.Drawing.Size(46, 17);
            this.check_Title.TabIndex = 24;
            this.check_Title.Text = "Title";
            this.check_Title.UseVisualStyleBackColor = true;
            this.check_Title.CheckedChanged += new System.EventHandler(this.check_Title_CheckedChanged);
            // 
            // check_Year
            // 
            this.check_Year.AutoSize = true;
            this.check_Year.Location = new System.Drawing.Point(1102, 31);
            this.check_Year.Name = "check_Year";
            this.check_Year.Size = new System.Drawing.Size(48, 17);
            this.check_Year.TabIndex = 25;
            this.check_Year.Text = "Year";
            this.check_Year.UseVisualStyleBackColor = true;
            this.check_Year.CheckedChanged += new System.EventHandler(this.check_Year_CheckedChanged);
            // 
            // chec_CatalogNr
            // 
            this.chec_CatalogNr.AutoSize = true;
            this.chec_CatalogNr.Location = new System.Drawing.Point(1099, 55);
            this.chec_CatalogNr.Name = "chec_CatalogNr";
            this.chec_CatalogNr.Size = new System.Drawing.Size(76, 17);
            this.chec_CatalogNr.TabIndex = 26;
            this.chec_CatalogNr.Text = "Catalog Nr";
            this.chec_CatalogNr.UseVisualStyleBackColor = true;
            this.chec_CatalogNr.CheckedChanged += new System.EventHandler(this.chec_CatalogNr_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 556);
            this.Controls.Add(this.chec_CatalogNr);
            this.Controls.Add(this.check_Year);
            this.Controls.Add(this.check_Title);
            this.Controls.Add(this.check_Artist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_comboBox);
            this.Controls.Add(this.search_listBox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.listBox_Albuen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bibiliothek";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Albuen;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ListBox search_listBox;
        private System.Windows.Forms.ComboBox search_comboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox check_Artist;
        private System.Windows.Forms.CheckBox check_Title;
        private System.Windows.Forms.CheckBox check_Year;
        private System.Windows.Forms.CheckBox chec_CatalogNr;
    }
}

