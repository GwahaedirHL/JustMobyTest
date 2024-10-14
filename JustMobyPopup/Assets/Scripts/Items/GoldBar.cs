using System;

namespace Game.Items
{
    [Serializable]
    public class GoldBar : IItem
    {
        public ItemType ID => ItemType.GoldBar;
    }
}
