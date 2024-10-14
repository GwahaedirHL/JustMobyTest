using System;

namespace Game.Items
{
    [Serializable]
    public class GoldCoin : IItem
    {
        public ItemType ID => ItemType.GoldCoin;
    }
}
