namespace Simulado.Views
{
    partial class PageProfessor
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
            this.lblNomeProf = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProf
            // 
            this.lblNomeProf.AutoSize = true;
            this.lblNomeProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProf.Location = new System.Drawing.Point(24, 18);
            this.lblNomeProf.Name = "lblNomeProf";
            this.lblNomeProf.Size = new System.Drawing.Size(0, 16);
            this.lblNomeProf.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(663, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 44);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(12, 183);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.Size = new System.Drawing.Size(776, 255);
            this.dgvTurmas.TabIndex = 2;
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTurma.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarTurma.Location = new System.Drawing.Point(663, 68);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(125, 46);
            this.btnCadastrarTurma.TabIndex = 3;
            this.btnCadastrarTurma.Text = "Cadastrar Turma";
            this.btnCadastrarTurma.UseVisualStyleBackColor = false;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.BackColor = System.Drawing.Color.Tomato;
            this.btnCadastrarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(663, 120);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(125, 46);
            this.btnCadastrarAtividade.TabIndex = 4;
            this.btnCadastrarAtividade.Text = "Cadastrar Atividade";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = false;
            // 
            // PageProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Controls.Add(this.dgvTurmas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNomeProf);
            this.Name = "PageProfessor";
            this.Text = "PageProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProf;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Button btnCadastrarAtividade;
    }
}