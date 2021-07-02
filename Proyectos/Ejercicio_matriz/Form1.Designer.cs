
namespace Ejercicio_matriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ColumntextBox = new System.Windows.Forms.TextBox();
            this.Resultadobutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilatextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Ingrese Numero Filas";
            // 
            // ColumntextBox
            // 
            this.ColumntextBox.Location = new System.Drawing.Point(300, 196);
            this.ColumntextBox.Name = "ColumntextBox";
            this.ColumntextBox.Size = new System.Drawing.Size(73, 20);
            this.ColumntextBox.TabIndex = 1;
            // 
            // Resultadobutton
            // 
            this.Resultadobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Resultadobutton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadobutton.Location = new System.Drawing.Point(431, 249);
            this.Resultadobutton.Name = "Resultadobutton";
            this.Resultadobutton.Size = new System.Drawing.Size(122, 34);
            this.Resultadobutton.TabIndex = 2;
            this.Resultadobutton.Text = "&Matriz Resultado";
            this.Resultadobutton.UseVisualStyleBackColor = false;
            this.Resultadobutton.Click += new System.EventHandler(this.Resultadobutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Ingrese Numero Columnas";
            // 
            // FilatextBox
            // 
            this.FilatextBox.Location = new System.Drawing.Point(182, 196);
            this.FilatextBox.Name = "FilatextBox";
            this.FilatextBox.Size = new System.Drawing.Size(73, 20);
            this.FilatextBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(191, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(431, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Nueva Matriz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Salirbutton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton.Location = new System.Drawing.Point(431, 357);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(122, 33);
            this.Salirbutton.TabIndex = 7;
            this.Salirbutton.Text = "&Salir";
            this.Salirbutton.UseVisualStyleBackColor = false;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(242, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matrices";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FilatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resultadobutton);
            this.Controls.Add(this.ColumntextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumntextBox;
        private System.Windows.Forms.Button Resultadobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilatextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Label label3;
    }
}

