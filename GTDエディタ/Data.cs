using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace GTDGfB^
{
    public class NumBox : NumericUpDown
    {
        public int GetValue()
        {
            return decimal.ToInt32(this.Value);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }
    }

    class «\
    {
        public int[] RXg = new int[6];
        public int[] UÍ = new int[6];
        public int[] Ëö = new int[6];
        public int[] AË = new int[6];
        public int[] e¬ = new int[6];

        public int[] xA = new int[6];
        public int[] xB = new int[6];
        public int[] ­ÐÍ = new int[6];
        public int[] ­ÍÍ = new int[6];

        public int[] øÊÊ = new int[6];
        public int[] ­¶¦ = new int[6];
        public int[] Hit = new int[6];

        public string ¼O = "";
        public string à¾ = "";
        public int ®« = 0;
        public int »è = 0;
        public int íÞ = 0;
        public int r¥ = 0;
        public int ÇÁøÊ = 0;
        public int í°ÁU = 0;

        public «\()
        {
            for(int i=0;i<6;++i)
            {
                RXg[i] = new int();
                UÍ[i] = new int();
                Ëö[i] = new int();
                AË[i] = new int();
                e¬[i] = new int();
                xA[i] = new int();
                xB[i] = new int();
                ­ÐÍ[i] = new int();
                ­ÍÍ[i] = new int();
                øÊÊ[i] = new int();
                ­¶¦[i] = new int();
                Hit[i] = new int();
            }
        }

        public void Copy(«\ Rs[³)
        {
            ¼O = Rs[³.¼O;
            à¾ = Rs[³.à¾;

            ®« = Rs[³.®«;
            »è = Rs[³.»è;
            r¥ = Rs[³.r¥;
            ÇÁøÊ = Rs[³.ÇÁøÊ;
            íÞ = Rs[³.íÞ;
            í°ÁU = Rs[³.í°ÁU;

            for (int i = 0; i < 6; ++i)
            {
                RXg[i] = Rs[³.RXg[i];
                UÍ[i] = Rs[³.UÍ[i];
                Ëö[i] = Rs[³.Ëö[i];
                AË[i] = Rs[³.AË[i];
                e¬[i] = Rs[³.e¬[i];
                xA[i] = Rs[³.xA[i];
                xB[i] = Rs[³.xB[i];
                ­ÐÍ[i] = Rs[³.­ÐÍ[i];
                ­ÍÍ[i] = Rs[³.­ÍÍ[i];
                øÊÊ[i] = Rs[³.øÊÊ[i];
                ­¶¦[i] = Rs[³.­¶¦[i];
                Hit[i] = Rs[³.Hit[i];
            }
        }

    }


}