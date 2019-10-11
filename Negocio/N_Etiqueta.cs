using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    /****************************************Etiqueta Productor Packing******************************************************/
    public class N_Etiqueta_Productor_Packing
    {
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public List<E_Etiqueta_Productor_Packing> ListaEtiquetas()
        {
            D_Etiqueta_Productor_Packing etiqueta2 = new D_Etiqueta_Productor_Packing();
            List<E_Etiqueta_Productor_Packing> temp = new List<E_Etiqueta_Productor_Packing>();
            temp = etiqueta2.ListaEtiquetas();
            if (temp != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
        public E_Etiqueta_Productor_Packing ObtenerEtiqueta(string id)
        {
            D_Etiqueta_Productor_Packing etiqueta2 = new D_Etiqueta_Productor_Packing();
            E_Etiqueta_Productor_Packing temp = new E_Etiqueta_Productor_Packing();
            if ((temp = etiqueta2.ObtenerEtiqueta(id)) != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
        public bool CrearEtiqueta(E_Etiqueta_Productor_Packing etiqueta)
        {
            D_Etiqueta_Productor_Packing etiqueta2 = new D_Etiqueta_Productor_Packing();
            if (!etiqueta2.CrearEtiqueta(etiqueta))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta creada";
                return true;
            }
        }

        public bool ModificarEtiqueta(E_Etiqueta_Productor_Packing etiqueta)
        {
            D_Etiqueta_Productor_Packing etiqueta2 = new D_Etiqueta_Productor_Packing();
            if (!etiqueta2.ModificarEtiqueta(etiqueta))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta modificada";
                return true;
            }
        }

        public bool BorrarEtiqueta(string id)
        {
            D_Etiqueta_Productor_Packing etiqueta2 = new D_Etiqueta_Productor_Packing();
            if (!etiqueta2.BorrarEtiqueta(id))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta eliminada";
                return true;
            }
        }
    }

    /*************************************************Etiqueta Quesos******************************************/
    public class N_Etiqueta_Quesos
    {
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public List<E_Etiqueta_Quesos> ListaEtiquetas()
        {
            D_Etiqueta_Quesos etiqueta2 = new D_Etiqueta_Quesos();
            List<E_Etiqueta_Quesos> temp = new List<E_Etiqueta_Quesos>();
            temp = etiqueta2.ListaEtiquetas();
            if (temp != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
        public E_Etiqueta_Quesos ObtenerEtiqueta(string id)
        {
            D_Etiqueta_Quesos etiqueta2 = new D_Etiqueta_Quesos();
            E_Etiqueta_Quesos temp = new E_Etiqueta_Quesos();
            if ((temp = etiqueta2.ObtenerEtiqueta(id)) != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
        public bool CrearEtiqueta(E_Etiqueta_Quesos etiqueta)
        {
            D_Etiqueta_Quesos etiqueta2 = new D_Etiqueta_Quesos();
            if (!etiqueta2.CrearEtiqueta(etiqueta))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta creada";
                return true;
            }
        }

        public bool ModificarEtiqueta(E_Etiqueta_Quesos etiqueta)
        {
            D_Etiqueta_Quesos etiqueta2 = new D_Etiqueta_Quesos();
            if (!etiqueta2.ModificarEtiqueta(etiqueta))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta modificada";
                return true;
            }
        }

        public bool BorrarEtiqueta(string id)
        {
            D_Etiqueta_Quesos etiqueta2 = new D_Etiqueta_Quesos();
            if (!etiqueta2.BorrarEtiqueta(id))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta eliminada";
                return true;
            }
        }
    }
    /*************************************************Etiqueta PTI******************************************/
    public class N_Etiqueta_PTI
    {
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public List<E_Etiqueta_PTI> ListaEtiquetas()
        {
            D_Etiqueta_PTI etiqueta2 = new D_Etiqueta_PTI();
            List<E_Etiqueta_PTI> temp = new List<E_Etiqueta_PTI>();
            temp = etiqueta2.ListaEtiquetas();
            if (temp != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
        public E_Etiqueta_PTI ObtenerEtiqueta(string id)
        {
            D_Etiqueta_PTI etiqueta2 = new D_Etiqueta_PTI();
            E_Etiqueta_PTI temp = new E_Etiqueta_PTI();
            if ((temp = etiqueta2.ObtenerEtiqueta(id)) != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
        public bool CrearEtiqueta(E_Etiqueta_PTI etiqueta)
        {
            D_Etiqueta_PTI etiqueta2 = new D_Etiqueta_PTI();
            if (!etiqueta2.CrearEtiqueta(etiqueta))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta creada";
                return true;
            }
        }

        public bool ModificarEtiqueta(E_Etiqueta_PTI etiqueta)
        {
            D_Etiqueta_PTI etiqueta2 = new D_Etiqueta_PTI();
            if (!etiqueta2.ModificarEtiqueta(etiqueta))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta modificada";
                return true;
            }
        }

        public bool BorrarEtiqueta(string id)
        {
            D_Etiqueta_PTI etiqueta2 = new D_Etiqueta_PTI();
            if (!etiqueta2.BorrarEtiqueta(id))
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta eliminada";
                return true;
            }
        }
    }
}
