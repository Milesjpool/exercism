using System.Collections.Generic;

namespace ScrabbleTrans
{
    public static class ScrabbleTransform
    {
        public static object Transform(Dictionary<int, IList<string>> oldData)
        {
            var newData = new Dictionary<string, int>();

            OldDictionaryToNewDictionary(oldData, newData);
            
            return newData;
        }

        private static void OldDictionaryToNewDictionary(Dictionary<int, IList<string>> oldData, Dictionary<string, int> newData)
        {
            foreach (KeyValuePair<int, IList<string>> pair in oldData)
            {
                AddPairsToNewDictionary(newData, pair);
            }
        }

        private static void AddPairsToNewDictionary(Dictionary<string, int> newData, KeyValuePair<int, IList<string>> pair)
        {
            foreach (string s in pair.Value)
            {
                newData.Add(s.ToLower(), pair.Key);
            }
        }
    }
}