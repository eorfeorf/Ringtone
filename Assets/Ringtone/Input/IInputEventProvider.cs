using UniRx;
using UnityEngine;


namespace Ringtone.Input
{
    public interface IInputEventProvider
    {
        IReadOnlyReactiveProperty<Vector2> Touch { get; }
    }
}