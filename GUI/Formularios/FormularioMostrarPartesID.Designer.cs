namespace uai_poo_actividad_integradora_3.GUI.Formularios
{
    partial class FormularioMostrarPartesID
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
            campoDeTextoPartesID = new TextBox();
            SuspendLayout();
            // 
            // campoDeTextoPartesID
            // 
            campoDeTextoPartesID.Location = new Point(12, 12);
            campoDeTextoPartesID.Multiline = true;
            campoDeTextoPartesID.Name = "campoDeTextoPartesID";
            campoDeTextoPartesID.ReadOnly = true;
            campoDeTextoPartesID.Size = new Size(344, 175);
            campoDeTextoPartesID.TabIndex = 0;
            // 
            // FormularioMostrarPartesID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 199);
            Controls.Add(campoDeTextoPartesID);
            Name = "FormularioMostrarPartesID";
            Text = "Partes ID";
            Load += FormularioMostrarPartesID_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoDeTextoPartesID;
    }
}