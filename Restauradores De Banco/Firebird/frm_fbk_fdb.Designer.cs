namespace Restauradores_De_Banco
{
    partial class Frm_fbk_fdb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_fbk_fdb));
            this.txt_caminhoFBK = new System.Windows.Forms.TextBox();
            this.bt_buscarFBK = new System.Windows.Forms.Button();
            this.lbl_fbk = new System.Windows.Forms.Label();
            this.lbl_FDB = new System.Windows.Forms.Label();
            this.txt_caminhoFDB = new System.Windows.Forms.TextBox();
            this.bt_buscarFDB = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bt_fbkToFdb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rich_resultado = new System.Windows.Forms.RichTextBox();
            this.group_driveFire = new System.Windows.Forms.GroupBox();
            this.radio_4 = new System.Windows.Forms.RadioButton();
            this.radio_3 = new System.Windows.Forms.RadioButton();
            this.radio_25 = new System.Windows.Forms.RadioButton();
            this.radio_2 = new System.Windows.Forms.RadioButton();
            this.group_driveFire.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_caminhoFBK
            // 
            this.txt_caminhoFBK.Location = new System.Drawing.Point(12, 26);
            this.txt_caminhoFBK.Name = "txt_caminhoFBK";
            this.txt_caminhoFBK.Size = new System.Drawing.Size(548, 23);
            this.txt_caminhoFBK.TabIndex = 0;
            this.txt_caminhoFBK.Text = "C:\\";
            this.txt_caminhoFBK.Leave += new System.EventHandler(this.txt_caminhoFBK_Leave);
            // 
            // bt_buscarFBK
            // 
            this.bt_buscarFBK.Location = new System.Drawing.Point(566, 26);
            this.bt_buscarFBK.Name = "bt_buscarFBK";
            this.bt_buscarFBK.Size = new System.Drawing.Size(75, 23);
            this.bt_buscarFBK.TabIndex = 1;
            this.bt_buscarFBK.Text = "Buscar";
            this.bt_buscarFBK.UseVisualStyleBackColor = true;
            this.bt_buscarFBK.Click += new System.EventHandler(this.bt_buscarFBK_Click);
            // 
            // lbl_fbk
            // 
            this.lbl_fbk.AutoSize = true;
            this.lbl_fbk.Location = new System.Drawing.Point(12, 8);
            this.lbl_fbk.Name = "lbl_fbk";
            this.lbl_fbk.Size = new System.Drawing.Size(75, 15);
            this.lbl_fbk.TabIndex = 2;
            this.lbl_fbk.Text = "Arquivo .FBK";
            // 
            // lbl_FDB
            // 
            this.lbl_FDB.AutoSize = true;
            this.lbl_FDB.Location = new System.Drawing.Point(12, 66);
            this.lbl_FDB.Name = "lbl_FDB";
            this.lbl_FDB.Size = new System.Drawing.Size(76, 15);
            this.lbl_FDB.TabIndex = 3;
            this.lbl_FDB.Text = "Arquivo .FDB";
            // 
            // txt_caminhoFDB
            // 
            this.txt_caminhoFDB.Location = new System.Drawing.Point(12, 84);
            this.txt_caminhoFDB.Name = "txt_caminhoFDB";
            this.txt_caminhoFDB.Size = new System.Drawing.Size(548, 23);
            this.txt_caminhoFDB.TabIndex = 4;
            this.txt_caminhoFDB.Text = "C:\\";
            // 
            // bt_buscarFDB
            // 
            this.bt_buscarFDB.Location = new System.Drawing.Point(567, 84);
            this.bt_buscarFDB.Name = "bt_buscarFDB";
            this.bt_buscarFDB.Size = new System.Drawing.Size(75, 23);
            this.bt_buscarFDB.TabIndex = 5;
            this.bt_buscarFDB.Text = "Buscar";
            this.bt_buscarFDB.UseVisualStyleBackColor = true;
            this.bt_buscarFDB.Click += new System.EventHandler(this.bt_buscarFBD_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // bt_fbkToFdb
            // 
            this.bt_fbkToFdb.Location = new System.Drawing.Point(12, 124);
            this.bt_fbkToFdb.Name = "bt_fbkToFdb";
            this.bt_fbkToFdb.Size = new System.Drawing.Size(104, 45);
            this.bt_fbkToFdb.TabIndex = 6;
            this.bt_fbkToFdb.Text = ".FBK => .FDB";
            this.bt_fbkToFdb.UseVisualStyleBackColor = true;
            this.bt_fbkToFdb.Click += new System.EventHandler(this.bt_fbkToFdb_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(122, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = ".FDB => .FBK ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rich_resultado
            // 
            this.rich_resultado.BackColor = System.Drawing.SystemColors.Control;
            this.rich_resultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rich_resultado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rich_resultado.Location = new System.Drawing.Point(12, 175);
            this.rich_resultado.Name = "rich_resultado";
            this.rich_resultado.ReadOnly = true;
            this.rich_resultado.Size = new System.Drawing.Size(629, 183);
            this.rich_resultado.TabIndex = 8;
            this.rich_resultado.Text = "";
            // 
            // group_driveFire
            // 
            this.group_driveFire.Controls.Add(this.radio_4);
            this.group_driveFire.Controls.Add(this.radio_3);
            this.group_driveFire.Controls.Add(this.radio_25);
            this.group_driveFire.Controls.Add(this.radio_2);
            this.group_driveFire.Location = new System.Drawing.Point(232, 124);
            this.group_driveFire.Name = "group_driveFire";
            this.group_driveFire.Size = new System.Drawing.Size(360, 45);
            this.group_driveFire.TabIndex = 9;
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
            // Frm_fbk_fdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 368);
            this.Controls.Add(this.group_driveFire);
            this.Controls.Add(this.rich_resultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_fbkToFdb);
            this.Controls.Add(this.bt_buscarFDB);
            this.Controls.Add(this.txt_caminhoFDB);
            this.Controls.Add(this.lbl_FDB);
            this.Controls.Add(this.lbl_fbk);
            this.Controls.Add(this.bt_buscarFBK);
            this.Controls.Add(this.txt_caminhoFBK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_fbk_fdb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBK <=> FDB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pgdmp_FormClosed);
            this.group_driveFire.ResumeLayout(false);
            this.group_driveFire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_caminhoFBK;
        private Button bt_buscarFBK;
        private Label lbl_fbk;
        private Label lbl_FDB;
        private TextBox txt_caminhoFDB;
        private Button bt_buscarFDB;
        private FolderBrowserDialog folder;
        private OpenFileDialog fileDialog;
        private Button bt_fbkToFdb;
        private Button button2;
        private RichTextBox rich_resultado;
        private GroupBox group_driveFire;
        private RadioButton radio_4;
        private RadioButton radio_3;
        private RadioButton radio_25;
        private RadioButton radio_2;
    }
}