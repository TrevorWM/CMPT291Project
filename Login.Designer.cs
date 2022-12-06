
namespace _291_Project
{
    partial class Login
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
            this.UnameTB = new System.Windows.Forms.TextBox();
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.CustLoginBTN = new System.Windows.Forms.Button();
            this.EmpLoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnameTB
            // 
            this.UnameTB.BackColor = System.Drawing.Color.Gold;
            this.UnameTB.Location = new System.Drawing.Point(141, 115);
            this.UnameTB.MaxLength = 50;
            this.UnameTB.Name = "UnameTB";
            this.UnameTB.Size = new System.Drawing.Size(210, 23);
            this.UnameTB.TabIndex = 55;
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.AutoSize = true;
            this.UsernameLBL.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLBL.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLBL.ForeColor = System.Drawing.Color.Gold;
            this.UsernameLBL.Location = new System.Drawing.Point(176, 94);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(137, 18);
            this.UsernameLBL.TabIndex = 58;
            this.UsernameLBL.Text = "Enter Username";
            // 
            // ExitBTN
            // 
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBTN.ForeColor = System.Drawing.Color.Gold;
            this.ExitBTN.Location = new System.Drawing.Point(192, 175);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(102, 25);
            this.ExitBTN.TabIndex = 78;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // CustLoginBTN
            // 
            this.CustLoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustLoginBTN.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustLoginBTN.ForeColor = System.Drawing.Color.Gold;
            this.CustLoginBTN.Location = new System.Drawing.Point(249, 144);
            this.CustLoginBTN.Name = "CustLoginBTN";
            this.CustLoginBTN.Size = new System.Drawing.Size(102, 25);
            this.CustLoginBTN.TabIndex = 79;
            this.CustLoginBTN.Text = "Customer";
            this.CustLoginBTN.UseVisualStyleBackColor = true;
            this.CustLoginBTN.Click += new System.EventHandler(this.CustLoginBTN_Click);
            // 
            // EmpLoginBTN
            // 
            this.EmpLoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpLoginBTN.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpLoginBTN.ForeColor = System.Drawing.Color.Gold;
            this.EmpLoginBTN.Location = new System.Drawing.Point(141, 144);
            this.EmpLoginBTN.Name = "EmpLoginBTN";
            this.EmpLoginBTN.Size = new System.Drawing.Size(102, 25);
            this.EmpLoginBTN.TabIndex = 80;
            this.EmpLoginBTN.Text = "Employee";
            this.EmpLoginBTN.UseVisualStyleBackColor = true;
            this.EmpLoginBTN.Click += new System.EventHandler(this.EmpLoginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(167, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 50);
            this.label1.TabIndex = 81;
            this.label1.Text = "TBMRS";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(492, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpLoginBTN);
            this.Controls.Add(this.CustLoginBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.UsernameLBL);
            this.Controls.Add(this.UnameTB);
            this.Name = "Login";
            this.Text = "TBMRS - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnameTB;
        private System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button CustLoginBTN;
        private System.Windows.Forms.Button EmpLoginBTN;
        private System.Windows.Forms.Label label1;
    }
}

