using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using Ringtone.Notes;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace Ringtone.Notes
{
    public sealed class NoteTap : BaseNote
    {
        public override void Judge()
        {
            isJudge.Value = Rank.Perfect;
            Destroy(gameObject);
        }
    }
}