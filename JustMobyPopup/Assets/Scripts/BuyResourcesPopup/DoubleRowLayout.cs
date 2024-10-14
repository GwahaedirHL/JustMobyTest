using Cysharp.Threading.Tasks;
using Game.Items;
using UnityEngine;

namespace Game.Popups
{
    public class DoubleRowLayout : MonoBehaviour
    {
        [SerializeField]
        Transform firstRow;

        [SerializeField]
        Transform secondRow;

        [SerializeField]
        ItemView itemViewPrefab;

        public async UniTask Init(RewardItem[] itemViews)
        {
            int half = Mathf.Min(3, itemViews.Length);

            for (int i = 0; i < itemViews.Length; i++)
            {
                Transform parentRow = i < half ? firstRow : secondRow;

                var view = Instantiate(itemViewPrefab, parentRow, false);
                await view.Draw(itemViews[i].ItemData.SpriteRef, itemViews[i].Count);
                view.gameObject.SetActive(true);
            }
        }
    }
}
