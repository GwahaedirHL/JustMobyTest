using Game.Items;
using Game.Popups;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Serialization
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemData", order = 2)]
    public class ItemData : ScriptableObject
    {
        [SerializeField]
        AssetReferenceSprite spriteRef;

        [SerializeField]
        ItemType itemID;

        public AssetReferenceSprite SpriteRef => spriteRef;
    }
}
