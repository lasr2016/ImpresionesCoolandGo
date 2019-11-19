using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /****************************************Etiqueta Productor Packing******************************************************/
    public class E_Etiqueta_Productor_Packing
    {
        public string ID { get; set; }
        public string Nombre_etiqueta { get; set; }
        public string CSG { get; set; }
        public string Region_CSG { get; set; }
        public string Province_CSG { get; set; }
        public string Township_CSG { get; set; }
        public string CSP { get; set; }
        public string Region_CSP { get; set; }
        public string Province_CSP { get; set; }
        public string Township_CSP { get; set; }
        //public string PackDate { get; set; }
        public string Producto { get; set; }
        public string Embalaje { get; set; }
        public string OnlyExport { get; set; }
        public string Exported_by { get; set; }
    }
    /*************************************************Etiqueta Quesos******************************************/
    public class E_Etiqueta_Quesos
    {
        public string ID { get; set; }
        public string Nombre_etiqueta { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }
        public string SAP { get; set; }
        //public string F_Vencimiento { get; set; }
    }
    /*************************************************Etiqueta PTI******************************************/
    public class E_Etiqueta_PTI
    {
        public string ID { get; set; }
        public string Nombre_etiqueta { get; set; }
        public string Importador { get; set; }
        public string Producto { get; set; }
        public string Embalaje { get; set; }
        public string Categoria { get; set; }
        public string Gtin { get; set; }
    }
}
