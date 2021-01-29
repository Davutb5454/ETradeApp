
namespace ETradeApp.WinFormsUI
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
            this.dgw_product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_name_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_up = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_product
            // 
            this.dgw_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_product.Location = new System.Drawing.Point(12, 12);
            this.dgw_product.Name = "dgw_product";
            this.dgw_product.Size = new System.Drawing.Size(776, 168);
            this.dgw_product.TabIndex = 0;
            this.dgw_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_product_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cbx_category
            // 
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(80, 207);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(205, 21);
            this.cbx_category.TabIndex = 2;
            this.cbx_category.SelectedIndexChanged += new System.EventHandler(this.cbx_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(80, 238);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(205, 20);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_name_ad
            // 
            this.txt_name_ad.Location = new System.Drawing.Point(583, 186);
            this.txt_name_ad.Name = "txt_name_ad";
            this.txt_name_ad.Size = new System.Drawing.Size(205, 20);
            this.txt_name_ad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "add";
            // 
            // txt_up
            // 
            this.txt_up.Location = new System.Drawing.Point(545, 295);
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(205, 20);
            this.txt_up.TabIndex = 8;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(504, 302);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(40, 13);
            this.delete.TabIndex = 7;
            this.delete.Text = "update";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_up);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.txt_name_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_name_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_up;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

