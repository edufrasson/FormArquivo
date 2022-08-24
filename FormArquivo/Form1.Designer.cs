namespace FormArquivo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImportar = new MaterialSkin.Controls.MaterialButton();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.btnMarcar = new MaterialSkin.Controls.MaterialButton();
            this.btnDesmarcar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportar.Depth = 0;
            this.btnImportar.DrawShadows = true;
            this.btnImportar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.HighEmphasis = true;
            this.btnImportar.Icon = null;
            this.btnImportar.Location = new System.Drawing.Point(32, 92);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(161, 36);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar Arquivo";
            this.btnImportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportar.UseAccentColor = false;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(32, 148);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.Size = new System.Drawing.Size(918, 351);
            this.dgvDespesas.TabIndex = 1;
            this.dgvDespesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesas_CellClick);
            // 
            // btnMarcar
            // 
            this.btnMarcar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMarcar.Depth = 0;
            this.btnMarcar.DrawShadows = true;
            this.btnMarcar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.HighEmphasis = true;
            this.btnMarcar.Icon = null;
            this.btnMarcar.Location = new System.Drawing.Point(608, 92);
            this.btnMarcar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMarcar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(132, 36);
            this.btnMarcar.TabIndex = 2;
            this.btnMarcar.Text = "Marcar Todas";
            this.btnMarcar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMarcar.UseAccentColor = false;
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesmarcar.Depth = 0;
            this.btnDesmarcar.DrawShadows = true;
            this.btnDesmarcar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.HighEmphasis = true;
            this.btnDesmarcar.Icon = null;
            this.btnDesmarcar.Location = new System.Drawing.Point(791, 92);
            this.btnDesmarcar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDesmarcar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(159, 36);
            this.btnDesmarcar.TabIndex = 3;
            this.btnDesmarcar.Text = "Desmarcar Todas";
            this.btnDesmarcar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDesmarcar.UseAccentColor = false;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(47, 535);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(131, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0,00";
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSelecao.Location = new System.Drawing.Point(385, 535);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(48, 22);
            this.lblSelecao.TabIndex = 7;
            this.lblSelecao.Text = "0,00";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(301, 535);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Seleção:";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(767, 532);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(183, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "Baixar Selecionadas";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 604);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.lblSelecao);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.dgvDespesas);
            this.Controls.Add(this.btnImportar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnImportar;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private MaterialSkin.Controls.MaterialButton btnMarcar;
        private MaterialSkin.Controls.MaterialButton btnDesmarcar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSelecao;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}

