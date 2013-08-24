namespace Cumparator
{
    partial class FormInregistrare
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
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label usernameLabel;
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.cumparatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.btnAccepta = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cNPLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cumparatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Location = new System.Drawing.Point(31, 99);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(32, 13);
            cNPLabel.TabIndex = 1;
            cNPLabel.Text = "CNP:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(355, 54);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(29, 15);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "Nume:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(155, 138);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(29, 54);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 9;
            prenumeLabel.Text = "Prenume:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(155, 99);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 11;
            telefonLabel.Text = "Telefon:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(33, 138);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 13;
            usernameLabel.Text = "Username:";
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "CNP", true));
            this.cNPTextBox.Location = new System.Drawing.Point(34, 115);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(118, 20);
            this.cNPTextBox.TabIndex = 3;
            // 
            // cumparatorBindingSource
            // 
            this.cumparatorBindingSource.DataSource = typeof(LicitatiiDAL.Cumparator);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(358, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(32, 31);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(226, 20);
            this.numeTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(156, 154);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(32, 70);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(226, 20);
            this.prenumeTextBox.TabIndex = 2;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(158, 115);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cumparatorBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(36, 154);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // btnAccepta
            // 
            this.btnAccepta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccepta.Location = new System.Drawing.Point(102, 194);
            this.btnAccepta.Name = "btnAccepta";
            this.btnAccepta.Size = new System.Drawing.Size(75, 23);
            this.btnAccepta.TabIndex = 7;
            this.btnAccepta.Text = "Accepta";
            this.btnAccepta.UseVisualStyleBackColor = true;
            this.btnAccepta.Click += new System.EventHandler(this.btnAccepta_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulare.Location = new System.Drawing.Point(183, 194);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(75, 23);
            this.btnAnulare.TabIndex = 8;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormInregistrare
            // 
            this.AcceptButton = this.btnAccepta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulare;
            this.ClientSize = new System.Drawing.Size(296, 253);
            this.Controls.Add(this.btnAccepta);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "FormInregistrare";
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.FormInregistrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cumparatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cumparatorBindingSource;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button btnAccepta;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}