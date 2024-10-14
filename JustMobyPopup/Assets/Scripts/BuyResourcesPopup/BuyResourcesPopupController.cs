using AssetOperations;
using Cysharp.Threading.Tasks;

namespace Game.Popups
{
    public class BuyResourcesPopupController
    {
        BuyResourcesPopupModel model;
        BuyResorcesPopupView view;

        public BuyResourcesPopupController(BuyResourcesPopupModel model)
        {
            this.model = model;
        }

        public async UniTask ShowPopupAsync()
        {
            var operationResult = await SceneController.Inst.LoadPopupAsync<BuyResorcesPopupView>(model);
            if (operationResult.Status != LoadOperationStatus.Succeeded)
                return;

            var sprite = await model.ImageRef.GetAssetAsync();
            view = operationResult.Result;
            view.Buy += OnBuyClick;
            await view.Draw(model.HeaderText, model.DescriptionText, sprite, model.Rewards, model.PriceData);
        }

        void OnBuyClick()
        {
            model.Buy();
            view.Close();
        }       
    }
}
