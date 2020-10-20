using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using Ringtone.Notes;
using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace Ringtone.Notes
{
    public class NoteTap : BaseNote
    {    
        public override Rank Judge()
        {
            return Rank.Perfect;
        }
    }
}