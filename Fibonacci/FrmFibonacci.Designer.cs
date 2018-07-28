namespace Fibonacci
{
    partial class FrmFibonacci
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumSequencia = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LstBResultado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num.  Sequência";
            // 
            // TxtNumSequencia
            // 
            this.TxtNumSequencia.Location = new System.Drawing.Point(12, 25);
            this.TxtNumSequencia.Name = "TxtNumSequencia";
            this.TxtNumSequencia.Size = new System.Drawing.Size(122, 20);
            this.TxtNumSequencia.TabIndex = 1;
            this.TxtNumSequencia.TextChanged += new System.EventHandler(this.TxtNumSequencia_TextChanged);
            this.TxtNumSequencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumSequencia_KeyDown);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(140, 22);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(87, 23);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LstBResultado
            // 
            this.LstBResultado.FormattingEnabled = true;
            this.LstBResultado.Location = new System.Drawing.Point(12, 77);
            this.LstBResultado.Name = "LstBResultado";
            this.LstBResultado.Size = new System.Drawing.Size(215, 238);
            this.LstBResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado do Calculo";
            // 
            // FrmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LstBResultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNumSequencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmFibonacci_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumSequencia;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.ListBox LstBResultado;
        private System.Windows.Forms.Label label2;
    }
}

