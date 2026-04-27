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
            tabControl1 = new TabControl();
            tabPage_organizer = new TabPage();
            label_directory = new Label();
            tabPage_config = new TabPage();
            btn_salvar = new Button();
            clb_tipos_validos = new CheckedListBox();
            lb_tipos = new Label();
            tabControl1.SuspendLayout();
            tabPage_organizer.SuspendLayout();
            tabPage_config.SuspendLayout();
            SuspendLayout();
            // 
            // btn_selecionar_pasta
            // 
            btn_selecionar_pasta.BackgroundImage = (Image)resources.GetObject("btn_selecionar_pasta.BackgroundImage");
            btn_selecionar_pasta.BackgroundImageLayout = ImageLayout.Zoom;
            btn_selecionar_pasta.Location = new Point(99, 102);
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
            tb_caminho.Location = new Point(97, 67);
            tb_caminho.Margin = new Padding(4);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.ReadOnly = true;
            tb_caminho.Size = new Size(345, 27);
            tb_caminho.TabIndex = 0;
            // 
            // btn_organizar
            // 
            btn_organizar.Location = new Point(175, 102);
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
            btn_limpar.Location = new Point(137, 102);
            btn_limpar.Margin = new Padding(4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(30, 30);
            btn_limpar.TabIndex = 2;
            toolTipBotoes.SetToolTip(btn_limpar, "Limpar pasta");
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_organizer);
            tabControl1.Controls.Add(tabPage_config);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(8, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(556, 368);
            tabControl1.TabIndex = 5;
            // 
            // tabPage_organizer
            // 
            tabPage_organizer.Controls.Add(label_directory);
            tabPage_organizer.Controls.Add(tb_caminho);
            tabPage_organizer.Controls.Add(btn_limpar);
            tabPage_organizer.Controls.Add(btn_selecionar_pasta);
            tabPage_organizer.Controls.Add(btn_organizar);
            tabPage_organizer.Location = new Point(4, 24);
            tabPage_organizer.Name = "tabPage_organizer";
            tabPage_organizer.Padding = new Padding(3);
            tabPage_organizer.Size = new Size(548, 340);
            tabPage_organizer.TabIndex = 0;
            tabPage_organizer.Text = "Organizar";
            tabPage_organizer.UseVisualStyleBackColor = true;
            // 
            // label_directory
            // 
            label_directory.AutoSize = true;
            label_directory.Location = new Point(99, 48);
            label_directory.Name = "label_directory";
            label_directory.Size = new Size(56, 15);
            label_directory.TabIndex = 4;
            label_directory.Text = "Diretório:";
            // 
            // tabPage_config
            // 
            tabPage_config.Controls.Add(btn_salvar);
            tabPage_config.Controls.Add(clb_tipos_validos);
            tabPage_config.Controls.Add(lb_tipos);
            tabPage_config.Location = new Point(4, 24);
            tabPage_config.Name = "tabPage_config";
            tabPage_config.Padding = new Padding(3);
            tabPage_config.Size = new Size(548, 340);
            tabPage_config.TabIndex = 1;
            tabPage_config.Text = "Configurações";
            tabPage_config.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(54, 187);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 9;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // clb_tipos_validos
            // 
            clb_tipos_validos.BackColor = SystemColors.ScrollBar;
            clb_tipos_validos.BorderStyle = BorderStyle.None;
            clb_tipos_validos.FormattingEnabled = true;
            clb_tipos_validos.Items.AddRange(new object[] { "Documentos", "Músicas", "Fotos", "Vídeos", "Planilhas", "Aplicativos", "Outros" });
            clb_tipos_validos.Location = new Point(36, 55);
            clb_tipos_validos.Name = "clb_tipos_validos";
            clb_tipos_validos.Size = new Size(120, 126);
            clb_tipos_validos.TabIndex = 8;
            // 
            // lb_tipos
            // 
            lb_tipos.AutoSize = true;
            lb_tipos.Location = new Point(36, 37);
            lb_tipos.Name = "lb_tipos";
            lb_tipos.Size = new Size(76, 15);
            lb_tipos.TabIndex = 7;
            lb_tipos.Text = "Tipos Válidos";
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 384);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "F_Main";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organizador de Pastas";
            tabControl1.ResumeLayout(false);
            tabPage_organizer.ResumeLayout(false);
            tabPage_organizer.PerformLayout();
            tabPage_config.ResumeLayout(false);
            tabPage_config.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_selecionar_pasta;
        private TextBox tb_caminho;
        private Button btn_organizar;
        private FolderBrowserDialog fbd_Bucasdor;
        private Button btn_limpar;
        private ToolTip toolTipBotoes;
        private TabPage tabPage_organizer;
        private Label label_directory;
        private Label lb_tipos;
        private Button btn_salvar;
        public CheckedListBox clb_tipos_validos;
        public TabPage tabPage_config;
        public TabControl tabControl1;
    }
}
