using System.Threading.Tasks;
using mm = UnityMethods.MonobehaivourMethods;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace UnityMethods
{
    public static class Methods
    {
        public static void DebugInConsole(string msg)
        {
            mm.print(msg);
        }
        public static void CreateRandom(int minVal, int maxVal)
        {
            Random.Range(minVal, maxVal);
        }
        public static void CreateRandomFloat(float minVal, float maxVal)
        {
            Random.Range(minVal, maxVal);
        }
        public static void ChangeText(string text, Text TextToChange) => TextToChange.text = text;
        public static IEnumerator WaitForSeconds(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            yield return null;
        }
    }
}
