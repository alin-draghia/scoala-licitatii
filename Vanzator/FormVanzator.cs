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

            this.Text = "Vanzator - " + vanzator.Nume + " " + vanzator.Prenume;

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


            var maxProd = vanzator.Produs
                .Where(p => p.CumparatorId != null && p.DataDeSfarsit < DateTime.Now)
                .Select(p => new
                {
                    p.Id,
                    p.Nume,
                    p.PretDeInceput,
                    p.PretLicitat,
                    Profit = p.PretLicitat - p.PretDeInceput
                }).OrderByDescending(v => v.Profit)
                .FirstOrDefault();

            if (maxProd != null)
            {
                tbNumeCeaMaiBunaLicitatie.Text = maxProd.Nume;
                tbPretStartCeaMaiBunaLicitatie.Text = maxProd.PretDeInceput.ToString();
                tbPretSfarsitCeaMaiBunaLicitatie.Text = maxProd.PretLicitat.ToString();
            }

            var minProd = vanzator.Produs
               .Where(p => p.CumparatorId != null && p.DataDeSfarsit < DateTime.Now)
               .Select(p => new
               {
                   p.Id,
                   p.Nume,
                   p.PretDeInceput,
                   p.PretLicitat,
                   Profit = p.PretLicitat - p.PretDeInceput
               }).OrderBy(v => v.Profit)
               .FirstOrDefault();

            if (minProd != null)
            {
                tbNumeCeaMaiSlabaLicitatie.Text = minProd.Nume;
                tbPretStartCeaMaiSlabaLicitatie.Text = minProd.PretDeInceput.ToString();
                tbPretSfarsitCeaMaiSlabaLicitatie.Text = minProd.PretLicitat.ToString();
            }

            var incasari = vanzator.Produs
               .Where(p => p.CumparatorId != null && p.DataDeSfarsit < DateTime.Now)
               .Select(p => new
               {
                   p.PretLicitat,
               }).Sum(p => p.PretLicitat).GetValueOrDefault(0.0m);

            tbValTotalIncasari.Text = incasari.ToString();


            var profit = vanzator.Produs
               .Where(p => p.CumparatorId != null && p.DataDeSfarsit < DateTime.Now)
               .Select(p => new
               {
                   Profit = p.PretLicitat - p.PretDeInceput
               }).Sum(p => p.Profit).GetValueOrDefault(0.0m);

            tbProfit.Text = profit.ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

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

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            var raspuns = MessageBox.Show("Doriti sa stergeti produsul?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (raspuns == System.Windows.Forms.DialogResult.Yes)
            {
                var prod = produsBindingSource.Current;
                Program.Vanzator.Produs.Remove((Produs)prod);
                Program.Context.SaveChanges();
                updateBinding();
            }

        }

        private void produsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            Filtru filtru;
            Enum.TryParse<Filtru>(toolStripComboBox1.ComboBox.SelectedValue.ToString(), out filtru);

            if (filtru == Filtru.Vandute)
            {
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

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*
             * recontectare in caz ca datele au fost modificate in afara aplicatiei curente
             */
            Program.Context.Dispose();
            Program.Context = new LicitatiiContext();
            Program.Vanzator = Program.Context.Utilizatori.OfType<LicitatiiDAL.Vanzator>().Where(u => u.Id == Program.Vanzator.Id).FirstOrDefault();
            updateBinding();
        }


    }
}
