namespace Restauradores_De_Banco.Firebird
{
    partial class Frm_gbk_gdb
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
            this.group_driveFire = new System.Windows.Forms.GroupBox();
            this.radio_4 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.radio_25 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.bt_GdbToGbk = new System.Windows.Forms.Button();
            this.bt_gbkToGdb = new System.Windows.Forms.Button();
            this.bt_buscarGDB = new System.Windows.Forms.Button();
            this.txt_caminhoGDB = new System.Windows.Forms.TextBox();
            this.lbl_GDB = new System.Windows.Forms.Label();
            this.lbl_gbk = new System.Windows.Forms.Label();
            this.bt_buscarGBK = new System.Windows.Forms.Button();
            this.txt_caminhoGBK = new System.Windows.Forms.TextBox();
            this.rich_resultado = new System.Windows.Forms.RichTextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.group_driveFire.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_driveFire
            // 
            this.group_driveFire.Controls.Add(this.radio_4);
            this.group_driveFire.Controls.Add(this.radio_3);
            this.group_driveFire.Controls.Add(this.radio_25);
            this.group_driveFire.Controls.Add(this.radio_2);
            this.group_driveFire.Location = new System.Drawing.Point(232, 122);
            this.group_driveFire.Name = "group_driveFire";
            this.group_driveFire.Size = new System.Drawing.Size(360, 45);
            this.group_driveFire.TabIndex = 19;
            this.group_driveFire.TabStop = false;
            this.group_driveFire.Text = "Drive";
            // 
            // radio_4
            // 
            this.radio_4.AutoSize = true;
            this.radio_4.Location = new System.Drawing.Point(273, 20);
            this.radio_4.Name = "radio_4";
            this.radio_4.Size = new System.Drawing.Size(83, 19);
            this.radio_4.TabIndex = 3;
            this.radio_4.TabStop = true;
            this.radio_4.Text = "Firebird 4.0";
            this.radio_4.UseVisualStyleBackColor = true;
            // 
            // radio_3
            // 
            this.radio_3.AutoSize = true;
            this.radio_3.Location = new System.Drawing.Point(184, 20);
            this.radio_3.Name = "radio_3";
            this.radio_3.Size = new System.Drawing.Size(83, 19);
            this.radio_3.TabIndex = 2;
            this.radio_3.TabStop = true;
            this.radio_3.Text = "Firebird 3.0";
            this.radio_3.UseVisualStyleBackColor = true;
            // 
            // radio_25
            // 
            this.radio_25.AutoSize = true;
            this.radio_25.Location = new System.Drawing.Point(95, 20);
            this.radio_25.Name = "radio_25";
            this.radio_25.Size = new System.Drawing.Size(83, 19);
            this.radio_25.TabIndex = 1;
            this.radio_25.TabStop = true;
            this.radio_25.Text = "Firebird 2.5";
            this.radio_25.UseVisualStyleBackColor = true;
            // 
            // radio_2
            // 
            this.radio_2.AutoSize = true;
            this.radio_2.Location = new System.Drawing.Point(6, 20);
            this.radio_2.Name = "radio_2";
            this.radio_2.Size = new System.Drawing.Size(83, 19);
            this.radio_2.TabIndex = 0;
            this.radio_2.TabStop = true;
            this.radio_2.Text = "Firebird 2.0";
            this.radio_2.UseVisualStyleBackColor = true;
            // 
            // bt_GdbToGbk
            // 
            this.bt_GdbToGbk.Enabled = false;
            this.bt_GdbToGbk.Location = new System.Drawing.Point(122, 122);
            this.bt_GdbToGbk.Name = "bt_GdbToGbk";
            this.bt_GdbToGbk.Size = new System.Drawing.Size(104, 45);
            this.bt_GdbToGbk.TabIndex = 17;
            this.bt_GdbToGbk.Text = ".GDB => .GBK ";
            this.bt_GdbToGbk.UseVisualStyleBackColor = true;
            // 
            // bt_gbkToGdb
            // 
            this.bt_gbkToGdb.Location = new System.Drawing.Point(12, 122);
            this.bt_gbkToGdb.Name = "bt_gbkToGdb";
            this.bt_gbkToGdb.Size = new System.Drawing.Size(104, 45);
            this.bt_gbkToGdb.TabIndex = 16;
            this.bt_gbkToGdb.Text = ".GBK => .GDB";
            this.bt_gbkToGdb.UseVisualStyleBackColor = true;
            this.bt_gbkToGdb.Click += new System.EventHandler(this.bt_gbkToGdb_Click);
            // 
            // bt_buscarGDB
            // 
            this.bt_buscarGDB.Location = new System.Drawing.Point(567, 82);
            this.bt_buscarGDB.Name = "bt_buscarGDB";
            this.bt_buscarGDB.Size = new System.Drawing.Size(75, 23);
            this.bt_buscarGDB.TabIndex = 15;
            this.bt_buscarGDB.Text = "Buscar";
            this.bt_buscarGDB.UseVisualStyleBackColor = true;
            this.bt_buscarGDB.Click += new System.EventHandler(this.bt_buscarGDB_Click);
            // 
            // txt_caminhoGDB
            // 
            this.txt_caminhoGDB.Location = new System.Drawing.Point(12, 82);
            this.txt_caminhoGDB.Name = "txt_caminhoGDB";
            this.txt_caminhoGDB.Size = new System.Drawing.Size(548, 23);
            this.txt_caminhoGDB.TabIndex = 14;
            this.txt_caminhoGDB.Text = "C:\\";
            // 
            // lbl_GDB
            // 
            this.lbl_GDB.AutoSize = true;
            this.lbl_GDB.Location = new System.Drawing.Point(12, 64);
            this.lbl_GDB.Name = "lbl_GDB";
            this.lbl_GDB.Size = new System.Drawing.Size(78, 15);
            this.lbl_GDB.TabIndex = 13;
            this.lbl_GDB.Text = "Arquivo .GDB";
            // 
            // lbl_gbk
            // 
            this.lbl_gbk.AutoSize = true;
            this.lbl_gbk.Location = new System.Drawing.Point(12, 6);
            this.lbl_gbk.Name = "lbl_gbk";
            this.lbl_gbk.Size = new System.Drawing.Size(77, 15);
            this.lbl_gbk.TabIndex = 12;
            this.lbl_gbk.Text = "Arquivo .GBK";
            // 
            // bt_buscarGBK
            // 
            this.bt_buscarGBK.Location = new System.Drawing.Point(566, 24);
            this.bt_buscarGBK.Name = "bt_buscarGBK";
            this.bt_buscarGBK.Size = new System.Drawing.Size(75, 23);
            this.bt_buscarGBK.TabIndex = 11;
            this.bt_buscarGBK.Text = "Buscar";
            this.bt_buscarGBK.UseVisualStyleBackColor = true;
            this.bt_buscarGBK.Click += new System.EventHandler(this.bt_buscarGBK_Click);
            // 
            // txt_caminhoGBK
            // 
            this.txt_caminhoGBK.Location = new System.Drawing.Point(12, 24);
            this.txt_caminhoGBK.Name = "txt_caminhoGBK";
            this.txt_caminhoGBK.Size = new System.Drawing.Size(548, 23);
            this.txt_caminhoGBK.TabIndex = 10;
            this.txt_caminhoGBK.Text = "C:\\";
            // 
            // rich_resultado
            // 
            this.rich_resultado.BackColor = System.Drawing.SystemColors.Control;
            this.rich_resultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rich_resultado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rich_resultado.Location = new System.Drawing.Point(12, 173);
            this.rich_resultado.Name = "rich_resultado";
            this.rich_resultado.ReadOnly = true;
            this.rich_resultado.Size = new System.Drawing.Size(629, 183);
            this.rich_resultado.TabIndex = 18;
            this.rich_resultado.Text = "";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // Frm_gbk_gdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 364);
            this.Controls.Add(this.group_driveFire);
            this.Controls.Add(this.bt_GdbToGbk);
            this.Controls.Add(this.bt_gbkToGdb);
            this.Controls.Add(this.bt_buscarGDB);
            this.Controls.Add(this.txt_caminhoGDB);
            this.Controls.Add(this.lbl_GDB);
            this.Controls.Add(this.lbl_gbk);
            this.Controls.Add(this.bt_buscarGBK);
            this.Controls.Add(this.txt_caminhoGBK);
            this.Controls.Add(this.rich_resultado);
            this.Name = "Frm_gbk_gdb";
            this.Text = "GBK <=> GDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_gbk_gdb_FormClosed);
            this.group_driveFire.ResumeLayout(false);
            this.group_driveFire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox group_driveFire;
        private RadioButton radio_4;
        private RadioButton radio_3;
        private RadioButton radio_25;
        private RadioButton radio_2;
        private Button bt_GdbToGbk;
        private Button bt_gbkToGdb;
        private Button bt_buscarGDB;
        private TextBox txt_caminhoGDB;
        private Label lbl_GDB;
        private Label lbl_gbk;
        private Button bt_buscarGBK;
        private TextBox txt_caminhoGBK;
        private RichTextBox rich_resultado;
        private OpenFileDialog fileDialog;
    }
}