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
    public partial class FormularVanzator : Form
    {
        private LicitatiiContext context = new LicitatiiContext();

        public FormularVanzator()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var produse = context.Produse.Where(p => p.VanzatorId == Program.Vanzator.Id).ToList();
            this.produsBindingSource.DataSource = context.Produse.Local;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
