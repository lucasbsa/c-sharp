namespace AppConsole
{
    partial class Dados
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
            this.colocar_dados_listBox = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clique";
            // 
            // colocar_dados_listBox
            // 
            this.colocar_dados_listBox.Location = new System.Drawing.Point(102, 12);
            this.colocar_dados_listBox.Name = "colocar_dados_listBox";
            this.colocar_dados_listBox.Size = new System.Drawing.Size(113, 33);
            this.colocar_dados_listBox.TabIndex = 1;
            this.colocar_dados_listBox.Text = "Novo";
            this.colocar_dados_listBox.UseVisualStyleBackColor = true;
            this.colocar_dados_listBox.Click += new System.EventHandler(this.colocar_dados_listBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 147);
            this.listBox1.TabIndex = 2;
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.colocar_dados_listBox);
            this.Controls.Add(this.label1);
            this.Name = "Dados";
            this.Text = "Dados";
            this.Load += new System.EventHandler(this.Dados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colocar_dados_listBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}