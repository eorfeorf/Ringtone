using System;
using System.Collections;
using System.Collections.Generic;
using Ringtone.Player.Input;
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
            inputEventProvider.Touch.Subscribe(touchPos =>
            {
                // タッチしたら判定する.
                
            }).AddTo(this);
        }
    }
}