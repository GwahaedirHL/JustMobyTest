using AssetOperations;
using Cysharp.Threading.Tasks;
using Game.Popups;
using Game.Serialization;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        Button openRandomPopupButton;
        
        [SerializeField]
        Button openPopupButton;

        [SerializeField]
        Slider itemsCountSlider;

        [SerializeField]
        TextMeshProUGUI sliderText;

        [SerializeField]
        DummyContentCreator modelCreator;

        [SerializeField]
        OfferData presetData;

        int itemsCount;
        CancellationTokenSource cts;

        void Start()
        {
            itemsCount = (int)itemsCountSlider.value;
            sliderText.text = itemsCount.ToString();

            itemsCountSlider.onValueChanged.AddListener((value) =>
            {
                itemsCount = (int)value;
                sliderText.text = itemsCount.ToString();
            });

            openRandomPopupButton.onClick.AddListener(async () =>
            {
                EnableUI(false);
                cts?.Cancel();
                await OpenPopup();
            });

            openPopupButton.onClick.AddListener(async () =>
            {
                EnableUI(false);
                cts?.Cancel();
                await OpenPopup(presetData);
            });
        }

        async UniTask OpenPopup(OfferData data = null)
        {
            cts = new CancellationTokenSource();
            BuyResourcesPopupModel model;
            if (data == null)
                model = modelCreator.CreateDummyModel(itemsCount);
            else
                model = new BuyResourcesPopupModel(data);

            var controller = new BuyResourcesPopupController(model);
            await controller.ShowPopupAsync(cts.Token);
            EnableUI(true);
        }

        void EnableUI(bool enable)
        {
            openRandomPopupButton.interactable = enable;
            openPopupButton.interactable = enable;
        }
    }
}