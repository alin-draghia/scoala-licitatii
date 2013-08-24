namespace Cumparator
{
    partial class FormAutentificare
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.creazaContLink = new System.Windows.Forms.LinkLabel();
            this.btnAccepta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(80, 30);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(169, 20);
            this.tbUser.TabIndex = 1;
            // 
            // btnAnulare
            // 
            this.btnAnulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulare.Location = new System.Drawing.Point(174, 112);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(75, 23);
            this.btnAnulare.TabIndex = 5;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(80, 59);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(169, 20);
            this.tbPass.TabIndex = 2;
            // 
            // creazaContLink
            // 
            this.creazaContLink.AutoSize = true;
            this.creazaContLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creazaContLink.Location = new System.Drawing.Point(76, 82);
            this.creazaContLink.Name = "creazaContLink";
            this.creazaContLink.Size = new System.Drawing.Size(141, 22);
            this.creazaContLink.TabIndex = 3;
            this.creazaContLink.TabStop = true;
            this.creazaContLink.Text = "Creaza cont nou";
            this.creazaContLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creazaContLink_LinkClicked);
            // 
            // btnAccepta
            // 
            this.btnAccepta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccepta.Location = new System.Drawing.Point(93, 112);
            this.btnAccepta.Name = "btnAccepta";
            this.btnAccepta.Size = new System.Drawing.Size(75, 23);
            this.btnAccepta.TabIndex = 4;
            this.btnAccepta.Text = "Accepta";
            this.btnAccepta.UseVisualStyleBackColor = true;
            this.btnAccepta.Click += new System.EventHandler(this.btnAccepta_Click);
            // 
            // FormAutentificare
            // 
            this.AcceptButton = this.btnAccepta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnulare;
            this.ClientSize = new System.Drawing.Size(292, 147);
            this.Controls.Add(this.btnAccepta);
            this.Controls.Add(this.creazaContLink);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Name = "FormAutentificare";
            this.Text = "Autentificare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.LinkLabel creazaContLink;
        private System.Windows.Forms.Button btnAccepta;
    }
}