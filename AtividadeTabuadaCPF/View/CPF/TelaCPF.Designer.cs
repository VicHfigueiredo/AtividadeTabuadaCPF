
namespace AtividadeTabuadaCPF.View.CPF
{
    partial class TelaCPF
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.tbxCPF = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validar o número do CPF";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(138, 111);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(36, 19);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(199, 107);
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(208, 23);
            this.tbxCPF.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Bisque;
            this.lblResultado.Location = new System.Drawing.Point(138, 181);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(495, 240);
            this.lblResultado.TabIndex = 3;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(439, 109);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // TelaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tbxCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.label1);
            this.Name = "TelaCPF";
            this.ShowIcon = false;
            this.Text = "TelaCPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox tbxCPF;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnValidar;
    }
}