namespace IntroducaoForms
{
    partial class RegisterForm
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
            this.LinkLogin = new System.Windows.Forms.LinkLabel();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.Label();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.LabelAge = new System.Windows.Forms.Label();
            this.DateAge = new System.Windows.Forms.DateTimePicker();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LinkLogin
            // 
            this.LinkLogin.AutoSize = true;
            this.LinkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLogin.Location = new System.Drawing.Point(378, 383);
            this.LinkLogin.Name = "LinkLogin";
            this.LinkLogin.Size = new System.Drawing.Size(43, 17);
            this.LinkLogin.TabIndex = 9;
            this.LinkLogin.TabStop = true;
            this.LinkLogin.Text = "Login";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.SystemColors.ControlText;
            this.ButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.Location = new System.Drawing.Point(338, 339);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(124, 41);
            this.ButtonRegister.TabIndex = 8;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(188, 181);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(416, 23);
            this.TxtName.TabIndex = 6;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(185, 165);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Name";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(188, 66);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(416, 23);
            this.TxtEmail.TabIndex = 7;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(185, 50);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(42, 17);
            this.LabelEmail.TabIndex = 5;
            this.LabelEmail.Text = "Email";
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelColor.Location = new System.Drawing.Point(185, 226);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(96, 17);
            this.LabelColor.TabIndex = 4;
            this.LabelColor.Text = "Favorite Color";
            // 
            // TxtColor
            // 
            this.TxtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColor.Location = new System.Drawing.Point(188, 242);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(416, 23);
            this.TxtColor.TabIndex = 6;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAge.Location = new System.Drawing.Point(185, 286);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(33, 17);
            this.LabelAge.TabIndex = 4;
            this.LabelAge.Text = "Age";
            // 
            // DateAge
            // 
            this.DateAge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAge.Location = new System.Drawing.Point(188, 306);
            this.DateAge.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.DateAge.Name = "DateAge";
            this.DateAge.Size = new System.Drawing.Size(93, 20);
            this.DateAge.TabIndex = 10;
            this.DateAge.Value = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(185, 107);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(69, 17);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(188, 123);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(416, 23);
            this.TxtPassword.TabIndex = 7;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateAge);
            this.Controls.Add(this.LinkLogin);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.LabelColor);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LabelEmail);
            this.Name = "RegisterForm";
            this.Text = "Register Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLogin;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.DateTimePicker DateAge;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}