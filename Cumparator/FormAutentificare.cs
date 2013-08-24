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
    public partial class FormAutentificare : Form
    {
        public LicitatiiDAL.Cumparator Cumparator { get; set; }

        public FormAutentificare()
        {
            InitializeComponent();
        }

        private void creazaContLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var contDlg = new FormInregistrare();
            contDlg.ShowDialog();
            tbUser.Text = string.Empty;
            tbPass.Text = string.Empty;
        }

        private void btnAccepta_Click(object sender, EventArgs e)
        {
            using (var ctx = new LicitatiiDAL.LicitatiiContext())
            {
                var cumparator = ctx.Utilizatori.OfType<LicitatiiDAL.Cumparator>()
                    .Where(v => v.Username.Equals(tbUser.Text))
                    .Where(v => v.Password.Equals(tbPass.Text))
                    .FirstOrDefault();
                if (cumparator != null)
                {
                    Program.Cumparator = cumparator;
                    errorProvider1.SetError(btnAccepta, string.Empty);
                }
                else
                {
                    Program.Cumparator = null;
                    DialogResult = System.Windows.Forms.DialogResult.None;
                    errorProvider1.SetIconAlignment(btnAccepta, ErrorIconAlignment.MiddleLeft);
                    errorProvider1.SetError(btnAccepta, "Utilizator sau parola gresite!");
                }
            }
        }
    }
}
