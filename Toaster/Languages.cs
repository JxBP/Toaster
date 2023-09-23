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
                "zh" => "新通知", // Traditional Chinese (Taiwan)
                _ => null,
            };
        }
    }
}
