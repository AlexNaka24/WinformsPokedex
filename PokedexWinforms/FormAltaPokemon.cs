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
        public FormAltaPokemon()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Pokemon poke = new Pokemon();

            try
            {
                poke.Numero = int.Parse(textBoxNumero.Text);
                poke.Nombre = textBoxNombre.Text;
                poke.Descripcion = textBoxDescripcion.Text;
                poke.UrlImagen = textBoxUrlImagen.Text;
                poke.Tipo = (Elemento)comboBoxTipo.SelectedItem;
                poke.Debilidad = (Elemento)comboBoxDebilidad.SelectedItem;

                PokemonNegocio negocio = new PokemonNegocio();
                negocio.agregar(poke);
                MessageBox.Show("Pokemon agregado correctamente");
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
                comboBoxDebilidad.DataSource = elementoNegocio.listar();
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
