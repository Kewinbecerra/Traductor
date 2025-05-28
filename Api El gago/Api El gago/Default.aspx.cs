using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Api_El_gago
{
    public partial class _Default : Page
    {
        string connectionString = "Data Source=.;Initial Catalog=idiomas;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTraducir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrEmpty(palabra))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"SELECT e.codigo, i.Palabra AS PalabraIng, f.Palabra AS PalabraFr, a.Palabra AS PalabraAl
                                   FROM español e
                                   LEFT JOIN Ingles i ON e.codigoingles = i.codigo
                                   LEFT JOIN Frances f ON e.codigofrances = f.codigo
                                   LEFT JOIN Aleman a ON e.codigoaleman = a.codigo
                                   WHERE e.Palabra = @palabra";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@palabra", palabra);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblIngles.Text = "Inglés: " + reader["PalabraIng"].ToString();
                                lblFrances.Text = "Francés: " + reader["PalabraFr"].ToString();
                                lblAleman.Text = "Alemán: " + reader["PalabraAl"].ToString();
                            }
                            else
                            {
                                lblIngles.Text = "Inglés: No encontrada";
                                lblFrances.Text = "Francés: No encontrada";
                                lblAleman.Text = "Alemán: No encontrada";
                                lblSinonimos.Text = "Sinónimos: (ninguno)";
                                return;
                            }
                        }
                    }

                    string sinonimosSql = @"SELECT Palabra 
                                            FROM español
                                            WHERE codigoingles = (SELECT codigoingles FROM español WHERE Palabra = @palabra)
                                              AND Palabra <> @palabra";

                    using (SqlCommand cmdSinonimos = new SqlCommand(sinonimosSql, con))
                    {
                        cmdSinonimos.Parameters.AddWithValue("@palabra", palabra);
                        using (SqlDataReader reader = cmdSinonimos.ExecuteReader())
                        {
                            List<string> sinonimos = new List<string>();
                            while (reader.Read())
                            {
                                sinonimos.Add(reader["Palabra"].ToString());
                            }
                            lblSinonimos.Text = sinonimos.Count > 0
                                ? "Sinónimos: " + string.Join(", ", sinonimos)
                                : "Sinónimos: (ninguno)";
                        }
                    }
                }
            }
        }
    }
}