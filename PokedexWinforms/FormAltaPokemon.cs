using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PokedexWinforms
{
    public partial class FormAltaPokemon : Form
    {
        private Pokemon pokemon = null;

        public FormAltaPokemon()
        {
            InitializeComponent();
        }

        public FormAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                // Solo actualiza los campos, el Id se mantiene
                pokemon.Numero = int.Parse(textBoxNumero.Text);
                pokemon.Nombre = textBoxNombre.Text;
                pokemon.Descripcion = textBoxDescripcion.Text;
                pokemon.UrlImagen = textBoxUrlImagen.Text;
                pokemon.Tipo = (Elemento)comboBoxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)comboBoxDebilidad.SelectedItem;

                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                }
                else
                {
                    negocio.agregar(pokemon);
                }

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los datos");
            }
        }

        private void FormAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                comboBoxTipo.DataSource = elementoNegocio.listar();
                comboBoxTipo.ValueMember = "Id";
                comboBoxTipo.DisplayMember = "Descripcion";
                comboBoxDebilidad.DataSource = elementoNegocio.listar();
                comboBoxDebilidad.ValueMember = "Id";
                comboBoxDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    textBoxNumero.Text = pokemon.Numero.ToString();
                    textBoxNombre.Text = pokemon.Nombre;
                    textBoxDescripcion.Text = pokemon.Descripcion;
                    textBoxUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);    
                    comboBoxTipo.SelectedValue = pokemon.Tipo.Id;
                    comboBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los datos");
            }
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

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }
    }
}
