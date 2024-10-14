using Game.Popups;
using Game.Serialization;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Items
{
    [Serializable]
    public struct RewardItem
    {
        [SerializeField]
        public ItemData ItemData;
        public int Count;

        public RewardItem(ItemData itemData, int count)
        {
            ItemData = itemData;
            Count = count;
        }
    }
}
