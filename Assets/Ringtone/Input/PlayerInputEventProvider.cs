using UniRx;
using UnityEngine;

namespace Ringtone.Input
{
    public class PlayerInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch { get; } = new ReactiveProperty<Vector2>();
    }
}