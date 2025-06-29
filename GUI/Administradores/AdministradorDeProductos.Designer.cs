namespace uai_poo_actividad_integradora_3.GUI.Grillas
{
    partial class AdministradorDeProductos
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
            grillaDeProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            botonAgregarProducto = new Button();
            botonBorrarProducto = new Button();
            botonModificarProducto = new Button();
            botonClonarProducto = new Button();
            botonMostrarPartesDelID = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaDeProductos).BeginInit();
            SuspendLayout();
            // 
            // grillaDeProductos
            // 
            grillaDeProductos.AllowUserToAddRows = false;
            grillaDeProductos.AllowUserToDeleteRows = false;
            grillaDeProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaDeProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Precio, Stock });
            grillaDeProductos.Location = new Point(0, 0);
            grillaDeProductos.MultiSelect = false;
            grillaDeProductos.Name = "grillaDeProductos";
            grillaDeProductos.ReadOnly = true;
            grillaDeProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaDeProductos.Size = new Size(598, 450);
            grillaDeProductos.TabIndex = 0;
            grillaDeProductos.ColumnHeaderMouseClick += GrillaDeProductos_ColumnHeaderMouseClick;
            grillaDeProductos.SelectionChanged += GrillaDeProductos_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Location = new Point(641, 12);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(124, 32);
            botonAgregarProducto.TabIndex = 1;
            botonAgregarProducto.Text = "Agregar Producto";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += BotonAgregarProducto_Click;
            // 
            // botonBorrarProducto
            // 
            botonBorrarProducto.Enabled = false;
            botonBorrarProducto.Location = new Point(641, 50);
            botonBorrarProducto.Name = "botonBorrarProducto";
            botonBorrarProducto.Size = new Size(124, 32);
            botonBorrarProducto.TabIndex = 2;
            botonBorrarProducto.Text = "Borrar Producto";
            botonBorrarProducto.UseVisualStyleBackColor = true;
            botonBorrarProducto.Click += BotonBorrarProducto_Click;
            // 
            // botonModificarProducto
            // 
            botonModificarProducto.Enabled = false;
            botonModificarProducto.Location = new Point(641, 88);
            botonModificarProducto.Name = "botonModificarProducto";
            botonModificarProducto.Size = new Size(124, 32);
            botonModificarProducto.TabIndex = 3;
            botonModificarProducto.Text = "Modificar Producto";
            botonModificarProducto.UseVisualStyleBackColor = true;
            botonModificarProducto.Click += BotonModificarProducto_Click;
            // 
            // botonClonarProducto
            // 
            botonClonarProducto.Enabled = false;
            botonClonarProducto.Location = new Point(641, 126);
            botonClonarProducto.Name = "botonClonarProducto";
            botonClonarProducto.Size = new Size(124, 32);
            botonClonarProducto.TabIndex = 4;
            botonClonarProducto.Text = "Clonar Producto";
            botonClonarProducto.UseVisualStyleBackColor = true;
            botonClonarProducto.Click += BotonClonarProducto_Click;
            // 
            // botonMostrarPartesDelID
            // 
            botonMostrarPartesDelID.Enabled = false;
            botonMostrarPartesDelID.Location = new Point(641, 164);
            botonMostrarPartesDelID.Name = "botonMostrarPartesDelID";
            botonMostrarPartesDelID.Size = new Size(124, 32);
            botonMostrarPartesDelID.TabIndex = 5;
            botonMostrarPartesDelID.Text = "Mostrar Partes del ID";
            botonMostrarPartesDelID.UseVisualStyleBackColor = true;
            botonMostrarPartesDelID.Click += BotonMostrarPartesDelID_Click;
            // 
            // AdministradorDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonMostrarPartesDelID);
            Controls.Add(botonClonarProducto);
            Controls.Add(botonModificarProducto);
            Controls.Add(botonBorrarProducto);
            Controls.Add(botonAgregarProducto);
            Controls.Add(grillaDeProductos);
            Name = "AdministradorDeProductos";
            Text = "Administrador de Productos";
            ((System.ComponentModel.ISupportInitialize)grillaDeProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaDeProductos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private Button botonAgregarProducto;
        private Button botonBorrarProducto;
        private Button botonModificarProducto;
        private Button botonClonarProducto;
        private Button botonMostrarPartesDelID;
    }
}