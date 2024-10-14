using Cysharp.Threading.Tasks;
using Game.Items;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Game.Popups
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField]
        Image itemIcon;

        [SerializeField]
        Text itemAmountText;

        public async UniTask Draw(AssetReferenceSprite sprite, int itemCount)
        {
            itemIcon.sprite = await sprite.GetAssetAsync();
            itemAmountText.text = itemCount.ToString();
        }
    }
}
