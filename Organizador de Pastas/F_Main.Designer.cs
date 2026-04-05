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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            btn_selecionar_pasta = new Button();
            tb_caminho = new TextBox();
            btn_organizar = new Button();
            fbd_Bucasdor = new FolderBrowserDialog();
            btn_limpar = new Button();
            toolTipBotoes = new ToolTip(components);
            SuspendLayout();
            // 
            // btn_selecionar_pasta
            // 
            btn_selecionar_pasta.BackgroundImage = (Image)resources.GetObject("btn_selecionar_pasta.BackgroundImage");
            btn_selecionar_pasta.BackgroundImageLayout = ImageLayout.Zoom;
            btn_selecionar_pasta.Location = new Point(375, 21);
            btn_selecionar_pasta.Margin = new Padding(4);
            btn_selecionar_pasta.Name = "btn_selecionar_pasta";
            btn_selecionar_pasta.Size = new Size(30, 30);
            btn_selecionar_pasta.TabIndex = 1;
            toolTipBotoes.SetToolTip(btn_selecionar_pasta, "Buscar pasta");
            btn_selecionar_pasta.UseVisualStyleBackColor = true;
            btn_selecionar_pasta.Click += btn_selecionar_pasta_Click;
            // 
            // tb_caminho
            // 
            tb_caminho.Enabled = false;
            tb_caminho.Font = new Font("Segoe UI", 11F);
            tb_caminho.Location = new Point(22, 21);
            tb_caminho.Margin = new Padding(4);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.ReadOnly = true;
            tb_caminho.Size = new Size(345, 27);
            tb_caminho.TabIndex = 0;
            // 
            // btn_organizar
            // 
            btn_organizar.Location = new Point(451, 21);
            btn_organizar.Margin = new Padding(4);
            btn_organizar.Name = "btn_organizar";
            btn_organizar.Size = new Size(100, 30);
            btn_organizar.TabIndex = 3;
            btn_organizar.Text = "Organizar";
            toolTipBotoes.SetToolTip(btn_organizar, "Organiza os arquivos");
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
            btn_limpar.BackgroundImage = (Image)resources.GetObject("btn_limpar.BackgroundImage");
            btn_limpar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_limpar.Location = new Point(413, 21);
            btn_limpar.Margin = new Padding(4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(30, 30);
            btn_limpar.TabIndex = 2;
            toolTipBotoes.SetToolTip(btn_limpar, "Limpar pasta");
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 76);
            Controls.Add(btn_limpar);
            Controls.Add(btn_organizar);
            Controls.Add(tb_caminho);
            Controls.Add(btn_selecionar_pasta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Main";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
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
        private ToolTip toolTipBotoes;
    }
}
