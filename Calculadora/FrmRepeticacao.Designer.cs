namespace Calculadora
{
    partial class FrmRepeticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepeticacao));
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.Lblcategorias = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.ltbCategoria = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(73, 116);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(138, 28);
            this.cbbCategorias.TabIndex = 0;
            this.cbbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbbCategorias_SelectedIndexChanged);
            // 
            // Lblcategorias
            // 
            this.Lblcategorias.AutoSize = true;
            this.Lblcategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcategorias.Location = new System.Drawing.Point(69, 88);
            this.Lblcategorias.Name = "Lblcategorias";
            this.Lblcategorias.Size = new System.Drawing.Size(86, 20);
            this.Lblcategorias.TabIndex = 1;
            this.Lblcategorias.Text = "Categorias";
            this.Lblcategorias.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(52, 447);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(182, 42);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // ltbCategoria
            // 
            this.ltbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbCategoria.FormattingEnabled = true;
            this.ltbCategoria.ItemHeight = 20;
            this.ltbCategoria.Items.AddRange(new object[] {
            ""});
            this.ltbCategoria.Location = new System.Drawing.Point(379, 116);
            this.ltbCategoria.Name = "ltbCategoria";
            this.ltbCategoria.Size = new System.Drawing.Size(327, 284);
            this.ltbCategoria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = " Listar Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = " Listar Categorias";
            // 
            // FrmRepeticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ltbCategoria);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.Lblcategorias);
            this.Controls.Add(this.cbbCategorias);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmRepeticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repetição";
            this.Load += new System.EventHandler(this.FrmRepeticacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.Label Lblcategorias;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.ListBox ltbCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}