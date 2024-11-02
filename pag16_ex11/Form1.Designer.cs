namespace pag16_ex11
{
    partial class Form1
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(210, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(284, 18);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Digite uma temperatura em graus Celsius:";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(279, 77);
            this.txtCelsius.Multiline = true;
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(110, 18);
            this.txtCelsius.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(298, 241);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(73, 25);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcukar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.Location = new System.Drawing.Point(230, 110);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(236, 18);
            this.lblKelvin.TabIndex = 4;
            this.lblKelvin.Text = "Sua temperatura em escala Kelvin:";
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(279, 144);
            this.txtKelvin.Multiline = true;
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(110, 18);
            this.txtKelvin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sua temperatura em escala Fahrenheit:";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(279, 202);
            this.txtFahrenheit.Multiline = true;
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(110, 18);
            this.txtFahrenheit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFahrenheit;
    }
}

