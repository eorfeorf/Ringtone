using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


namespace Ringtone.Touch
{
    public interface ITouchable
    {
        IReadOnlyReactiveProperty<bool> IsTouch { get; }
    }
}