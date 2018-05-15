namespace HistoriasMecanicas {
    partial class FormAuto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuto));
            this.labelMarcaModelo = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.buttonNuevaConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCostoManoObra = new System.Windows.Forms.TextBox();
            this.textBoxCostoRepuestos = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKilometraje = new System.Windows.Forms.TextBox();
            this.listBoxArreglos = new System.Windows.Forms.ListBox();
            this.labelDueno = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelSinVenir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMarcaModelo
            // 
            this.labelMarcaModelo.AutoSize = true;
            this.labelMarcaModelo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaModelo.Location = new System.Drawing.Point(12, 9);
            this.labelMarcaModelo.Name = "labelMarcaModelo";
            this.labelMarcaModelo.Size = new System.Drawing.Size(77, 27);
            this.labelMarcaModelo.TabIndex = 0;
            this.labelMarcaModelo.Text = "Marca";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(12, 63);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(44, 22);
            this.labelAno.TabIndex = 2;
            this.labelAno.Text = "Año";
            // 
            // buttonNuevaConsulta
            // 
            this.buttonNuevaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaConsulta.Location = new System.Drawing.Point(11, 111);
            this.buttonNuevaConsulta.Name = "buttonNuevaConsulta";
            this.buttonNuevaConsulta.Size = new System.Drawing.Size(102, 32);
            this.buttonNuevaConsulta.TabIndex = 3;
            this.buttonNuevaConsulta.Text = "Nuevo";
            this.buttonNuevaConsulta.UseVisualStyleBackColor = true;
            this.buttonNuevaConsulta.Click += new System.EventHandler(this.buttonNuevoArreglo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Costo Mano Obra $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Costo Repuestos $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción";
            // 
            // textBoxCostoManoObra
            // 
            this.textBoxCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostoManoObra.Location = new System.Drawing.Point(328, 342);
            this.textBoxCostoManoObra.Multiline = true;
            this.textBoxCostoManoObra.Name = "textBoxCostoManoObra";
            this.textBoxCostoManoObra.ReadOnly = true;
            this.textBoxCostoManoObra.Size = new System.Drawing.Size(261, 28);
            this.textBoxCostoManoObra.TabIndex = 16;
            // 
            // textBoxCostoRepuestos
            // 
            this.textBoxCostoRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostoRepuestos.Location = new System.Drawing.Point(328, 290);
            this.textBoxCostoRepuestos.Multiline = true;
            this.textBoxCostoRepuestos.Name = "textBoxCostoRepuestos";
            this.textBoxCostoRepuestos.ReadOnly = true;
            this.textBoxCostoRepuestos.Size = new System.Drawing.Size(261, 26);
            this.textBoxCostoRepuestos.TabIndex = 15;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(331, 85);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(262, 179);
            this.textBoxDescripcion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kilometraje";
            // 
            // textBoxKilometraje
            // 
            this.textBoxKilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKilometraje.Location = new System.Drawing.Point(331, 31);
            this.textBoxKilometraje.Multiline = true;
            this.textBoxKilometraje.Name = "textBoxKilometraje";
            this.textBoxKilometraje.Size = new System.Drawing.Size(262, 27);
            this.textBoxKilometraje.TabIndex = 12;
            this.textBoxKilometraje.TextChanged += new System.EventHandler(this.textBoxKilometraje_TextChanged);
            // 
            // listBoxArreglos
            // 
            this.listBoxArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArreglos.FormattingEnabled = true;
            this.listBoxArreglos.ItemHeight = 20;
            this.listBoxArreglos.Location = new System.Drawing.Point(11, 146);
            this.listBoxArreglos.Name = "listBoxArreglos";
            this.listBoxArreglos.Size = new System.Drawing.Size(311, 224);
            this.listBoxArreglos.TabIndex = 1;
            this.listBoxArreglos.SelectedIndexChanged += new System.EventHandler(this.listBoxArreglos_SelectedIndexChanged);
            this.listBoxArreglos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxArreglos_KeyUp);
            // 
            // labelDueno
            // 
            this.labelDueno.AutoSize = true;
            this.labelDueno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueno.Location = new System.Drawing.Point(12, 86);
            this.labelDueno.Name = "labelDueno";
            this.labelDueno.Size = new System.Drawing.Size(66, 22);
            this.labelDueno.TabIndex = 22;
            this.labelDueno.Text = "Dueño";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(119, 111);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(102, 32);
            this.buttonEliminar.TabIndex = 23;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatente.Location = new System.Drawing.Point(12, 36);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(95, 27);
            this.labelPatente.TabIndex = 24;
            this.labelPatente.Text = "Patente";
            // 
            // labelSinVenir
            // 
            this.labelSinVenir.AutoSize = true;
            this.labelSinVenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinVenir.Location = new System.Drawing.Point(482, 8);
            this.labelSinVenir.Name = "labelSinVenir";
            this.labelSinVenir.Size = new System.Drawing.Size(117, 20);
            this.labelSinVenir.TabIndex = 25;
            this.labelSinVenir.Text = "Sin Venir: 9999";
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(609, 399);
            this.Controls.Add(this.labelSinVenir);
            this.Controls.Add(this.labelPatente);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelDueno);
            this.Controls.Add(this.listBoxArreglos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCostoManoObra);
            this.Controls.Add(this.textBoxCostoRepuestos);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKilometraje);
            this.Controls.Add(this.buttonNuevaConsulta);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelMarcaModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuto";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarcaModelo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Button buttonNuevaConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCostoManoObra;
        private System.Windows.Forms.TextBox textBoxCostoRepuestos;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKilometraje;
        private System.Windows.Forms.ListBox listBoxArreglos;
        private System.Windows.Forms.Label labelDueno;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelSinVenir;
    }
}