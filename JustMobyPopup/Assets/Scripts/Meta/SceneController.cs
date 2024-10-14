using AssetOperations;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Popups
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField]
        Canvas canvas;

        public static SceneController Inst;

        public void Awake()
        {
            Inst = this;
        }

        public async UniTask<LoadOperationResult<V>> LoadPopupAsync<V>(PopupModel model) where V : PopupView 
        {
            var loadOperation = Addressables.LoadAssetAsync<GameObject>(model.LoadKey);
            await loadOperation.Task;

            if (loadOperation.Result == null)
            {
                Addressables.Release(loadOperation);
                return new LoadOperationResult<V>();
            }

            GameObject popupGO = Instantiate(loadOperation.Result, canvas.transform, false);
            popupGO.SetActive(false);
            popupGO.TryGetComponent<V>(out V popup);

            popup.Closing += () =>
            {
                if (loadOperation.IsValid())
                    Addressables.Release(loadOperation);
            };

            return new LoadOperationResult<V>(popup);
        }
    }
}
