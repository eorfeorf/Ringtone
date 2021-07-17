using UnityEngine;

namespace Ringtone.Scripts.Managers
{
    public interface IStageTimeManager
    {
        void Start();
        void Reset();
        float GetTime();
    }

    public sealed class StageTimeManager : IStageTimeManager
    {
        private float stageTime;
        
        public void Start()
        {
            stageTime = Time.time;
        }

        public void Reset()
        {
            stageTime = 0f;
        }

        public float GetTime()
        {
            return stageTime;
        }
    }
}