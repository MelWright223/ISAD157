namespace databaseConnectionNew
{
    partial class userProfilePage
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
            this.namePanel = new System.Windows.Forms.Panel();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.userIDLbl = new System.Windows.Forms.Label();
            this.profileUserIDtxt = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.genderLbl = new System.Windows.Forms.Label();
            this.homeTownLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.relationshipLbl = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.homeTownTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.relationshipTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.workplaceData = new System.Windows.Forms.DataGridView();
            this.workLbl = new System.Windows.Forms.Label();
            this.uniLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.universityData = new System.Windows.Forms.DataGridView();
            this.messageData = new System.Windows.Forms.DataGridView();
            this.friendDataGrid = new System.Windows.Forms.DataGridView();
            this.friendLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.namePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workplaceData)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.namePanel.Controls.Add(this.lastNameLbl);
            this.namePanel.Controls.Add(this.firstNameLbl);
            this.namePanel.Location = new System.Drawing.Point(306, 12);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(334, 59);
            this.namePanel.TabIndex = 1;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(164, 16);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(103, 24);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "LastName";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(53, 16);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(105, 24);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "FirstName";
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.Location = new System.Drawing.Point(302, 100);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(41, 20);
            this.infoLbl.TabIndex = 5;
            this.infoLbl.Text = "Info";
            this.infoLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // userIDLbl
            // 
            this.userIDLbl.AutoSize = true;
            this.userIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLbl.Location = new System.Drawing.Point(739, 13);
            this.userIDLbl.Name = "userIDLbl";
            this.userIDLbl.Size = new System.Drawing.Size(60, 20);
            this.userIDLbl.TabIndex = 10;
            this.userIDLbl.Text = "UserID";
            // 
            // profileUserIDtxt
            // 
            this.profileUserIDtxt.Enabled = false;
            this.profileUserIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileUserIDtxt.Location = new System.Drawing.Point(821, 12);
            this.profileUserIDtxt.Name = "profileUserIDtxt";
            this.profileUserIDtxt.Size = new System.Drawing.Size(124, 26);
            this.profileUserIDtxt.TabIndex = 9;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(8, 12);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(74, 20);
            this.genderLbl.TabIndex = 16;
            this.genderLbl.Text = "Gender:";
            // 
            // homeTownLbl
            // 
            this.homeTownLbl.AutoSize = true;
            this.homeTownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTownLbl.Location = new System.Drawing.Point(8, 43);
            this.homeTownLbl.Name = "homeTownLbl";
            this.homeTownLbl.Size = new System.Drawing.Size(108, 20);
            this.homeTownLbl.TabIndex = 17;
            this.homeTownLbl.Text = "Home Town:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLbl.Location = new System.Drawing.Point(8, 80);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(44, 20);
            this.cityLbl.TabIndex = 18;
            this.cityLbl.Text = "City:";
            // 
            // relationshipLbl
            // 
            this.relationshipLbl.AutoSize = true;
            this.relationshipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipLbl.Location = new System.Drawing.Point(8, 114);
            this.relationshipLbl.Name = "relationshipLbl";
            this.relationshipLbl.Size = new System.Drawing.Size(114, 20);
            this.relationshipLbl.TabIndex = 19;
            this.relationshipLbl.Text = "Relationship:";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infoPanel.Controls.Add(this.relationshipTxt);
            this.infoPanel.Controls.Add(this.cityTxt);
            this.infoPanel.Controls.Add(this.homeTownTxt);
            this.infoPanel.Controls.Add(this.genderTxt);
            this.infoPanel.Controls.Add(this.relationshipLbl);
            this.infoPanel.Controls.Add(this.cityLbl);
            this.infoPanel.Controls.Add(this.homeTownLbl);
            this.infoPanel.Controls.Add(this.genderLbl);
            this.infoPanel.Location = new System.Drawing.Point(306, 123);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(380, 152);
            this.infoPanel.TabIndex = 20;
            // 
            // genderTxt
            // 
            this.genderTxt.Location = new System.Drawing.Point(149, 12);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(112, 20);
            this.genderTxt.TabIndex = 20;
            // 
            // homeTownTxt
            // 
            this.homeTownTxt.Location = new System.Drawing.Point(149, 45);
            this.homeTownTxt.Name = "homeTownTxt";
            this.homeTownTxt.Size = new System.Drawing.Size(112, 20);
            this.homeTownTxt.TabIndex = 21;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(149, 82);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(112, 20);
            this.cityTxt.TabIndex = 22;
            // 
            // relationshipTxt
            // 
            this.relationshipTxt.Location = new System.Drawing.Point(149, 116);
            this.relationshipTxt.Name = "relationshipTxt";
            this.relationshipTxt.Size = new System.Drawing.Size(112, 20);
            this.relationshipTxt.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.workplaceData);
            this.panel3.Location = new System.Drawing.Point(712, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 233);
            this.panel3.TabIndex = 21;
            // 
            // workplaceData
            // 
            this.workplaceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workplaceData.Location = new System.Drawing.Point(3, 3);
            this.workplaceData.Name = "workplaceData";
            this.workplaceData.Size = new System.Drawing.Size(233, 227);
            this.workplaceData.TabIndex = 0;
            // 
            // workLbl
            // 
            this.workLbl.AutoSize = true;
            this.workLbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.workLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workLbl.Location = new System.Drawing.Point(708, 351);
            this.workLbl.Name = "workLbl";
            this.workLbl.Size = new System.Drawing.Size(93, 20);
            this.workLbl.TabIndex = 1;
            this.workLbl.Text = "Workplace";
            // 
            // uniLbl
            // 
            this.uniLbl.AutoSize = true;
            this.uniLbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.uniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniLbl.Location = new System.Drawing.Point(708, 82);
            this.uniLbl.Name = "uniLbl";
            this.uniLbl.Size = new System.Drawing.Size(87, 20);
            this.uniLbl.TabIndex = 22;
            this.uniLbl.Text = "University";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.universityData);
            this.panel4.Location = new System.Drawing.Point(712, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 233);
            this.panel4.TabIndex = 23;
            // 
            // universityData
            // 
            this.universityData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityData.Location = new System.Drawing.Point(3, 3);
            this.universityData.Name = "universityData";
            this.universityData.Size = new System.Drawing.Size(230, 227);
            this.universityData.TabIndex = 0;
            // 
            // messageData
            // 
            this.messageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageData.Location = new System.Drawing.Point(289, 319);
            this.messageData.Name = "messageData";
            this.messageData.Size = new System.Drawing.Size(413, 285);
            this.messageData.TabIndex = 27;
            // 
            // friendDataGrid
            // 
            this.friendDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendDataGrid.Location = new System.Drawing.Point(12, 23);
            this.friendDataGrid.Name = "friendDataGrid";
            this.friendDataGrid.Size = new System.Drawing.Size(258, 581);
            this.friendDataGrid.TabIndex = 25;
            // 
            // friendLbl
            // 
            this.friendLbl.AutoSize = true;
            this.friendLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendLbl.Location = new System.Drawing.Point(12, 0);
            this.friendLbl.Name = "friendLbl";
            this.friendLbl.Size = new System.Drawing.Size(57, 20);
            this.friendLbl.TabIndex = 24;
            this.friendLbl.Text = "label1";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.Location = new System.Drawing.Point(302, 296);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(90, 20);
            this.messageLbl.TabIndex = 28;
            this.messageLbl.Text = "Messages";
            // 
            // userProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(957, 612);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.messageData);
            this.Controls.Add(this.friendDataGrid);
            this.Controls.Add(this.friendLbl);
            this.Controls.Add(this.uniLbl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.workLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.userIDLbl);
            this.Controls.Add(this.profileUserIDtxt);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.namePanel);
            this.Name = "userProfilePage";
            this.Text = "userProfilePage";
            this.Load += new System.EventHandler(this.userProfilePage_Load);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workplaceData)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.universityData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label userIDLbl;
        private System.Windows.Forms.TextBox profileUserIDtxt;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label homeTownLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label relationshipLbl;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.TextBox relationshipTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox homeTownTxt;
        private System.Windows.Forms.TextBox genderTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView workplaceData;
        private System.Windows.Forms.Label workLbl;
        private System.Windows.Forms.Label uniLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView universityData;
        private System.Windows.Forms.DataGridView messageData;
        private System.Windows.Forms.DataGridView friendDataGrid;
        private System.Windows.Forms.Label friendLbl;
        private System.Windows.Forms.Label messageLbl;
    }
}