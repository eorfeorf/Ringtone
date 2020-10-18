using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using Ringtone.Player.Input;
using UniRx;
using UnityEngine;

namespace Ringtone.Player
{
    public class PlayerNoteJudge : MonoBehaviour
    {
        public IReadOnlyReactiveProperty<IJudgeable> CurrentJudge;
        
        private IInputEventProvider inputEventProvider;

        public void SetInputEventProvider(IInputEventProvider provider)
        {
            inputEventProvider = provider;
        }
    }
}