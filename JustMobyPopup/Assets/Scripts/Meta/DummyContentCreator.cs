using Game.Items;
using Game.Popups;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public class DummyContentCreator : MonoBehaviour
    {
        [SerializeField]
        ItemsCollection itemsCollection;

        [SerializeField]
        TextCollection textCollection;

        [SerializeField]
        ImageRefsCollection imageKeysCollection;        

        public BuyResourcesPopupModel CreateDummyModel(int itemsCount) 
        {
            var random = new System.Random();
            var rewards = new List<RewardItem>();

            for (int i = 0; i < itemsCount; i++)
            {
                var item = itemsCollection.Collection[i];
                rewards.Add(new RewardItem(item, random.Next(5, 200)));
            }

            var header = textCollection.Headers[random.Next(textCollection.Headers.Length)];
            var description = textCollection.Descriptions[random.Next(textCollection.Descriptions.Length)];
            var imageRef = imageKeysCollection.ImageRefs[random.Next(imageKeysCollection.ImageRefs.Length)];
            var cost = random.Next(100, 1000);
            var discount = random.Next(100);
            discount = discount > 50 ? 0 : discount;

            return new BuyResourcesPopupModel(cost, discount)
            {
                DescriptionText = description,
                HeaderText = header,
                ImageRef = imageRef,
                Rewards = rewards.ToArray()
            };
        }

    }
}
