using System.Collections;
using System.Collections.Generic;
using Ringtone.Managers.Internal;
using UnityEngine;

namespace Ringtone.Managers
{
    public class StageManager : MonoBehaviour
    {
        private readonly IStageTimeManager stageTimeManager;
        

        public StageManager(StageTimeManager stageTimeManager)
        {
            this.stageTimeManager = stageTimeManager;
        }

        public void StageStart()
        {
            stageTimeManager.Start();
        }

        public void StageEnd()
        {
            stageTimeManager.Reset();
        }

        public void StagePause()
        {
            
        }

        public void CreateNotesData()
        {
            
        }
    }
}