using Cysharp.Threading.Tasks;
using Game.Items;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Popups
{
    public class BuyResorcesPopupView : PopupView
    {
        [SerializeField]
        TextMeshProUGUI headerText;

        [SerializeField]
        TextMeshProUGUI descriptionText;

        [SerializeField]
        PurchaseButtonView purchaseButton;

        [SerializeField]
        Button closeButton;

        [SerializeField]
        DoubleRowLayout itemsLayout;

        [SerializeField]
        Image offerImage;

        public event UnityAction Buy;

        public async UniTask Draw(string headerText,
                                  string descriptionText,
                                  Sprite offerSprite,
                                  RewardItem[] items,
                                  PriceData priceData)
        {
            this.headerText.text = headerText;
            this.descriptionText.text = descriptionText;
            offerImage.sprite = offerSprite;
            await itemsLayout.Init(items);
            closeButton.onClick.AddListener(Close);
            purchaseButton.OnClick.AddListener(() => Buy?.Invoke());
            purchaseButton.Draw(priceData);
            gameObject.SetActive(true);
        }        
    }
}
