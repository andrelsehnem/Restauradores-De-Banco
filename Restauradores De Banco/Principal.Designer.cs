namespace Restauradores_De_Banco
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_pgdmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_pgdmp
            // 
            this.bt_pgdmp.Location = new System.Drawing.Point(13, 12);
            this.bt_pgdmp.Name = "bt_pgdmp";
            this.bt_pgdmp.Size = new System.Drawing.Size(123, 37);
            this.bt_pgdmp.TabIndex = 0;
            this.bt_pgdmp.Text = "Restaurar pgdmp";
            this.bt_pgdmp.UseVisualStyleBackColor = true;
            this.bt_pgdmp.Click += new System.EventHandler(this.bt_pgdmp_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_pgdmp);
            this.Name = "Principal";
            this.Text = "Restaurador de Bancos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_pgdmp;
    }
}