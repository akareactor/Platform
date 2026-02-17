using UnityEngine;

namespace KulibinSpace.Platform {

    public abstract class PlatformInstaller : MonoBehaviour {

        protected abstract ISaveProvider CreateSaves ();
        protected abstract IAdsProvider CreateAds ();
        protected abstract IAnalyticsProvider CreateAnalytics ();
        protected abstract IPlatformProvider CreatePlatform ();
        protected abstract ILeaderboardProvider CreateLeaderboards ();

        protected virtual void Awake () {
            PlatformLayer.Saves = CreateSaves();
            PlatformLayer.Ads = CreateAds();
            PlatformLayer.Analytics = CreateAnalytics();
            PlatformLayer.Platform = CreatePlatform();
            PlatformLayer.Leaderboards = CreateLeaderboards();

            Debug.Log($"Platform installed: {PlatformLayer.Platform?.GetType().Name}");
        }
    }

}
