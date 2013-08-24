using LicitatiiDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanzator
{
    public partial class FormAddProdus : Form
    {

        public Produs Produs { get; set; }

        public FormAddProdus()
        {
            InitializeComponent();
        }

        private void FormAddProdus_Load(object sender, EventArgs e)
        {

            produsBindingSource.DataSource = Produs;
        }

        private void btnAccepta_Click(object sender, EventArgs e)
        {
            // todo: validare date 
            bool valid = true;
            
            if (string.IsNullOrWhiteSpace(numeTextBox.Text))
            {
                errorProvider1.SetError(numeTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(numeTextBox, null);
            }

            if (string.IsNullOrWhiteSpace(descriereTextBox.Text))
            {
                errorProvider1.SetError(descriereTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(descriereTextBox, null);
            }

            if (pretDeInceputNumericUpDown.Value <= 0.0M)
            {
                errorProvider1.SetError(pretDeInceputNumericUpDown, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(pretDeInceputNumericUpDown, null);
            }

            if (dataDeInceputDateTimePicker.Value < DateTime.Now)
            {
                errorProvider1.SetError(dataDeInceputDateTimePicker, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(dataDeInceputDateTimePicker, null);
            }

            if (dataDeSfarsitDateTimePicker.Value < dataDeInceputDateTimePicker.Value)
            {
                errorProvider1.SetError(dataDeSfarsitDateTimePicker, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(dataDeSfarsitDateTimePicker, null);
            }

            if (valid)
            {

            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                
            }

        }

        
    }
}
