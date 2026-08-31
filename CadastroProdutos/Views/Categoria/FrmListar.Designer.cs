namespace CadastroProdutos.Views.Categoria
{
    partial class FrmListar
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
            flpItens = new FlowLayoutPanel();
            btCadastrar = new Button();
            txtBusca = new TextBox();
            btBuscar = new Button();
            SuspendLayout();
            // 
            // flpItens
            // 
            flpItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpItens.AutoScroll = true;
            flpItens.BackColor = Color.White;
            flpItens.BorderStyle = BorderStyle.Fixed3D;
            flpItens.Location = new Point(90, 67);
            flpItens.Name = "flpItens";
            flpItens.Size = new Size(625, 296);
            flpItens.TabIndex = 0;
            // 
            // btCadastrar
            // 
            btCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btCadastrar.Location = new Point(347, 387);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(120, 39);
            btCadastrar.TabIndex = 1;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBusca.Location = new Point(218, 31);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(249, 23);
            txtBusca.TabIndex = 2;
            // 
            // btBuscar
            // 
            btBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscar.Location = new Point(490, 22);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(117, 39);
            btBuscar.TabIndex = 3;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Controls.Add(btCadastrar);
            Controls.Add(flpItens);
            Name = "FrmListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListar";
            Load += FrmListar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpItens;
        private Button btCadastrar;
        private TextBox txtBusca;
        private Button btBuscar;
    }
}