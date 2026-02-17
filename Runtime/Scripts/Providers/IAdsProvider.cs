using System;

namespace KulibinSpace.Platform {

    public interface IAdsProvider {
        bool IsInterstitialReady { get; }
        void ShowInterstitial ();
        event Action OnCloseAd;
    }

}
