namespace Vanzator
{
    partial class FormAddProdus
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
            System.Windows.Forms.Label dataDeInceputLabel;
            System.Windows.Forms.Label dataDeSfarsitLabel;
            System.Windows.Forms.Label descriereLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label pretDeInceputLabel;
            System.Windows.Forms.Label pretLicitatLabel;
            this.dataDeInceputDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDeSfarsitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriereTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.pretLicitatTextBox = new System.Windows.Forms.TextBox();
            this.pretDeInceputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnAccepta = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            dataDeInceputLabel = new System.Windows.Forms.Label();
            dataDeSfarsitLabel = new System.Windows.Forms.Label();
            descriereLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            pretDeInceputLabel = new System.Windows.Forms.Label();
            pretLicitatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDeInceputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDeInceputLabel
            // 
            dataDeInceputLabel.AutoSize = true;
            dataDeInceputLabel.Location = new System.Drawing.Point(251, 41);
            dataDeInceputLabel.Name = "dataDeInceputLabel";
            dataDeInceputLabel.Size = new System.Drawing.Size(58, 13);
            dataDeInceputLabel.TabIndex = 1;
            dataDeInceputLabel.Text = "Data Start:";
            // 
            // dataDeSfarsitLabel
            // 
            dataDeSfarsitLabel.AutoSize = true;
            dataDeSfarsitLabel.Location = new System.Drawing.Point(251, 82);
            dataDeSfarsitLabel.Name = "dataDeSfarsitLabel";
            dataDeSfarsitLabel.Size = new System.Drawing.Size(65, 13);
            dataDeSfarsitLabel.TabIndex = 3;
            dataDeSfarsitLabel.Text = "Data Sfarsit:";
            // 
            // descriereLabel
            // 
            descriereLabel.AutoSize = true;
            descriereLabel.Location = new System.Drawing.Point(40, 82);
            descriereLabel.Name = "descriereLabel";
            descriereLabel.Size = new System.Drawing.Size(55, 13);
            descriereLabel.TabIndex = 5;
            descriereLabel.Text = "Descriere:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(40, 331);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(40, 41);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 9;
            numeLabel.Text = "Nume:";
            // 
            // pretDeInceputLabel
            // 
            pretDeInceputLabel.AutoSize = true;
            pretDeInceputLabel.Location = new System.Drawing.Point(251, 121);
            pretDeInceputLabel.Name = "pretDeInceputLabel";
            pretDeInceputLabel.Size = new System.Drawing.Size(51, 13);
            pretDeInceputLabel.TabIndex = 11;
            pretDeInceputLabel.Text = "Pret Start";
            // 
            // pretLicitatLabel
            // 
            pretLicitatLabel.AutoSize = true;
            pretLicitatLabel.Location = new System.Drawing.Point(40, 292);
            pretLicitatLabel.Name = "pretLicitatLabel";
            pretLicitatLabel.Size = new System.Drawing.Size(60, 13);
            pretLicitatLabel.TabIndex = 13;
            pretLicitatLabel.Text = "Pret Licitat:";
            pretLicitatLabel.Visible = false;
            // 
            // dataDeInceputDateTimePicker
            // 
            this.dataDeInceputDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dataDeInceputDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produsBindingSource, "DataDeInceput", true));
            this.dataDeInceputDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDeInceputDateTimePicker.Location = new System.Drawing.Point(254, 57);
            this.dataDeInceputDateTimePicker.Name = "dataDeInceputDateTimePicker";
            this.dataDeInceputDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.dataDeInceputDateTimePicker.TabIndex = 2;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataSource = typeof(LicitatiiDAL.Produs);
            // 
            // dataDeSfarsitDateTimePicker
            // 
            this.dataDeSfarsitDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dataDeSfarsitDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produsBindingSource, "DataDeSfarsit", true));
            this.dataDeSfarsitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataDeSfarsitDateTimePicker.Location = new System.Drawing.Point(254, 98);
            this.dataDeSfarsitDateTimePicker.Name = "dataDeSfarsitDateTimePicker";
            this.dataDeSfarsitDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.dataDeSfarsitDateTimePicker.TabIndex = 3;
            // 
            // descriereTextBox
            // 
            this.descriereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Descriere", true));
            this.descriereTextBox.Location = new System.Drawing.Point(43, 98);
            this.descriereTextBox.Multiline = true;
            this.descriereTextBox.Name = "descriereTextBox";
            this.descriereTextBox.Size = new System.Drawing.Size(200, 117);
            this.descriereTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(43, 347);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.Visible = false;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(41, 57);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 0;
            // 
            // pretLicitatTextBox
            // 
            this.pretLicitatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "PretLicitat", true));
            this.pretLicitatTextBox.Location = new System.Drawing.Point(43, 308);
            this.pretLicitatTextBox.Name = "pretLicitatTextBox";
            this.pretLicitatTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretLicitatTextBox.TabIndex = 14;
            this.pretLicitatTextBox.Visible = false;
            // 
            // pretDeInceputNumericUpDown
            // 
            this.pretDeInceputNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produsBindingSource, "PretDeInceput", true));
            this.pretDeInceputNumericUpDown.DecimalPlaces = 2;
            this.pretDeInceputNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pretDeInceputNumericUpDown.Location = new System.Drawing.Point(254, 137);
            this.pretDeInceputNumericUpDown.Name = "pretDeInceputNumericUpDown";
            this.pretDeInceputNumericUpDown.Size = new System.Drawing.Size(133, 20);
            this.pretDeInceputNumericUpDown.TabIndex = 4;
            this.pretDeInceputNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pretDeInceputNumericUpDown.ThousandsSeparator = true;
            // 
            // btnAccepta
            // 
            this.btnAccepta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccepta.Location = new System.Drawing.Point(254, 163);
            this.btnAccepta.Name = "btnAccepta";
            this.btnAccepta.Size = new System.Drawing.Size(133, 23);
            this.btnAccepta.TabIndex = 16;
            this.btnAccepta.TabStop = false;
            this.btnAccepta.Text = "Accepta";
            this.btnAccepta.UseVisualStyleBackColor = true;
            this.btnAccepta.Click += new System.EventHandler(this.btnAccepta_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(254, 192);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(133, 23);
            this.btnAnuleaza.TabIndex = 17;
            this.btnAnuleaza.TabStop = false;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddProdus
            // 
            this.AcceptButton = this.btnAccepta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(438, 269);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnAccepta);
            this.Controls.Add(this.pretDeInceputNumericUpDown);
            this.Controls.Add(dataDeInceputLabel);
            this.Controls.Add(this.dataDeInceputDateTimePicker);
            this.Controls.Add(dataDeSfarsitLabel);
            this.Controls.Add(this.dataDeSfarsitDateTimePicker);
            this.Controls.Add(descriereLabel);
            this.Controls.Add(this.descriereTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(pretDeInceputLabel);
            this.Controls.Add(pretLicitatLabel);
            this.Controls.Add(this.pretLicitatTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddProdus";
            this.ShowInTaskbar = false;
            this.Text = "Adaugare Produs...";
            this.Load += new System.EventHandler(this.FormAddProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretDeInceputNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataDeInceputDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataDeSfarsitDateTimePicker;
        private System.Windows.Forms.TextBox descriereTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox pretLicitatTextBox;
        private System.Windows.Forms.NumericUpDown pretDeInceputNumericUpDown;
        private System.Windows.Forms.Button btnAccepta;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.BindingSource produsBindingSource;
    }
}