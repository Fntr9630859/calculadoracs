
namespace cal
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
            this.dato1 = new System.Windows.Forms.TextBox();
            this.dato2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ejecuta = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dato1
            // 
            this.dato1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.Location = new System.Drawing.Point(117, 33);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(84, 23);
            this.dato1.TabIndex = 0;
            this.dato1.Text = "0";
            // 
            // dato2
            // 
            this.dato2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.Location = new System.Drawing.Point(117, 67);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(84, 23);
            this.dato2.TabIndex = 1;
            this.dato2.Text = "0";
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(117, 140);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(84, 23);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "dato 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "dato 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "operacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "resultado";
            // 
            // ejecuta
            // 
            this.ejecuta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ejecuta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ejecuta.Location = new System.Drawing.Point(31, 182);
            this.ejecuta.Name = "ejecuta";
            this.ejecuta.Size = new System.Drawing.Size(217, 33);
            this.ejecuta.TabIndex = 8;
            this.ejecuta.Text = "ejecuta";
            this.ejecuta.UseVisualStyleBackColor = false;
            this.ejecuta.Click += new System.EventHandler(this.ejecuta_Click_1);
            // 
            // operacion
            // 
            this.operacion.AllowDrop = true;
            this.operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operacion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.FormattingEnabled = true;
            this.operacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operacion.Location = new System.Drawing.Point(117, 105);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(41, 23);
            this.operacion.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(258, 218);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.ejecuta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dato1;
        private System.Windows.Forms.TextBox dato2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ejecuta;
        private System.Windows.Forms.ComboBox operacion;
    }
}

