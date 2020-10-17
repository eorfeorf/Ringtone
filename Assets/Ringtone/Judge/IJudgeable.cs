using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


namespace Ringtone.Judge
{
    public interface IJudgeable
    {
        IReadOnlyReactiveProperty<bool> IsJudge { get; }
        Rank Judge();
    }
}