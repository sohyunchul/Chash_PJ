﻿namespace WinFormsApp2
{
    partial class Form0726_1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0726_1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            btn_Minus = new System.Windows.Forms.Button();
            btn_Plus = new System.Windows.Forms.Button();
            lb_Cnt = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbItem1 = new System.Windows.Forms.Label();
            pbItem1 = new System.Windows.Forms.PictureBox();
            btnOk = new System.Windows.Forms.Button();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            imageList2 = new System.Windows.Forms.ImageList(components);
            lbcom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "유료옵션";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 30);
            label2.TabIndex = 1;
            label2.Text = "무료옵션";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(15, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "얼음조금";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(15, 94);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "얼음많이";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new System.Drawing.Point(27, 22);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_Minus);
            splitContainer1.Panel1.Controls.Add(btn_Plus);
            splitContainer1.Panel1.Controls.Add(lb_Cnt);
            splitContainer1.Panel1.Controls.Add(lbPrice);
            splitContainer1.Panel1.Controls.Add(lbItem1);
            splitContainer1.Panel1.Controls.Add(pbItem1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnOk);
            splitContainer1.Panel2.Controls.Add(numericUpDown1);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(radioButton2);
            splitContainer1.Panel2.Controls.Add(radioButton1);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new System.Drawing.Size(360, 669);
            splitContainer1.SplitterDistance = 256;
            splitContainer1.TabIndex = 4;
            // 
            // btn_Minus
            // 
            btn_Minus.Location = new System.Drawing.Point(141, 100);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new System.Drawing.Size(75, 23);
            btn_Minus.TabIndex = 8;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            btn_Minus.Click += btn_Minus_Click;
            // 
            // btn_Plus
            // 
            btn_Plus.Location = new System.Drawing.Point(248, 100);
            btn_Plus.Name = "btn_Plus";
            btn_Plus.Size = new System.Drawing.Size(75, 23);
            btn_Plus.TabIndex = 7;
            btn_Plus.Text = "+";
            btn_Plus.UseVisualStyleBackColor = true;
            btn_Plus.Click += btn_Plus_Click;
            // 
            // lb_Cnt
            // 
            lb_Cnt.AutoSize = true;
            lb_Cnt.Location = new System.Drawing.Point(222, 108);
            lb_Cnt.Name = "lb_Cnt";
            lb_Cnt.Size = new System.Drawing.Size(14, 15);
            lb_Cnt.TabIndex = 6;
            lb_Cnt.Text = "1";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(203, 157);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(74, 21);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "상품가격";
            // 
            // lbItem1
            // 
            lbItem1.AutoSize = true;
            lbItem1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbItem1.Location = new System.Drawing.Point(203, 54);
            lbItem1.Name = "lbItem1";
            lbItem1.Size = new System.Drawing.Size(58, 21);
            lbItem1.TabIndex = 1;
            lbItem1.Text = "상품명";
            // 
            // pbItem1
            // 
            pbItem1.Location = new System.Drawing.Point(15, 54);
            pbItem1.Name = "pbItem1";
            pbItem1.Size = new System.Drawing.Size(108, 162);
            pbItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbItem1.TabIndex = 0;
            pbItem1.TabStop = false;
            // 
            // btnOk
            // 
            btnOk.Location = new System.Drawing.Point(174, 289);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 23);
            btnOk.TabIndex = 12;
            btnOk.Text = "확인";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(222, 192);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(140, 231);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(58, 21);
            label8.TabIndex = 10;
            label8.Text = "\\1000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(140, 194);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 21);
            label7.TabIndex = 9;
            label7.Text = "\\500";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(162, 99);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(14, 13);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(162, 59);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(14, 13);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(15, 235);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 21);
            label6.TabIndex = 5;
            label6.Text = "펄추가";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(15, 192);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 21);
            label5.TabIndex = 4;
            label5.Text = "샷추가";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "아메리카노(HOT).jpg");
            imageList2.Images.SetKeyName(1, "아메리카노(ICED).jpg");
            imageList2.Images.SetKeyName(2, "더블에스프레소.jpg");
            imageList2.Images.SetKeyName(3, "콜드브루라떼(ICED).jpg");
            imageList2.Images.SetKeyName(4, "원조커피(ICED).jpg");
            imageList2.Images.SetKeyName(5, "달달연유라떼(ICED).jpg");
            imageList2.Images.SetKeyName(6, "바닐라라떼(ICED).jpg");
            imageList2.Images.SetKeyName(7, "아이스크림 카페모카(ICED).jpg");
            // 
            // lbcom
            // 
            lbcom.AutoSize = true;
            lbcom.Location = new System.Drawing.Point(633, 371);
            lbcom.Name = "lbcom";
            lbcom.Size = new System.Drawing.Size(39, 15);
            lbcom.TabIndex = 5;
            lbcom.Text = "label9";
            // 
            // Form0726_1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(417, 725);
            Controls.Add(lbcom);
            Controls.Add(splitContainer1);
            Name = "Form0726_1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form0726_1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbItem1;
        private System.Windows.Forms.PictureBox pbItem1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lbcom;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Label lb_Cnt;
    }
}