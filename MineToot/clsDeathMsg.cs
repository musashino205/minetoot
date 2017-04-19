using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;

namespace MineToot
{
    class clsDeathMsg
    {
        private int dtIndex = 0;
        private string user = "";
        private string obj = "";
        private string way = "";

        // regular expressions array
        Regex[] deathMsg =
            new Regex[] {
                    // Lava
                    new Regex(@"(.*?) tried to swim in lava while trying to escape (.*?)$"),
                    new Regex(@"(.*?) tried to swim in lava to escape (.*?)$"),
                    new Regex(@"(.*?) tried to swim in lava$") };

        // regular expressions and translations pair DataTable
        DataTable deathDt = new DataTable("DeathDt");
        
        public clsDeathMsg()
        {
            deathDt.Columns.Add("regex", Type.GetType("System.String"));
            deathDt.Columns.Add("trans", Type.GetType("System.String"));

            // Lava
            deathDt.Rows.Add("(.*?) tried to swim in lava while trying to escape (.*?)$", "$1 は $2 から逃れようと溶岩遊泳を試みた");
            deathDt.Rows.Add("(.*?) tried to swim in lava to escape (.*?)$", "$1 は $2 から逃れようと溶岩遊泳を試みた");
            deathDt.Rows.Add("(.*?) tried to swim in lava$", "$1 は溶岩遊泳を試みた");
            deathDt.Rows.Add("(.*?) discovered floor was lava$", "$1 は床が溶岩だったと気付いた");

            // Fell
            deathDt.Rows.Add("(.*?) fell from a high place$", "$1 は高い所から落ちた");
            deathDt.Rows.Add("(.*?) fell off a ladder$", "$1 ははしごから落ちた");
            deathDt.Rows.Add("(.*?) fell off some vines$", "$1 はツタから滑り落ちた");
            deathDt.Rows.Add("(.*?) fell out of the world$", "$1 は奈落の底へ落ちてしまった");
            deathDt.Rows.Add("(.*?) fell out of the water$", "$1 は水から落ちた");
            deathDt.Rows.Add("(.*?) fell into a patch of fire$", "$1 は火の海に落ちた");
            deathDt.Rows.Add("(.*?) fell into a patch of cacti$", "$1 はサボテンの上に落ちた");
            deathDt.Rows.Add("(.*?) fell from a high place and fell out of the world$", "$1 は奈落の底へ落ちてしまった");

            // Shot
            deathDt.Rows.Add("(.*?) was shot by (.*?) using (.*?)$", "$1 は $2 の $3 で射抜かれた");
            deathDt.Rows.Add("(.*?) was shot by arrow$", "$1 は矢に射抜かれた");
            deathDt.Rows.Add("(.*?) was shot by (.*?)$", "$1 は $2 に射抜かれた");
            deathDt.Rows.Add("(.*?) was shot off some vines by (.*?)$", "$1 は $2 によって命が尽きて落下した");
            deathDt.Rows.Add("(.*?) was shot off a ladder by (.*?)$", "$1 は $2 によって命が尽きて落下した");

            // Killed
            deathDt.Rows.Add("(.*?) was killed by magic$", "$1 は魔法で殺された");
            deathDt.Rows.Add("(.*?) was killed by (.*?) using magic$", "$1 は魔法を使う $2 に殺された");
            deathDt.Rows.Add("(.*?) was killed while trying to hurt (.*?)$", "$1 は $2 を傷つけようとして殺されました");

            // Slain
            deathDt.Rows.Add("(.*?) was slain by (.*?) using (.*?)$", "$1 は $2 の $3 で殺害された");
            deathDt.Rows.Add("(.*?) was slain by (.*?)$", "$1 は $2 に殺害された");

            // Was
            deathDt.Rows.Add("(.*?) was squashed by a falling anvil$", "$1 は落下してきた金床に押しつぶされた");
            deathDt.Rows.Add("(.*?) was pricked to death$", "$1 は刺されて死んでしまった");
            deathDt.Rows.Add("(.*?) was pummeled by (.*?)$", "$1 は $2 によってぺしゃんこにされた");
            deathDt.Rows.Add("(.*?) was doomed to fall$", "$1 は $2 によって命が尽きて落下した");
            deathDt.Rows.Add("(.*?) was blown up by (.*?)$", "$1 は $2 に爆破されてしまった");
            deathDt.Rows.Add("(.*?) was blown from a high place by (.*?)$", "$1 は $2 によって命が尽きて落下した");
            deathDt.Rows.Add("(.*?) was burnt to a crisp whilst fighting (.*?)$", "$1 は $2 と戦いながらカリカリに焼けてしまった");
            deathDt.Rows.Add("(.*?) was knocked into the void by (.*?)$", "$1 は奈落の底へ落ちてしまった");
            deathDt.Rows.Add("(.*?) was fireballed by (.*?)$", "$1 は $2 によって火だるまにされた");
            deathDt.Rows.Add("(.*?) was squashed by a falling block$", "$1 は落下してきたブロックに押しつぶされた");

            // Walked
            deathDt.Rows.Add("(.*?) walked into a cactus whilst trying to escape (.*?)$", "$1 は $2 から逃げようとしてサボテンにぶつかってしまった");
            deathDt.Rows.Add("(.*?) walked into a fire whilst fighting (.*?)$", "$1 は $2 と戦いながら火の中へ踏み入れてしまった");

            // Drowned
            deathDt.Rows.Add("(.*?) drowned whilst trying to escape (.*?)$", "$1 は $2 から逃れようとして溺れ死んでしまった");
            deathDt.Rows.Add("(.*?) drowned$", "$1 は溺れ死んでしまった");

            // Death
            deathDt.Rows.Add("(.*?) burned to death$", "$1 はこんがりと焼けてしまった");
            deathDt.Rows.Add("(.*?) starved to death$", "$1 は飢え死にしてしまった");

            // Other
            deathDt.Rows.Add("(.*?) died$", "$1 は死んでしまった");
            deathDt.Rows.Add("(.*?) suffocated in a wall$", "$1 は壁の中で窒息してしまった");
            deathDt.Rows.Add("(.*?) blew up$", "$1 は爆発に巻き込まれてしまった");
            deathDt.Rows.Add("(.*?) hit the ground too hard$", "$1 は地面と強く激突してしまった");
            deathDt.Rows.Add("(.*?) got finished off by (.*?) using (.*?)$", "$1 は $2 の $3 で殺害された");
            deathDt.Rows.Add("(.*?) went up in flames$", "$1 は炎に巻かれてしまった");
            deathDt.Rows.Add("(.*?) withered away$", "$1 は枯れ果ててしまった");
            deathDt.Rows.Add("(.*?) experienced kinetic energy$", "$1 は運動エネルギーを体験した");
        }

        // XML output (Experimental, XML was NOT used)
        public void dtXml(string lang)
        {
            if(deathDt != null)
            {
                StreamWriter sw;
                string xmlPath = @".\lang\" + lang + ".xml";
                if (!File.Exists(xmlPath))
                {
                    File.Create(xmlPath);
                }
                sw = new StreamWriter(xmlPath, false, Encoding.GetEncoding("shift_jis"));
                deathDt.WriteXml(sw);
            }
        }

        public bool isDeath(string text)
        {
            bool death = false;
            for (int i = 0; i < deathMsg.Length; i++)
            {
                if (deathMsg[i].Matches(text).Count == 1)
                {
                    death = true;
                    break;
                }
            }

            return death;
        }

        public bool isDeathDt(string text)
        {
            bool death = false;
            for (int i = 0; i < deathDt.Rows.Count; i++)
            {
                string reg = deathDt.Rows[i][0].ToString();
                if (Regex.Matches(text, reg).Count != 0)
                {
                    death = true;
                    dtIndex = i;
                    break;
                }
            }
            if (!death) dtIndex = 0;

            return death;
        }

        public void setDataStrs(string text)
        {
            // ### property ###
            //user, obj, way 
            obj = "";
            way = "";

            string[] deathAry = Regex.Split(text, deathDt.Rows[dtIndex][0].ToString());

            if(deathAry.Length >= 3)
            {
                user = deathAry[1];
            }
            if(deathAry.Length >= 4)
            {
                obj = deathAry[2];
            }
            if(deathAry.Length >= 5)
            {
                way = deathAry[3];
            }
        }

        public string assemMsg(string text)
        {
            string str = "";

            setDataStrs(text);

            if (user != "")
            {
                str = Regex.Replace(deathDt.Rows[dtIndex][1].ToString(), @"\$1", user);
                if (obj != "")
                {
                    str = Regex.Replace(str, @"\$2", obj);
                    if (way != "")
                    {
                        str = Regex.Replace(str, @"\$3", obj);
                    }
                }
            }
            return str;
        }
    }
}
