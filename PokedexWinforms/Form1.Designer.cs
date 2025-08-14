namespace PokedexWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPokemons = new System.Windows.Forms.DataGridView();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminarLogico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPokemons
            // 
            this.dataGridViewPokemons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPokemons.Location = new System.Drawing.Point(26, 43);
            this.dataGridViewPokemons.Name = "dataGridViewPokemons";
            this.dataGridViewPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPokemons.Size = new System.Drawing.Size(536, 334);
            this.dataGridViewPokemons.TabIndex = 0;
            this.dataGridViewPokemons.SelectionChanged += new System.EventHandler(this.dataGridViewPokemons_SelectionChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPokemon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(600, 43);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(306, 334);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 1;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAgregar.FlatAppearance.BorderSize = 2;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(12, 383);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(152, 38);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEliminar.FlatAppearance.BorderSize = 2;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminar.Location = new System.Drawing.Point(328, 383);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(152, 38);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Orange;
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSalir.FlatAppearance.BorderSize = 2;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(754, 398);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(152, 38);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.Wheat;
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonModificar.FlatAppearance.BorderSize = 2;
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(170, 383);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(152, 38);
            this.buttonModificar.TabIndex = 6;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminarLogico
            // 
            this.buttonEliminarLogico.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEliminarLogico.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEliminarLogico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEliminarLogico.FlatAppearance.BorderSize = 2;
            this.buttonEliminarLogico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarLogico.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarLogico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminarLogico.Location = new System.Drawing.Point(486, 383);
            this.buttonEliminarLogico.Name = "buttonEliminarLogico";
            this.buttonEliminarLogico.Size = new System.Drawing.Size(166, 38);
            this.buttonEliminarLogico.TabIndex = 7;
            this.buttonEliminarLogico.Text = "Eliminar Logico";
            this.buttonEliminarLogico.UseVisualStyleBackColor = false;
            this.buttonEliminarLogico.Click += new System.EventHandler(this.buttonEliminarLogico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 462);
            this.Controls.Add(this.buttonEliminarLogico);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.dataGridViewPokemons);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(964, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(964, 501);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminarLogico;
    }
}

