namespace ActividadDesempeño_RegistroCiudadanos_0902_22_12338
{
    partial class Form_ConsultaCiudadanos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconoRegresar = new FontAwesome.Sharp.IconButton();
            this.LabelBarraSuperior = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.IconoRegresar);
            this.panel1.Controls.Add(this.LabelBarraSuperior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 2;
            // 
            // IconoRegresar
            // 
            this.IconoRegresar.BackColor = System.Drawing.Color.Transparent;
            this.IconoRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.IconoRegresar.FlatAppearance.BorderSize = 0;
            this.IconoRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconoRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IconoRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.IconoRegresar.IconColor = System.Drawing.Color.Snow;
            this.IconoRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoRegresar.IconSize = 35;
            this.IconoRegresar.Location = new System.Drawing.Point(8, 4);
            this.IconoRegresar.Name = "IconoRegresar";
            this.IconoRegresar.Size = new System.Drawing.Size(42, 33);
            this.IconoRegresar.TabIndex = 3;
            this.IconoRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconoRegresar.UseVisualStyleBackColor = false;
            // 
            // LabelBarraSuperior
            // 
            this.LabelBarraSuperior.AutoSize = true;
            this.LabelBarraSuperior.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBarraSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelBarraSuperior.Location = new System.Drawing.Point(48, 0);
            this.LabelBarraSuperior.Name = "LabelBarraSuperior";
            this.LabelBarraSuperior.Size = new System.Drawing.Size(268, 36);
            this.LabelBarraSuperior.TabIndex = 2;
            this.LabelBarraSuperior.Text = "Consulta ciudadanos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 325);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_ConsultaCiudadanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ConsultaCiudadanos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_ConsultaCiudadanos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IconoRegresar;
        private System.Windows.Forms.Label LabelBarraSuperior;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}