﻿namespace WinFormsApp
{
    partial class Form1
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lbPodEpisode = new ListBox();
            lbEpisodeInfo = new ListBox();
            label5 = new Label();
            tbCategory = new TextBox();
            btAddCategory = new Button();
            lbShowCategorys = new ListBox();
            btChangeCategory = new Button();
            btDeleteCategory = new Button();
            btChangePod = new Button();
            btDeletePod = new Button();
            cbChangeCategory = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btAddPod
            // 
            btAddPod.Location = new Point(504, 64);
            btAddPod.Margin = new Padding(2);
            btAddPod.Name = "btAddPod";
            btAddPod.Size = new Size(125, 27);
            btAddPod.TabIndex = 0;
            btAddPod.Text = "Lägg till podd";
            btAddPod.UseVisualStyleBackColor = true;
            btAddPod.Click += btAddPod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Poddnamn:";
            // 
            // tbPodName
            // 
            tbPodName.Location = new Point(46, 68);
            tbPodName.Margin = new Padding(2);
            tbPodName.Name = "tbPodName";
            tbPodName.Size = new Size(121, 27);
            tbPodName.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(193, 66);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(146, 28);
            cbCategory.TabIndex = 3;
            cbCategory.Text = "Välj kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 4;
            label2.Text = "Lägg till URL:";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(364, 66);
            tbURL.Margin = new Padding(2);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(121, 27);
            tbURL.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 387);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Poddavsnitt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 387);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 7;
            label4.Text = "Avsnittsbeskrivning:";
            // 
            // lvPodInfo
            // 
            lvPodInfo.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvPodInfo.Location = new Point(37, 118);
            lvPodInfo.Margin = new Padding(2);
            lvPodInfo.Name = "lvPodInfo";
            lvPodInfo.Size = new Size(349, 226);
            lvPodInfo.TabIndex = 8;
            lvPodInfo.UseCompatibleStateImageBehavior = false;
            lvPodInfo.View = View.Details;
            lvPodInfo.SelectedIndexChanged += lvPodInfo_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Antal avsnitt";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Namn";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Titel";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kategori";
            columnHeader4.Width = 100;
            // 
            // lbPodEpisode
            // 
            lbPodEpisode.FormattingEnabled = true;
            lbPodEpisode.ItemHeight = 20;
            lbPodEpisode.Location = new Point(46, 425);
            lbPodEpisode.Margin = new Padding(2);
            lbPodEpisode.Name = "lbPodEpisode";
            lbPodEpisode.Size = new Size(207, 164);
            lbPodEpisode.TabIndex = 9;
            // 
            // lbEpisodeInfo
            // 
            lbEpisodeInfo.FormattingEnabled = true;
            lbEpisodeInfo.ItemHeight = 20;
            lbEpisodeInfo.Location = new Point(287, 425);
            lbEpisodeInfo.Margin = new Padding(2);
            lbEpisodeInfo.Name = "lbEpisodeInfo";
            lbEpisodeInfo.Size = new Size(214, 164);
            lbEpisodeInfo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 170);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 11;
            label5.Text = "Lägg till ny kategori:";
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(418, 199);
            tbCategory.Margin = new Padding(2);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(121, 27);
            tbCategory.TabIndex = 12;
            // 
            // btAddCategory
            // 
            btAddCategory.Location = new Point(566, 199);
            btAddCategory.Margin = new Padding(2);
            btAddCategory.Name = "btAddCategory";
            btAddCategory.Size = new Size(126, 27);
            btAddCategory.TabIndex = 13;
            btAddCategory.Text = "Lägg till kategori";
            btAddCategory.UseVisualStyleBackColor = true;
            // 
            // lbShowCategorys
            // 
            lbShowCategorys.FormattingEnabled = true;
            lbShowCategorys.ItemHeight = 20;
            lbShowCategorys.Location = new Point(406, 240);
            lbShowCategorys.Margin = new Padding(2);
            lbShowCategorys.Name = "lbShowCategorys";
            lbShowCategorys.Size = new Size(145, 104);
            lbShowCategorys.TabIndex = 14;
            // 
            // btChangeCategory
            // 
            btChangeCategory.Location = new Point(566, 240);
            btChangeCategory.Margin = new Padding(2);
            btChangeCategory.Name = "btChangeCategory";
            btChangeCategory.Size = new Size(123, 27);
            btChangeCategory.TabIndex = 15;
            btChangeCategory.Text = "Ändra kategori";
            btChangeCategory.UseVisualStyleBackColor = true;
            // 
            // btDeleteCategory
            // 
            btDeleteCategory.Location = new Point(566, 282);
            btDeleteCategory.Margin = new Padding(2);
            btDeleteCategory.Name = "btDeleteCategory";
            btDeleteCategory.Size = new Size(123, 27);
            btDeleteCategory.TabIndex = 16;
            btDeleteCategory.Text = "Ta bort kategori";
            btDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btChangePod
            // 
            btChangePod.Location = new Point(667, 95);
            btChangePod.Margin = new Padding(2);
            btChangePod.Name = "btChangePod";
            btChangePod.Size = new Size(114, 27);
            btChangePod.TabIndex = 17;
            btChangePod.Text = "Ändra podd";
            btChangePod.UseVisualStyleBackColor = true;
            // 
            // btDeletePod
            // 
            btDeletePod.Location = new Point(504, 96);
            btDeletePod.Margin = new Padding(2);
            btDeletePod.Name = "btDeletePod";
            btDeletePod.Size = new Size(119, 27);
            btDeletePod.TabIndex = 18;
            btDeletePod.Text = "Ta bort pod";
            btDeletePod.UseVisualStyleBackColor = true;
            // 
            // cbChangeCategory
            // 
            cbChangeCategory.FormattingEnabled = true;
            cbChangeCategory.Location = new Point(657, 64);
            cbChangeCategory.Margin = new Padding(2);
            cbChangeCategory.Name = "cbChangeCategory";
            cbChangeCategory.Size = new Size(146, 28);
            cbChangeCategory.TabIndex = 19;
            cbChangeCategory.Text = "Välj ny kategori";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 14);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 20;
            label6.Text = "Mina podcasts";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 646);
            Controls.Add(label6);
            Controls.Add(cbChangeCategory);
            Controls.Add(btDeletePod);
            Controls.Add(btChangePod);
            Controls.Add(btDeleteCategory);
            Controls.Add(btChangeCategory);
            Controls.Add(lbShowCategorys);
            Controls.Add(btAddCategory);
            Controls.Add(tbCategory);
            Controls.Add(label5);
            Controls.Add(lbEpisodeInfo);
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
            Margin = new Padding(2);
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
        private ListBox lbEpisodeInfo;
        private Label label5;
        private TextBox tbCategory;
        private Button btAddCategory;
        private ListBox lbShowCategorys;
        private Button btChangeCategory;
        private Button btDeleteCategory;
        private Button btChangePod;
        private Button btDeletePod;
        private ComboBox cbChangeCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label6;
    }
}