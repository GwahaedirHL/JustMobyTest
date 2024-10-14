using AssetOperations;
using Cysharp.Threading.Tasks;
using Game.Popups;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        Button openPopupButton;

        [SerializeField]
        Slider itemsCountSlider;

        [SerializeField]
        TextMeshProUGUI sliderText;

        [SerializeField]
        DummyContentCreator modelCreator;

        int itemsCount;

        void Start()
        {
            itemsCount = (int)itemsCountSlider.value;
            sliderText.text = itemsCount.ToString();

            itemsCountSlider.onValueChanged.AddListener((value) =>
            {
                itemsCount = (int)value;
                sliderText.text = itemsCount.ToString();
            });

            openPopupButton.onClick.AddListener(async () => await OpenPopup());
        }

        async UniTask OpenPopup()
        {
            var model = modelCreator.CreateDummyModel(itemsCount);
            var controller = new BuyResourcesPopupController(model);
            await controller.ShowPopupAsync();            
        }
    }
}