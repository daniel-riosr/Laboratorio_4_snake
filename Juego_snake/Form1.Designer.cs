namespace Juego_snake
{
    partial class La_Culebrita
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iniciar = new System.Windows.Forms.Button();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iniciar.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(318, 37);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(131, 50);
            this.iniciar.TabIndex = 1;
            this.iniciar.Text = "JUGAR";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(375, 187);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(22, 23);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "PUNTAJE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Image = global::Juego_snake.Properties.Resources.fondo3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // La_Culebrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "La_Culebrita";
            this.Text = "La_Culebrita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label label1;
    }
}

