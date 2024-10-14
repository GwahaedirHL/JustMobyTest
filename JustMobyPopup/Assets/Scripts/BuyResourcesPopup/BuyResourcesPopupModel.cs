using Game.Items;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Popups
{
    public class BuyResourcesPopupModel : PopupModel
    {
        public override object LoadKey => "Assets/Prefabs/OfferView.prefab";

        //Предпологается что сюда передается обект OfferData и из него заполняются поля,
        //но мы рандомим в рантайме все значения. Поэтому публичные свойства.
        public RewardItem[] Rewards { get; set; }
        public AssetReferenceSprite ImageRef { get; set; }
        public string DescriptionText { get; set; }
        public string HeaderText { get; set; }
        public PriceData PriceData => priceData;

        PriceData priceData;

        public BuyResourcesPopupModel(float cost, int discount = 0)
        {
            priceData = new PriceData(cost, discount);
        }

        public void Buy()
        {
            Debug.Log("Purchased");
        }
    }
}
