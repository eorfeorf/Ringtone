using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using UniRx;
using UnityEngine;

namespace Ringtone.Notes
{
    public class BaseNote : MonoBehaviour, IJudgeable
    {
        public IReadOnlyReactiveProperty<bool> IsJudge => isJudge;
        private readonly ReactiveProperty<bool> isJudge = new ReactiveProperty<bool>();
        public Type Type => type;
        private Type type;

        public void Initialize(Type type)
        {
            this.type = type;
        }

        public virtual Rank Judge()
        {
            return Rank.Miss;
        }
    }
}