namespace Tiipos_e_referências
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
            this.btLloyd = new System.Windows.Forms.Button();
            this.btLucinda = new System.Windows.Forms.Button();
            this.btSwap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLloyd
            // 
            this.btLloyd.Location = new System.Drawing.Point(361, 66);
            this.btLloyd.Name = "btLloyd";
            this.btLloyd.Size = new System.Drawing.Size(75, 23);
            this.btLloyd.TabIndex = 0;
            this.btLloyd.Text = "Lloyd";
            this.btLloyd.UseVisualStyleBackColor = true;
            this.btLloyd.Click += new System.EventHandler(this.btLloyd_Click);
            // 
            // btLucinda
            // 
            this.btLucinda.Location = new System.Drawing.Point(361, 104);
            this.btLucinda.Name = "btLucinda";
            this.btLucinda.Size = new System.Drawing.Size(75, 23);
            this.btLucinda.TabIndex = 1;
            this.btLucinda.Text = "Lucinda";
            this.btLucinda.UseVisualStyleBackColor = true;
            this.btLucinda.Click += new System.EventHandler(this.btLucinda_Click);
            // 
            // btSwap
            // 
            this.btSwap.Location = new System.Drawing.Point(361, 145);
            this.btSwap.Name = "btSwap";
            this.btSwap.Size = new System.Drawing.Size(75, 23);
            this.btSwap.TabIndex = 2;
            this.btSwap.Text = "Swap!";
            this.btSwap.UseVisualStyleBackColor = true;
            this.btSwap.Click += new System.EventHandler(this.btSwap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSwap);
            this.Controls.Add(this.btLucinda);
            this.Controls.Add(this.btLloyd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLloyd;
        private System.Windows.Forms.Button btLucinda;
        private System.Windows.Forms.Button btSwap;
        private System.Windows.Forms.Button button1;
    }
}

