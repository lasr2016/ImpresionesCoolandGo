using RawPrinterDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_CodigoZPL
    {
        private N_Archivo archivo = new N_Archivo();
        public string Nombre_archivo;
        private N_Impresion impresora = new N_Impresion();
        public static int axisX { get; set; }
        public static int axisY { get; set; }

        public void ImpresionEtiqueta1(string guia, string fecha, string hora, string correlativo)
        {
            Nombre_archivo = "C:\\Temp\\EtiquetaTemp.txt";
            archivo.Nombre_archivo = Nombre_archivo;
            impresora.Archivo = Nombre_archivo;
            impresora.NuevaImpresion();

            impresora.Grabar("KS15");
            impresora.Grabar("n");
            impresora.Grabar("M1477");
            impresora.Grabar("O0220");
            impresora.Grabar("d");
            impresora.Grabar("D");
            impresora.Grabar("L");
            impresora.Grabar("D11");
            impresora.Grabar("H20");
            impresora.Grabar("ySPM");
            impresora.Grabar("A2");
            impresora.Grabar("1911" + "A36" + (0504 + axisY).ToString().PadLeft(4, '0') + (0277 + axisX).ToString().PadLeft(4, '0') + correlativo);
            impresora.Grabar("1911" + "A18" + (0199 + axisY).ToString().PadLeft(4, '0') + (0096 + axisX).ToString().PadLeft(4, '0') + "CARGA CONOCIDA");
            impresora.Grabar("1911" + "A10" + (0182 + axisY).ToString().PadLeft(4, '0') + (0099 + axisX).ToString().PadLeft(4, '0') + "N DE ACREDITACION: AC 04/2019");
            impresora.Grabar("1X11000" + (0108 + axisY).ToString().PadLeft(4, '0') + (0173 + axisX).ToString().PadLeft(4, '0') + "L131001");
            impresora.Grabar("1911" + "A10" + (0113 + axisY).ToString().PadLeft(4, '0') + (0115 + axisX).ToString().PadLeft(4, '0') + "FECHA:");
            impresora.Grabar("1X11000" + (0080 + axisY).ToString().PadLeft(4, '0') + (0173 + axisX).ToString().PadLeft(4, '0') + "L131001");
            impresora.Grabar("1911" + "A10" + (0085 + axisY).ToString().PadLeft(4, '0') + (0119 + axisX).ToString().PadLeft(4, '0') + "HORA:");
            impresora.Grabar("1X11000" + (0140 + axisY).ToString().PadLeft(4, '0') + (0173 + axisX).ToString().PadLeft(4, '0') + "L131001");
            impresora.Grabar("1911" + "A24" + (0133 + axisY).ToString().PadLeft(4, '0') + (0203 + axisX).ToString().PadLeft(4, '0') + guia);
            impresora.Grabar("1911" + "A18" + (0106 + axisY).ToString().PadLeft(4, '0') + (0177 + axisX).ToString().PadLeft(4, '0') + fecha);
            impresora.Grabar("1911" + "A18" + (0078 + axisY).ToString().PadLeft(4, '0') + (0188 + axisX).ToString().PadLeft(4, '0') + hora);
            impresora.Grabar("1X11000" + (0055 + axisY).ToString().PadLeft(4, '0') + (0131 + axisX).ToString().PadLeft(4, '0') + "L160016");
            impresora.Grabar("A1");
            impresora.Grabar("1911" + "A10" + (0055 + axisY).ToString().PadLeft(4, '0') + (0133 + axisX).ToString().PadLeft(4, '0') + "" + "CARGO NET CENTER" + "");
            impresora.Grabar("Q0001");
            impresora.Grabar("E");

            RawPrinter.SendFileToPrinter("ImpresoraZPL", Nombre_archivo);
        }

        public void ImpresionEtiquetaQuesos(string producto, string codigoBarras, string fechaVencimiento, string codigoSAP, string Cantidad)
        {
            Nombre_archivo = "C:\\Temp\\EtiquetaTemp.txt";
            archivo.Nombre_archivo = Nombre_archivo;
            impresora.Archivo = Nombre_archivo;
            impresora.NuevaImpresion();

            impresora.Grabar("^XA");
            impresora.Grabar("^MMT");
            impresora.Grabar("^PW799");
            impresora.Grabar("^LL0400");
            impresora.Grabar("^LS0");
            impresora.Grabar(@"^FT54,67^A0N,31,31^FH\^FD" + producto + "^FS");
            impresora.Grabar("^BY3,3,166^FT97,262^BCN,,Y,N");
            impresora.Grabar("^FD>:" + codigoBarras + "^FS");
            if (codigoSAP.Trim() != "")
            {
                impresora.Grabar(@"^FT69,338^A0N,31,31^FH\^FDSAP^FS");
                impresora.Grabar(@"^FT66,375^A0N,31,31^FH\^FD" + codigoSAP + "^FS");
            }
            impresora.Grabar(@"^FT571,334^A0N,31,31^FH\^FDF. VENC^FS");            
            impresora.Grabar(@"^FT571,374^A0N,31,31^FH\^FD" + fechaVencimiento + "^FS");
            
            impresora.Grabar("^PQ1,0,1,Y^XZ");    

            RawPrinter.SendFileToPrinter("ImpresoraZPL", Nombre_archivo);
        }
    }
}
