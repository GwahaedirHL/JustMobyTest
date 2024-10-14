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

        [SerializeReference, SelectType(typeof(GoldCoin))]
        IItem item;

        public AssetReferenceSprite SpriteRef => spriteRef;
    }
}
