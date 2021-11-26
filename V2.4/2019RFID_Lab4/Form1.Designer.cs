namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.Sector = new System.Windows.Forms.ComboBox();
            this.Block = new System.Windows.Forms.ComboBox();
            this.KeyAB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tebReadData = new System.Windows.Forms.TextBox();
            this.BtnReadData = new System.Windows.Forms.Button();
            this.label_point4 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.but_CleanCard = new System.Windows.Forms.Button();
            this.but_SignCard = new System.Windows.Forms.Button();
            this.textBox_Point = new System.Windows.Forms.TextBox();
            this.textBox_SignDay = new System.Windows.Forms.TextBox();
            this.textBox_MemName = new System.Windows.Forms.TextBox();
            this.textBox_MemID = new System.Windows.Forms.TextBox();
            this.label_point = new System.Windows.Forms.Label();
            this.label_SignDay = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_member = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.but_ReadCard = new System.Windows.Forms.Button();
            this.textBox_Point2 = new System.Windows.Forms.TextBox();
            this.textBox_SignDay2 = new System.Windows.Forms.TextBox();
            this.textBox_MemName2 = new System.Windows.Forms.TextBox();
            this.textBox_MemID2 = new System.Windows.Forms.TextBox();
            this.label_point2 = new System.Windows.Forms.Label();
            this.label_SignDay2 = new System.Windows.Forms.Label();
            this.label_name2 = new System.Windows.Forms.Label();
            this.label_member2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.but_AddPoint = new System.Windows.Forms.Button();
            this.textBox_Point3 = new System.Windows.Forms.TextBox();
            this.label_point3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.but_SpendPoint = new System.Windows.Forms.Button();
            this.textBox_Point4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tebWriteData = new System.Windows.Forms.TextBox();
            this.BtnWriteData = new System.Windows.Forms.Button();
            this.label_point4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(120, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Sector
            // 
            this.Sector.FormattingEnabled = true;
            this.Sector.Location = new System.Drawing.Point(14, 37);
            this.Sector.Name = "Sector";
            this.Sector.Size = new System.Drawing.Size(48, 20);
            this.Sector.TabIndex = 14;
            this.Sector.SelectedIndexChanged += new System.EventHandler(this.Sector_SelectedIndexChanged);
            // 
            // Block
            // 
            this.Block.FormattingEnabled = true;
            this.Block.Location = new System.Drawing.Point(78, 37);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(48, 20);
            this.Block.TabIndex = 15;
            this.Block.SelectedIndexChanged += new System.EventHandler(this.Block_SelectedIndexChanged);
            // 
            // KeyAB
            // 
            this.KeyAB.FormattingEnabled = true;
            this.KeyAB.Location = new System.Drawing.Point(141, 37);
            this.KeyAB.Name = "KeyAB";
            this.KeyAB.Size = new System.Drawing.Size(48, 20);
            this.KeyAB.TabIndex = 16;
            this.KeyAB.SelectedIndexChanged += new System.EventHandler(this.KeyAB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sector :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Block :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "KeyAB :";
            // 
            // LoadKey
            // 
            this.LoadKey.Location = new System.Drawing.Point(207, 37);
            this.LoadKey.Name = "LoadKey";
            this.LoadKey.Size = new System.Drawing.Size(100, 22);
            this.LoadKey.TabIndex = 20;
            this.LoadKey.Text = "FFFFFFFFFFFF";
            this.LoadKey.TextChanged += new System.EventHandler(this.LoadKey_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load Key :";
            // 
            // tebReadData
            // 
            this.tebReadData.Location = new System.Drawing.Point(14, 74);
            this.tebReadData.Name = "tebReadData";
            this.tebReadData.Size = new System.Drawing.Size(219, 22);
            this.tebReadData.TabIndex = 22;
            // 
            // BtnReadData
            // 
            this.BtnReadData.Location = new System.Drawing.Point(243, 74);
            this.BtnReadData.Name = "BtnReadData";
            this.BtnReadData.Size = new System.Drawing.Size(75, 23);
            this.BtnReadData.TabIndex = 23;
            this.BtnReadData.Text = "Read data";
            this.BtnReadData.UseVisualStyleBackColor = true;
            this.BtnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // label_point4
            // 
            this.label_point4.Controls.Add(this.tabPage1);
            this.label_point4.Controls.Add(this.tabPage2);
            this.label_point4.Controls.Add(this.tabPage3);
            this.label_point4.Controls.Add(this.tabPage4);
            this.label_point4.Location = new System.Drawing.Point(16, 141);
            this.label_point4.Name = "label_point4";
            this.label_point4.SelectedIndex = 0;
            this.label_point4.Size = new System.Drawing.Size(302, 198);
            this.label_point4.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.but_CleanCard);
            this.tabPage1.Controls.Add(this.but_SignCard);
            this.tabPage1.Controls.Add(this.textBox_Point);
            this.tabPage1.Controls.Add(this.textBox_SignDay);
            this.tabPage1.Controls.Add(this.textBox_MemName);
            this.tabPage1.Controls.Add(this.textBox_MemID);
            this.tabPage1.Controls.Add(this.label_point);
            this.tabPage1.Controls.Add(this.label_SignDay);
            this.tabPage1.Controls.Add(this.label_name);
            this.tabPage1.Controls.Add(this.label_member);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "發卡";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // but_CleanCard
            // 
            this.but_CleanCard.Location = new System.Drawing.Point(203, 84);
            this.but_CleanCard.Name = "but_CleanCard";
            this.but_CleanCard.Size = new System.Drawing.Size(75, 23);
            this.but_CleanCard.TabIndex = 9;
            this.but_CleanCard.Text = "清空卡片";
            this.but_CleanCard.UseVisualStyleBackColor = true;
            // 
            // but_SignCard
            // 
            this.but_SignCard.Location = new System.Drawing.Point(203, 51);
            this.but_SignCard.Name = "but_SignCard";
            this.but_SignCard.Size = new System.Drawing.Size(75, 23);
            this.but_SignCard.TabIndex = 8;
            this.but_SignCard.Text = "卡片製作";
            this.but_SignCard.UseVisualStyleBackColor = true;
            // 
            // textBox_Point
            // 
            this.textBox_Point.Location = new System.Drawing.Point(85, 110);
            this.textBox_Point.Name = "textBox_Point";
            this.textBox_Point.Size = new System.Drawing.Size(100, 22);
            this.textBox_Point.TabIndex = 7;
            // 
            // textBox_SignDay
            // 
            this.textBox_SignDay.Location = new System.Drawing.Point(85, 81);
            this.textBox_SignDay.Name = "textBox_SignDay";
            this.textBox_SignDay.Size = new System.Drawing.Size(100, 22);
            this.textBox_SignDay.TabIndex = 6;
            // 
            // textBox_MemName
            // 
            this.textBox_MemName.Location = new System.Drawing.Point(85, 53);
            this.textBox_MemName.Name = "textBox_MemName";
            this.textBox_MemName.Size = new System.Drawing.Size(100, 22);
            this.textBox_MemName.TabIndex = 5;
            // 
            // textBox_MemID
            // 
            this.textBox_MemID.Location = new System.Drawing.Point(85, 25);
            this.textBox_MemID.Name = "textBox_MemID";
            this.textBox_MemID.Size = new System.Drawing.Size(100, 22);
            this.textBox_MemID.TabIndex = 4;
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.Location = new System.Drawing.Point(20, 113);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(41, 12);
            this.label_point.TabIndex = 3;
            this.label_point.Text = "點數：";
            // 
            // label_SignDay
            // 
            this.label_SignDay.AutoSize = true;
            this.label_SignDay.Location = new System.Drawing.Point(20, 84);
            this.label_SignDay.Name = "label_SignDay";
            this.label_SignDay.Size = new System.Drawing.Size(65, 12);
            this.label_SignDay.TabIndex = 2;
            this.label_SignDay.Text = "申請日期：";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(20, 56);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓名：";
            // 
            // label_member
            // 
            this.label_member.AutoSize = true;
            this.label_member.Location = new System.Drawing.Point(20, 28);
            this.label_member.Name = "label_member";
            this.label_member.Size = new System.Drawing.Size(65, 12);
            this.label_member.TabIndex = 0;
            this.label_member.Text = "會員編號：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.but_ReadCard);
            this.tabPage2.Controls.Add(this.textBox_Point2);
            this.tabPage2.Controls.Add(this.textBox_SignDay2);
            this.tabPage2.Controls.Add(this.textBox_MemName2);
            this.tabPage2.Controls.Add(this.textBox_MemID2);
            this.tabPage2.Controls.Add(this.label_point2);
            this.tabPage2.Controls.Add(this.label_SignDay2);
            this.tabPage2.Controls.Add(this.label_name2);
            this.tabPage2.Controls.Add(this.label_member2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查詢";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // but_ReadCard
            // 
            this.but_ReadCard.Location = new System.Drawing.Point(201, 51);
            this.but_ReadCard.Name = "but_ReadCard";
            this.but_ReadCard.Size = new System.Drawing.Size(75, 23);
            this.but_ReadCard.TabIndex = 9;
            this.but_ReadCard.Text = "讀取卡片";
            this.but_ReadCard.UseVisualStyleBackColor = true;
            // 
            // textBox_Point2
            // 
            this.textBox_Point2.Location = new System.Drawing.Point(85, 110);
            this.textBox_Point2.Name = "textBox_Point2";
            this.textBox_Point2.Size = new System.Drawing.Size(100, 22);
            this.textBox_Point2.TabIndex = 8;
            // 
            // textBox_SignDay2
            // 
            this.textBox_SignDay2.Location = new System.Drawing.Point(85, 81);
            this.textBox_SignDay2.Name = "textBox_SignDay2";
            this.textBox_SignDay2.Size = new System.Drawing.Size(100, 22);
            this.textBox_SignDay2.TabIndex = 7;
            // 
            // textBox_MemName2
            // 
            this.textBox_MemName2.Location = new System.Drawing.Point(85, 53);
            this.textBox_MemName2.Name = "textBox_MemName2";
            this.textBox_MemName2.Size = new System.Drawing.Size(100, 22);
            this.textBox_MemName2.TabIndex = 6;
            // 
            // textBox_MemID2
            // 
            this.textBox_MemID2.Location = new System.Drawing.Point(85, 25);
            this.textBox_MemID2.Name = "textBox_MemID2";
            this.textBox_MemID2.Size = new System.Drawing.Size(100, 22);
            this.textBox_MemID2.TabIndex = 5;
            // 
            // label_point2
            // 
            this.label_point2.AutoSize = true;
            this.label_point2.Location = new System.Drawing.Point(20, 113);
            this.label_point2.Name = "label_point2";
            this.label_point2.Size = new System.Drawing.Size(41, 12);
            this.label_point2.TabIndex = 4;
            this.label_point2.Text = "點數：";
            // 
            // label_SignDay2
            // 
            this.label_SignDay2.AutoSize = true;
            this.label_SignDay2.Location = new System.Drawing.Point(20, 84);
            this.label_SignDay2.Name = "label_SignDay2";
            this.label_SignDay2.Size = new System.Drawing.Size(65, 12);
            this.label_SignDay2.TabIndex = 3;
            this.label_SignDay2.Text = "申請日期：";
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Location = new System.Drawing.Point(20, 56);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(41, 12);
            this.label_name2.TabIndex = 2;
            this.label_name2.Text = "姓名：";
            // 
            // label_member2
            // 
            this.label_member2.AutoSize = true;
            this.label_member2.Location = new System.Drawing.Point(20, 28);
            this.label_member2.Name = "label_member2";
            this.label_member2.Size = new System.Drawing.Size(65, 12);
            this.label_member2.TabIndex = 1;
            this.label_member2.Text = "會員編號：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.but_AddPoint);
            this.tabPage3.Controls.Add(this.textBox_Point3);
            this.tabPage3.Controls.Add(this.label_point3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(294, 172);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "儲值";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // but_AddPoint
            // 
            this.but_AddPoint.Location = new System.Drawing.Point(189, 52);
            this.but_AddPoint.Name = "but_AddPoint";
            this.but_AddPoint.Size = new System.Drawing.Size(75, 23);
            this.but_AddPoint.TabIndex = 2;
            this.but_AddPoint.Text = "加值點數";
            this.but_AddPoint.UseVisualStyleBackColor = true;
            // 
            // textBox_Point3
            // 
            this.textBox_Point3.Location = new System.Drawing.Point(71, 52);
            this.textBox_Point3.Name = "textBox_Point3";
            this.textBox_Point3.Size = new System.Drawing.Size(100, 22);
            this.textBox_Point3.TabIndex = 1;
            // 
            // label_point3
            // 
            this.label_point3.AutoSize = true;
            this.label_point3.Location = new System.Drawing.Point(24, 56);
            this.label_point3.Name = "label_point3";
            this.label_point3.Size = new System.Drawing.Size(41, 12);
            this.label_point3.TabIndex = 0;
            this.label_point3.Text = "點數：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.but_SpendPoint);
            this.tabPage4.Controls.Add(this.textBox_Point4);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(294, 172);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "消費";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // but_SpendPoint
            // 
            this.but_SpendPoint.Location = new System.Drawing.Point(189, 52);
            this.but_SpendPoint.Name = "but_SpendPoint";
            this.but_SpendPoint.Size = new System.Drawing.Size(75, 23);
            this.but_SpendPoint.TabIndex = 2;
            this.but_SpendPoint.Text = "消費點數";
            this.but_SpendPoint.UseVisualStyleBackColor = true;
            // 
            // textBox_Point4
            // 
            this.textBox_Point4.Location = new System.Drawing.Point(71, 52);
            this.textBox_Point4.Name = "textBox_Point4";
            this.textBox_Point4.Size = new System.Drawing.Size(100, 22);
            this.textBox_Point4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "點數：";
            // 
            // tebWriteData
            // 
            this.tebWriteData.Location = new System.Drawing.Point(14, 102);
            this.tebWriteData.Name = "tebWriteData";
            this.tebWriteData.Size = new System.Drawing.Size(219, 22);
            this.tebWriteData.TabIndex = 25;
            this.tebWriteData.TextChanged += new System.EventHandler(this.tebWriteData_TextChanged);
            // 
            // BtnWriteData
            // 
            this.BtnWriteData.Location = new System.Drawing.Point(243, 103);
            this.BtnWriteData.Name = "BtnWriteData";
            this.BtnWriteData.Size = new System.Drawing.Size(75, 23);
            this.BtnWriteData.TabIndex = 26;
            this.BtnWriteData.Text = "Write data";
            this.BtnWriteData.UseVisualStyleBackColor = true;
            this.BtnWriteData.Click += new System.EventHandler(this.BtnWriteData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 389);
            this.Controls.Add(this.BtnWriteData);
            this.Controls.Add(this.tebWriteData);
            this.Controls.Add(this.label_point4);
            this.Controls.Add(this.BtnReadData);
            this.Controls.Add(this.tebReadData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyAB);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.Sector);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "ISO14443A 範例程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.label_point4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox Sector;
        private System.Windows.Forms.ComboBox Block;
        private System.Windows.Forms.ComboBox KeyAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoadKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tebReadData;
        private System.Windows.Forms.Button BtnReadData;
        private System.Windows.Forms.TabControl label_point4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button but_CleanCard;
        private System.Windows.Forms.Button but_SignCard;
        private System.Windows.Forms.TextBox textBox_Point;
        private System.Windows.Forms.TextBox textBox_SignDay;
        private System.Windows.Forms.TextBox textBox_MemName;
        private System.Windows.Forms.TextBox textBox_MemID;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.Label label_SignDay;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_member;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button but_ReadCard;
        private System.Windows.Forms.TextBox textBox_Point2;
        private System.Windows.Forms.TextBox textBox_SignDay2;
        private System.Windows.Forms.TextBox textBox_MemName2;
        private System.Windows.Forms.TextBox textBox_MemID2;
        private System.Windows.Forms.Label label_point2;
        private System.Windows.Forms.Label label_SignDay2;
        private System.Windows.Forms.Label label_name2;
        private System.Windows.Forms.Label label_member2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button but_AddPoint;
        private System.Windows.Forms.TextBox textBox_Point3;
        private System.Windows.Forms.Label label_point3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button but_SpendPoint;
        private System.Windows.Forms.TextBox textBox_Point4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tebWriteData;
        private System.Windows.Forms.Button BtnWriteData;
    }
}

