using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


namespace Ringtone.Touch
{
    /// <summary>
    /// タッチを行うインターフェイス。
    /// </summary>
    public interface ITouchable
    {
        /// <summary>
        /// true:タッチ前
        /// false:タッチ後
        /// </summary>
        IReadOnlyReactiveProperty<bool> IsTouch { get; }

        void Touch();
    }
}