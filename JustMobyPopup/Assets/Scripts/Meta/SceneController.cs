using AssetOperations;
using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Popups
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField]
        Canvas canvas;

        public static SceneController Inst;
        static bool isOpened;

        public void Awake()
        {
            isOpened = false;
            Inst = this;
        }

        public async UniTask<LoadOperationResult<V>> LoadPopupAsync<V>(PopupModel model, CancellationToken cancellationToken) where V : PopupView 
        {
            if (isOpened)
                return new LoadOperationResult<V>(); 

            var loadOperation = Addressables.LoadAssetAsync<GameObject>(model.LoadKey);            
            await UniTask.WhenAny(loadOperation.ToUniTask(), UniTask.WaitUntilCanceled(cancellationToken));

            if (cancellationToken.IsCancellationRequested)
            {
                if (loadOperation.IsValid())
                {
                    Addressables.Release(loadOperation);
                }
                return new LoadOperationResult<V>();
            }

            if (loadOperation.Result == null)
            {
                Addressables.Release(loadOperation);
                return new LoadOperationResult<V>();
            }

            GameObject popupGO = Instantiate(loadOperation.Result, canvas.transform, false);
            popupGO.SetActive(false);
            popupGO.TryGetComponent<V>(out V popup);
            isOpened = true;

            popup.Closing += () =>
            {
                if (loadOperation.IsValid())
                    Addressables.Release(loadOperation);

                isOpened = false;
            };

            return new LoadOperationResult<V>(popup);
        }
    }
}
