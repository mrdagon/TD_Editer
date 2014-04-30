namespace GTDエディタ
{
    class 性能
    {
        public int[] コスト = new int[6];
        public int[] 攻撃力 = new int[6];
        public int[] 射程 = new int[6];
        public int[] 速度 = new int[6];

        public int[] 支援効果 = new int[6];
        public int[] 支援範囲 = new int[6];
        public int[] 爆発威力 = new int[6];
        public int[] 爆発範囲 = new int[6];

        public int[] 効果量 = new int[6];
        public int[] 発生率 = new int[6];
        public int[] Hit数 = new int[6];

        public string 名前 = "";
        public string 説明 = "";
        public int 属性 = 0;
        public int 判定 = 0;
        public int 種類 = 0;
        public int 詠唱数 = 0;
        public int 追加効果 = 0;


        public 性能()
        {
            for(int i=0;i<6;++i)
            {
                コスト[i] = new int();
                攻撃力[i] = new int();
                射程[i] = new int();
                速度[i] = new int();
                支援効果[i] = new int();
                支援範囲[i] = new int();
                爆発威力[i] = new int();
                爆発範囲[i] = new int();
                効果量[i] = new int();
                発生率[i] = new int();
                Hit数[i] = new int();
            }
        }

        public void Copy(性能 コピー元)
        {
            名前 = コピー元.名前;
            説明 = コピー元.説明;
            属性 = コピー元.属性;
            判定 = コピー元.判定;
            詠唱数 = コピー元.詠唱数;
            追加効果 = コピー元.追加効果;
            種類 = コピー元.種類;

            for (int i = 0; i < 6; ++i)
            {
                コスト[i] = コピー元.コスト[i];
                攻撃力[i] = コピー元.攻撃力[i];
                射程[i] = コピー元.射程[i];
                速度[i] = コピー元.速度[i];
                支援効果[i] = コピー元.支援効果[i];
                支援範囲[i] = コピー元.支援範囲[i];
                爆発威力[i] = コピー元.爆発威力[i];
                爆発範囲[i] = コピー元.爆発範囲[i];
                効果量[i] = コピー元.効果量[i];
                発生率[i] = コピー元.発生率[i];
                Hit数[i] = コピー元.Hit数[i];
            }
        }

    }


}