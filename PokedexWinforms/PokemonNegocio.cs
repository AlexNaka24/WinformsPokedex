using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PokedexWinforms
{
    class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexionDB = new SqlConnection();
            SqlCommand comandoDB = new SqlCommand();
            SqlDataReader lectorDB;

            try
            {
                // conexion a la db

                conexionDB.ConnectionString = "Server=DESKTOP-NBHEMT3; Database=POKEDEX_DB; Integrated security=True";
                comandoDB.CommandType = System.Data.CommandType.Text;

                // consulta a la db

                comandoDB.CommandText = "SELECT Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo , D.Descripcion Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
                comandoDB.Connection = conexionDB;

                conexionDB.Open();
                lectorDB = comandoDB.ExecuteReader();

                while (lectorDB.Read())
                {
                    Pokemon pokemonAux = new Pokemon();
                    pokemonAux.Numero = (int)lectorDB["Numero"];
                    pokemonAux.Nombre = (string)lectorDB["Nombre"];
                    pokemonAux.Descripcion = (string)lectorDB["Descripcion"];
                    pokemonAux.UrlImagen = (string)lectorDB["UrlImagen"];
                    pokemonAux.Tipo = new Elemento();
                    pokemonAux.Tipo.Descripcion = (string)lectorDB["Tipo"];
                    pokemonAux.Debilidad = new Elemento();
                    pokemonAux.Debilidad.Descripcion = (string)lectorDB["Debilidad"];

                    lista.Add(pokemonAux);
                }

                conexionDB.Close();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
