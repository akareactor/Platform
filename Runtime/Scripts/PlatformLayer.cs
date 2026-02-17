using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KulibinSpace.Platform {

    public class PlatformLayer {
        public static ISaveProvider Saves;
        public static IAdsProvider Ads;
        public static IAnalyticsProvider Analytics;
        public static IPlatformProvider Platform;
        public static ILeaderboardProvider Leaderboards;
    }

}
