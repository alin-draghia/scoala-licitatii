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

namespace Cumparator
{
    public partial class FormCumparator : Form
    {
        enum Filtru
        {
            Active,
            Cumparate,
            Licitate
        }

        public FormCumparator()
        {
            InitializeComponent();
        }

        private void FormCumparator_Load(object sender, EventArgs e)
        {
            var cumparator = Program.Cumparator;
            this.Text = "Cumparator - " + cumparator.Nume + " " + cumparator.Prenume;

            cbFiltru.ComboBox.DataSource = Enum.GetValues(typeof(Filtru));
            cbFiltru.ComboBox.SelectedValueChanged += ComboBox_SelectedValueChanged;
    
            RefreshData();

            errorProvider1.SetIconAlignment(tbPretLicitat.TextBox, ErrorIconAlignment.MiddleLeft);
            errorProvider1.SetError(tbPretLicitat.TextBox, null);

        }

        private void RefreshData()
        {
           
            Filtru filtru;
            Enum.TryParse<Filtru>(cbFiltru.ComboBox.SelectedValue.ToString(), out filtru);

            switch (filtru)
            {
                case Filtru.Active:

                    using (var ctx = new LicitatiiDAL.LicitatiiContext())
                    {
                        var produse = ctx.Produse
                            .Where(p => p.DataDeSfarsit > DateTime.Now)
                            .Select(p=> new {
                                p.Id,
                                p.Nume,
                                p.Descriere,
                                p.DataDeInceput,
                                p.DataDeSfarsit,
                                p.PretDeInceput,
                                p.PretLicitat,
                                p.CumparatorId,
                                p.VanzatorId,
                                Vanzator = p.Vanzator.Nume + " " + p.Vanzator.Prenume
                            }).ToList();

                        produsBindingSource.DataSource = produse;
                    }

                    break;
                case Filtru.Cumparate:
                    using (var ctx = new LicitatiiDAL.LicitatiiContext())
                    {
                        var cumparator = ctx
                            .Utilizatori
                            .OfType<LicitatiiDAL.Cumparator>()
                            .Where(c => c.Id == Program.Cumparator.Id).FirstOrDefault();

                        var produse = cumparator.Produs
                            .Where(p => p.DataDeSfarsit < DateTime.Now)
                            .Select(p=> new {
                                p.Id,
                                p.Nume,
                                p.Descriere,
                                p.DataDeInceput,
                                p.DataDeSfarsit,
                                p.PretDeInceput,
                                p.PretLicitat,
                                p.CumparatorId,
                                p.VanzatorId,
                                Vanzator = p.Vanzator.Nume + " " + p.Vanzator.Prenume
                            }).ToList();
                        produsBindingSource.DataSource = produse;
                    }
                    break;
                case Filtru.Licitate:
                    using (var ctx = new LicitatiiContext())
                    {
                        var cumparator = ctx
                                .Utilizatori
                                .OfType<LicitatiiDAL.Cumparator>()
                                .Where(c => c.Id == Program.Cumparator.Id).FirstOrDefault();

                        var produse = cumparator.Produs
                            .Where(p => p.DataDeSfarsit > DateTime.Now)
                            .Select(p => new
                            {
                                p.Id,
                                p.Nume,
                                p.Descriere,
                                p.DataDeInceput,
                                p.DataDeSfarsit,
                                p.PretDeInceput,
                                p.PretLicitat,
                                p.CumparatorId,
                                p.VanzatorId,
                                Vanzator = p.Vanzator.Nume + " " + p.Vanzator.Prenume
                            }).ToList();
                        produsBindingSource.DataSource = produse;
                    }
                    break;
                default:
                    break;
            }

            using (var ctx = new LicitatiiContext())
            {
                var totalCheltuit = ctx.Produse
                    .Where(p => p.CumparatorId == Program.Cumparator.Id && p.DataDeSfarsit < DateTime.Now)
                    .Select(p => new { val = p.PretLicitat })
                    .Sum(p => p.val).GetValueOrDefault(0.0m);
                tbTotalCheltuit.Text = totalCheltuit.ToString();
            }

        }

        void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

      
        private void produsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            dynamic produs = produsBindingSource.Current;
            if (produs != null)
            {
                var pretCurent = produs.PretLicitat > produs.PretDeInceput ? produs.PretLicitat : produs.PretDeInceput;
                tbPretLicitat.Text = pretCurent.ToString();
            }
            else
            {
                tbPretLicitat.Text = string.Empty;
            }
        }

        private void btnUrcaPretul_Click(object sender, EventArgs e)
        {
            Decimal pretCurent;
            Decimal.TryParse(tbPretLicitat.Text, out pretCurent);
            pretCurent += 5.0M;
            tbPretLicitat.Text = pretCurent.ToString();
        }

        private void btnLiciteaza_Click(object sender, EventArgs e)
        {
            dynamic produsCurent = produsBindingSource.Current;
            using (var ctx = new LicitatiiContext())
            {
                int produsId = produsCurent.Id;
                var produsDb = ctx.Produse
                    .Where(p => p.Id == produsId)
                    .FirstOrDefault();

                Decimal pretCurent;
                Decimal.TryParse(tbPretLicitat.Text, out pretCurent);
                if (produsDb.PretLicitat >= pretCurent || produsDb.PretDeInceput >= pretCurent)
                {
                    errorProvider1.SetError(tbPretLicitat.TextBox, "Pretul licitat trebuie sa fie mai mare decat pretul curent.");
                }
                else
                {
                    errorProvider1.SetError(tbPretLicitat.TextBox, null);


                    produsDb.CumparatorId = Program.Cumparator.Id;
                    produsDb.PretLicitat = pretCurent;
                    ctx.SaveChanges();

                }
            }

            RefreshData();
        }
    }
}
