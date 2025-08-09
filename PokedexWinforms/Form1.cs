using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexWinforms
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAgregar.Cursor = Cursors.Hand;
            buttonEliminar.Cursor = Cursors.Hand;
            buttonSalir.Cursor = Cursors.Hand;

            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listar();        
            dataGridViewPokemons.DataSource = listaPokemons;
            dataGridViewPokemons.Columns["UrlImagen"].Visible = false;

            pictureBoxPokemon.Load(listaPokemons[0].UrlImagen);
        }

        private void dataGridViewPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);

            Elemento elemento = new Elemento();
            elemento.ToString();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has salido de la pokedex, muchas gracias!");
            this.Close();
        }    

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPokemons.SelectedRows.Count > 0)
            {
                int numero = Convert.ToInt32(dataGridViewPokemons.SelectedRows[0].Cells["Numero"].Value);

                string connectionString = "Server=DESKTOP-NBHEMT3; Database=POKEDEX_DB; Integrated Security=true;";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "DELETE FROM Pokemons WHERE Numero = @numero";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@numero", numero);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para eliminar.");
                        }
                    }
                }

                PokemonNegocio pokemonNegocio = new PokemonNegocio();
                dataGridViewPokemons.DataSource = pokemonNegocio.listar();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }   
}
