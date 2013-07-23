namespace Vanzator
{
    partial class FormularInregistrareVanzator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label usernameLabel;
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.vanzatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            adresaLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vanzatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(26, 75);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 1;
            adresaLabel.Text = "Adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanzatorBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(90, 72);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 2;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(26, 23);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "Nume:";
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanzatorBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(90, 20);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(26, 127);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanzatorBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(90, 124);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(26, 49);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 9;
            prenumeLabel.Text = "Prenume:";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanzatorBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(90, 46);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeTextBox.TabIndex = 10;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(26, 101);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanzatorBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(90, 98);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 12;
            // 
            // vanzatorBindingSource
            // 
            this.vanzatorBindingSource.DataSource = typeof(LicitatiiDAL.Vanzator);
            // 
            // FormularInregistrareVanzator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 265);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "FormularInregistrareVanzator";
            this.Text = "FormularInregistrareVanzator";
            ((System.ComponentModel.ISupportInitialize)(this.vanzatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vanzatorBindingSource;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}