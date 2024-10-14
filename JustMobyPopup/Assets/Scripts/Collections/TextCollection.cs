using UnityEngine;

namespace Game.UI
{
    [CreateAssetMenu(fileName = "TextCollection", menuName = "ScriptableObjects/TextCollection")]
    public class TextCollection : ScriptableObject
    {
        [SerializeField]
        string[] headers;

        [SerializeField]
        string[] descriptions;

        public string[] Headers => headers;
        public string[] Descriptions => descriptions;
    }
}
