using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


namespace Ringtone.Player.Input
{
    public interface IInputEventProvider
    {
        IReadOnlyReactiveProperty<Vector2> Touch { get; }
    }
}