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
using Dominio;
using Negocio;

namespace PokedexWinforms
{
    public partial class Form1 : Form
    {
        public List<Pokemon> listaPokemons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dataGridViewPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPokemons.CurrentRow == null)
                return;

            Pokemon seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
            if (seleccionado == null)
                return;

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

        private void Cargar()
        {
            buttonAgregar.Cursor = Cursors.Hand;
            buttonEliminar.Cursor = Cursors.Hand;
            buttonSalir.Cursor = Cursors.Hand;
            buttonModificar.Cursor = Cursors.Hand;

            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listar();
            dataGridViewPokemons.DataSource = listaPokemons;
            dataGridViewPokemons.Columns["UrlImagen"].Visible = false;
            dataGridViewPokemons.Columns["Id"].Visible = false;

            pictureBoxPokemon.Load();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has salido de la pokedex, muchas gracias!");
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAltaPokemon formAlta = new FormAltaPokemon();
            formAlta.ShowDialog();
            Cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;

            FormAltaPokemon modificar = new FormAltaPokemon(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar(false);
        }

        private void buttonEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            Pokemon pokemonSeleccionado;

            try
            {
                var resultado = MessageBox.Show(
                    "¿Seguro que desea eliminar el pokemon seleccionado?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    pokemonSeleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;

                    if (logico)
                        pokemonNegocio.eliminarLogico(pokemonSeleccionado.Id);
                    else
                        pokemonNegocio.eliminarFisico(pokemonSeleccionado.Id);

                    Cargar();
                }
                else if (resultado == DialogResult.No)
                {
                    Cargar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione algun pokemon");
            }
        }
    }   
}
