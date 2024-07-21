using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pjSueldoEmpleado
{
    class Sueldo
    {
        private string _categoria;
        public string categoria
    {
        get
        {
            return _categoria;

        }
        set
        {
            _categoria = value;
        }

    }
        private int _horas;
        public int horas
        {
            get
            {
                return _horas;
            }
            set
            {
                _horas = value;
            }
        }
        public double asignaSueldo()
        {
            switch (categoria)
            {
                case "Simple": return 15;
                case "Profesional": return 25;

            }
            return 0;

        }
        public double calculaBruto()
        {
            return asignaSueldo() * horas;
        }
        public double calculaDescuento()
        {
            double subtotal = calculaBruto();
            return (subtotal*0.12);
            
        }
        public double calculaNeto()
        {
            return calculaBruto() - calculaDescuento();
        }
    }
}
