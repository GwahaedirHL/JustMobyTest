using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace Game.Popups
{
    public static class AssetReferenceExtention
    {
        public static async UniTask<T> GetAssetAsync<T>(this AssetReferenceT<T> reference) where T : UnityEngine.Object
        {
            var operation = reference.LoadAssetAsync();
            await operation.Task;
            var result = operation.Result;
            reference.ReleaseAsset();
            return result;
        }
    }
}
