using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    /****************************************Etiqueta Productor Packing******************************************************/
    public class D_Etiqueta_Productor_Packing : D_MySQL
    {
        private string _mensaje;
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public List<E_Etiqueta_Productor_Packing> ListaEtiquetas()
        {
            string query = "select * from tbl_prpk_etiqueta;";
            MySqlCommand cmd;
            List<E_Etiqueta_Productor_Packing> temp = new List<E_Etiqueta_Productor_Packing>();
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Etiqueta_Productor_Packing etiqueta = new E_Etiqueta_Productor_Packing();

                            etiqueta.ID = Convert.ToString(reader["id"]);
                            etiqueta.CSG = Convert.ToString(reader["csg"]);
                            etiqueta.Region_1 = Convert.ToString(reader["region_1"]);
                            etiqueta.Province_1 = Convert.ToString(reader["province_1"]);
                            etiqueta.Township_1 = Convert.ToString(reader["township_1"]);
                            etiqueta.CSP = Convert.ToString(reader["csp"]);                      
                            etiqueta.Region_2 = Convert.ToString(reader["region_2"]);                        
                            etiqueta.Province_2 = Convert.ToString(reader["province_2"]);                          
                            etiqueta.Township_2 = Convert.ToString(reader["township_2"]);
                            etiqueta.Descripcion_1 = Convert.ToString(reader["descripcion_1"]);
                            etiqueta.Descripcion_2 = Convert.ToString(reader["descripcion_2"]);
                            etiqueta.Descripcion_3 = Convert.ToString(reader["descripcion_3"]);
                            etiqueta.Exported_by = Convert.ToString(reader["exportedby"]);

                            temp.Add(etiqueta);
                        }
                        Desconectar();
                        return temp;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }

        }

        public E_Etiqueta_Productor_Packing ObtenerEtiqueta(string id)
        {
            string query = "select * from tbl_prpk_etiqueta where id = @id;";
            MySqlCommand cmd;
            E_Etiqueta_Productor_Packing etiqueta = new E_Etiqueta_Productor_Packing(); ;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            etiqueta.ID = Convert.ToString(reader["id"]);
                            etiqueta.CSG = Convert.ToString(reader["csg"]);
                            etiqueta.Region_1 = Convert.ToString(reader["region_1"]);
                            etiqueta.Province_1 = Convert.ToString(reader["province_1"]);
                            etiqueta.Township_1 = Convert.ToString(reader["township_1"]);
                            etiqueta.CSP = Convert.ToString(reader["csp"]);
                            etiqueta.Region_2 = Convert.ToString(reader["region_2"]);
                            etiqueta.Province_2 = Convert.ToString(reader["province_2"]);
                            etiqueta.Township_2 = Convert.ToString(reader["township_2"]);
                            etiqueta.Descripcion_1 = Convert.ToString(reader["descripcion_1"]);
                            etiqueta.Descripcion_2 = Convert.ToString(reader["descripcion_2"]);
                            etiqueta.Descripcion_3 = Convert.ToString(reader["descripcion_3"]);
                            etiqueta.Exported_by = Convert.ToString(reader["exportedby"]);
                        }
                        Desconectar();
                        return etiqueta;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }
        public bool CrearEtiqueta(E_Etiqueta_Productor_Packing etiqueta)
        {
            string query = "insert into tbl_prpk_etiqueta(csg,region_1,province_1,township_1,csp,region_2,province_2,township_2,descripcion_1,descripcion_2,descripcion_3,exportedby) " +
                            "values (@csg,@region1,@province1,@township1,@csp,@region2,@province2,@township2,@descripcion1,@descripcion2,@descripcion3,@exportedby);";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@csg", etiqueta.CSG);
                    cmd.Parameters.AddWithValue("@region1", etiqueta.Region_1);
                    cmd.Parameters.AddWithValue("@province1", etiqueta.Province_1);
                    cmd.Parameters.AddWithValue("@township1", etiqueta.Township_1);
                    cmd.Parameters.AddWithValue("@csp", etiqueta.CSP);
                    cmd.Parameters.AddWithValue("@region2", etiqueta.Region_2);
                    cmd.Parameters.AddWithValue("@province2", etiqueta.Province_2);
                    cmd.Parameters.AddWithValue("@township2", etiqueta.Township_2);
                    cmd.Parameters.AddWithValue("@descripcion1", etiqueta.Descripcion_1);
                    cmd.Parameters.AddWithValue("@descripcion2", etiqueta.Descripcion_2);
                    cmd.Parameters.AddWithValue("@descripcion3", etiqueta.Descripcion_3);
                    cmd.Parameters.AddWithValue("@exportedby", etiqueta.Exported_by);

                    cmd.ExecuteNonQuery();
                    etiqueta.ID = cmd.LastInsertedId.ToString();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool BorrarEtiqueta(string id)
        {
            string query = "delete from tbl_prpk_etiqueta where id = @id;";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool ModificarEtiqueta(E_Etiqueta_Productor_Packing etiqueta)
        {
            string query = "update tbl_prpk_etiqueta set csg = @csg, region_1 = @region1, province_1 = @province1, township_1 = @township1, csp = @csp, region_2 = @region2, province = @province2," +
                            " township_2 = @township2, descripcion_1 = @descripcion1, descripcion_2 = @descripcion2, descripcion_3 = @descripcion3, exportedby = @exportedby where id = @id;";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@csg", etiqueta.CSG);
                    cmd.Parameters.AddWithValue("@region1", etiqueta.Region_1);
                    cmd.Parameters.AddWithValue("@province1", etiqueta.Province_1);
                    cmd.Parameters.AddWithValue("@township1", etiqueta.Township_1);
                    cmd.Parameters.AddWithValue("@csp", etiqueta.CSP);
                    cmd.Parameters.AddWithValue("@region2", etiqueta.Region_2);
                    cmd.Parameters.AddWithValue("@province2", etiqueta.Province_2);
                    cmd.Parameters.AddWithValue("@township2", etiqueta.Township_2);
                    cmd.Parameters.AddWithValue("@descripcion1", etiqueta.Descripcion_1);
                    cmd.Parameters.AddWithValue("@descripcion2", etiqueta.Descripcion_2);
                    cmd.Parameters.AddWithValue("@descripcion3", etiqueta.Descripcion_3);
                    cmd.Parameters.AddWithValue("@exportedby", etiqueta.Exported_by);
                    cmd.Parameters.AddWithValue("@id", etiqueta.ID);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }
    }

    /*************************************************Etiqueta Quesos******************************************/
    public class D_Etiqueta_Quesos : D_MySQL
    {
        private string _mensaje;
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public List<E_Etiqueta_Quesos> ListaEtiquetas()
        {
            string query = "select * from tbl_qu_etiqueta;";
            MySqlCommand cmd;
            List<E_Etiqueta_Quesos> temp = new List<E_Etiqueta_Quesos>();
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Etiqueta_Quesos etiqueta = new E_Etiqueta_Quesos();

                            etiqueta.ID = Convert.ToString(reader["id"]);
                            etiqueta.Descripcion = Convert.ToString(reader["descripcion"]);
                            etiqueta.Codigo = Convert.ToString(reader["codigo"]);
                            etiqueta.SAP = Convert.ToString(reader["sap"]);

                            temp.Add(etiqueta);
                        }
                        Desconectar();
                        return temp;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }

        }

        public E_Etiqueta_Quesos ObtenerEtiqueta(string id)
        {
            string query = "select * from tbl_qu_etiqueta where id = @id;";
            MySqlCommand cmd;
            E_Etiqueta_Quesos etiqueta = new E_Etiqueta_Quesos(); ;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            etiqueta.ID = Convert.ToString(reader["id"]);
                            etiqueta.Descripcion = Convert.ToString(reader["descripcion"]);
                            etiqueta.Codigo = Convert.ToString(reader["codigo"]);
                            etiqueta.SAP = Convert.ToString(reader["sap"]);
                        }
                        Desconectar();
                        return etiqueta;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }
        public bool CrearEtiqueta(E_Etiqueta_Quesos etiqueta)
        {
            string query = "insert into tbl_qu_etiqueta(descripcion,sap,codigo) " +
                            "values (@descripcion,@sap,@codigo);";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("descripcion", etiqueta.Descripcion);
                    cmd.Parameters.AddWithValue("@sap", etiqueta.SAP);
                    cmd.Parameters.AddWithValue("@codigo", etiqueta.Codigo);

                    cmd.ExecuteNonQuery();
                    etiqueta.ID = cmd.LastInsertedId.ToString();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool BorrarEtiqueta(string id)
        {
            string query = "delete from tbl_qu_etiqueta where id = @id;";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool ModificarEtiqueta(E_Etiqueta_Quesos etiqueta)
        {
            string query = "update tbl_qu_etiqueta set descripcion = @descripcion, sap = @sap, codigo = @codigo where id = @id;";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", etiqueta.Descripcion);
                    cmd.Parameters.AddWithValue("@sap", etiqueta.SAP);
                    cmd.Parameters.AddWithValue("@codigo", etiqueta.Codigo);
                    cmd.Parameters.AddWithValue("@id", etiqueta.ID);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }
    }

    /*************************************************Etiqueta PTI******************************************/
    public class D_Etiqueta_PTI : D_MySQL
    {
        private string _mensaje;
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public List<E_Etiqueta_PTI> ListaEtiquetas()
        {
            string query = "select * from tbl_pti_etiqueta;";
            MySqlCommand cmd;
            List<E_Etiqueta_PTI> temp = new List<E_Etiqueta_PTI>();
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Etiqueta_PTI etiqueta = new E_Etiqueta_PTI();

                            etiqueta.ID = Convert.ToString(reader["id"]);
                            etiqueta.Nombre_etiqueta = Convert.ToString(reader["nombre_etiqueta"]);
                            etiqueta.Importador = Convert.ToString(reader["importador"]);
                            etiqueta.Producto = Convert.ToString(reader["producto"]);
                            etiqueta.Empaque = Convert.ToString(reader["empaque"]);
                            etiqueta.Gtin = Convert.ToString(reader["gtin"]);

                            temp.Add(etiqueta);
                        }
                        Desconectar();
                        return temp;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }

        }

        public E_Etiqueta_PTI ObtenerEtiqueta(string id)
        {
            string query = "select * from tbl_pti_etiqueta where id = @id;";
            MySqlCommand cmd;
            E_Etiqueta_PTI etiqueta = new E_Etiqueta_PTI(); ;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            etiqueta.ID = Convert.ToString(reader["id"]);
                            etiqueta.Nombre_etiqueta = Convert.ToString(reader["nombre_etiqueta"]);
                            etiqueta.Importador = Convert.ToString(reader["importador"]);
                            etiqueta.Producto = Convert.ToString(reader["producto"]);
                            etiqueta.Empaque = Convert.ToString(reader["empaque"]);
                            etiqueta.Gtin = Convert.ToString(reader["gtin"]);
                        }
                        Desconectar();
                        return etiqueta;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }
        public bool CrearEtiqueta(E_Etiqueta_PTI etiqueta)
        {
            string query = "insert into tbl_pti_etiqueta(nombre_etiqueta,importador,producto,empaque,gtin) " +
                            "values (@nombre_etiqueta,@importador,@producto,@empaque,@gtin);";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("(@nombre_etiqueta", etiqueta.Nombre_etiqueta);
                    cmd.Parameters.AddWithValue("@importador", etiqueta.Importador);
                    cmd.Parameters.AddWithValue("@producto", etiqueta.Producto);
                    cmd.Parameters.AddWithValue("@empaque", etiqueta.Empaque);
                    cmd.Parameters.AddWithValue("@gtin", etiqueta.Gtin);

                    cmd.ExecuteNonQuery();
                    etiqueta.ID = cmd.LastInsertedId.ToString();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool BorrarEtiqueta(string id)
        {
            string query = "delete from tbl_pti_etiqueta where id = @id;";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool ModificarEtiqueta(E_Etiqueta_PTI etiqueta)
        {
            string query = "update tbl_pti_etiqueta set nombre_etiqueta = @nombre_etiqueta, importador = @importador, producto = @producto, empaque = @empaque, gtin = @gtin  where id = @id;";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@nombre_etiqueta", etiqueta.Nombre_etiqueta);
                    cmd.Parameters.AddWithValue("@importador", etiqueta.Importador);
                    cmd.Parameters.AddWithValue("@producto", etiqueta.Producto);
                    cmd.Parameters.AddWithValue("@empaque", etiqueta.Empaque);
                    cmd.Parameters.AddWithValue("@gtin", etiqueta.Gtin);
                    cmd.Parameters.AddWithValue("@id", etiqueta.ID);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public bool ExisteGTIN(string gtin)
        {
            string query = "select * from tbl_pti_producto where id = @gtin;";
            MySqlCommand cmd;
            List<E_Etiqueta_PTI> temp = new List<E_Etiqueta_PTI>();
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@gtin", gtin);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return false;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }
    }
}
