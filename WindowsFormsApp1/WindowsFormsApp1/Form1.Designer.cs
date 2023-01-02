
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.Username_L = new System.Windows.Forms.Label();
            this.Username_fill = new System.Windows.Forms.TextBox();
            this.Password_fill = new System.Windows.Forms.TextBox();
            this.Password_L = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TermsCheck = new System.Windows.Forms.CheckBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LoggedInpage = new System.Windows.Forms.Panel();
            this.Logged_in = new System.Windows.Forms.Label();
            this.LoggedInpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AccessibleName = "Title";
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Bauhaus 93", 68F);
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Location = new System.Drawing.Point(12, 76);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(329, 103);
            this.Title.TabIndex = 0;
            this.Title.Text = "SIGN IN";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username_L
            // 
            this.Username_L.AutoSize = true;
            this.Username_L.BackColor = System.Drawing.Color.Transparent;
            this.Username_L.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Username_L.Font = new System.Drawing.Font("Book Antiqua", 10.25F);
            this.Username_L.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Username_L.Location = new System.Drawing.Point(41, 204);
            this.Username_L.Name = "Username_L";
            this.Username_L.Size = new System.Drawing.Size(72, 18);
            this.Username_L.TabIndex = 1;
            this.Username_L.Text = "Username";
            this.Username_L.Click += new System.EventHandler(this.label2_Click);
            // 
            // Username_fill
            // 
            this.Username_fill.AccessibleName = "Username_TypeBox";
            this.Username_fill.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Username_fill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Username_fill.Location = new System.Drawing.Point(44, 222);
            this.Username_fill.Name = "Username_fill";
            this.Username_fill.Size = new System.Drawing.Size(264, 13);
            this.Username_fill.TabIndex = 2;
            this.Username_fill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_fill
            // 
            this.Password_fill.AccessibleName = "Password_TypeBox";
            this.Password_fill.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Password_fill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Password_fill.Location = new System.Drawing.Point(44, 270);
            this.Password_fill.Name = "Password_fill";
            this.Password_fill.Size = new System.Drawing.Size(264, 13);
            this.Password_fill.TabIndex = 4;
            this.Password_fill.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Password_L
            // 
            this.Password_L.AutoSize = true;
            this.Password_L.BackColor = System.Drawing.Color.Transparent;
            this.Password_L.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Password_L.Font = new System.Drawing.Font("Book Antiqua", 10.25F);
            this.Password_L.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Password_L.Location = new System.Drawing.Point(41, 252);
            this.Password_L.Name = "Password_L";
            this.Password_L.Size = new System.Drawing.Size(70, 18);
            this.Password_L.TabIndex = 3;
            this.Password_L.Text = "Password";
            this.Password_L.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(58, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "I agree to the ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(124, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Terms and conditions";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TermsCheck
            // 
            this.TermsCheck.AccessibleName = "AgreeCheck";
            this.TermsCheck.AutoSize = true;
            this.TermsCheck.BackColor = System.Drawing.Color.Transparent;
            this.TermsCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TermsCheck.Location = new System.Drawing.Point(45, 343);
            this.TermsCheck.Name = "TermsCheck";
            this.TermsCheck.Size = new System.Drawing.Size(15, 14);
            this.TermsCheck.TabIndex = 7;
            this.TermsCheck.UseVisualStyleBackColor = false;
            this.TermsCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignIn
            // 
            this.SignIn.AccessibleName = "SignIN";
            this.SignIn.BackColor = System.Drawing.Color.Blue;
            this.SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.Enabled = false;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.SignIn.Location = new System.Drawing.Point(44, 389);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(92, 39);
            this.SignIn.TabIndex = 8;
            this.SignIn.Text = "SIGN IN";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Exit";
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Exit.FlatAppearance.BorderSize = 3;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Tomato;
            this.Exit.Location = new System.Drawing.Point(142, 389);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 39);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoggedInpage
            // 
            this.LoggedInpage.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.B5;
            this.LoggedInpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoggedInpage.Controls.Add(this.Logged_in);
            this.LoggedInpage.Enabled = false;
            this.LoggedInpage.Location = new System.Drawing.Point(-18, 0);
            this.LoggedInpage.Name = "LoggedInpage";
            this.LoggedInpage.Size = new System.Drawing.Size(895, 485);
            this.LoggedInpage.TabIndex = 10;
            this.LoggedInpage.Visible = false;
            this.LoggedInpage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logged_in
            // 
            this.Logged_in.AccessibleName = "Title";
            this.Logged_in.AutoSize = true;
            this.Logged_in.BackColor = System.Drawing.Color.Transparent;
            this.Logged_in.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logged_in.Font = new System.Drawing.Font("Bauhaus 93", 68F);
            this.Logged_in.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logged_in.Location = new System.Drawing.Point(205, 269);
            this.Logged_in.Name = "Logged_in";
            this.Logged_in.Size = new System.Drawing.Size(474, 103);
            this.Logged_in.TabIndex = 11;
            this.Logged_in.Text = "LOGGED IN";
            this.Logged_in.Visible = false;
            this.Logged_in.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.B5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 476);
            this.Controls.Add(this.LoggedInpage);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.TermsCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password_fill);
            this.Controls.Add(this.Password_L);
            this.Controls.Add(this.Username_fill);
            this.Controls.Add(this.Username_L);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoggedInpage.ResumeLayout(false);
            this.LoggedInpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Username_L;
        private System.Windows.Forms.TextBox Username_fill;
        private System.Windows.Forms.TextBox Password_fill;
        private System.Windows.Forms.Label Password_L;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox TermsCheck;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel LoggedInpage;
        private System.Windows.Forms.Label Logged_in;
    }
}

