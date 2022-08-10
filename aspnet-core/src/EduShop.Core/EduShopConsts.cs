using EduShop.Debugging;

namespace EduShop
{
    public class EduShopConsts
    {
        public const string LocalizationSourceName = "EduShop";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "96af5fbb6b5144f89aae51c02a67cfb1";
    }
}
