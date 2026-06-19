using UnityEngine;

namespace KulibinSpace.Platform {

    public interface IPlatformProvider {
        string Language { get; }
        void GameReady ();
        DeviceType deviceType { get; }
    }

}
