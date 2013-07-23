using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicitatiiDAL
{
    public partial class Utilizator
    {
        public override string ToString()
        {
            return Nume + ", " + Prenume + ", " + Username + ", " + Password; 
        }
    }

    public partial class Vanzator
    {
        public override string ToString()
        {
            return base.ToString() + ", " + Adresa;
        }
    }

    public partial class Cumparator
    {
        public override string ToString()
        {
            return base.ToString() + ", " + CNP + ", " + Telefon;
        }
    }
}
