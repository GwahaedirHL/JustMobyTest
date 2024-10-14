using UnityEngine;
using UnityEngine.Events;

namespace Game.Popups
{
    public abstract class PopupView : MonoBehaviour
    {
        public event UnityAction Closing;

        public virtual void Close()
        {
            Closing?.Invoke();
            Destroy(gameObject);
        }
    }
}