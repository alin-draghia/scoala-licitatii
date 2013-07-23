namespace Vanzator
{
    partial class FormularAutentificare
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
            this.utilizatorTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parolaTextbox = new System.Windows.Forms.TextBox();
            this.anuleazaButon = new System.Windows.Forms.Button();
            this.acceptaButon = new System.Windows.Forms.Button();
            this.creazaContLink = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator:";
            // 
            // utilizatorTextbox
            // 
            this.utilizatorTextbox.Location = new System.Drawing.Point(83, 20);
            this.utilizatorTextbox.Name = "utilizatorTextbox";
            this.utilizatorTextbox.Size = new System.Drawing.Size(189, 20);
            this.utilizatorTextbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola:";
            // 
            // parolaTextbox
            // 
            this.parolaTextbox.Location = new System.Drawing.Point(83, 46);
            this.parolaTextbox.Name = "parolaTextbox";
            this.parolaTextbox.Size = new System.Drawing.Size(189, 20);
            this.parolaTextbox.TabIndex = 1;
            this.parolaTextbox.UseSystemPasswordChar = true;
            // 
            // anuleazaButon
            // 
            this.anuleazaButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anuleazaButon.Location = new System.Drawing.Point(197, 102);
            this.anuleazaButon.Name = "anuleazaButon";
            this.anuleazaButon.Size = new System.Drawing.Size(75, 23);
            this.anuleazaButon.TabIndex = 2;
            this.anuleazaButon.TabStop = false;
            this.anuleazaButon.Text = "Anuleaza";
            this.anuleazaButon.UseVisualStyleBackColor = true;
            this.anuleazaButon.Click += new System.EventHandler(this.anuleazaButon_Click);
            // 
            // acceptaButon
            // 
            this.acceptaButon.Location = new System.Drawing.Point(116, 102);
            this.acceptaButon.Name = "acceptaButon";
            this.acceptaButon.Size = new System.Drawing.Size(75, 23);
            this.acceptaButon.TabIndex = 2;
            this.acceptaButon.TabStop = false;
            this.acceptaButon.Text = "Accepta";
            this.acceptaButon.UseVisualStyleBackColor = true;
            this.acceptaButon.Click += new System.EventHandler(this.acceptaButon_Click);
            // 
            // creazaContLink
            // 
            this.creazaContLink.AutoSize = true;
            this.creazaContLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creazaContLink.Location = new System.Drawing.Point(80, 69);
            this.creazaContLink.Name = "creazaContLink";
            this.creazaContLink.Size = new System.Drawing.Size(141, 22);
            this.creazaContLink.TabIndex = 2;
            this.creazaContLink.TabStop = true;
            this.creazaContLink.Text = "Creaza cont nou";
            this.creazaContLink.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormaAutentificare
            // 
            this.AcceptButton = this.acceptaButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuleazaButon;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.creazaContLink);
            this.Controls.Add(this.acceptaButon);
            this.Controls.Add(this.anuleazaButon);
            this.Controls.Add(this.parolaTextbox);
            this.Controls.Add(this.utilizatorTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaAutentificare";
            this.Text = "Formular Autentificare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox utilizatorTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parolaTextbox;
        private System.Windows.Forms.Button anuleazaButon;
        private System.Windows.Forms.Button acceptaButon;
        private System.Windows.Forms.LinkLabel creazaContLink;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}