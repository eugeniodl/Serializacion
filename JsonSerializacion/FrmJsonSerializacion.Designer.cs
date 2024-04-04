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
            label2 = new Label();
            txtNombre = new TextBox();
            txtMunicipio = new TextBox();
            label3 = new Label();
            txtDepartamento = new TextBox();
            label4 = new Label();
            btnInsertar = new Button();
            btnSerializarLista = new Button();
            btnDeserializarLista = new Button();
            dgvResultado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 31);
            label1.Name = "label1";
            label1.Size = new Size(394, 41);
            label1.TabIndex = 0;
            label1.Text = "Serializar y deserializar JSON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Empresa";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 111);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(334, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(166, 169);
            txtMunicipio.Margin = new Padding(3, 4, 3, 4);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(334, 27);
            txtMunicipio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 173);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Municipio";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(166, 236);
            txtDepartamento.Margin = new Padding(3, 4, 3, 4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(334, 27);
            txtDepartamento.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 240);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 5;
            label4.Text = "Departamento";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(58, 313);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(123, 31);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnSerializarLista
            // 
            btnSerializarLista.Enabled = false;
            btnSerializarLista.Location = new Point(216, 313);
            btnSerializarLista.Margin = new Padding(3, 4, 3, 4);
            btnSerializarLista.Name = "btnSerializarLista";
            btnSerializarLista.Size = new Size(123, 31);
            btnSerializarLista.TabIndex = 8;
            btnSerializarLista.Text = "Serializar lista";
            btnSerializarLista.UseVisualStyleBackColor = true;
            btnSerializarLista.Click += btnSerializarLista_Click;
            // 
            // btnDeserializarLista
            // 
            btnDeserializarLista.Location = new Point(377, 313);
            btnDeserializarLista.Margin = new Padding(3, 4, 3, 4);
            btnDeserializarLista.Name = "btnDeserializarLista";
            btnDeserializarLista.Size = new Size(123, 31);
            btnDeserializarLista.TabIndex = 9;
            btnDeserializarLista.Text = "Deserializar lista";
            btnDeserializarLista.UseVisualStyleBackColor = true;
            btnDeserializarLista.Click += btnDeserializarLista_Click;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Dock = DockStyle.Bottom;
            dgvResultado.Location = new Point(0, 380);
            dgvResultado.Margin = new Padding(3, 4, 3, 4);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 51;
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(566, 217);
            dgvResultado.TabIndex = 10;
            // 
            // FrmJsonSerializacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 597);
            Controls.Add(dgvResultado);
            Controls.Add(btnDeserializarLista);
            Controls.Add(btnSerializarLista);
            Controls.Add(btnInsertar);
            Controls.Add(txtDepartamento);
            Controls.Add(label4);
            Controls.Add(txtMunicipio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtMunicipio;
        private Label label3;
        private TextBox txtDepartamento;
        private Label label4;
        private Button btnInsertar;
        private Button btnSerializarLista;
        private Button btnDeserializarLista;
        private DataGridView dgvResultado;
    }
}