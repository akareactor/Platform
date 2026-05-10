using System;

namespace KulibinSpace.Platform {

    public static class SaveGameTypeRegistry {
        public static Func<SavedGame> Create;
    }

}
