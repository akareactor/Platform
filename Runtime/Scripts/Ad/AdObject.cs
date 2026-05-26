using UnityEngine;
using UnityEngine.Events;

namespace KulibinSpace.Platform {

    // 2024-02-25 21:05:10 Особый объект-слушатель, подписывается на события рекламы, может себя удалить для выключения контура управления
    public class AdObject : MonoBehaviour {

        public UnityEvent onCloseFullAd; // отложенный слушатель 

        void OnEnable () {
            PlatformLayer.Ads.OnCloseAd += CloseFullAd;
        }

        void OnDisable () {
            PlatformLayer.Ads.OnCloseAd -= CloseFullAd;
        }

        public void SelfDestroy () {
            Destroy(gameObject);
        }

        void CloseFullAd () {
            onCloseFullAd?.Invoke();
        }

    }

}
