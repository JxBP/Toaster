namespace Toaster
{
    internal class Languages
    {
        public static string? GetToastTitle(string language)
        {
            return language switch
            {
                "en" => "New Notification",
                "de" => "Neue Benachrichtigung",
                _ => null,
            };
        }
    }
}
