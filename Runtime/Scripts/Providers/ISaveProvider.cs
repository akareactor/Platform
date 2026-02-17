namespace KulibinSpace.Platform {

    public interface ISaveProvider {
        SavedGame Get ();
        void Set (SavedGame game);
        void Save ();
        void Reset ();
    }

}
