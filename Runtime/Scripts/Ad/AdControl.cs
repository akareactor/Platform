using UnityEngine;
using UnityEngine.Events;

namespace KulibinSpace.Platform {

    // Сделано на логике Plugin Your Games, но всё же перенесено на уровень платформы 2026-05-26 13:56:41
    // Старые комментарии оставлены.
    // контроль открытия рекламы. Особенность плагина YG в том, что если таймер рекламы ещё не истёк, то реклама просто не откроется и никто об этом не узнает.
    // Поэтому время нужно контролировать самому, при этом диспетчируя вызов помимо рекламы.

    public class AdControl : MonoBehaviour {

        bool allowFullscreenAd = false;
        public UnityEvent passOpenAd; // событие, которое запускается вместо рекламы, если её нельзя показывать.

        // а рекламу открываем, только если есть такая возможность
        public void OpenFullscreenAd () {
            if (allowFullscreenAd) {
                //print("Пытаюсь открыть полноэкранку");
                PlatformLayer.Ads.ShowInterstitial();
                allowFullscreenAd = false;
            } else {
                passOpenAd.Invoke();
            }
        }

        // 2024-02-25 18:12:01 делать рекламу на перезапуске игры до проигрыша
        // это невероятная костыльная тупизна, не верю, что мне приходится это делать
        // нужно отловить момент, когда таймер закончился и открыть возможность для рекламы
        void Update () {
            //if (!allowFullscreenAd && YandexGame.timerShowAd >= YandexGame.Instance.infoYG.fullscreenAdInterval) allowFullscreenAd = true; // старый плагин
            //if (!allowFullscreenAd && YGWRAP.isTimerAdvCompleted) allowFullscreenAd = true; // https://max-games.ru/plugin-yg/doc/inter-ad/
            if (!allowFullscreenAd && PlatformLayer.Ads.IsInterstitialReady) allowFullscreenAd = true; // https://max-games.ru/plugin-yg/doc/inter-ad/
        }

    }

}
