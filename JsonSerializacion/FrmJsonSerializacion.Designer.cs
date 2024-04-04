namespace JsonSerializacion
{
    partial class FrmJsonSerializacion
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtMunicipio = new TextBox();
            label2 = new Label();
            txtDepartamento = new TextBox();
            label3 = new Label();
            btnInsertar = new Button();
            btnSerializarLista = new Button();
            btnDeserializarLista = new Button();
            dgvResultado = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Empresa";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(187, 100);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(321, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(187, 152);
            txtMunicipio.Margin = new Padding(3, 4, 3, 4);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(321, 27);
            txtMunicipio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 156);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Municipio";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(187, 209);
            txtDepartamento.Margin = new Padding(3, 4, 3, 4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(321, 27);
            txtDepartamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 213);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Departamento";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(40, 277);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(143, 31);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnSerializarLista
            // 
            btnSerializarLista.Location = new Point(201, 277);
            btnSerializarLista.Margin = new Padding(3, 4, 3, 4);
            btnSerializarLista.Name = "btnSerializarLista";
            btnSerializarLista.Size = new Size(143, 31);
            btnSerializarLista.TabIndex = 7;
            btnSerializarLista.Text = "Serializar lista";
            btnSerializarLista.UseVisualStyleBackColor = true;
            btnSerializarLista.Click += btnSerializarLista_Click;
            // 
            // btnDeserializarLista
            // 
            btnDeserializarLista.Location = new Point(366, 277);
            btnDeserializarLista.Margin = new Padding(3, 4, 3, 4);
            btnDeserializarLista.Name = "btnDeserializarLista";
            btnDeserializarLista.Size = new Size(143, 31);
            btnDeserializarLista.TabIndex = 8;
            btnDeserializarLista.Text = "Deserializar lista";
            btnDeserializarLista.UseVisualStyleBackColor = true;
            btnDeserializarLista.Click += btnDeserializarLista_Click;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Dock = DockStyle.Bottom;
            dgvResultado.Location = new Point(0, 335);
            dgvResultado.Margin = new Padding(3, 4, 3, 4);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 51;
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(546, 228);
            dgvResultado.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 27);
            label4.Name = "label4";
            label4.Size = new Size(394, 41);
            label4.TabIndex = 10;
            label4.Text = "Serializar y deserializar JSON";
            // 
            // FrmJsonSerializacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 563);
            Controls.Add(label4);
            Controls.Add(dgvResultado);
            Controls.Add(btnDeserializarLista);
            Controls.Add(btnSerializarLista);
            Controls.Add(btnInsertar);
            Controls.Add(txtDepartamento);
            Controls.Add(label3);
            Controls.Add(txtMunicipio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmJsonSerializacion";
            Text = "Serializar y deserializar JSON";
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtMunicipio;
        private Label label2;
        private TextBox txtDepartamento;
        private Label label3;
        private Button btnInsertar;
        private Button btnSerializarLista;
        private Button btnDeserializarLista;
        private DataGridView dgvResultado;
        private Label label4;
    }
}