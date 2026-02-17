using System;
using System.Collections.Generic;

namespace KulibinSpace.Platform {

    public interface ILeaderboardProvider {
        int Score (string lbname);
        void Get (string lbname, Action<List<LeaderboardItem>> rep);
        void UpdateScore (string lbname, int score);
        void ClearScore (string lbname);
    }

}
