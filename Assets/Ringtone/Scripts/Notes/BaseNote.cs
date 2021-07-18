using System;
using Ringtone.Scripts.Judge;
using Ringtone.Touch;
using UniRx;
using UnityEngine;
using Type = Ringtone.Notes.Type;

namespace Ringtone.Scripts.Notes
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseNote : MonoBehaviour, IJudgeable, ITouchable
    {
        public IReadOnlyReactiveProperty<bool> IsTouch => isTouch;
        private readonly ReactiveProperty<bool> isTouch = new ReactiveProperty<bool>();
        public IReadOnlyReactiveProperty<Rank> IsJudge => isJudge;
        protected readonly ReactiveProperty<Rank> isJudge = new ReactiveProperty<Rank>();

        public int Id => id;
        
        // ノーツタイプ
        protected Type type;
        // 判定タイミング
        protected float judgeTime;
        // タップしたタイミング
        protected float touchTime;
        protected float startTime; // 決定論だとpauseに対応できない？

        protected int id;

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

        public void Initialize(Type type, float judgeTime, float startTime, int id)
        {
            this.type = type;
            this.judgeTime = judgeTime;
            this.startTime = startTime;
            this.id = id;
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
        
        protected Rank GetRank(float judgeSubTime)
        {
            // 差分の大きさでランクを決める
            // TODO:差分のテーブルを定義
            // TODO:正しい１フレームの時間を取得する
            float oneFrame = 1f / 60f;

            if (judgeSubTime < oneFrame * 2)
            {
                return Rank.Perfect;
            }
            else if (judgeSubTime < oneFrame * 4)
            {
                return Rank.Great;
            }
            else if (judgeSubTime < oneFrame * 6)
            {
                return Rank.Good;
            }
            else if (judgeSubTime < oneFrame * 8)
            {
                return Rank.Bad;
            }
            else
            {
                return Rank.Miss;
            }
        }
    }
}