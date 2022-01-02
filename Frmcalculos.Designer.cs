namespace CalculosGeometricos
{
    partial class frmcalculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculos));
            this.btnperimetro = new System.Windows.Forms.Button();
            this.btnarea = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnperimetro
            // 
            this.btnperimetro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnperimetro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperimetro.ForeColor = System.Drawing.Color.Black;
            this.btnperimetro.Location = new System.Drawing.Point(25, 65);
            this.btnperimetro.Name = "btnperimetro";
            this.btnperimetro.Size = new System.Drawing.Size(112, 33);
            this.btnperimetro.TabIndex = 0;
            this.btnperimetro.Text = "Perimetro (P)";
            this.btnperimetro.UseVisualStyleBackColor = false;
            this.btnperimetro.Click += new System.EventHandler(this.btnperimetro_Click);
            this.btnperimetro.MouseHover += new System.EventHandler(this.btnperimetro_MouseHover);
            // 
            // btnarea
            // 
            this.btnarea.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnarea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarea.Location = new System.Drawing.Point(156, 65);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(112, 33);
            this.btnarea.TabIndex = 1;
            this.btnarea.Text = "Área (A)";
            this.btnarea.UseVisualStyleBackColor = false;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // btnvolumen
            // 
            this.btnvolumen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnvolumen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolumen.Location = new System.Drawing.Point(290, 65);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(112, 33);
            this.btnvolumen.TabIndex = 2;
            this.btnvolumen.Text = "Volumen (V)";
            this.btnvolumen.UseVisualStyleBackColor = false;
            this.btnvolumen.Click += new System.EventHandler(this.btnvolumen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CALCULA LO QUE GUSTES!";
            // 
            // frmcalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.btnarea);
            this.Controls.Add(this.btnperimetro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcalculos";
            this.Text = "Calculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnperimetro;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.Button btnvolumen;
        private System.Windows.Forms.Label label1;
    }
}

