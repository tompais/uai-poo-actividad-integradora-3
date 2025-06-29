namespace uai_poo_actividad_integradora_3.GUI.Formularios
{
    partial class FormularioModificarProducto
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
            botonModificarProducto = new Button();
            label1 = new Label();
            campoNumericoStock = new NumericUpDown();
            etiquetaPrecio = new Label();
            campoNumericoPrecio = new NumericUpDown();
            etiquetaDescripcion = new Label();
            campoDeTextoDescripcion = new TextBox();
            etiquetaId = new Label();
            campoDeTextoEnmascaradoId = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)campoNumericoStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoPrecio).BeginInit();
            SuspendLayout();
            // 
            // botonModificarProducto
            // 
            botonModificarProducto.Location = new Point(155, 255);
            botonModificarProducto.Name = "botonModificarProducto";
            botonModificarProducto.Size = new Size(79, 32);
            botonModificarProducto.TabIndex = 21;
            botonModificarProducto.Text = "Modificar";
            botonModificarProducto.UseVisualStyleBackColor = true;
            botonModificarProducto.Click += BotonModificarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 208);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 20;
            label1.Text = "Stock";
            // 
            // campoNumericoStock
            // 
            campoNumericoStock.Location = new Point(131, 226);
            campoNumericoStock.Name = "campoNumericoStock";
            campoNumericoStock.Size = new Size(138, 23);
            campoNumericoStock.TabIndex = 19;
            campoNumericoStock.ValueChanged += ValidarCampos;
            // 
            // etiquetaPrecio
            // 
            etiquetaPrecio.AutoSize = true;
            etiquetaPrecio.Location = new Point(131, 160);
            etiquetaPrecio.Name = "etiquetaPrecio";
            etiquetaPrecio.Size = new Size(40, 15);
            etiquetaPrecio.TabIndex = 18;
            etiquetaPrecio.Text = "Precio";
            // 
            // campoNumericoPrecio
            // 
            campoNumericoPrecio.DecimalPlaces = 2;
            campoNumericoPrecio.Location = new Point(131, 178);
            campoNumericoPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            campoNumericoPrecio.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoPrecio.Name = "campoNumericoPrecio";
            campoNumericoPrecio.Size = new Size(138, 23);
            campoNumericoPrecio.TabIndex = 17;
            campoNumericoPrecio.Value = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoPrecio.ValueChanged += ValidarCampos;
            // 
            // etiquetaDescripcion
            // 
            etiquetaDescripcion.AutoSize = true;
            etiquetaDescripcion.Location = new Point(131, 116);
            etiquetaDescripcion.Name = "etiquetaDescripcion";
            etiquetaDescripcion.Size = new Size(69, 15);
            etiquetaDescripcion.TabIndex = 16;
            etiquetaDescripcion.Text = "Descripción";
            // 
            // campoDeTextoDescripcion
            // 
            campoDeTextoDescripcion.Location = new Point(131, 134);
            campoDeTextoDescripcion.Name = "campoDeTextoDescripcion";
            campoDeTextoDescripcion.Size = new Size(138, 23);
            campoDeTextoDescripcion.TabIndex = 15;
            campoDeTextoDescripcion.TextChanged += ValidarCampos;
            // 
            // etiquetaId
            // 
            etiquetaId.AutoSize = true;
            etiquetaId.Location = new Point(131, 72);
            etiquetaId.Name = "etiquetaId";
            etiquetaId.Size = new Size(17, 15);
            etiquetaId.TabIndex = 14;
            etiquetaId.Text = "Id";
            // 
            // campoDeTextoEnmascaradoId
            // 
            campoDeTextoEnmascaradoId.Location = new Point(131, 90);
            campoDeTextoEnmascaradoId.Mask = "000-\\L00-\\OP000-00/00/0000";
            campoDeTextoEnmascaradoId.Name = "campoDeTextoEnmascaradoId";
            campoDeTextoEnmascaradoId.Size = new Size(138, 23);
            campoDeTextoEnmascaradoId.TabIndex = 13;
            campoDeTextoEnmascaradoId.TextChanged += ValidarCampos;
            // 
            // FormularioModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 396);
            Controls.Add(botonModificarProducto);
            Controls.Add(label1);
            Controls.Add(campoNumericoStock);
            Controls.Add(etiquetaPrecio);
            Controls.Add(campoNumericoPrecio);
            Controls.Add(etiquetaDescripcion);
            Controls.Add(campoDeTextoDescripcion);
            Controls.Add(etiquetaId);
            Controls.Add(campoDeTextoEnmascaradoId);
            Name = "FormularioModificarProducto";
            Text = "Modificar Producto";
            Load += FormularioModificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)campoNumericoStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonModificarProducto;
        private Label label1;
        private NumericUpDown campoNumericoStock;
        private Label etiquetaPrecio;
        private NumericUpDown campoNumericoPrecio;
        private Label etiquetaDescripcion;
        private TextBox campoDeTextoDescripcion;
        private Label etiquetaId;
        private MaskedTextBox campoDeTextoEnmascaradoId;
    }
}