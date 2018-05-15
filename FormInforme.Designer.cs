namespace HistoriasMecanicas
{
    partial class FormInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInforme));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkBoxFacturacion = new System.Windows.Forms.CheckBox();
            this.labelRepuestos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "MM yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(108, 26);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.Location = new System.Drawing.Point(12, 42);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(131, 20);
            this.labelMensaje.TabIndex = 2;
            this.labelMensaje.Text = "Total Mano Obra:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 85);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(903, 322);
            this.textBox.TabIndex = 3;
            // 
            // checkBoxFacturacion
            // 
            this.checkBoxFacturacion.AutoSize = true;
            this.checkBoxFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFacturacion.Location = new System.Drawing.Point(803, 55);
            this.checkBoxFacturacion.Name = "checkBoxFacturacion";
            this.checkBoxFacturacion.Size = new System.Drawing.Size(112, 24);
            this.checkBoxFacturacion.TabIndex = 4;
            this.checkBoxFacturacion.Text = "Facturación";
            this.checkBoxFacturacion.UseVisualStyleBackColor = true;
            this.checkBoxFacturacion.CheckedChanged += new System.EventHandler(this.checkBoxFacturacion_CheckedChanged);
            // 
            // labelRepuestos
            // 
            this.labelRepuestos.AutoSize = true;
            this.labelRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepuestos.Location = new System.Drawing.Point(13, 62);
            this.labelRepuestos.Name = "labelRepuestos";
            this.labelRepuestos.Size = new System.Drawing.Size(130, 20);
            this.labelRepuestos.TabIndex = 5;
            this.labelRepuestos.Text = "Total Repuestos:";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 419);
            this.Controls.Add(this.labelRepuestos);
            this.Controls.Add(this.checkBoxFacturacion);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.dateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInforme";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox checkBoxFacturacion;
        private System.Windows.Forms.Label labelRepuestos;
    }
}