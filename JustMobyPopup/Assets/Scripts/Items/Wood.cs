using System;

namespace Game.Items
{
    [Serializable]
    public class Wood : IItem
    {
        public ItemType ID => ItemType.Wood;
    }
}
