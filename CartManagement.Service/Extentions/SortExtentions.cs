using System.Collections.ObjectModel;

namespace CartManagement.Service.Extentions
{
    internal static class SortExtentions
    {
        public static void OrderByReference<T>(this ObservableCollection<T> collection, List<T> comparison)
        {
            for (int i = 0; i < comparison.Count; i++)
            {
                collection.Move(collection.IndexOf(comparison[i]), i);
            }
        }
    }
}
