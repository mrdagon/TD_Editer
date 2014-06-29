namespace GTDエディタ
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.属性Box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.種類Box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.爆発 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.追加効果Box = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.名前Box = new System.Windows.Forms.TextBox();
            this.説明Box = new System.Windows.Forms.TextBox();
            this.判定Box = new System.Windows.Forms.ComboBox();
            this.詠唱数Box = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.種族特攻Box = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.詠唱数Box)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(373, 12);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(454, 12);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(75, 23);
            this.PasteButton.TabIndex = 3;
            this.PasteButton.Text = "Paste";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(12, 41);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(150, 496);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // 属性Box
            // 
            this.属性Box.FormattingEnabled = true;
            this.属性Box.Items.AddRange(new object[] {
            "炎",
            "氷",
            "樹",
            "空",
            "無"});
            this.属性Box.Location = new System.Drawing.Point(236, 110);
            this.属性Box.Name = "属性Box";
            this.属性Box.Size = new System.Drawing.Size(121, 20);
            this.属性Box.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "属性";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "種類";
            // 
            // 種類Box
            // 
            this.種類Box.AutoCompleteCustomSource.AddRange(new string[] {
            "両方",
            "対地",
            "対空",
            "貫通",
            "対地貫通",
            "対空貫通",
            "支援専用",
            "使い捨て"});
            this.種類Box.FormattingEnabled = true;
            this.種類Box.Items.AddRange(new object[] {
            "両方OK",
            "対地専用",
            "対空専用",
            "使い捨て",
            "支援専用"});
            this.種類Box.Location = new System.Drawing.Point(236, 136);
            this.種類Box.Name = "種類Box";
            this.種類Box.Size = new System.Drawing.Size(121, 20);
            this.種類Box.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "判定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "コスト";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "LV1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "攻撃力";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "射程";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "連射";
            // 
            // 爆発
            // 
            this.爆発.AutoSize = true;
            this.爆発.Location = new System.Drawing.Point(178, 359);
            this.爆発.Name = "爆発";
            this.爆発.Size = new System.Drawing.Size(53, 12);
            this.爆発.TabIndex = 29;
            this.爆発.Text = "爆発威力";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 31;
            this.label14.Text = "爆発範囲";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 33;
            this.label15.Text = "効果量";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 35;
            this.label16.Text = "発生率";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(380, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "詠唱数";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 510);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 12);
            this.label18.TabIndex = 39;
            this.label18.Text = "Hit数";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(176, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 41;
            this.label19.Text = "追加効果";
            // 
            // 追加効果Box
            // 
            this.追加効果Box.AutoCompleteCustomSource.AddRange(new string[] {
            "痺れ",
            "眠り",
            "吹き飛ばし",
            "防御低下",
            "無し"});
            this.追加効果Box.FormattingEnabled = true;
            this.追加効果Box.Items.AddRange(new object[] {
            "鈍足",
            "麻痺",
            "吹飛",
            "防御低下",
            "無し"});
            this.追加効果Box.Location = new System.Drawing.Point(235, 425);
            this.追加効果Box.Name = "追加効果Box";
            this.追加効果Box.Size = new System.Drawing.Size(121, 20);
            this.追加効果Box.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(178, 535);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 12);
            this.label20.TabIndex = 42;
            this.label20.Text = "DPS";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(178, 555);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 12);
            this.label21.TabIndex = 43;
            this.label21.Text = "DPC";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(286, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 12);
            this.label24.TabIndex = 47;
            this.label24.Text = "LV2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(338, 166);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "LV3";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(389, 166);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 12);
            this.label26.TabIndex = 65;
            this.label26.Text = "LV4";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(441, 166);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 12);
            this.label27.TabIndex = 74;
            this.label27.Text = "LV5";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(493, 166);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 12);
            this.label28.TabIndex = 83;
            this.label28.Text = "LV6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "説明";
            // 
            // 名前Box
            // 
            this.名前Box.Location = new System.Drawing.Point(236, 38);
            this.名前Box.Name = "名前Box";
            this.名前Box.Size = new System.Drawing.Size(121, 19);
            this.名前Box.TabIndex = 6;
            // 
            // 説明Box
            // 
            this.説明Box.AcceptsReturn = true;
            this.説明Box.Location = new System.Drawing.Point(236, 63);
            this.説明Box.Multiline = true;
            this.説明Box.Name = "説明Box";
            this.説明Box.Size = new System.Drawing.Size(311, 41);
            this.説明Box.TabIndex = 8;
            // 
            // 判定Box
            // 
            this.判定Box.FormattingEnabled = true;
            this.判定Box.Items.AddRange(new object[] {
            "円形",
            "四角",
            "十字-幅2",
            "十字-幅4"});
            this.判定Box.Location = new System.Drawing.Point(426, 111);
            this.判定Box.Name = "判定Box";
            this.判定Box.Size = new System.Drawing.Size(121, 20);
            this.判定Box.TabIndex = 84;
            // 
            // 詠唱数Box
            // 
            this.詠唱数Box.Location = new System.Drawing.Point(427, 138);
            this.詠唱数Box.Name = "詠唱数Box";
            this.詠唱数Box.Size = new System.Drawing.Size(120, 19);
            this.詠唱数Box.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 86;
            this.label13.Text = "弾速";
            // 
            // 種族特攻Box
            // 
            this.種族特攻Box.AutoCompleteCustomSource.AddRange(new string[] {
            "痺れ",
            "眠り",
            "吹き飛ばし",
            "防御低下",
            "無し"});
            this.種族特攻Box.FormattingEnabled = true;
            this.種族特攻Box.Items.AddRange(new object[] {
            "ゼリー",
            "ゴブリン",
            "ケットシー",
            "オーガ",
            "コボルド",
            "マーマン",
            "ゴーレム",
            "ケルベロス",
            "スケルトン",
            "シャーマン",
            "ゼリー王",
            "インプ",
            "ゴースト",
            "グリフィン",
            "ドラゴン",
            "なし"});
            this.種族特攻Box.Location = new System.Drawing.Point(424, 425);
            this.種族特攻Box.Name = "種族特攻Box";
            this.種族特攻Box.Size = new System.Drawing.Size(121, 20);
            this.種族特攻Box.TabIndex = 87;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(366, 428);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 88;
            this.label22.Text = "種族特攻";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(178, 575);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 12);
            this.label23.TabIndex = 89;
            this.label23.Text = "SUP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 90;
            this.label11.Text = "支援A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 91;
            this.label12.Text = "支援B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 616);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.種族特攻Box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.詠唱数Box);
            this.Controls.Add(this.判定Box);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.追加効果Box);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.爆発);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.種類Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.属性Box);
            this.Controls.Add(this.説明Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.名前Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GTDエディタ";
            ((System.ComponentModel.ISupportInitialize)(this.詠唱数Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox 属性Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox 種類Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label 爆発;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox 追加効果Box;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 名前Box;
        private System.Windows.Forms.TextBox 説明Box;
        private System.Windows.Forms.ComboBox 判定Box;
        private System.Windows.Forms.NumericUpDown 詠唱数Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox 種族特攻Box;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;


    }
}

