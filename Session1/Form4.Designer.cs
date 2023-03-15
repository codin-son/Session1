
namespace Session1
{
    partial class Form4
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
            this.tabContList = new System.Windows.Forms.TabControl();
            this.tabListDetails = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numMaxNight = new System.Windows.Forms.NumericUpDown();
            this.numMinNight = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHostRules = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExactAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApproAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numBath = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numRooms = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numBed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numCap = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAmenities = new System.Windows.Forms.TabPage();
            this.dgAmenities = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.tabDistanceAttract = new System.Windows.Forms.TabPage();
            this.dgDistance = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabContList.SuspendLayout();
            this.tabListDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            this.tabAmenities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmenities)).BeginInit();
            this.tabDistanceAttract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContList
            // 
            this.tabContList.Controls.Add(this.tabListDetails);
            this.tabContList.Controls.Add(this.tabAmenities);
            this.tabContList.Controls.Add(this.tabDistanceAttract);
            this.tabContList.Location = new System.Drawing.Point(12, 12);
            this.tabContList.Name = "tabContList";
            this.tabContList.SelectedIndex = 0;
            this.tabContList.Size = new System.Drawing.Size(1082, 400);
            this.tabContList.TabIndex = 0;
            this.tabContList.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabContList_Selected);
            // 
            // tabListDetails
            // 
            this.tabListDetails.Controls.Add(this.label13);
            this.tabListDetails.Controls.Add(this.numMaxNight);
            this.tabListDetails.Controls.Add(this.numMinNight);
            this.tabListDetails.Controls.Add(this.label12);
            this.tabListDetails.Controls.Add(this.label11);
            this.tabListDetails.Controls.Add(this.txtHostRules);
            this.tabListDetails.Controls.Add(this.label10);
            this.tabListDetails.Controls.Add(this.txtDesc);
            this.tabListDetails.Controls.Add(this.label9);
            this.tabListDetails.Controls.Add(this.txtExactAddress);
            this.tabListDetails.Controls.Add(this.label8);
            this.tabListDetails.Controls.Add(this.txtApproAddress);
            this.tabListDetails.Controls.Add(this.label7);
            this.tabListDetails.Controls.Add(this.numBath);
            this.tabListDetails.Controls.Add(this.label6);
            this.tabListDetails.Controls.Add(this.numRooms);
            this.tabListDetails.Controls.Add(this.label5);
            this.tabListDetails.Controls.Add(this.numBed);
            this.tabListDetails.Controls.Add(this.label4);
            this.tabListDetails.Controls.Add(this.numCap);
            this.tabListDetails.Controls.Add(this.label3);
            this.tabListDetails.Controls.Add(this.txtTitle);
            this.tabListDetails.Controls.Add(this.label2);
            this.tabListDetails.Controls.Add(this.cbType);
            this.tabListDetails.Controls.Add(this.label1);
            this.tabListDetails.Location = new System.Drawing.Point(4, 22);
            this.tabListDetails.Name = "tabListDetails";
            this.tabListDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabListDetails.Size = new System.Drawing.Size(1074, 374);
            this.tabListDetails.TabIndex = 0;
            this.tabListDetails.Text = "Listing Details";
            this.tabListDetails.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(355, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Maximum:";
            // 
            // numMaxNight
            // 
            this.numMaxNight.Location = new System.Drawing.Point(445, 338);
            this.numMaxNight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxNight.Name = "numMaxNight";
            this.numMaxNight.Size = new System.Drawing.Size(35, 20);
            this.numMaxNight.TabIndex = 23;
            this.numMaxNight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxNight.ValueChanged += new System.EventHandler(this.numMaxNight_ValueChanged);
            // 
            // numMinNight
            // 
            this.numMinNight.Location = new System.Drawing.Point(310, 338);
            this.numMinNight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinNight.Name = "numMinNight";
            this.numMinNight.Size = new System.Drawing.Size(35, 20);
            this.numMinNight.TabIndex = 22;
            this.numMinNight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinNight.ValueChanged += new System.EventHandler(this.numMinNight_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Minimum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Reservation Time (Nights):";
            // 
            // txtHostRules
            // 
            this.txtHostRules.Location = new System.Drawing.Point(179, 264);
            this.txtHostRules.Multiline = true;
            this.txtHostRules.Name = "txtHostRules";
            this.txtHostRules.Size = new System.Drawing.Size(889, 43);
            this.txtHostRules.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Host Rules:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(179, 215);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(889, 43);
            this.txtDesc.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Description:";
            // 
            // txtExactAddress
            // 
            this.txtExactAddress.Location = new System.Drawing.Point(179, 166);
            this.txtExactAddress.Multiline = true;
            this.txtExactAddress.Name = "txtExactAddress";
            this.txtExactAddress.Size = new System.Drawing.Size(889, 43);
            this.txtExactAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Exact Address:";
            // 
            // txtApproAddress
            // 
            this.txtApproAddress.Location = new System.Drawing.Point(179, 120);
            this.txtApproAddress.Multiline = true;
            this.txtApproAddress.Name = "txtApproAddress";
            this.txtApproAddress.Size = new System.Drawing.Size(889, 43);
            this.txtApproAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Approximate Address:";
            // 
            // numBath
            // 
            this.numBath.Location = new System.Drawing.Point(758, 70);
            this.numBath.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBath.Name = "numBath";
            this.numBath.Size = new System.Drawing.Size(51, 20);
            this.numBath.TabIndex = 11;
            this.numBath.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of Bathrooms:";
            // 
            // numRooms
            // 
            this.numRooms.Location = new System.Drawing.Point(527, 70);
            this.numRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRooms.Name = "numRooms";
            this.numRooms.Size = new System.Drawing.Size(51, 20);
            this.numRooms.TabIndex = 9;
            this.numRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Bedrooms:";
            // 
            // numBed
            // 
            this.numBed.Location = new System.Drawing.Point(293, 70);
            this.numBed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBed.Name = "numBed";
            this.numBed.Size = new System.Drawing.Size(51, 20);
            this.numBed.TabIndex = 7;
            this.numBed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Beds:";
            // 
            // numCap
            // 
            this.numCap.Location = new System.Drawing.Point(88, 70);
            this.numCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCap.Name = "numCap";
            this.numCap.Size = new System.Drawing.Size(53, 20);
            this.numCap.TabIndex = 5;
            this.numCap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacity:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(539, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(354, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(61, 5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(252, 21);
            this.cbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // tabAmenities
            // 
            this.tabAmenities.Controls.Add(this.dgAmenities);
            this.tabAmenities.Controls.Add(this.label14);
            this.tabAmenities.Location = new System.Drawing.Point(4, 22);
            this.tabAmenities.Name = "tabAmenities";
            this.tabAmenities.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmenities.Size = new System.Drawing.Size(1074, 374);
            this.tabAmenities.TabIndex = 1;
            this.tabAmenities.Text = "Amenities";
            this.tabAmenities.UseVisualStyleBackColor = true;
            this.tabAmenities.Click += new System.EventHandler(this.tabAmenities_Click);
            // 
            // dgAmenities
            // 
            this.dgAmenities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAmenities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAmenities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8});
            this.dgAmenities.Location = new System.Drawing.Point(25, 52);
            this.dgAmenities.Name = "dgAmenities";
            this.dgAmenities.Size = new System.Drawing.Size(600, 150);
            this.dgAmenities.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 159.3909F;
            this.Column1.HeaderText = "Amenity";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 40.60914F;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Choose Available Amenities:";
            // 
            // tabDistanceAttract
            // 
            this.tabDistanceAttract.Controls.Add(this.dgDistance);
            this.tabDistanceAttract.Controls.Add(this.label15);
            this.tabDistanceAttract.Location = new System.Drawing.Point(4, 22);
            this.tabDistanceAttract.Name = "tabDistanceAttract";
            this.tabDistanceAttract.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistanceAttract.Size = new System.Drawing.Size(1074, 374);
            this.tabDistanceAttract.TabIndex = 2;
            this.tabDistanceAttract.Text = "Distance to Attraction";
            this.tabDistanceAttract.UseVisualStyleBackColor = true;
            // 
            // dgDistance
            // 
            this.dgDistance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDistance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgDistance.Location = new System.Drawing.Point(22, 57);
            this.dgDistance.Name = "dgDistance";
            this.dgDistance.Size = new System.Drawing.Size(1027, 311);
            this.dgDistance.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Attraction";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Area";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Distance(km)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "On Foot (Minutes)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "By Car (minutes)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(712, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Specify the distance from each close by attraction and the time it takes to get t" +
    "o them:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(924, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(909, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close / Finish";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Location = new System.Drawing.Point(1015, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabContList);
            this.Name = "Form4";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabContList.ResumeLayout(false);
            this.tabListDetails.ResumeLayout(false);
            this.tabListDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            this.tabAmenities.ResumeLayout(false);
            this.tabAmenities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmenities)).EndInit();
            this.tabDistanceAttract.ResumeLayout(false);
            this.tabDistanceAttract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContList;
        private System.Windows.Forms.TabPage tabListDetails;
        private System.Windows.Forms.TabPage tabAmenities;
        private System.Windows.Forms.TabPage tabDistanceAttract;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numBed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApproAddress;
        private System.Windows.Forms.TextBox txtExactAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHostRules;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numMinNight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numMaxNight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgAmenities;
        private System.Windows.Forms.DataGridView dgDistance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}