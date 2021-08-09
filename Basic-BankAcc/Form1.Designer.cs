namespace Qcrotty_Exercise6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccBal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAccHist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTransAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnWithdrawal = new System.Windows.Forms.RadioButton();
            this.rbtnDeposit = new System.Windows.Forms.RadioButton();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account Number:";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNum.Location = new System.Drawing.Point(143, 28);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.ReadOnly = true;
            this.txtAccNum.Size = new System.Drawing.Size(125, 27);
            this.txtAccNum.TabIndex = 0;
            this.txtAccNum.TabStop = false;
            this.txtAccNum.Text = "000302019";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Balance:";
            // 
            // txtAccBal
            // 
            this.txtAccBal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccBal.Location = new System.Drawing.Point(437, 28);
            this.txtAccBal.Name = "txtAccBal";
            this.txtAccBal.ReadOnly = true;
            this.txtAccBal.Size = new System.Drawing.Size(134, 27);
            this.txtAccBal.TabIndex = 0;
            this.txtAccBal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account History:";
            // 
            // lstAccHist
            // 
            this.lstAccHist.FormattingEnabled = true;
            this.lstAccHist.ItemHeight = 20;
            this.lstAccHist.Location = new System.Drawing.Point(606, 68);
            this.lstAccHist.Name = "lstAccHist";
            this.lstAccHist.Size = new System.Drawing.Size(150, 324);
            this.lstAccHist.TabIndex = 10;
            this.lstAccHist.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtTransAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtnWithdrawal);
            this.groupBox1.Controls.Add(this.rbtnDeposit);
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(156, 274);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(374, 27);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Transaction Status:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(7, 175);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTransAmount
            // 
            this.txtTransAmount.Location = new System.Drawing.Point(156, 131);
            this.txtTransAmount.Name = "txtTransAmount";
            this.txtTransAmount.Size = new System.Drawing.Size(125, 27);
            this.txtTransAmount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transaciton Amount:";
            // 
            // rbtnWithdrawal
            // 
            this.rbtnWithdrawal.AutoSize = true;
            this.rbtnWithdrawal.Location = new System.Drawing.Point(6, 92);
            this.rbtnWithdrawal.Name = "rbtnWithdrawal";
            this.rbtnWithdrawal.Size = new System.Drawing.Size(106, 24);
            this.rbtnWithdrawal.TabIndex = 1;
            this.rbtnWithdrawal.TabStop = true;
            this.rbtnWithdrawal.Text = "Withdrawal";
            this.rbtnWithdrawal.UseVisualStyleBackColor = true;
            // 
            // rbtnDeposit
            // 
            this.rbtnDeposit.AutoSize = true;
            this.rbtnDeposit.Location = new System.Drawing.Point(6, 48);
            this.rbtnDeposit.Name = "rbtnDeposit";
            this.rbtnDeposit.Size = new System.Drawing.Size(82, 24);
            this.rbtnDeposit.TabIndex = 0;
            this.rbtnDeposit.TabStop = true;
            this.rbtnDeposit.Text = "Deposit";
            this.rbtnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(26, 409);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(94, 29);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "Get History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(143, 409);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(94, 29);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Get Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(662, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstAccHist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccBal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bank Account Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAccHist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTransAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnWithdrawal;
        private System.Windows.Forms.RadioButton rbtnDeposit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnClose;
    }
}

