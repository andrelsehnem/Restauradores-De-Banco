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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bt_pgdmp = new System.Windows.Forms.Button();
            this.bt_fbk_FDB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_gbk_gdb = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_pgdmp
            // 
            this.bt_pgdmp.Location = new System.Drawing.Point(6, 22);
            this.bt_pgdmp.Name = "bt_pgdmp";
            this.bt_pgdmp.Size = new System.Drawing.Size(123, 37);
            this.bt_pgdmp.TabIndex = 0;
            this.bt_pgdmp.Text = "Restaurar pgdmp";
            this.bt_pgdmp.UseVisualStyleBackColor = true;
            this.bt_pgdmp.Click += new System.EventHandler(this.bt_pgdmp_Click);
            // 
            // bt_fbk_FDB
            // 
            this.bt_fbk_FDB.Location = new System.Drawing.Point(6, 22);
            this.bt_fbk_FDB.Name = "bt_fbk_FDB";
            this.bt_fbk_FDB.Size = new System.Drawing.Size(123, 37);
            this.bt_fbk_FDB.TabIndex = 1;
            this.bt_fbk_FDB.Text = ".FBK <=> .FDB";
            this.bt_fbk_FDB.UseVisualStyleBackColor = true;
            this.bt_fbk_FDB.Click += new System.EventHandler(this.bt_fbk_fdb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_gbk_gdb);
            this.groupBox1.Controls.Add(this.bt_fbk_FDB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firebird";
            // 
            // bt_gbk_gdb
            // 
            this.bt_gbk_gdb.Location = new System.Drawing.Point(150, 22);
            this.bt_gbk_gdb.Name = "bt_gbk_gdb";
            this.bt_gbk_gdb.Size = new System.Drawing.Size(123, 37);
            this.bt_gbk_gdb.TabIndex = 2;
            this.bt_gbk_gdb.Text = ".GBK <=> .GDB";
            this.bt_gbk_gdb.UseVisualStyleBackColor = true;
            this.bt_gbk_gdb.Click += new System.EventHandler(this.bt_gbk_gdb_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_pgdmp);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PostgreSQL";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Restaurador de Bancos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_pgdmp;
        private Button bt_fbk_FDB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button bt_gbk_gdb;
    }
}