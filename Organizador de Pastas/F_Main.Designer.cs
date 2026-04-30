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
            br = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            tabControl1 = new TabControl();
            tabPage_organizer = new TabPage();
            label_directory = new Label();
            tabPage_config = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            button15 = new Button();
            btn_salvar = new Button();
            btn_cancelar = new Button();
            lb_tipos = new Label();
            tabControl1.SuspendLayout();
            tabPage_organizer.SuspendLayout();
            tabPage_config.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_selecionar_pasta
            // 
            btn_selecionar_pasta.BackgroundImage = (Image)resources.GetObject("btn_selecionar_pasta.BackgroundImage");
            btn_selecionar_pasta.BackgroundImageLayout = ImageLayout.Zoom;
            btn_selecionar_pasta.Location = new Point(35, 70);
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
            tb_caminho.Location = new Point(35, 35);
            tb_caminho.Margin = new Padding(32, 4, 32, 4);
            tb_caminho.Name = "tb_caminho";
            tb_caminho.ReadOnly = true;
            tb_caminho.Size = new Size(478, 27);
            tb_caminho.TabIndex = 0;
            // 
            // btn_organizar
            // 
            btn_organizar.Location = new Point(111, 70);
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
            btn_limpar.Location = new Point(73, 70);
            btn_limpar.Margin = new Padding(4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(30, 30);
            btn_limpar.TabIndex = 2;
            toolTipBotoes.SetToolTip(btn_limpar, "Limpar pasta");
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // br
            // 
            br.Dock = DockStyle.Fill;
            br.Location = new Point(436, 3);
            br.Name = "br";
            br.Size = new Size(71, 30);
            br.TabIndex = 0;
            br.Text = "Remover";
            toolTipBotoes.SetToolTip(br, "Remover pasta");
            br.UseVisualStyleBackColor = true;
            br.Click += btn_remover;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(436, 39);
            button2.Name = "button2";
            button2.Size = new Size(71, 30);
            button2.TabIndex = 1;
            button2.Text = "Remover";
            toolTipBotoes.SetToolTip(button2, "Remover pasta");
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_remover;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(436, 75);
            button3.Name = "button3";
            button3.Size = new Size(71, 30);
            button3.TabIndex = 2;
            button3.Text = "Remover";
            toolTipBotoes.SetToolTip(button3, "Remover pasta");
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_remover;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(436, 111);
            button4.Name = "button4";
            button4.Size = new Size(71, 30);
            button4.TabIndex = 3;
            button4.Text = "Remover";
            toolTipBotoes.SetToolTip(button4, "Remover pasta");
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_remover;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(436, 147);
            button5.Name = "button5";
            button5.Size = new Size(71, 30);
            button5.TabIndex = 4;
            button5.Text = "Remover";
            toolTipBotoes.SetToolTip(button5, "Remover pasta");
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_remover;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(436, 183);
            button6.Name = "button6";
            button6.Size = new Size(71, 30);
            button6.TabIndex = 5;
            button6.Text = "Remover";
            toolTipBotoes.SetToolTip(button6, "Remover pasta");
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_remover;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(436, 219);
            button7.Name = "button7";
            button7.Size = new Size(71, 33);
            button7.TabIndex = 6;
            button7.Text = "Remover";
            toolTipBotoes.SetToolTip(button7, "Remover pasta");
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_remover;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(360, 3);
            button8.Name = "button8";
            button8.Size = new Size(70, 30);
            button8.TabIndex = 7;
            button8.Text = "Editar";
            toolTipBotoes.SetToolTip(button8, "Editar extensões");
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_editar;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(360, 39);
            button9.Name = "button9";
            button9.Size = new Size(70, 30);
            button9.TabIndex = 8;
            button9.Text = "Editar";
            toolTipBotoes.SetToolTip(button9, "Editar extensões");
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn_editar;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(360, 75);
            button10.Name = "button10";
            button10.Size = new Size(70, 30);
            button10.TabIndex = 9;
            button10.Text = "Editar";
            toolTipBotoes.SetToolTip(button10, "Editar extensões");
            button10.UseVisualStyleBackColor = true;
            button10.Click += btn_editar;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(360, 111);
            button11.Name = "button11";
            button11.Size = new Size(70, 30);
            button11.TabIndex = 10;
            button11.Text = "Editar";
            toolTipBotoes.SetToolTip(button11, "Editar extensões");
            button11.UseVisualStyleBackColor = true;
            button11.Click += btn_editar;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(360, 147);
            button12.Name = "button12";
            button12.Size = new Size(70, 30);
            button12.TabIndex = 11;
            button12.Text = "Editar";
            toolTipBotoes.SetToolTip(button12, "Editar extensões");
            button12.UseVisualStyleBackColor = true;
            button12.Click += btn_editar;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(360, 183);
            button13.Name = "button13";
            button13.Size = new Size(70, 30);
            button13.TabIndex = 12;
            button13.Text = "Editar";
            toolTipBotoes.SetToolTip(button13, "Editar extensões");
            button13.UseVisualStyleBackColor = true;
            button13.Click += btn_editar;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(360, 219);
            button14.Name = "button14";
            button14.Size = new Size(70, 33);
            button14.TabIndex = 13;
            button14.Text = "Editar";
            toolTipBotoes.SetToolTip(button14, "Editar extensões");
            button14.UseVisualStyleBackColor = true;
            button14.Click += btn_editar;
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
            label_directory.Location = new Point(35, 16);
            label_directory.Margin = new Padding(32, 0, 3, 0);
            label_directory.Name = "label_directory";
            label_directory.Size = new Size(56, 15);
            label_directory.TabIndex = 4;
            label_directory.Text = "Diretório:";
            // 
            // tabPage_config
            // 
            tabPage_config.Controls.Add(tableLayoutPanel1);
            tabPage_config.Controls.Add(panel1);
            tabPage_config.Controls.Add(lb_tipos);
            tabPage_config.Location = new Point(4, 24);
            tabPage_config.Name = "tabPage_config";
            tabPage_config.Padding = new Padding(3);
            tabPage_config.Size = new Size(548, 340);
            tabPage_config.TabIndex = 1;
            tabPage_config.Text = "Configurações";
            tabPage_config.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(checkBox7, 0, 6);
            tableLayoutPanel1.Controls.Add(checkBox6, 0, 5);
            tableLayoutPanel1.Controls.Add(checkBox5, 0, 4);
            tableLayoutPanel1.Controls.Add(checkBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(br, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 2, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 2);
            tableLayoutPanel1.Controls.Add(button4, 2, 3);
            tableLayoutPanel1.Controls.Add(button5, 2, 4);
            tableLayoutPanel1.Controls.Add(button6, 2, 5);
            tableLayoutPanel1.Controls.Add(button7, 2, 6);
            tableLayoutPanel1.Controls.Add(button8, 1, 0);
            tableLayoutPanel1.Controls.Add(button9, 1, 1);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button11, 1, 3);
            tableLayoutPanel1.Controls.Add(button12, 1, 4);
            tableLayoutPanel1.Controls.Add(button13, 1, 5);
            tableLayoutPanel1.Controls.Add(button14, 1, 6);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(19, 26);
            tableLayoutPanel1.Margin = new Padding(16, 8, 16, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857122F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Size = new Size(510, 255);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Checked = true;
            checkBox7.CheckState = CheckState.Checked;
            checkBox7.Dock = DockStyle.Fill;
            checkBox7.Location = new Point(3, 219);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(351, 33);
            checkBox7.TabIndex = 20;
            checkBox7.Text = "Outros";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.Dock = DockStyle.Fill;
            checkBox6.Location = new Point(3, 183);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(351, 30);
            checkBox6.TabIndex = 19;
            checkBox6.Text = "Aplicativos";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Dock = DockStyle.Fill;
            checkBox5.Location = new Point(3, 147);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(351, 30);
            checkBox5.TabIndex = 18;
            checkBox5.Text = "Planilhas";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Dock = DockStyle.Fill;
            checkBox4.Location = new Point(3, 111);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(351, 30);
            checkBox4.TabIndex = 17;
            checkBox4.Text = "Vídeos";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Dock = DockStyle.Fill;
            checkBox3.Location = new Point(3, 75);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(351, 30);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "Fotos";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Location = new Point(3, 39);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(351, 30);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Músicas";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(351, 30);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Documentos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button15);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(btn_cancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 289);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 48);
            panel1.TabIndex = 10;
            // 
            // button15
            // 
            button15.Location = new Point(8, 13);
            button15.Margin = new Padding(8, 3, 8, 3);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 11;
            button15.Text = "Novo";
            button15.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(368, 13);
            btn_salvar.Margin = new Padding(8, 3, 8, 3);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(459, 13);
            btn_cancelar.Margin = new Padding(8, 3, 8, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_salvar_Click;
            // 
            // lb_tipos
            // 
            lb_tipos.AutoSize = true;
            lb_tipos.Dock = DockStyle.Top;
            lb_tipos.Location = new Point(3, 3);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Button btn_cancelar;
        public TabPage tabPage_config;
        public TabControl tabControl1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button br;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btn_salvar;
        private Button button15;
    }
}
