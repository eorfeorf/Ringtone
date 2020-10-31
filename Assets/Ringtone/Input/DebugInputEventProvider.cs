using UniRx;
using UnityEngine;

namespace Ringtone.Input
{
    public class DebugInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch { get; } = new ReactiveProperty<Vector2>();
    }
}