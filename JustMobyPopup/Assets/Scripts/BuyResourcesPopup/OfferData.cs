using Game.Items;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Serialization
{
    [CreateAssetMenu(fileName = "OfferData", menuName = "ScriptableObjects/OfferData", order = 1)]
    public class OfferData : ScriptableObject
    {
        [SerializeField]
        RewardItem[] rewardItems;

        [SerializeReference]
        AssetReference offerImage;

        [SerializeField]
        float fullPrice;

        [SerializeField]
        int discount;
    }
}
