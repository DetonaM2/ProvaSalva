
namespace ProvaSalva
{
    partial class Form1
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
            this.Nome = new System.Windows.Forms.Label();
            this.Salário = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.NumericUpDown();
            this.Dados = new System.Windows.Forms.GroupBox();
            this.Resultados = new System.Windows.Forms.GroupBox();
            this.Remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal)).BeginInit();
            this.Dados.SuspendLayout();
            this.Resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nome.Location = new System.Drawing.Point(31, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(46, 15);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome :";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // Salário
            // 
            this.Salário.AutoSize = true;
            this.Salário.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salário.Location = new System.Drawing.Point(31, 51);
            this.Salário.Name = "Salário";
            this.Salário.Size = new System.Drawing.Size(48, 15);
            this.Salário.TabIndex = 2;
            this.Salário.Text = "Salário :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.collum2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // collum2
            // 
            this.collum2.HeaderText = "Nome";
            this.collum2.Name = "collum2";
            this.collum2.ReadOnly = true;
            this.collum2.Width = 144;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Salário";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Adicionar
            // 
            this.Adicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Adicionar.Location = new System.Drawing.Point(270, 49);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 6;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(80, 16);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(265, 23);
            this.nom.TabIndex = 7;
            // 
            // sal
            // 
            this.sal.DecimalPlaces = 2;
            this.sal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sal.Location = new System.Drawing.Point(80, 49);
            this.sal.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(184, 23);
            this.sal.TabIndex = 9;
            // 
            // Dados
            // 
            this.Dados.BackColor = System.Drawing.SystemColors.Menu;
            this.Dados.BackgroundImage = global::ProvaSalva.Properties.Resources._601846;
            this.Dados.Controls.Add(this.Salário);
            this.Dados.Controls.Add(this.nom);
            this.Dados.Controls.Add(this.Nome);
            this.Dados.Controls.Add(this.sal);
            this.Dados.Controls.Add(this.Adicionar);
            this.Dados.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dados.Location = new System.Drawing.Point(13, 12);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(397, 89);
            this.Dados.TabIndex = 10;
            this.Dados.TabStop = false;
            this.Dados.Text = "Dados";
            // 
            // Resultados
            // 
            this.Resultados.BackgroundImage = global::ProvaSalva.Properties.Resources._601846;
            this.Resultados.Controls.Add(this.Remover);
            this.Resultados.Controls.Add(this.dataGridView1);
            this.Resultados.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resultados.Location = new System.Drawing.Point(11, 107);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(399, 210);
            this.Resultados.TabIndex = 11;
            this.Resultados.TabStop = false;
            this.Resultados.Text = "Resultados";
            // 
            // Remover
            // 
            this.Remover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remover.Location = new System.Drawing.Point(4, 181);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(75, 23);
            this.Remover.TabIndex = 5;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::ProvaSalva.Properties.Resources._601846;
            this.ClientSize = new System.Drawing.Size(422, 329);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.Resultados);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sal)).EndInit();
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.Resultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Salário;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.NumericUpDown sal;
        private System.Windows.Forms.GroupBox Dados;
        private System.Windows.Forms.GroupBox Resultados;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn collum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

