namespace CadastroProdutos.Views.Produtos
{
    partial class ProdControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            numPreco = new NumericUpDown();
            btnExcluir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(79, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 15);
            lblId.TabIndex = 0;
            lblId.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 50);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 87);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço:           R$";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Location = new Point(167, 85);
            numPreco.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(120, 23);
            numPreco.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(192, 118);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(63, 118);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // ProdControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(numPreco);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblId);
            Name = "ProdControl";
            Size = new Size(355, 148);
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private NumericUpDown numPreco;
        private Button btnExcluir;
        private Button btnEditar;
    }
}
