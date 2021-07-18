using UniRx;
using UnityEngine;

namespace Ringtone.Scripts.Input
{
    public interface IInputEventProvider
    {
        IReadOnlyReactiveProperty<Vector2> Touch { get; }
    }
}