using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;

namespace PokedexWinforms
{
    public partial class FormAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;

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
                    if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                    {
                        MessageBox.Show("El nombre es obligatorio");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
                    {
                        MessageBox.Show("La descripción es obligatoria");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBoxUrlImagen.Text))
                    {
                        MessageBox.Show("La URL de la imagen es obligatoria");
                        return;
                    }
                    else if (comboBoxTipo.SelectedItem == null)
                    {
                        MessageBox.Show("El tipo es obligatorio");
                        return;
                    }
                    else if (comboBoxDebilidad.SelectedItem == null)
                    {
                        MessageBox.Show("La debilidad es obligatoria");
                        return;
                    }
                    else if (pokemon.Numero <= 0)
                    {
                        MessageBox.Show("El número debe ser mayor a 0");
                        return;
                    }
                    else
                    {
                        negocio.modificar(pokemon);
                        MessageBox.Show("Modificado exitosamente");
                    }                    
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                    {
                        MessageBox.Show("El nombre es obligatorio");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
                    {
                        MessageBox.Show("La descripción es obligatoria");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBoxUrlImagen.Text))
                    {
                        MessageBox.Show("La URL de la imagen es obligatoria");
                        return;
                    }
                    else if (comboBoxTipo.SelectedItem == null)
                    {
                        MessageBox.Show("El tipo es obligatorio");
                        return;
                    }
                    else if (comboBoxDebilidad.SelectedItem == null)
                    {
                        MessageBox.Show("La debilidad es obligatoria");
                        return;
                    }
                    else if (pokemon.Numero <= 0)
                    {
                        MessageBox.Show("El número debe ser mayor a 0");
                        return;
                    }
                    else
                    {
                        negocio.agregar(pokemon);
                        MessageBox.Show("Agregado exitosamente");
                    }                  
                }

                //guardar imagen si levanto localmente
                if (archivo != null && !(textBoxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);               
            }
        }
    }
}
