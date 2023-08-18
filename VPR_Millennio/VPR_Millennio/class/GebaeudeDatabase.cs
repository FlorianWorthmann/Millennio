using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using VPR_Millennio.@class;
using VPR_Millennio.enumeration;

namespace VPR_Millennio.@class
{
    internal class GebaeudeDatabase
    {
        private const string ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bib\Desktop\Millennio\VPR_Millennio\VPR_Millennio\GebaeudeDaten.mdf;Integrated Security = True";
        private SqlConnection _connection;

        public GebaeudeDatabase()
        {
            _connection = new SqlConnection(ConnectionString);
        }
        public List<Gebaeude> SelectAll()
        {
            List<Gebaeude> gebaeude = new List<Gebaeude>();

            _connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Gebaeude";
            cmd.Connection = _connection;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gebaeudename = (string)reader["Gebauedename"];
                Ressources produktion = (Ressources)reader["Produktion"];
                bool tier_1 = (bool)reader["Tier_1"];
                bool tier_2 = (bool)reader["Tier_2"];
                bool tier_3 = (bool)reader["Tier_3"];
                int produktionsrate_1 = (int)reader["Produktionsrate_1"];
                int produktionsrate_2 = (int)reader["Produktionsrate_2"];
                int produktionsrate_3 = (int)reader["Produktionsrate_3"];
                int produktionskosten_1 = (int)reader["Produktionskosten_1"];
                int produktionskosten_2 = (int)reader["Produktionskosten_2"];
                int produktionskosten_3 = (int)reader["Produktionskosten_3"];
                Feldanforderungen feld = (Feldanforderungen)reader["Feld"];
                Kategorie kategorie = (Kategorie)reader["Kategorie"];
                Gebaeude geb = new Gebaeude(gebaeudename, produktion, tier_1, tier_2, tier_3, produktionsrate_1, produktionsrate_2, produktionsrate_3,
                produktionskosten_1, produktionskosten_2, produktionskosten_3, feld, kategorie);
                gebaeude.Add(geb);
            }

            _connection.Close();
            return gebaeude;
        }
    }
}
