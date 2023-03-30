namespace TesteSistema
{
    partial class TelaPrincipal
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resultado = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.campo_id = new System.Windows.Forms.TextBox();
            this.campo_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campo_profissao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campo_endereco = new System.Windows.Forms.TextBox();
            this.dados = new System.Windows.Forms.DataGridView();
            this.conexaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carregar = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.atualizar_registro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado.Location = new System.Drawing.Point(745, 18);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(182, 41);
            this.resultado.TabIndex = 1;
            this.resultado.Text = "Cadastrados";
            // 
            // salvar
            // 
            this.salvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salvar.Location = new System.Drawing.Point(161, 316);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(222, 57);
            this.salvar.TabIndex = 2;
            this.salvar.Text = "Novo Registro";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.botao2_Click);
            // 
            // campo_id
            // 
            this.campo_id.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campo_id.Location = new System.Drawing.Point(161, 38);
            this.campo_id.Name = "campo_id";
            this.campo_id.Size = new System.Drawing.Size(222, 47);
            this.campo_id.TabIndex = 3;
            // 
            // campo_nome
            // 
            this.campo_nome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campo_nome.Location = new System.Drawing.Point(161, 111);
            this.campo_nome.Name = "campo_nome";
            this.campo_nome.Size = new System.Drawing.Size(222, 47);
            this.campo_nome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Profissão";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // campo_profissao
            // 
            this.campo_profissao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campo_profissao.Location = new System.Drawing.Point(161, 182);
            this.campo_profissao.Name = "campo_profissao";
            this.campo_profissao.Size = new System.Drawing.Size(222, 47);
            this.campo_profissao.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Endereço";
            // 
            // campo_endereco
            // 
            this.campo_endereco.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campo_endereco.Location = new System.Drawing.Point(161, 244);
            this.campo_endereco.Name = "campo_endereco";
            this.campo_endereco.Size = new System.Drawing.Size(222, 47);
            this.campo_endereco.TabIndex = 14;
            // 
            // dados
            // 
            this.dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados.Location = new System.Drawing.Point(446, 65);
            this.dados.Name = "dados";
            this.dados.RowHeadersWidth = 51;
            this.dados.RowTemplate.Height = 18;
            this.dados.RowTemplate.ReadOnly = true;
            this.dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dados.Size = new System.Drawing.Size(772, 226);
            this.dados.TabIndex = 16;
            this.dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dados_CellClick);
            // 
            // carregar
            // 
            this.carregar.Location = new System.Drawing.Point(963, 30);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(177, 29);
            this.carregar.TabIndex = 17;
            this.carregar.Text = "Atualizar tabela";
            this.carregar.UseVisualStyleBackColor = true;
            this.carregar.Click += new System.EventHandler(this.carregar_Click);
            // 
            // Deletar
            // 
            this.Deletar.ForeColor = System.Drawing.Color.Red;
            this.Deletar.Location = new System.Drawing.Point(720, 316);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(233, 57);
            this.Deletar.TabIndex = 18;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // atualizar_registro
            // 
            this.atualizar_registro.BackColor = System.Drawing.Color.Orange;
            this.atualizar_registro.Location = new System.Drawing.Point(446, 316);
            this.atualizar_registro.Name = "atualizar_registro";
            this.atualizar_registro.Size = new System.Drawing.Size(222, 57);
            this.atualizar_registro.TabIndex = 19;
            this.atualizar_registro.Text = "Atualizar Registro";
            this.atualizar_registro.UseVisualStyleBackColor = false;
            this.atualizar_registro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 489);
            this.Controls.Add(this.atualizar_registro);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.dados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campo_endereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campo_profissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campo_nome);
            this.Controls.Add(this.campo_id);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label resultado;
        private Button salvar;
        private TextBox campo_id;
        private TextBox campo_nome;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox campo_profissao;
        private Label label5;
        private TextBox campo_endereco;
        private DataGridView dados;
        private BindingSource conexaoBindingSource;
        private Button carregar;
        private Button Deletar;
        private Button atualizar_registro;
    }
}