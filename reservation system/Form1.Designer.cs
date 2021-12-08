namespace reservation_system
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mcaDate = new System.Windows.Forms.MonthCalendar();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboNum = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂房系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcaDate
            // 
            this.mcaDate.Location = new System.Drawing.Point(40, 119);
            this.mcaDate.Name = "mcaDate";
            this.mcaDate.TabIndex = 1;
            this.mcaDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcaDate_DateChanged);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStart.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStart.Location = new System.Drawing.Point(376, 119);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(146, 25);
            this.lblStart.TabIndex = 2;
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEnd.Location = new System.Drawing.Point(376, 161);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(146, 25);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnd.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(285, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "入住日期 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(285, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "退房日期 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(298, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "房型 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(298, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "房數 : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboRoom
            // 
            this.cboRoom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(376, 206);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(175, 20);
            this.cboRoom.TabIndex = 8;
            // 
            // cboNum
            // 
            this.cboNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNum.FormattingEnabled = true;
            this.cboNum.Location = new System.Drawing.Point(376, 242);
            this.cboNum.Name = "cboNum";
            this.cboNum.Size = new System.Drawing.Size(68, 20);
            this.cboNum.TabIndex = 9;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Location = new System.Drawing.Point(476, 242);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 32);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "確定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShow.Location = new System.Drawing.Point(12, 316);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(575, 163);
            this.lblShow.TabIndex = 11;
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 488);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cboNum);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.mcaDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcaDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboNum;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblShow;
    }
}

