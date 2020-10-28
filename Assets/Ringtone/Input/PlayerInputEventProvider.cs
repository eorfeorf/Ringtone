using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Ringtone.Player.Input
{
    public class PlayerInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch { get; } = new ReactiveProperty<Vector2>();
    }
}