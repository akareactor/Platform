namespace KulibinSpace.Platform {

    public interface IPlatformProvider {
        string Language { get; }
        void GameReady ();
    }

}
