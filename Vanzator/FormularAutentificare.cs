using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicitatiiDAL;

namespace Vanzator
{
    public partial class FormularAutentificare : Form
    {
        public FormularAutentificare()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void acceptaButon_Click(object sender, EventArgs e)
        {
            var ctx = Program.Context;
            var vanzator = ctx.Utilizatori.OfType<LicitatiiDAL.Vanzator>()
                .Where(v => v.Username.Equals(utilizatorTextbox.Text))
                .Where(v => v.Password.Equals(parolaTextbox.Text))
                .FirstOrDefault();
            if (vanzator != null)
            {
                Program.Vanzator = vanzator;
                errorProvider1.SetError(acceptaButon, string.Empty);
            }
            else
            {
                Program.Vanzator = null;
                DialogResult = System.Windows.Forms.DialogResult.None;
                errorProvider1.SetIconAlignment(acceptaButon, ErrorIconAlignment.MiddleLeft);
                errorProvider1.SetError(acceptaButon, "Utilizator sau parola gresite!");
            }

        }

        private void anuleazaButon_Click(object sender, EventArgs e)
        {

        }
    }
}
