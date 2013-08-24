using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cumparator
{
    public partial class FormInregistrare : Form
    {

        public LicitatiiDAL.Cumparator Cumparator { get; set; }

        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void btnAccepta_Click(object sender, EventArgs e)
        {
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
            if (string.IsNullOrWhiteSpace(prenumeTextBox.Text))
            {
                errorProvider1.SetError(prenumeTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(prenumeTextBox, null);
            }
            if (string.IsNullOrWhiteSpace(cNPTextBox.Text))
            {
                errorProvider1.SetError(cNPTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(cNPTextBox, null);
            }
            if (string.IsNullOrWhiteSpace(telefonTextBox.Text))
            {
                errorProvider1.SetError(telefonTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(telefonTextBox, null);
            }
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                errorProvider1.SetError(usernameTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(usernameTextBox, null);
            }
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider1.SetError(passwordTextBox, "Invalid");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(passwordTextBox, null);
            }

            if (valid)
            {
                using (var ctx = new LicitatiiDAL.LicitatiiContext())
                {
                    ctx.Utilizatori.Add(this.Cumparator);
                    ctx.SaveChanges();
                }
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
            }
          
        }

        private void FormInregistrare_Load(object sender, EventArgs e)
        {
            Cumparator = new LicitatiiDAL.Cumparator();
            cumparatorBindingSource.DataSource = Cumparator;
        }
    }
}
