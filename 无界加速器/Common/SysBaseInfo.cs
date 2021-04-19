using NB.Model;
using System.Collections.Generic;

namespace NB.Common
{
    public static class SysBaseInfo
    {
        public static List<Games> Games = new List<Games>();

        public static List<ShadowsocksR> ShadowsocksR = new List<ShadowsocksR>();

        public static List<MyGames> MyGames = new List<MyGames>();

        public static GlobalMode globalMode = new GlobalMode();

        public static List<string> Rule = new List<string>();
        public static List<string> NFRule = new List<string>();

        public static string WebUrl = "http://15s700026n.51mypc.cn/Games/";

    }

    public enum GlobalMode
    {
        Route,
        NetFilter,
    }
}
