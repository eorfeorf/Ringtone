using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using UniRx;
using UnityEngine;

namespace Ringtone.Notes
{
    public class BaseNote : MonoBehaviour, IJudgeable
    {
        public IReadOnlyReactiveProperty<bool> IsJudge { get; }

        public Rank Judge()
        {
            return Rank.Perfect;
        }
    }
}