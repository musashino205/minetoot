using System;
using System.Text.RegularExpressions;

namespace MineToot
{
    class clsParseLog
    {
        private string time = "";
        private string type = "";
        private string user = "";
        private bool isTranslated = false;

        private bool doToot = false;

        clsDeathMsg clsDM = new clsDeathMsg();

        Regex baseReg = new Regex(@"^\[(\d{2}:\d{2}:\d{2})\]\s+\[([^\]]+)\]:\s+(.*?)$", RegexOptions.IgnoreCase);
        Regex chatReg = new Regex(@"^<([^>]+)>\s+(.*?)$", RegexOptions.IgnoreCase);
        Regex joinleftReg = new Regex(@"^(.*)(joined|left) the game", RegexOptions.IgnoreCase);
        Regex uuidReg2 = new Regex(@"UUID of player (\S+) is (\S+)");

        public string[] parseLogAray(string msg)
        {
            string[] baseStrAry;

            baseStrAry = baseReg.Split(msg);

            return baseStrAry;
        }

        public string parseLogLine(string msg, string svName)
        {
            string text = "";
            string say = "";
            string outMsg = "";
            string[] baseAry;
            baseAry = baseReg.Split(msg);
            if(baseAry.Length >= 5)
            {
                time = baseAry[1];
                type = baseAry[2];
                text = baseAry[3];

                // Chat
                if(type.ToLower() == "server thread/info" && chatReg.Matches(text).Count != 0)
                {
                    string[] chatAry = chatReg.Split(text);
                    type = "Chat";
                    user = chatAry[1];
                    say = chatAry[2];
                    outMsg = user + ": " + say + Environment.NewLine;

                    isTranslated = true;
                }
                // Join/Leave
                else if (joinleftReg.Matches(text).Count != 0)
                {
                    string[] joinleftAry = joinleftReg.Split(text);
                    user = joinleftAry[1];
                    string action = joinleftAry[2];
                    type = "Joined/Left";
                    if (action == "joined")
                    {
                        outMsg = "[System]: " + user + "がログインしました\r\n";
                    }
                    else
                    {
                        outMsg = "[System]: " + user + "がログアウトしました\r\n";
                    }

                    isTranslated = true;
                }
               // Death
                else if (type.ToLower() == "server thread/info" && clsDM.isDeathDt(text))
                {
                    user = clsDM.userName;
                    type = "Death";
                    outMsg = "[System]: " + clsDM.assemMsg(text) + Environment.NewLine;

                    isTranslated = true;
                }
                else
                {
                    isTranslated = false;
                }
            }

            return  svName + " <" + time + ">\r\nType: " + type + Environment.NewLine + outMsg;
        }

        public bool chkDoToot()
        {
            bool flgType = false;
            switch (type)
            {
                case "Joined/Left":
                    flgType = settings.app.Default.loginout;
                    break;
                case "Death":
                    flgType = settings.app.Default.death;
                    break;
                case "Chat":
                    flgType = settings.app.Default.chat;
                    break;
                default:
                    flgType = false;
                    break;
            }

            if (flgType)
            {
                if (settings.users.Default.user != "")
                {
                    string[] ary = settings.users.Default.user.Split(',');

                    for(int i = 0; i < ary.Length; i++)
                    {
                        if(ary[i] == user)
                        {
                            doToot = true;
                            break;
                        }
                    }
                }
                else
                {
                    doToot = true;
                }
            }
            else
            {
                doToot = false;
            }

            return doToot;
            
        }

        public bool translated
        {
            get
            {
                return isTranslated;
            }
            set
            {
                isTranslated = value;
            }
        }
    }
}
