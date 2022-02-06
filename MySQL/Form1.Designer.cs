namespace MySQL
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MakeDB = new System.Windows.Forms.Button();
            this.btn_Con = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Product = new System.Windows.Forms.TextBox();
            this.t_Price = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_halcon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MakeDB
            // 
            this.btn_MakeDB.Location = new System.Drawing.Point(59, 94);
            this.btn_MakeDB.Name = "btn_MakeDB";
            this.btn_MakeDB.Size = new System.Drawing.Size(75, 23);
            this.btn_MakeDB.TabIndex = 0;
            this.btn_MakeDB.Text = "テーブル作成";
            this.btn_MakeDB.UseVisualStyleBackColor = true;
            this.btn_MakeDB.Click += new System.EventHandler(this.btn_MakeDB_Click);
            // 
            // btn_Con
            // 
            this.btn_Con.Location = new System.Drawing.Point(159, 94);
            this.btn_Con.Name = "btn_Con";
            this.btn_Con.Size = new System.Drawing.Size(75, 23);
            this.btn_Con.TabIndex = 1;
            this.btn_Con.Text = "DB接続";
            this.btn_Con.UseVisualStyleBackColor = true;
            this.btn_Con.Click += new System.EventHandler(this.btn_Con_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "DB書込";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Product
            // 
            this.t_Product.Location = new System.Drawing.Point(277, 135);
            this.t_Product.Name = "t_Product";
            this.t_Product.Size = new System.Drawing.Size(100, 19);
            this.t_Product.TabIndex = 3;
            this.t_Product.Text = "ProductName";
            // 
            // t_Price
            // 
            this.t_Price.Location = new System.Drawing.Point(410, 135);
            this.t_Price.Name = "t_Price";
            this.t_Price.Size = new System.Drawing.Size(100, 19);
            this.t_Price.TabIndex = 4;
            this.t_Price.Text = "Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_halcon
            // 
            this.btn_halcon.Location = new System.Drawing.Point(59, 351);
            this.btn_halcon.Name = "btn_halcon";
            this.btn_halcon.Size = new System.Drawing.Size(75, 23);
            this.btn_halcon.TabIndex = 6;
            this.btn_halcon.Text = "Halcon実行";
            this.btn_halcon.UseVisualStyleBackColor = true;
            this.btn_halcon.Click += new System.EventHandler(this.btn_halcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "実数型";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "整数型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "文字列";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_halcon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_Price);
            this.Controls.Add(this.t_Product);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Con);
            this.Controls.Add(this.btn_MakeDB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MakeDB;
        private System.Windows.Forms.Button btn_Con;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Product;
        private System.Windows.Forms.TextBox t_Price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_halcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

