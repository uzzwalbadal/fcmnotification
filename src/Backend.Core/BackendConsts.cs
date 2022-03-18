using Backend.Debugging;

namespace Backend
{
    public class BackendConsts
    {
        public const string LocalizationSourceName = "Backend";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "0ed345ca60d2476191814a8f5a5e9e88";
    }
}
