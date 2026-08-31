namespace CadastroProdutos.Views.Categoria
{
    partial class CategoriaControl
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
            lblNome = new Label();
            btEditar = new Button();
            btRemover = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(16, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 15);
            lblId.TabIndex = 0;
            lblId.Text = "lblId";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(0, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(92, 30);
            lblNome.TabIndex = 1;
            lblNome.Text = "lblNome";
            // 
            // btEditar
            // 
            btEditar.Location = new Point(179, 15);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 2;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(179, 81);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(75, 23);
            btRemover.TabIndex = 3;
            btRemover.Text = "Remover";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // CategoriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "CategoriaControl";
            Size = new Size(295, 123);
            Load += CategoriaControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Button btEditar;
        private Button btRemover;
    }
}
