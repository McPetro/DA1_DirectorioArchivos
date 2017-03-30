namespace DirectorioArchivos
{
    partial class AgregarArchivo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArchivo = new System.Windows.Forms.Button();
            this.textArchivo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonArchivo
            // 
            this.buttonArchivo.Location = new System.Drawing.Point(427, 15);
            this.buttonArchivo.Name = "buttonArchivo";
            this.buttonArchivo.Size = new System.Drawing.Size(124, 23);
            this.buttonArchivo.TabIndex = 4;
            this.buttonArchivo.Text = "Agregar Archivo";
            this.buttonArchivo.UseVisualStyleBackColor = true;
            // 
            // textArchivo
            // 
            this.textArchivo.Location = new System.Drawing.Point(25, 15);
            this.textArchivo.Name = "textArchivo";
            this.textArchivo.Size = new System.Drawing.Size(378, 20);
            this.textArchivo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 250);
            this.dataGridView1.TabIndex = 5;
            // 
            // AgregarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonArchivo);
            this.Controls.Add(this.textArchivo);
            this.Name = "AgregarArchivo";
            this.Size = new System.Drawing.Size(588, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArchivo;
        private System.Windows.Forms.TextBox textArchivo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
