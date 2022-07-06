using UnityEngine;
/*
 * Abstract base code for UI views
 * It is used by the view manager 
 */
namespace Eyes4Eye.UI
{
    public abstract class View : MonoBehaviour
    {

        public bool IsInitialized { get; private set; }

        public virtual void Initialize()
        {
            IsInitialized = true;
        }

        public virtual void Show()
        {
            gameObject.SetActive(true);
        }
        
        public virtual void Hide()
        {
            gameObject.SetActive(false);
        }

    }

}