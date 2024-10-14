using Game.Serialization;
using UnityEngine;

namespace Game.Items
{
    [CreateAssetMenu(fileName = "ItemsCollection", menuName = "ScriptableObjects/ItemsCollection")]
    public class ItemsCollection : ScriptableObject
    {
        [SerializeField]
        ItemData[] items;

        public int ItemsCount => items.Length;
        public ItemData[] Collection => items;
    }
}
