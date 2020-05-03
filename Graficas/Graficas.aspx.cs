using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Graficas : System.Web.UI.Page
{
    int[] tiempo = new int[5];
    int[] distancia = new int[5];
    protected void Page_Load(object sender, EventArgs e)
    {
        ObtenerDatos();
    }

    protected void Chart1_Load(object sender, EventArgs e)
    {

    }
    public void ObtenerDatos()
    {
        Conexion con = new Conexion();
        MySqlConnection conn = new MySqlConnection();
          conn.ConnectionString=  Conexion.cadena;
        MySqlCommand cmd = new MySqlCommand("select * from datos",conn);
        conn.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        int cont = 0;
        while (reader.Read())
        {
            tiempo[cont] = Convert.ToInt32(reader.GetString(0));
            distancia[cont] = Convert.ToInt32(reader.GetInt32(1));
            cont++;
        }
        reader.Close();
        conn.Close();
        Graf.Series["Series"].Points.DataBindXY(tiempo,distancia);
       

    }
}