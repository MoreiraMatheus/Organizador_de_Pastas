namespace Organizador_de_Pastas
{
    partial class F_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btn_selecionar_pasta = new Button();
            tb_caminho = new TextBox();
            btn_organizar = new Button();
            fbd_Bucasdor = new FolderBrowserDialog();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // btn_selecionar_pasta
            // 
            btn_selecionar_pasta.Location = new Point(12, 78);
            btn_selecionar_pasta.Name = "btn_selecionar_pasta";
            btn_selecionar_pasta.Size = new Size(111, 23);
            btn_selecionar_pasta.TabIndex = 0;
            btn_selecionar_pasta.Text = "Selecionar Pasta";
            btn_selecionar_pasta.UseVisualStyleBackColor = true;
            btn_selecionar_pasta.Click += btn_selecionar_pasta_Click;
            // 
            // tb_caminho
            // 
            tb_caminho.Enabled = false;
            tb_caminho.Location = new Point(12, 37);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.ReadOnly = true;
            tb_caminho.Size = new Size(345, 23);
            tb_caminho.TabIndex = 1;
            // 
            // btn_organizar
            // 
            btn_organizar.Location = new Point(246, 78);
            btn_organizar.Name = "btn_organizar";
            btn_organizar.Size = new Size(111, 23);
            btn_organizar.TabIndex = 3;
            btn_organizar.Text = "Organizar";
            btn_organizar.UseVisualStyleBackColor = true;
            btn_organizar.Click += btn_organizar_Click;
            // 
            // fbd_Bucasdor
            // 
            fbd_Bucasdor.InitialDirectory = "Downloads";
            fbd_Bucasdor.RootFolder = Environment.SpecialFolder.UserProfile;
            fbd_Bucasdor.ShowNewFolderButton = false;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(129, 78);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(111, 23);
            btn_limpar.TabIndex = 4;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 165);
            Controls.Add(btn_limpar);
            Controls.Add(btn_organizar);
            Controls.Add(tb_caminho);
            Controls.Add(btn_selecionar_pasta);
            Name = "F_Main";
            Text = "Organizador de Pastas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_selecionar_pasta;
        private TextBox tb_caminho;
        private Button btn_organizar;
        private FolderBrowserDialog fbd_Bucasdor;
        private Button btn_limpar;
    }
}
