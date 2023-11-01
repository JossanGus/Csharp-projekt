namespace WinFormsApp
{
    partial class StartUpPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAddPod = new Button();
            label1 = new Label();
            tbPodName = new TextBox();
            cbCategory = new ComboBox();
            label2 = new Label();
            tbURL = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lvPodInfo = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            lbPodEpisode = new ListBox();
            label5 = new Label();
            tbCategory = new TextBox();
            btAddCategory = new Button();
            lbShowCategorys = new ListBox();
            btChangeCategory = new Button();
            btDeleteCategory = new Button();
            btChangePod = new Button();
            btDeletePod = new Button();
            cbCategoryFilter = new ComboBox();
            label6 = new Label();
            tbEpisodeInfo = new TextBox();
            btRensaListan = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // btAddPod
            // 
            btAddPod.Location = new Point(492, 162);
            btAddPod.Margin = new Padding(2, 3, 2, 3);
            btAddPod.Name = "btAddPod";
            btAddPod.Size = new Size(178, 33);
            btAddPod.TabIndex = 0;
            btAddPod.Text = "Lägg till podd";
            btAddPod.UseVisualStyleBackColor = true;
            btAddPod.Click += btAddPod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 1;
            label1.Text = "Poddnamn:";
            // 
            // tbPodName
            // 
            tbPodName.Location = new Point(55, 98);
            tbPodName.Margin = new Padding(2, 3, 2, 3);
            tbPodName.Name = "tbPodName";
            tbPodName.Size = new Size(151, 32);
            tbPodName.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(226, 98);
            cbCategory.Margin = new Padding(2, 3, 2, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(182, 32);
            cbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 4;
            label2.Text = "Lägg till URL:";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(447, 98);
            tbURL.Margin = new Padding(2, 3, 2, 3);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(151, 32);
            tbURL.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 453);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 6;
            label3.Text = "Poddavsnitt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 453);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 24);
            label4.TabIndex = 7;
            label4.Text = "Avsnittsbeskrivning:";
            // 
            // lvPodInfo
            // 
            lvPodInfo.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4, columnHeader1 });
            lvPodInfo.Location = new Point(44, 162);
            lvPodInfo.Margin = new Padding(2, 3, 2, 3);
            lvPodInfo.Name = "lvPodInfo";
            lvPodInfo.Size = new Size(435, 271);
            lvPodInfo.TabIndex = 8;
            lvPodInfo.UseCompatibleStateImageBehavior = false;
            lvPodInfo.View = View.Details;
            lvPodInfo.SelectedIndexChanged += lvPodInfo_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Namn";
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 2;
            columnHeader4.Text = "Kategori";
            columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Antal avsnitt";
            columnHeader1.Width = 150;
            // 
            // lbPodEpisode
            // 
            lbPodEpisode.FormattingEnabled = true;
            lbPodEpisode.ItemHeight = 24;
            lbPodEpisode.Location = new Point(49, 482);
            lbPodEpisode.Margin = new Padding(2, 3, 2, 3);
            lbPodEpisode.Name = "lbPodEpisode";
            lbPodEpisode.Size = new Size(328, 196);
            lbPodEpisode.TabIndex = 9;
            lbPodEpisode.SelectedIndexChanged += lbPodEpisode_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 72);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 24);
            label5.TabIndex = 11;
            label5.Text = "Lägg till ny kategori:";
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(768, 96);
            tbCategory.Margin = new Padding(2, 3, 2, 3);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(232, 32);
            tbCategory.TabIndex = 12;
            // 
            // btAddCategory
            // 
            btAddCategory.Location = new Point(1017, 92);
            btAddCategory.Margin = new Padding(2, 3, 2, 3);
            btAddCategory.Name = "btAddCategory";
            btAddCategory.Size = new Size(158, 33);
            btAddCategory.TabIndex = 13;
            btAddCategory.Text = "Lägg till kategori";
            btAddCategory.UseVisualStyleBackColor = true;
            btAddCategory.Click += btAddCategory_Click;
            // 
            // lbShowCategorys
            // 
            lbShowCategorys.FormattingEnabled = true;
            lbShowCategorys.ItemHeight = 24;
            lbShowCategorys.Location = new Point(768, 142);
            lbShowCategorys.Margin = new Padding(2, 3, 2, 3);
            lbShowCategorys.Name = "lbShowCategorys";
            lbShowCategorys.Size = new Size(232, 124);
            lbShowCategorys.TabIndex = 14;
            // 
            // btChangeCategory
            // 
            btChangeCategory.Location = new Point(1017, 140);
            btChangeCategory.Margin = new Padding(2, 3, 2, 3);
            btChangeCategory.Name = "btChangeCategory";
            btChangeCategory.Size = new Size(153, 33);
            btChangeCategory.TabIndex = 15;
            btChangeCategory.Text = "Ändra kategori";
            btChangeCategory.UseVisualStyleBackColor = true;
            btChangeCategory.Click += btChangeCategory_Click;
            // 
            // btDeleteCategory
            // 
            btDeleteCategory.Location = new Point(1017, 188);
            btDeleteCategory.Margin = new Padding(2, 3, 2, 3);
            btDeleteCategory.Name = "btDeleteCategory";
            btDeleteCategory.Size = new Size(153, 33);
            btDeleteCategory.TabIndex = 16;
            btDeleteCategory.Text = "Ta bort kategori";
            btDeleteCategory.UseVisualStyleBackColor = true;
            btDeleteCategory.Click += btDeleteCategory_Click;
            // 
            // btChangePod
            // 
            btChangePod.Location = new Point(492, 201);
            btChangePod.Margin = new Padding(2, 3, 2, 3);
            btChangePod.Name = "btChangePod";
            btChangePod.Size = new Size(178, 33);
            btChangePod.TabIndex = 17;
            btChangePod.Text = "Ändra podd";
            btChangePod.UseVisualStyleBackColor = true;
            btChangePod.Click += btChangePod_Click;
            // 
            // btDeletePod
            // 
            btDeletePod.Location = new Point(492, 240);
            btDeletePod.Margin = new Padding(2, 3, 2, 3);
            btDeletePod.Name = "btDeletePod";
            btDeletePod.Size = new Size(178, 33);
            btDeletePod.TabIndex = 18;
            btDeletePod.Text = "Ta bort pod";
            btDeletePod.UseVisualStyleBackColor = true;
            btDeletePod.Click += btDeletePod_Click;
            // 
            // cbCategoryFilter
            // 
            cbCategoryFilter.FormattingEnabled = true;
            cbCategoryFilter.Location = new Point(492, 288);
            cbCategoryFilter.Margin = new Padding(2, 3, 2, 3);
            cbCategoryFilter.Name = "cbCategoryFilter";
            cbCategoryFilter.Size = new Size(216, 32);
            cbCategoryFilter.TabIndex = 19;
            cbCategoryFilter.Text = "Filtrera poddkategori";
            cbCategoryFilter.SelectedIndexChanged += cbCategoryFilter_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(576, 17);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(210, 39);
            label6.TabIndex = 20;
            label6.Text = "Mina podcasts";
            // 
            // tbEpisodeInfo
            // 
            tbEpisodeInfo.Location = new Point(403, 482);
            tbEpisodeInfo.Multiline = true;
            tbEpisodeInfo.Name = "tbEpisodeInfo";
            tbEpisodeInfo.ScrollBars = ScrollBars.Vertical;
            tbEpisodeInfo.Size = new Size(535, 193);
            tbEpisodeInfo.TabIndex = 21;
            // 
            // btRensaListan
            // 
            btRensaListan.Location = new Point(492, 335);
            btRensaListan.Margin = new Padding(2, 3, 2, 3);
            btRensaListan.Name = "btRensaListan";
            btRensaListan.Size = new Size(178, 33);
            btRensaListan.TabIndex = 22;
            btRensaListan.Text = "Rensa listan";
            btRensaListan.UseVisualStyleBackColor = true;
            btRensaListan.Click += btRensaListan_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 69);
            label7.Name = "label7";
            label7.Size = new Size(121, 24);
            label7.TabIndex = 23;
            label7.Text = "Välj kategori:\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1322, 691);
            Controls.Add(label7);
            Controls.Add(btRensaListan);
            Controls.Add(tbEpisodeInfo);
            Controls.Add(label6);
            Controls.Add(cbCategoryFilter);
            Controls.Add(btDeletePod);
            Controls.Add(btChangePod);
            Controls.Add(btDeleteCategory);
            Controls.Add(btChangeCategory);
            Controls.Add(lbShowCategorys);
            Controls.Add(btAddCategory);
            Controls.Add(tbCategory);
            Controls.Add(label5);
            Controls.Add(lbPodEpisode);
            Controls.Add(lvPodInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbURL);
            Controls.Add(label2);
            Controls.Add(cbCategory);
            Controls.Add(tbPodName);
            Controls.Add(label1);
            Controls.Add(btAddPod);
            Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddPod;
        private Label label1;
        private TextBox tbPodName;
        private ComboBox cbCategory;
        private Label label2;
        private TextBox tbURL;
        private Label label3;
        private Label label4;
        private ListView lvPodInfo;
        private ListBox lbPodEpisode;
        private Label label5;
        private TextBox tbCategory;
        private Button btAddCategory;
        private ListBox lbShowCategorys;
        private Button btChangeCategory;
        private Button btDeleteCategory;
        private Button btChangePod;
        private Button btDeletePod;
        private ComboBox cbCategoryFilter;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private Label label6;
        private TextBox tbEpisodeInfo;
        private Button btRensaListan;
        private Label label7;
    }
}