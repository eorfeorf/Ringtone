using System;
using UniRx;
using UnityEngine;

namespace Ringtone.Input
{
    public class PlayerInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch { get; } = new ReactiveProperty<Vector2>();

        private void Awake()
        {
            Touch.Subscribe(Touched).AddTo(this);
        }

        private void Touched(Vector2 pos)
        {
            //　座標を使ってノーツとの衝突判定を行う
            
        }
    }
}