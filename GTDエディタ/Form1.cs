using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GTDエディタ
{
    public partial class Form1 : Form
    {
        const int 魔法数 = 80;//共通20 + 専用 5×12
        const int Box位置X = 236;
        const int Box間隔 = 52;
        string fileName = "\\data.txt";
        FileStream file;

        int index = 0;
        int copy_index = -1;//コピー元のインデックス

        性能[] MagicS = new 性能[魔法数];

        NumBox[] コストBox = new NumBox[6];
        NumBox[] 攻撃力Box = new NumBox[6];
        NumBox[] 射程Box = new NumBox[6];
        NumBox[] 連射Box = new NumBox[6];
        NumBox[] 弾速Box = new NumBox[6];

        NumBox[] 連射支援Box = new NumBox[6];
        NumBox[] 射程支援Box = new NumBox[6];
        NumBox[] 爆発威力Box = new NumBox[6];
        NumBox[] 爆発範囲Box = new NumBox[6];

        NumBox[] 効果量Box = new NumBox[6];
        NumBox[] 発生率Box = new NumBox[6];
        NumBox[] Hit数Box = new NumBox[6];

        Label[] DPS表示 = new Label[6];
        Label[] DPC表示 = new Label[6];

        NumBox[] BoxBuff = new NumBox[6 * 12];

        public Form1()
        {
            fileName = System.IO.Directory.GetCurrentDirectory() + "\\data.txt";

            InitializeComponent();

            for(int i=0;i<魔法数;++i)
            {
                MagicS[i] = new 性能();
            }

            int x = 0;
            int y = 181;

            for (int i = 0; i < 6 * 12; ++i )
            {
                x = Box位置X + i % 6 * Box間隔;
                if (i == 6 * 5) y = 316;
                if (i == 6 * 7) y = 374;
                if (i == 6 * 9) y = 460;

                BoxBuff[i] = new NumBox();
                BoxBuff[i].Size = new Size(44, 19);
 
                BoxBuff[i].Location = new Point( x , y );

                BoxBuff[i].Maximum = 9999;
                BoxBuff[i].Minimum = 0;

                Controls.Add(BoxBuff[i]);
                if (i % 6 == 5) y += 25;
            }

            for (int i = 0; i < 6; ++i)
            {
                DPS表示[i] = new Label();
                DPC表示[i] = new Label();

                DPS表示[i].Size = new Size(44, 19);
                DPC表示[i].Size = new Size(44, 19);

                DPS表示[i].Location = new Point(Box位置X + i * Box間隔, 543);
                DPC表示[i].Location = new Point(Box位置X + i * Box間隔, 570);

                Controls.Add(DPS表示[i]);
                Controls.Add(DPC表示[i]);
            }

            for (int i = 0; i < 6; ++i)
            {
                コストBox[i] = BoxBuff[i + 6 * 0];
                攻撃力Box[i] = BoxBuff[i + 6 * 1];
                射程Box[i] = BoxBuff[i + 6 * 2];
                連射Box[i] = BoxBuff[i + 6 * 3];
                弾速Box[i] = BoxBuff[i + 6 * 4];
                連射支援Box[i] = BoxBuff[i + 6 * 5];
                射程支援Box[i] = BoxBuff[i + 6 * 6];
                爆発威力Box[i] = BoxBuff[i + 6 * 7];
                爆発範囲Box[i] = BoxBuff[i + 6 * 8];
                効果量Box[i] = BoxBuff[i + 6 * 9];
                発生率Box[i] = BoxBuff[i + 6 * 10];
                Hit数Box[i] = BoxBuff[i + 6 * 11];
            }

            DataLoad();

            for (int i = 0; i < 魔法数; ++i)
            {
                if (i % 5 == 0) listBox.Items.Add( "●" + MagicS[i].名前);
                else listBox.Items.Add( MagicS[i].名前);
            }

            UpdateBox();

            for (int i = 0; i < 66; ++i)
            {
                BoxBuff[i].TextChanged += new EventHandler(ChangeDPS);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        void ChangeDPS(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
            {
                double dps = 攻撃力Box[i].GetValue() * 連射Box[i].GetValue() * Hit数Box[i].GetValue();
                dps = dps * (連射支援Box[i].GetValue() + 100);
                dps /= 1000;
                double cost = コストBox[i].GetValue();
                double dpc = dps / cost;

                DPS表示[i].Text = dps.ToString("F0");
                DPC表示[i].Text = dpc.ToString("F1");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Ctrl + V をボタンのショートカットキーとして処理する
            if ((int)keyData == (int)Keys.Control + (int)Keys.V)
            {
                this.PasteButton.PerformClick();
                return true;
            }

            // Ctrl + C をボタンのショートカットキーとして処理する
            if ((int)keyData == (int)Keys.Control + (int)Keys.C)
            {
                this.CopyButton.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0) return;

            UpdateData();
            index = listBox.SelectedIndex;
            UpdateBox();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            copy_index = index;
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            MagicS[index].Copy(MagicS[copy_index]);
            UpdateBox();

            for (int i = 0; i < 魔法数; ++i)
            {
                if (i % 5 == 0) listBox.Items[i] = "●" + MagicS[i].名前;
                else listBox.Items[i] = MagicS[i].名前;
            }
        }

        private void UpdateData()
        {
            MagicS[index].名前 = 名前Box.Text;
            MagicS[index].説明 = 説明Box.Text;
            MagicS[index].属性 = 属性Box.SelectedIndex;
            MagicS[index].判定 = 判定Box.SelectedIndex;
            MagicS[index].種類 = 種類Box.SelectedIndex;
            MagicS[index].詠唱数 = Decimal.ToInt32(詠唱数Box.Value);
            MagicS[index].追加効果 = 追加効果Box.SelectedIndex;

            for (int i = 0; i < 6; ++i)
            {
                MagicS[index].コスト[i] = コストBox[i].GetValue();
                MagicS[index].攻撃力[i] = 攻撃力Box[i].GetValue();
                MagicS[index].射程[i] = 射程Box[i].GetValue();
                MagicS[index].連射[i] = 連射Box[i].GetValue();
                MagicS[index].弾速[i] = 弾速Box[i].GetValue();

                MagicS[index].支援連射[i] = 連射支援Box[i].GetValue();
                MagicS[index].支援射程[i] = 射程支援Box[i].GetValue();
                MagicS[index].爆発威力[i] = 爆発威力Box[i].GetValue();
                MagicS[index].爆発範囲[i] = 爆発範囲Box[i].GetValue();

                MagicS[index].効果量[i] = 効果量Box[i].GetValue();
                MagicS[index].発生率[i] = 発生率Box[i].GetValue();
                MagicS[index].Hit数[i] = Hit数Box[i].GetValue();
            }

        }

        private void UpdateBox()
        {
            名前Box.Text = MagicS[index].名前;
            説明Box.Text = MagicS[index].説明;
            属性Box.SelectedIndex = MagicS[index].属性;
            種類Box.SelectedIndex = MagicS[index].種類;
            判定Box.SelectedIndex = MagicS[index].判定;
            詠唱数Box.Value = MagicS[index].詠唱数;
            if (MagicS[index].追加効果 > 4) MagicS[index].追加効果 = 4;
            追加効果Box.SelectedIndex = MagicS[index].追加効果;

            for(int i=0;i<6;++i)
            {
                コストBox[i].Value = MagicS[index].コスト[i];
                攻撃力Box[i].Value = MagicS[index].攻撃力[i];
                射程Box[i].Value = MagicS[index].射程[i];
                連射Box[i].Value = MagicS[index].連射[i];
                弾速Box[i].Value = MagicS[index].弾速[i];

                連射支援Box[i].Value = MagicS[index].支援連射[i];
                射程支援Box[i].Value = MagicS[index].支援射程[i];
                爆発威力Box[i].Value = MagicS[index].爆発威力[i];
                爆発範囲Box[i].Value = MagicS[index].爆発範囲[i];

                効果量Box[i].Value = MagicS[index].効果量[i];
                発生率Box[i].Value = MagicS[index].発生率[i];
                Hit数Box[i].Value = MagicS[index].Hit数[i];

                double dps = 攻撃力Box[i].GetValue() * 連射Box[i].GetValue() * Hit数Box[i].GetValue();
                dps = dps * (連射支援Box[i].GetValue() + 100);
                dps /= 1000;
                double cost = コストBox[i].GetValue();
                double dpc = dps / cost;

                DPS表示[i].Text = dps.ToString("F0");
                DPC表示[i].Text = dpc.ToString("F1");
            }

        }

        private void DataLoad()
        {
            if( !System.IO.File.Exists(fileName) )
            {
                //ファイルがないなら読み込まない
                return;
            }

            file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);

            for (int i = 0; i < 魔法数; ++i)
            {
                LoadString(ref MagicS[i].名前);
                LoadString(ref MagicS[i].説明);
                LoadInt(ref MagicS[i].属性);
                LoadInt(ref MagicS[i].判定);
                LoadInt(ref MagicS[i].種類);
                LoadInt(ref MagicS[i].詠唱数);
                LoadInt(ref MagicS[i].追加効果);

                LoadIntS(ref MagicS[i].コスト);
                LoadIntS(ref MagicS[i].攻撃力);
                LoadIntS(ref MagicS[i].射程);
                LoadIntS(ref MagicS[i].連射);
                LoadIntS(ref MagicS[i].弾速);

                LoadIntS(ref MagicS[i].支援連射);
                LoadIntS(ref MagicS[i].支援射程);
                LoadIntS(ref MagicS[i].爆発威力);
                LoadIntS(ref MagicS[i].爆発範囲);

                LoadIntS(ref MagicS[i].効果量);
                LoadIntS(ref MagicS[i].発生率);
                LoadIntS(ref MagicS[i].Hit数);
            }

            file.Close();
        }

        private void DataSave()
        {
            UpdateData();

            file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

            for (int i = 0; i < 魔法数;++i )
            {
                if (i % 5 == 0) listBox.Items[i] = "●" + MagicS[i].名前;
                else            listBox.Items[i] = MagicS[i].名前;

                SaveString(MagicS[i].名前);
                SaveString(MagicS[i].説明);
                SaveInt(MagicS[i].属性);
                SaveInt(MagicS[i].判定);
                SaveInt(MagicS[i].種類);
                SaveInt(MagicS[i].詠唱数);
                SaveInt(MagicS[i].追加効果);

                SaveIntS(MagicS[i].コスト);
                SaveIntS(MagicS[i].攻撃力);
                SaveIntS(MagicS[i].射程);
                SaveIntS(MagicS[i].連射);
                SaveIntS(MagicS[i].弾速);

                SaveIntS(MagicS[i].支援連射);
                SaveIntS(MagicS[i].支援射程);
                SaveIntS(MagicS[i].爆発威力);
                SaveIntS(MagicS[i].爆発範囲);

                SaveIntS(MagicS[i].効果量);
                SaveIntS(MagicS[i].発生率);
                SaveIntS(MagicS[i].Hit数);
            }

            file.Close();

        }
        
        private void SaveString(string 文字列)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes( 文字列 );
            byte[] 文字数 = BitConverter.GetBytes(byteArray.Length);

            file.Write(文字数, 0, 4);
            file.Write(byteArray, 0, byteArray.Length);
        }

        private void SaveInt(int 数値)
        {
            file.Write(BitConverter.GetBytes(数値), 0, 4);
        }

        private void SaveIntS(int[] 数値)
        {
            for (int i = 0; i < 6; ++i)
            {
                file.Write(BitConverter.GetBytes(数値[i]), 0, 4);
            }
        }
        private void LoadString(ref string 文字列)
        {
            int 文字数 = 0;
            LoadInt(ref 文字数);

            byte[] byteS = new byte[文字数];

            file.Read(byteS, 0, 文字数);

            文字列 = Encoding.UTF8.GetString(byteS);
        }

        private void LoadInt(ref int 数値)
        {
            byte[] byteS = new byte[4];
            file.Read(byteS,0,4);
            数値 = BitConverter.ToInt32(byteS,0);
        }

        private void LoadIntS(ref int[] 数値)
        {
            byte[] byteS = new byte[4];
            for (int i = 0; i < 6;++i )
            {
                file.Read(byteS, 0, 4);
                数値[i] = BitConverter.ToInt32(byteS, 0);
            }
        }
    
    }
}
