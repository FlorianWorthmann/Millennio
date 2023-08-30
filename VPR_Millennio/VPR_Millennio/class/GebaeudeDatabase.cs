using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using VPR_Millennio.@class;
using VPR_Millennio.enumeration;

namespace VPR_Millennio.@class
{
    /// <summary> Class <c>GebaeudeDatabase</c>
    /// Klasse die, die Gebaeude aus der Datenbank ausließt und Gebaeude erstellt
    /// </summary>
    internal class GebaeudeDatabase
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bib\Desktop\Millennio\VPR_Millennio\VPR_Millennio\GebaeudeDaten.mdf;Integrated Security = True";
        private SqlConnection _connection;

        public GebaeudeDatabase()
        {
            _connection = new SqlConnection(ConnectionString);
        }

        /// <summary> <m>SelectAll</m>
        /// Erstellt eine Datenbank verbindung und Ließt alle Gebaeude aus der Datenbank aus.
        /// </summary>
        /// <returns>Gibt eine Liste von Gebaeuden zurück</returns>
        public List<Gebaeude> SelectAll()
        {
            List<Gebaeude> gebaeude = new List<Gebaeude>();

            _connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Gebaeude";
            cmd.Connection = _connection;

            SqlDataReader reader = cmd.ExecuteReader();

            int produktionskosten_1 = 0;
            int produktionskosten_2 = 0;
            int produktionskosten_3 = 0;

            //Lars Engbert
            while (reader.Read())
            {
                string gebaeudename = (string)reader["Gebaeudename"];
                Ressources produktion = (Ressources)Ressources.Parse(typeof(Ressources), reader.GetString("Produktion"));
                bool tier_1 = Convert.ToBoolean(Convert.ToInt32(reader.GetString("Tier_1")));
                bool tier_2 = Convert.ToBoolean(Convert.ToInt32(reader.GetString("Tier_2")));
                bool tier_3 = Convert.ToBoolean(Convert.ToInt32(reader.GetString("Tier_3")));
                int produktionsrate_1 = Convert.ToInt32(reader.GetString("Produktionsrate_1"));
                int produktionsrate_2 = Convert.ToInt32(reader.GetString("Produktionsrate_2"));
                int produktionsrate_3 = Convert.ToInt32(reader.GetString("Produktionsrate_3"));
                if (!DBNull.Value.Equals(reader["Produktionskosten_1"])) {
                    produktionskosten_1 = Convert.ToInt32(reader.GetString("Produktionskosten_1"));
                }
                if (!DBNull.Value.Equals(reader["Produktionskosten_2"])) {
                    produktionskosten_2 = Convert.ToInt32(reader.GetString("Produktionskosten_2"));
                }
                if (!DBNull.Value.Equals(reader["Produktionskosten_3"])) {
                    produktionskosten_3 = Convert.ToInt32(reader.GetString("Produktionskosten_3"));
                }
                Feldanforderungen feld = (Feldanforderungen)Feldanforderungen.Parse(typeof(Feldanforderungen), reader.GetString("Feld"));
                Kategorie kategorie = (Kategorie)Kategorie.Parse(typeof(Kategorie), reader.GetString("Kategorie"));
                Gebaeude geb = new Gebaeude(gebaeudename, produktion, tier_1, tier_2, tier_3, produktionsrate_1, produktionsrate_2, produktionsrate_3,
                produktionskosten_1, produktionskosten_2, produktionskosten_3, feld, kategorie);
                gebaeude.Add(geb);
            }

            _connection.Close();
            return gebaeude;
        }
    }
}
