using System;

namespace Game.Items
{
    [Serializable]
    public class Mushroom : IItem
    {
        public ItemType ID => ItemType.Mushroom;
    }
}
