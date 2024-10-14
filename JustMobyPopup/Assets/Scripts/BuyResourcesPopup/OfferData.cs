using Game.Items;
using Game.Popups;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Serialization
{
    [CreateAssetMenu(fileName = "OfferData", menuName = "ScriptableObjects/OfferData", order = 1)]
    public class OfferData : ScriptableObject
    {
        [SerializeField]
        string headerText;

        [SerializeField]
        string descriptionText;

        [SerializeField]
        RewardItem[] rewardItems;

        [SerializeField]
        AssetReferenceSprite imageRef;

        [SerializeField]
        PriceData priceData;

        public string HeaderText => headerText;
        public string DescriptionText => descriptionText;
        public RewardItem[] RewardItems => rewardItems;
        public AssetReferenceSprite ImageRef => imageRef;
        public PriceData PriceData => priceData;
    }
}
