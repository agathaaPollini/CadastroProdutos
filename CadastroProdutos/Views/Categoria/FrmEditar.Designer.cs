namespace CadastroProdutos.Views.Categoria
{
    partial class FrmEditar
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
            lblID = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            btCadastrar = new Button();
            flpProds = new FlowLayoutPanel();
            label3 = new Label();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(71, 21);
            lblID.Name = "lblID";
            lblID.Size = new Size(38, 15);
            lblID.TabIndex = 0;
            lblID.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 51);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(201, 23);
            txtNome.TabIndex = 2;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(186, 105);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(135, 23);
            btCadastrar.TabIndex = 3;
            btCadastrar.Text = "Novo Produto";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // flpProds
            // 
            flpProds.AutoScroll = true;
            flpProds.BackColor = Color.White;
            flpProds.BorderStyle = BorderStyle.Fixed3D;
            flpProds.Location = new Point(12, 146);
            flpProds.Name = "flpProds";
            flpProds.Size = new Size(358, 256);
            flpProds.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 105);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Produtos:";
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(137, 434);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(112, 42);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(389, 505);
            Controls.Add(btSalvar);
            Controls.Add(label3);
            Controls.Add(flpProds);
            Controls.Add(btCadastrar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(lblID);
            MaximizeBox = false;
            Name = "FrmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label label2;
        private TextBox txtNome;
        private Button btCadastrar;
        private FlowLayoutPanel flpProds;
        private Label label3;
        private Button btSalvar;
    }
}