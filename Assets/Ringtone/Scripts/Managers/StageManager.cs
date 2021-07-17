using Ringtone.Scripts.MusicScore;
using UnityEngine;

namespace Ringtone.Scripts.Managers
{
    public class StageManager : MonoBehaviour
    {
        private readonly IStageTimeManager stageTimeManager = new StageTimeManager();
        private readonly NoteDataLoader noteDataLoader = new NoteDataLoader();
        
        private int musicScoreId;
        
        public StageManager(int musicScoreId)
        {
            this.musicScoreId = musicScoreId;
        }

        public void StageStart()
        {
            stageTimeManager.Start();
            noteDataLoader.Load(musicScoreId);
        }

        public void StageEnd()
        {
            stageTimeManager.Reset();
        }

        public void StageReset()
        {
            
        }

        public void StagePause()
        {
            
        }
    }
}