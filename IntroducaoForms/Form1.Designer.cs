namespace IntroducaoForms
{
    partial class LoginForm
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
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.ButtonJoin = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LinkRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(192, 70);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(42, 17);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(195, 86);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(416, 23);
            this.TxtEmail.TabIndex = 1;
            // 
            // ButtonJoin
            // 
            this.ButtonJoin.BackColor = System.Drawing.SystemColors.ControlText;
            this.ButtonJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonJoin.ForeColor = System.Drawing.Color.White;
            this.ButtonJoin.Location = new System.Drawing.Point(336, 228);
            this.ButtonJoin.Name = "ButtonJoin";
            this.ButtonJoin.Size = new System.Drawing.Size(124, 41);
            this.ButtonJoin.TabIndex = 2;
            this.ButtonJoin.Text = "Join";
            this.ButtonJoin.UseVisualStyleBackColor = false;
            this.ButtonJoin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonJoin_MouseClick);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(192, 154);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(69, 17);
            this.LabelPassword.TabIndex = 0;
            this.LabelPassword.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(195, 170);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(416, 23);
            this.TxtPassword.TabIndex = 1;
            // 
            // LinkRegister
            // 
            this.LinkRegister.AutoSize = true;
            this.LinkRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRegister.Location = new System.Drawing.Point(364, 272);
            this.LinkRegister.Name = "LinkRegister";
            this.LinkRegister.Size = new System.Drawing.Size(61, 17);
            this.LinkRegister.TabIndex = 3;
            this.LinkRegister.TabStop = true;
            this.LinkRegister.Text = "Register";
            this.LinkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegister_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.LinkRegister);
            this.Controls.Add(this.ButtonJoin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LabelEmail);
            this.Name = "LoginForm";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button ButtonJoin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel LinkRegister;
    }
}

