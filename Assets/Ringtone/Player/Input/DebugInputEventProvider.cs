using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Ringtone.Player.Input
{
    public class DebugInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch { get; } = new ReactiveProperty<Vector2>();
    }
}