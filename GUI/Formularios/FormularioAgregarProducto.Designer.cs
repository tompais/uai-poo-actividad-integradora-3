namespace uai_poo_actividad_integradora_3.GUI.Formularios
{
    partial class FormularioAgregarProducto
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
            campoDeTextoEnmascaradoId = new MaskedTextBox();
            etiquetaId = new Label();
            campoDeTextoDescripcion = new TextBox();
            etiquetaDescripcion = new Label();
            campoNumericoPrecio = new NumericUpDown();
            etiquetaPrecio = new Label();
            label1 = new Label();
            campoNumericoStock = new NumericUpDown();
            botonAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)campoNumericoPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoStock).BeginInit();
            SuspendLayout();
            // 
            // campoDeTextoEnmascaradoId
            // 
            campoDeTextoEnmascaradoId.Location = new Point(126, 95);
            campoDeTextoEnmascaradoId.Mask = "000-\\L00-\\OP000-00/00/0000";
            campoDeTextoEnmascaradoId.Name = "campoDeTextoEnmascaradoId";
            campoDeTextoEnmascaradoId.Size = new Size(138, 23);
            campoDeTextoEnmascaradoId.TabIndex = 4;
            campoDeTextoEnmascaradoId.TextChanged += ValidarCampos;
            // 
            // etiquetaId
            // 
            etiquetaId.AutoSize = true;
            etiquetaId.Location = new Point(126, 77);
            etiquetaId.Name = "etiquetaId";
            etiquetaId.Size = new Size(17, 15);
            etiquetaId.TabIndex = 5;
            etiquetaId.Text = "Id";
            // 
            // campoDeTextoDescripcion
            // 
            campoDeTextoDescripcion.Location = new Point(126, 139);
            campoDeTextoDescripcion.Name = "campoDeTextoDescripcion";
            campoDeTextoDescripcion.Size = new Size(138, 23);
            campoDeTextoDescripcion.TabIndex = 6;
            campoDeTextoDescripcion.TextChanged += ValidarCampos;
            // 
            // etiquetaDescripcion
            // 
            etiquetaDescripcion.AutoSize = true;
            etiquetaDescripcion.Location = new Point(126, 121);
            etiquetaDescripcion.Name = "etiquetaDescripcion";
            etiquetaDescripcion.Size = new Size(69, 15);
            etiquetaDescripcion.TabIndex = 7;
            etiquetaDescripcion.Text = "Descripción";
            // 
            // campoNumericoPrecio
            // 
            campoNumericoPrecio.DecimalPlaces = 2;
            campoNumericoPrecio.Location = new Point(126, 183);
            campoNumericoPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            campoNumericoPrecio.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoPrecio.Name = "campoNumericoPrecio";
            campoNumericoPrecio.Size = new Size(138, 23);
            campoNumericoPrecio.TabIndex = 8;
            campoNumericoPrecio.Value = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoPrecio.ValueChanged += ValidarCampos;
            // 
            // etiquetaPrecio
            // 
            etiquetaPrecio.AutoSize = true;
            etiquetaPrecio.Location = new Point(126, 165);
            etiquetaPrecio.Name = "etiquetaPrecio";
            etiquetaPrecio.Size = new Size(40, 15);
            etiquetaPrecio.TabIndex = 9;
            etiquetaPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 213);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 11;
            label1.Text = "Stock";
            // 
            // campoNumericoStock
            // 
            campoNumericoStock.Location = new Point(126, 231);
            campoNumericoStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            campoNumericoStock.Name = "campoNumericoStock";
            campoNumericoStock.Size = new Size(138, 23);
            campoNumericoStock.TabIndex = 10;
            campoNumericoStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Enabled = false;
            botonAgregarProducto.Location = new Point(150, 260);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(79, 32);
            botonAgregarProducto.TabIndex = 12;
            botonAgregarProducto.Text = "Agregar";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += BotonAgregarProducto_Click;
            // 
            // FormularioAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 404);
            Controls.Add(botonAgregarProducto);
            Controls.Add(label1);
            Controls.Add(campoNumericoStock);
            Controls.Add(etiquetaPrecio);
            Controls.Add(campoNumericoPrecio);
            Controls.Add(etiquetaDescripcion);
            Controls.Add(campoDeTextoDescripcion);
            Controls.Add(etiquetaId);
            Controls.Add(campoDeTextoEnmascaradoId);
            Name = "FormularioAgregarProducto";
            Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)campoNumericoPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox campoDeTextoEnmascaradoId;
        private Label etiquetaId;
        private TextBox campoDeTextoDescripcion;
        private Label etiquetaDescripcion;
        private NumericUpDown campoNumericoPrecio;
        private Label etiquetaPrecio;
        private Label label1;
        private NumericUpDown campoNumericoStock;
        private Button botonAgregarProducto;
    }
}