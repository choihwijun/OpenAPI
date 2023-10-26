namespace 쇼핑_검색
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_query = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.pbox_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_maker = new System.Windows.Forms.Label();
            this.lb_brand = new System.Windows.Forms.Label();
            this.lb_url = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lb_lprice = new System.Windows.Forms.Label();
            this.lb_hprice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_minprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_maxprice = new System.Windows.Forms.TextBox();
            this.lv_shopping = new System.Windows.Forms.ListView();
            this.상품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품 : ";
            // 
            // tbox_query
            // 
            this.tbox_query.Location = new System.Drawing.Point(68, 24);
            this.tbox_query.Name = "tbox_query";
            this.tbox_query.Size = new System.Drawing.Size(338, 21);
            this.tbox_query.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(333, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(72, 21);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pbox_image
            // 
            this.pbox_image.Location = new System.Drawing.Point(429, 23);
            this.pbox_image.Name = "pbox_image";
            this.pbox_image.Size = new System.Drawing.Size(389, 277);
            this.pbox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_image.TabIndex = 4;
            this.pbox_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "제조사 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "브랜드 :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "상품명 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "링크 :";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(467, 313);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 12);
            this.lb_name.TabIndex = 10;
            // 
            // lb_maker
            // 
            this.lb_maker.AutoSize = true;
            this.lb_maker.Location = new System.Drawing.Point(467, 335);
            this.lb_maker.Name = "lb_maker";
            this.lb_maker.Size = new System.Drawing.Size(0, 12);
            this.lb_maker.TabIndex = 11;
            // 
            // lb_brand
            // 
            this.lb_brand.AutoSize = true;
            this.lb_brand.Location = new System.Drawing.Point(467, 356);
            this.lb_brand.Name = "lb_brand";
            this.lb_brand.Size = new System.Drawing.Size(0, 12);
            this.lb_brand.TabIndex = 12;
            // 
            // lb_url
            // 
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(472, 416);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(108, 12);
            this.lb_url.TabIndex = 13;
            this.lb_url.TabStop = true;
            this.lb_url.Text = "http://ehpub.co.kr";
            this.lb_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_url_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "최저가 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "최고가 :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 16);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "가격 오름차순";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(135, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 16);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "가격 내림차순";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lb_lprice
            // 
            this.lb_lprice.AutoSize = true;
            this.lb_lprice.Location = new System.Drawing.Point(470, 375);
            this.lb_lprice.Name = "lb_lprice";
            this.lb_lprice.Size = new System.Drawing.Size(53, 12);
            this.lb_lprice.TabIndex = 18;
            this.lb_lprice.Text = "[최저가]";
            // 
            // lb_hprice
            // 
            this.lb_hprice.AutoSize = true;
            this.lb_hprice.Location = new System.Drawing.Point(471, 395);
            this.lb_hprice.Name = "lb_hprice";
            this.lb_hprice.Size = new System.Drawing.Size(53, 12);
            this.lb_hprice.TabIndex = 19;
            this.lb_hprice.Text = "[최고가]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "가격 범위";
            // 
            // tb_minprice
            // 
            this.tb_minprice.Location = new System.Drawing.Point(88, 55);
            this.tb_minprice.Name = "tb_minprice";
            this.tb_minprice.Size = new System.Drawing.Size(100, 21);
            this.tb_minprice.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "~";
            // 
            // tb_maxprice
            // 
            this.tb_maxprice.Location = new System.Drawing.Point(214, 55);
            this.tb_maxprice.Name = "tb_maxprice";
            this.tb_maxprice.Size = new System.Drawing.Size(100, 21);
            this.tb_maxprice.TabIndex = 23;
            // 
            // lv_shopping
            // 
            this.lv_shopping.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상품명,
            this.columnHeader1});
            this.lv_shopping.HideSelection = false;
            this.lv_shopping.Location = new System.Drawing.Point(25, 108);
            this.lv_shopping.Name = "lv_shopping";
            this.lv_shopping.Size = new System.Drawing.Size(380, 339);
            this.lv_shopping.TabIndex = 24;
            this.lv_shopping.UseCompatibleStateImageBehavior = false;
            this.lv_shopping.View = System.Windows.Forms.View.Details;
            this.lv_shopping.SelectedIndexChanged += new System.EventHandler(this.lv_shopping_SelectedIndexChanged);
            // 
            // 상품명
            // 
            this.상품명.Text = "상품명";
            this.상품명.Width = 248;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "가격";
            this.columnHeader1.Width = 128;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 495);
            this.Controls.Add(this.lv_shopping);
            this.Controls.Add(this.tb_maxprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_minprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_hprice);
            this.Controls.Add(this.lb_lprice);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_url);
            this.Controls.Add(this.lb_brand);
            this.Controls.Add(this.lb_maker);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbox_image);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_query);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "쇼핑";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_query;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pbox_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_maker;
        private System.Windows.Forms.Label lb_brand;
        private System.Windows.Forms.LinkLabel lb_url;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lb_lprice;
        private System.Windows.Forms.Label lb_hprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_minprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_maxprice;
        private System.Windows.Forms.ListView lv_shopping;
        private System.Windows.Forms.ColumnHeader 상품명;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

