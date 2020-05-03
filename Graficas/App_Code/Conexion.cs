using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de Class1
/// </summary>
public class Conexion

{
    public static string cadena = "server=localhost; database=grafica; uid=root; pwd=root; port=3304";
    MySqlConnection conn = new MySqlConnection();
    public Conexion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //


    }
}