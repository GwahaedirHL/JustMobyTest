using Game.Popups;
using Game.Serialization;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Items
{
    public struct RewardItem
    {
        public readonly ItemData ItemData;
        public readonly int Count;

        public RewardItem(ItemData itemData, int count)
        {
            ItemData = itemData;
            Count = count;
        }
    }
}
