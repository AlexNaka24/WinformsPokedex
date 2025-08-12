using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.Cryptography.X509Certificates;

namespace Negocio
{
    public class PokemonNegocio
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

                comandoDB.CommandText = "SELECT Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo , D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
                comandoDB.Connection = conexionDB;

                conexionDB.Open();
                lectorDB = comandoDB.ExecuteReader();

                while (lectorDB.Read())
                {
                    Pokemon pokemonAux = new Pokemon();
                    pokemonAux.Id = (int)lectorDB["Id"];
                    pokemonAux.Numero = (int)lectorDB["Numero"];
                    pokemonAux.Nombre = (string)lectorDB["Nombre"];
                    pokemonAux.Descripcion = (string)lectorDB["Descripcion"];

                    if (lectorDB.IsDBNull(lectorDB.GetOrdinal("UrlImagen")))
                        pokemonAux.UrlImagen = null;
                    else
                        pokemonAux.UrlImagen = (string)lectorDB["UrlImagen"];

                    pokemonAux.Tipo = new Elemento();
                    pokemonAux.Tipo.Id = (int)lectorDB["IdTipo"];
                    pokemonAux.Tipo.Descripcion = (string)lectorDB["Tipo"];
                    pokemonAux.Debilidad = new Elemento();
                    pokemonAux.Debilidad.Id = (int)lectorDB["IdDebilidad"];
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

        public void agregar(Pokemon nuevoPokemon)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta($"INSERT INTO POKEMONS(Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) VALUES ({nuevoPokemon.Numero}, '{nuevoPokemon.Nombre}', '{nuevoPokemon.Descripcion}', 1, @idTipo, @idDebilidad, @urlImagen)");
                datos.setearParametro("@idTipo", nuevoPokemon.Tipo.Id);
                datos.setearParametro("@idDebilidad", nuevoPokemon.Debilidad.Id);
                datos.setearParametro("@urlImagen", nuevoPokemon.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("UPDATE POKEMONS SET Numero = @numero, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @urlImagen, IdTipo = @idTipo, IdDebilidad = @idDebilidad WHERE Id = @id");
                datos.setearParametro("@numero", pokemon.Numero);
                datos.setearParametro("@nombre", pokemon.Nombre);
                datos.setearParametro("@descripcion", pokemon.Descripcion);
                datos.setearParametro("@urlImagen", pokemon.UrlImagen);
                datos.setearParametro("@idTipo", pokemon.Tipo.Id);
                datos.setearParametro("@idDebilidad", pokemon.Debilidad.Id);
                datos.setearParametro("@id", pokemon.Id);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
