using LicitatiiDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanzator
{
    public partial class FormVanzator : Form
    {
        enum Filtru
        {
            Active,
            Vandute,
            Nevandute
        }


        public FormVanzator()
        {
            InitializeComponent();
        }

        private void FormVanzator_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.ComboBox.DataSource = Enum.GetValues(typeof(Filtru));
            toolStripComboBox1.ComboBox.SelectedValueChanged += ComboBox_SelectedValueChanged;
            updateBinding();
            timer1.Enabled = true;
        }

        void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateBinding();
        }

        private void updateBinding()
        {
            var ctx = Program.Context;
            //hack ef
            var vanzator = Program.Vanzator;
            object prods = vanzator.Produs;

            Filtru filtru;
            Enum.TryParse<Filtru>(toolStripComboBox1.ComboBox.SelectedValue.ToString(), out filtru);
            switch (filtru)
            {
                case Filtru.Active:
                    prods = vanzator.Produs.Where(p => p.DataDeSfarsit > DateTime.Now);
                    break;
                case Filtru.Vandute:
                    prods = vanzator.Produs.Where(p => p.DataDeSfarsit < DateTime.Now && p.Cumparator != null);
                    break;
                case Filtru.Nevandute:
                    prods = vanzator.Produs.Where(p => p.DataDeSfarsit < DateTime.Now && p.Cumparator == null);
                    break;
                default:
                    break;
            }

            produsBindingSource.DataSource = null;
            produsBindingSource.DataSource = prods;
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var dlgAddProdus = new FormAddProdus();


            /*
             * Noto: Entity framework este o porcarie
             */
            var oc = ((IObjectContextAdapter)Program.Context).ObjectContext;
            var p = oc.CreateObject<Produs>();

            
            p.Vanzator = Program.Vanzator;
            p.DataDeInceput = DateTime.Now.AddMinutes(5.0);
            p.DataDeSfarsit = DateTime.Now.AddMinutes(10.0);

            dlgAddProdus.Produs = p;

            if (dlgAddProdus.ShowDialog() == DialogResult.OK)
            {
                var prods = Program.Vanzator.Produs;
                prods.Add(dlgAddProdus.Produs);
                // this might throw dbexception
                Program.Context.SaveChanges();

                updateBinding();

            }
            else
            {
                produsBindingSource.CancelEdit();
            }
            timer1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var raspuns = MessageBox.Show("Doriti sa stergeti produsul?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (raspuns == System.Windows.Forms.DialogResult.Yes)
            {
                var prod = produsBindingSource.Current;
                Program.Vanzator.Produs.Remove((Produs)prod);
                Program.Context.SaveChanges();
                updateBinding();
            }
            timer1.Enabled = true;
        }

        private void produsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            timer1.Enabled = false;
            Filtru filtru;
            Enum.TryParse<Filtru>(toolStripComboBox1.ComboBox.SelectedValue.ToString(), out filtru);

            if (filtru == Filtru.Vandute)
            {
                timer1.Enabled = true;
                return;
            }

            var row = e.RowIndex;

            var dlgAddProdus = new FormAddProdus();
            dlgAddProdus.Text = "Editare Produs";


            var p = (Produs)produsBindingSource.List[row];
           
            dlgAddProdus.Produs = p;

            if (dlgAddProdus.ShowDialog() == DialogResult.OK)
            {
                var prods = Program.Vanzator.Produs;
                prods.Add(dlgAddProdus.Produs);
                // this might throw dbexception
                Program.Context.SaveChanges();

                updateBinding();

            }
            else
            {
                produsBindingSource.CancelEdit();
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateBinding();
        }

       
    }
}
