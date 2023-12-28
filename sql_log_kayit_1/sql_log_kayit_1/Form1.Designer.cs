namespace sql_log_kayit_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Sql_Connet = new System.Windows.Forms.Button();
            this.textBox_Sql_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_log_Add = new System.Windows.Forms.Button();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.textBox_Mesaj_Tablo = new System.Windows.Forms.TextBox();
            this.textBox_Log_Tablo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Sql_Connet
            // 
            this.button_Sql_Connet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Sql_Connet.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button_Sql_Connet.Enabled = false;
            this.button_Sql_Connet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sql_Connet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Sql_Connet.Location = new System.Drawing.Point(280, 116);
            this.button_Sql_Connet.Name = "button_Sql_Connet";
            this.button_Sql_Connet.Size = new System.Drawing.Size(217, 54);
            this.button_Sql_Connet.TabIndex = 0;
            this.button_Sql_Connet.Text = "Sql Connet";
            this.button_Sql_Connet.UseVisualStyleBackColor = false;
            this.button_Sql_Connet.Click += new System.EventHandler(this.button_Sql_Connet_Click);
            // 
            // textBox_Sql_Path
            // 
            this.textBox_Sql_Path.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Sql_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sql_Path.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Sql_Path.Location = new System.Drawing.Point(12, 63);
            this.textBox_Sql_Path.Name = "textBox_Sql_Path";
            this.textBox_Sql_Path.Size = new System.Drawing.Size(776, 31);
            this.textBox_Sql_Path.TabIndex = 2;
            this.textBox_Sql_Path.TextChanged += new System.EventHandler(this.textBox_Sql_Path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(299, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQL Connet Path";
            // 
            // button_log_Add
            // 
            this.button_log_Add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_log_Add.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button_log_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_log_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_log_Add.Location = new System.Drawing.Point(280, 326);
            this.button_log_Add.Name = "button_log_Add";
            this.button_log_Add.Size = new System.Drawing.Size(217, 54);
            this.button_log_Add.TabIndex = 4;
            this.button_log_Add.Text = "Log Add";
            this.button_log_Add.UseVisualStyleBackColor = false;
            this.button_log_Add.Click += new System.EventHandler(this.button_log_Add_Click);
            // 
            // textBox_Log
            // 
            this.textBox_Log.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Log.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Log.Location = new System.Drawing.Point(151, 215);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(505, 85);
            this.textBox_Log.TabIndex = 5;
            // 
            // textBox_Mesaj_Tablo
            // 
            this.textBox_Mesaj_Tablo.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Mesaj_Tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Mesaj_Tablo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Mesaj_Tablo.Location = new System.Drawing.Point(251, 178);
            this.textBox_Mesaj_Tablo.Name = "textBox_Mesaj_Tablo";
            this.textBox_Mesaj_Tablo.Size = new System.Drawing.Size(158, 31);
            this.textBox_Mesaj_Tablo.TabIndex = 6;
            // 
            // textBox_Log_Tablo
            // 
            this.textBox_Log_Tablo.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Log_Tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Log_Tablo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Log_Tablo.Location = new System.Drawing.Point(581, 178);
            this.textBox_Log_Tablo.Name = "textBox_Log_Tablo";
            this.textBox_Log_Tablo.Size = new System.Drawing.Size(158, 31);
            this.textBox_Log_Tablo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mesaj Tablo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(438, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log Tablo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Log_Tablo);
            this.Controls.Add(this.textBox_Mesaj_Tablo);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.button_log_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Sql_Path);
            this.Controls.Add(this.button_Sql_Connet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Sql_Connet;
        private System.Windows.Forms.TextBox textBox_Sql_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_log_Add;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.TextBox textBox_Mesaj_Tablo;
        private System.Windows.Forms.TextBox textBox_Log_Tablo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

