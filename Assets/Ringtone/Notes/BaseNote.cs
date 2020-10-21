using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using Ringtone.Touch;
using UniRx;
using UnityEngine;

namespace Ringtone.Notes
{
    public class BaseNote : MonoBehaviour, IJudgeable, ITouchable
    {
        public IReadOnlyReactiveProperty<bool> IsTouch => isTouch;
        private readonly ReactiveProperty<bool> isTouch = new ReactiveProperty<bool>();
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