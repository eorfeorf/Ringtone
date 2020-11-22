using Ringtone.Input;
using Ringtone.Touch;
using UniRx;
using UnityEngine;

namespace Ringtone.Player
{
    public class PlayerNoteToucher : MonoBehaviour
    {
        public IReadOnlyReactiveProperty<ITouchable> CurrentTouch;
        
        private IInputEventProvider inputEventProvider;

        public void SetInputEventProvider(IInputEventProvider provider)
        {
            inputEventProvider = provider;
        }
        
        private void Awake()
        {
            inputEventProvider = GameObject.Find("InputEventProvider").GetComponent<IInputEventProvider>();
            
            inputEventProvider.Touch.Subscribe(touchPos =>
            {
                // タッチしたら判定する.
                Debug.Log("Note Touch!");
            }).AddTo(this);
        }
    }
}