using System.Collections;
using System.Collections.Generic;
using Ringtone.Notes;
using Ringtone.Scripts.Notes;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace Ringtone.Notes
{
    public sealed class NoteTap : BaseNote
    {
        public override void Judge()
        {
            // TODO:節で判定
            // ひとまず単純な時間差で判定
            float subTime = touchTime - startTime;
            
            // touchTimeがどれくらいjudgeTimeに離れているか？
            float judgeSubTime = Mathf.Abs(judgeTime - subTime);

            isJudge.Value = GetRank(judgeSubTime);
            Destroy(gameObject);
        }
    }
}