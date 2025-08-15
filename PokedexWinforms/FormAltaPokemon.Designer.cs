namespace PokedexWinforms
{
    partial class FormAltaPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDebilidad = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxDebilidad = new System.Windows.Forms.ComboBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.textBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(98, 115);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(98, 148);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(79, 177);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumero.Location = new System.Drawing.Point(151, 113);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumero.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Location = new System.Drawing.Point(151, 146);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescripcion.Location = new System.Drawing.Point(151, 177);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(101, 329);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(197, 329);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(114, 210);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 8;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelDebilidad
            // 
            this.labelDebilidad.AutoSize = true;
            this.labelDebilidad.Location = new System.Drawing.Point(91, 241);
            this.labelDebilidad.Name = "labelDebilidad";
            this.labelDebilidad.Size = new System.Drawing.Size(54, 13);
            this.labelDebilidad.TabIndex = 9;
            this.labelDebilidad.Text = "Debilidad:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(151, 207);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 3;
            // 
            // comboBoxDebilidad
            // 
            this.comboBoxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDebilidad.FormattingEnabled = true;
            this.comboBoxDebilidad.Location = new System.Drawing.Point(151, 238);
            this.comboBoxDebilidad.Name = "comboBoxDebilidad";
            this.comboBoxDebilidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDebilidad.TabIndex = 4;
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(84, 276);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.labelUrlImagen.TabIndex = 12;
            this.labelUrlImagen.Text = "Url Imagen:";
            // 
            // textBoxUrlImagen
            // 
            this.textBoxUrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUrlImagen.Location = new System.Drawing.Point(151, 274);
            this.textBoxUrlImagen.Name = "textBoxUrlImagen";
            this.textBoxUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.textBoxUrlImagen.TabIndex = 5;
            this.textBoxUrlImagen.Leave += new System.EventHandler(this.textBoxUrlImagen_Leave);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(375, 116);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(213, 181);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 14;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(278, 274);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(57, 23);
            this.buttonAgregar.TabIndex = 15;
            this.buttonAgregar.Text = "Browser";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(662, 416);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.textBoxUrlImagen);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.comboBoxDebilidad);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelDebilidad);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNumero);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 455);
            this.Name = "FormAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo pokemon";
            this.Load += new System.EventHandler(this.FormAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDebilidad;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxDebilidad;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonAgregar;
    }
}