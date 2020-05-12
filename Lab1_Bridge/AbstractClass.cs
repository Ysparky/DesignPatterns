using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bridge
{
    class AbstractionClass
    {
        private IDate _date;
        public AbstractionClass(IDate date)
        {
            _date = date;
        }

        public virtual string Hoy()
        {
            return _date.hoy();
        }
        public virtual string Maniana()
        {
            return _date.maniana();
        }
        public virtual string Ayer()
        {
            return _date.ayer();
        }
    }
    interface IDate
    {
        string hoy();
        string maniana();
        string ayer();
    }
    class BigEndian : IDate
    {
        public string ayer()
        {
            string dt_ayer = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            return dt_ayer;
        }

        public string hoy()
        {
            string dt_hoy = DateTime.Today.ToString("yyyy-MM-dd");
            return dt_hoy;
        }

        public string maniana()
        {
            string dt_maniana = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
            return dt_maniana;
        }
    }
    class DDMMAA : IDate
    {
        public string ayer()
        {
            string dt_ayer = DateTime.Today.AddDays(-1).ToString("dd-MM-yyyy");
            return dt_ayer;
        }

        public string hoy()
        {
            string dt_hoy = DateTime.Today.ToString("dd-MM-yyyy");
            return dt_hoy;
        }

        public string maniana()
        {
            string dt_maniana = DateTime.Today.AddDays(1).ToString("dd-MM-yyyy");
            return dt_maniana;
        }
    }
    class MMDDAA : IDate
    {
        public string ayer()
        {
            string dt_ayer = DateTime.Today.AddDays(-1).ToString("MM-dd-yyyy");
            return dt_ayer;
        }

        public string hoy()
        {
            string dt_hoy = DateTime.Today.ToString("MM-dd-yyyy");
            return dt_hoy;
        }

        public string maniana()
        {
            string dt_maniana = DateTime.Today.AddDays(1).ToString("MM-dd-yyyy");
            return dt_maniana;
        }
    }
}

