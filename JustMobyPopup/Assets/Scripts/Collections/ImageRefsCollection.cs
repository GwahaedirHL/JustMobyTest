using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.UI
{
    [CreateAssetMenu(fileName = "ImageRefsCollection", menuName = "ScriptableObjects/ImageRefsCollection")]
    public class ImageRefsCollection : ScriptableObject
    {
        [SerializeField]
        AssetReferenceSprite[] imageRefs;

        public AssetReferenceSprite[] ImageRefs => imageRefs;
    }
}
