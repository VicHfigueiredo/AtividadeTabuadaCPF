
namespace AtividadeTabuadaCPF.View
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnCpf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atividades de tabuada e cpf";
            // 
            // btnTabuada
            // 
            this.btnTabuada.BackColor = System.Drawing.Color.LightGray;
            this.btnTabuada.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabuada.Location = new System.Drawing.Point(177, 106);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(414, 69);
            this.btnTabuada.TabIndex = 1;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = false;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnCpf
            // 
            this.btnCpf.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCpf.Location = new System.Drawing.Point(177, 226);
            this.btnCpf.Name = "btnCpf";
            this.btnCpf.Size = new System.Drawing.Size(414, 67);
            this.btnCpf.TabIndex = 2;
            this.btnCpf.Text = "Validar";
            this.btnCpf.UseVisualStyleBackColor = true;
            this.btnCpf.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 366);
            this.Controls.Add(this.btnCpf);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnCpf;
    }
}