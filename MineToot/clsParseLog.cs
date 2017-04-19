using System;
using System.Text.RegularExpressions;

namespace MineToot
{
    class clsParseLog
    {
        private string time = "";
        private string type = "";
        private string user = "";

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

        public string parseLogLine(string msg)
        {
            string text = "";
            string say = "";
            string obj = "";
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
                }
               // Death
                else if (type.ToLower() == "server thread/info" && clsDM.isDeathDt(text))
                {
                    type = "Death";
                    outMsg = "[System]: " + clsDM.assemMsg(text) + Environment.NewLine;
                }
            }

            return "Type: " + type + Environment.NewLine + "#taihacraft <" + time + ">\r\n" + outMsg;
        }
    }
}
