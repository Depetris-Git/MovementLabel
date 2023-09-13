namespace Movimiento
{
    partial class Form1
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
            this.btIniciar = new System.Windows.Forms.Button();
            this.timerRed = new System.Windows.Forms.Timer(this.components);
            this.timerYellow = new System.Windows.Forms.Timer(this.components);
            this.btPausar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.Location = new System.Drawing.Point(3, 3);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(183, 47);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // timerRed
            // 
            this.timerRed.Interval = 60;
            this.timerRed.Tick += new System.EventHandler(this.timerRed_Tick);
            // 
            // timerYellow
            // 
            this.timerYellow.Interval = 60;
            this.timerYellow.Tick += new System.EventHandler(this.timerYellow_Tick);
            // 
            // btPausar
            // 
            this.btPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPausar.Location = new System.Drawing.Point(192, 3);
            this.btPausar.Name = "btPausar";
            this.btPausar.Size = new System.Drawing.Size(185, 47);
            this.btPausar.TabIndex = 2;
            this.btPausar.Text = "Pausar";
            this.btPausar.UseVisualStyleBackColor = true;
            this.btPausar.Click += new System.EventHandler(this.btPausar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPausar);
            this.Controls.Add(this.btIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Timer timerYellow;
        public System.Windows.Forms.Timer timerRed;
        private System.Windows.Forms.Button btPausar;
    }
}

