using System;

namespace Game.Items
{
    [Serializable]
    public class Silver : IItem
    {
        public ItemType ID => ItemType.Silver;
    }
}
