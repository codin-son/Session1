
namespace Session1
{
    partial class Form3
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
            this.tabRole = new System.Windows.Forms.TabControl();
            this.tpTraveler = new System.Windows.Forms.TabPage();
            this.dgTraveler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tpOwner = new System.Windows.Forms.TabPage();
            this.dgOwner = new System.Windows.Forms.DataGridView();
            this.btnAddListing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoSearch = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabRole.SuspendLayout();
            this.tpTraveler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTraveler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwner)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.tpTraveler);
            this.tabRole.Controls.Add(this.tpOwner);
            this.tabRole.Location = new System.Drawing.Point(12, 119);
            this.tabRole.Name = "tabRole";
            this.tabRole.SelectedIndex = 0;
            this.tabRole.Size = new System.Drawing.Size(1210, 364);
            this.tabRole.TabIndex = 1;
            this.tabRole.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabRole_Selected);
            // 
            // tpTraveler
            // 
            this.tpTraveler.Controls.Add(this.dgTraveler);
            this.tpTraveler.Controls.Add(this.pictureBox2);
            this.tpTraveler.Controls.Add(this.txtSearch);
            this.tpTraveler.Location = new System.Drawing.Point(4, 22);
            this.tpTraveler.Name = "tpTraveler";
            this.tpTraveler.Padding = new System.Windows.Forms.Padding(3);
            this.tpTraveler.Size = new System.Drawing.Size(1202, 338);
            this.tpTraveler.TabIndex = 0;
            this.tpTraveler.Text = "I\'m Traveler";
            this.tpTraveler.UseVisualStyleBackColor = true;
            // 
            // dgTraveler
            // 
            this.dgTraveler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTraveler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTraveler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgTraveler.Location = new System.Drawing.Point(21, 94);
            this.dgTraveler.Name = "dgTraveler";
            this.dgTraveler.Size = new System.Drawing.Size(1160, 238);
            this.dgTraveler.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Title";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Capacity";
            this.Column2.HeaderText = "Capacity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "Area";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name1";
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Session1.Properties.Resources._135_search;
            this.pictureBox2.Location = new System.Drawing.Point(21, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(43, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(534, 29);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search destination or Listing Title or Attraction";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // tpOwner
            // 
            this.tpOwner.Controls.Add(this.dgOwner);
            this.tpOwner.Controls.Add(this.btnAddListing);
            this.tpOwner.Location = new System.Drawing.Point(4, 22);
            this.tpOwner.Name = "tpOwner";
            this.tpOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tpOwner.Size = new System.Drawing.Size(1202, 338);
            this.tpOwner.TabIndex = 1;
            this.tpOwner.Text = "I\'m Owner / Manager";
            this.tpOwner.UseVisualStyleBackColor = true;
            // 
            // dgOwner
            // 
            this.dgOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOwner.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOwner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgOwner.Location = new System.Drawing.Point(6, 65);
            this.dgOwner.Name = "dgOwner";
            this.dgOwner.Size = new System.Drawing.Size(1189, 257);
            this.dgOwner.TabIndex = 1;
            this.dgOwner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOwner_CellContentClick);
            // 
            // btnAddListing
            // 
            this.btnAddListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddListing.Image = global::Session1.Properties.Resources._267_plus;
            this.btnAddListing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddListing.Location = new System.Drawing.Point(22, 19);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(118, 30);
            this.btnAddListing.TabIndex = 0;
            this.btnAddListing.Text = "Add Listing";
            this.btnAddListing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddListing.UseVisualStyleBackColor = true;
            this.btnAddListing.Click += new System.EventHandler(this.btnAddListing_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNoSearch);
            this.panel1.Location = new System.Drawing.Point(-1, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 32);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "items found";
            // 
            // lblNoSearch
            // 
            this.lblNoSearch.AutoSize = true;
            this.lblNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSearch.Location = new System.Drawing.Point(11, 8);
            this.lblNoSearch.Name = "lblNoSearch";
            this.lblNoSearch.Size = new System.Drawing.Size(18, 20);
            this.lblNoSearch.TabIndex = 0;
            this.lblNoSearch.Text = "3";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1056, 112);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1137, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.pictureBox1.Location = new System.Drawing.Point(545, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ID";
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Title";
            this.Column5.HeaderText = "Title";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Capacity";
            this.Column6.HeaderText = "Capacity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Name";
            this.Column7.HeaderText = "Area";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name1";
            this.Column8.HeaderText = "Type";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Text = "Edit Details";
            this.Column9.UseColumnTextForLinkValue = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 526);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabRole);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabRole.ResumeLayout(false);
            this.tpTraveler.ResumeLayout(false);
            this.tpTraveler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTraveler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpOwner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOwner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabRole;
        private System.Windows.Forms.TabPage tpTraveler;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tpOwner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoSearch;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgTraveler;
        private System.Windows.Forms.Button btnAddListing;
        private System.Windows.Forms.DataGridView dgOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewLinkColumn Column9;
    }
}