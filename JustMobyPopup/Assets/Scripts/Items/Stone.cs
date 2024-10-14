using System;

namespace Game.Items
{
    [Serializable]
    public class Stone : IItem
    {
        public ItemType ID => ItemType.Stone;
    }
}
