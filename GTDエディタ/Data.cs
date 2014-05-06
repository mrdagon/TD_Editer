using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace GTD�G�f�B�^
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

    class ���\
    {
        public int[] �R�X�g = new int[6];
        public int[] �U���� = new int[6];
        public int[] �˒� = new int[6];
        public int[] �A�� = new int[6];
        public int[] �e�� = new int[6];

        public int[] �x���A�� = new int[6];
        public int[] �x���˒� = new int[6];
        public int[] �����З� = new int[6];
        public int[] �����͈� = new int[6];

        public int[] ���ʗ� = new int[6];
        public int[] ������ = new int[6];
        public int[] Hit�� = new int[6];

        public string ���O = "";
        public string ���� = "";
        public int ���� = 0;
        public int ���� = 0;
        public int ��� = 0;
        public int �r���� = 0;
        public int �ǉ����� = 0;

        public ���\()
        {
            for(int i=0;i<6;++i)
            {
                �R�X�g[i] = new int();
                �U����[i] = new int();
                �˒�[i] = new int();
                �A��[i] = new int();
                �e��[i] = new int();
                �x���A��[i] = new int();
                �x���˒�[i] = new int();
                �����З�[i] = new int();
                �����͈�[i] = new int();
                ���ʗ�[i] = new int();
                ������[i] = new int();
                Hit��[i] = new int();
            }
        }

        public void Copy(���\ �R�s�[��)
        {
            ���O = �R�s�[��.���O;
            ���� = �R�s�[��.����;

            ���� = �R�s�[��.����;
            ���� = �R�s�[��.����;
            �r���� = �R�s�[��.�r����;
            �ǉ����� = �R�s�[��.�ǉ�����;
            ��� = �R�s�[��.���;

            for (int i = 0; i < 6; ++i)
            {
                �R�X�g[i] = �R�s�[��.�R�X�g[i];
                �U����[i] = �R�s�[��.�U����[i];
                �˒�[i] = �R�s�[��.�˒�[i];
                �A��[i] = �R�s�[��.�A��[i];
                �e��[i] = �R�s�[��.�e��[i];
                �x���A��[i] = �R�s�[��.�x���A��[i];
                �x���˒�[i] = �R�s�[��.�x���˒�[i];
                �����З�[i] = �R�s�[��.�����З�[i];
                �����͈�[i] = �R�s�[��.�����͈�[i];
                ���ʗ�[i] = �R�s�[��.���ʗ�[i];
                ������[i] = �R�s�[��.������[i];
                Hit��[i] = �R�s�[��.Hit��[i];
            }
        }

    }


}