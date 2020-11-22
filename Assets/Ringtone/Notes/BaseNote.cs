using System;
using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using Ringtone.Touch;
using UniRx;
using UnityEngine;

namespace Ringtone.Notes
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseNote : MonoBehaviour, IJudgeable, ITouchable
    {
        public IReadOnlyReactiveProperty<bool> IsTouch => isTouch;
        private readonly ReactiveProperty<bool> isTouch = new ReactiveProperty<bool>();
        
        public IReadOnlyReactiveProperty<Judge.Rank> IsJudge => isJudge;
        protected readonly ReactiveProperty<Rank> isJudge = new ReactiveProperty<Rank>();
        
        public Type Type => type;
        private Type type;

        private void Awake()
        {
            isTouch.SkipLatestValueOnSubscribe().Subscribe(isTouch =>
            {
                if (isTouch)
                {
                    Judge();
                }
            }).AddTo(this);
        }

        public void Initialize(Type type)
        {
            this.type = type;
        }
        
        public virtual void Judge()
        {
            throw new NotImplementedException();
        }

        public void Touch()
        {
            isTouch.Value = true;
        }

        public void Untouch()
        {
            isTouch.Value = false;
        }
    }
}