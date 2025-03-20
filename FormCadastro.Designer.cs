namespace AT2_WFCadastro
{
    partial class FormCadastro
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
            mskCod = new MaskedTextBox();
            txtNome = new TextBox();
            txtDescrição = new TextBox();
            chkAtivo = new CheckBox();
            chkInativo = new CheckBox();
            dtpDataCadastro = new DateTimePicker();
            btnSalvar = new Button();
            lblCod = new Label();
            SuspendLayout();
            // 
            // mskCod
            // 
            mskCod.Location = new Point(22, 37);
            mskCod.Mask = "00000";
            mskCod.Name = "mskCod";
            mskCod.Size = new Size(100, 23);
            mskCod.TabIndex = 0;
            mskCod.ValidatingType = typeof(int);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(177, 37);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtDescrição
            // 
            txtDescrição.Location = new Point(22, 67);
            txtDescrição.Multiline = true;
            txtDescrição.Name = "txtDescrição";
            txtDescrição.PlaceholderText = "Descrição...";
            txtDescrição.Size = new Size(137, 127);
            txtDescrição.TabIndex = 2;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(177, 69);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 3;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            chkAtivo.CheckStateChanged += chkAtivo_CheckStateChanged;
            // 
            // chkInativo
            // 
            chkInativo.AutoSize = true;
            chkInativo.Location = new Point(177, 94);
            chkInativo.Name = "chkInativo";
            chkInativo.Size = new Size(62, 19);
            chkInativo.TabIndex = 4;
            chkInativo.Text = "Inativo";
            chkInativo.UseVisualStyleBackColor = true;
            chkInativo.CheckedChanged += chkInativo_CheckedChanged;
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(177, 128);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(100, 23);
            dtpDataCadastro.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(176, 162);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(137, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(21, 13);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(49, 15);
            lblCod.TabIndex = 7;
            lblCod.Text = "Código:";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 197);
            Controls.Add(lblCod);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataCadastro);
            Controls.Add(chkInativo);
            Controls.Add(chkAtivo);
            Controls.Add(txtDescrição);
            Controls.Add(txtNome);
            Controls.Add(mskCod);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCod;
        private TextBox txtNome;
        private TextBox txtDescrição;
        private CheckBox chkAtivo;
        private CheckBox chkInativo;
        private DateTimePicker dtpDataCadastro;
        private Button btnSalvar;
        private Label lblCod;
    }
}