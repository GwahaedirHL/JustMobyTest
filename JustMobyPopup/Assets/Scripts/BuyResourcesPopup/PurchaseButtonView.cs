using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

namespace Game.Popups
{
    public class PurchaseButtonView : MonoBehaviour
    {
        [SerializeField]
        TextMeshProUGUI crossedPriceText;

        [SerializeField]
        TextMeshProUGUI mainPriceText;

        [SerializeField]
        TextMeshProUGUI discountLableText;

        [SerializeField]
        GameObject discountlable;

        [SerializeField]
        Button button;

        const string discountFormat = "-{0}%";
        const string priceFormat = "${0}";
        public ButtonClickedEvent OnClick => button.onClick;

        public void Draw(PriceData priceData)
        {
            var mainPrice = priceData.HasDiscount ? priceData.DiscountCost.ToString() : priceData.FullCost.ToString();
            mainPriceText.text = string.Format(priceFormat, mainPrice);
            crossedPriceText.text = string.Format(priceFormat, priceData.FullCost.ToString());
            discountLableText.text = string.Format(discountFormat, priceData.Discount.ToString());

            discountlable.gameObject.SetActive(priceData.HasDiscount);
            crossedPriceText.gameObject.SetActive(priceData.HasDiscount);
        }
    }
}
