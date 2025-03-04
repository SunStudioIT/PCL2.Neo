using System.Threading.Tasks;

namespace PCL2.Neo.Helpers
{
    public static class NotificationHelper
    {
        public static async Task<int> ShowMessageAsync(string message)
        {
            return await ShowMessageAsync(message, "提示");
        }

        public static async Task<int> ShowMessageAsync(string message, string title)
        {
            // 没做完
            return 0;
        }
    }
}