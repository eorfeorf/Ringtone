using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


namespace Ringtone.Judge
{
    /// <summary>
    /// 判定を行うインターフェイス。
    /// </summary>
    public interface IJudgeable
    {
        /// <summary>
        /// true:判定前
        /// false:判定後
        /// </summary>
        IReadOnlyReactiveProperty<Rank> IsJudge { get; }
        void Judge();
    }
}