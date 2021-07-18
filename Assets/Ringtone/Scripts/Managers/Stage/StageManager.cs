using System;
using Ringtone.Notes;
using Ringtone.Scripts.MusicScore;
using Ringtone.Scripts.Notes;
using UnityEngine;

namespace Ringtone.Scripts.Managers
{
    public class StageManager : MonoBehaviour
    {
        [SerializeField] private NotesFactory notesFactory = new NotesFactory();
        private readonly IStageTimeManager stageTimeManager = new StageTimeManager();
        private MusicScoreRepository musicScoreRepo = new MusicScoreRepository();
        private NotesRepository noteRepository = new NotesRepository();
        private NoteDataLoader noteDataLoader;
        
        private int musicScoreId;

        private void Awake()
        {
            StageStart();
        }

        private void LoadNoteData(int musicScoreId)
        {
            this.musicScoreId = musicScoreId;
        }

        public void StageStart()
        {
            stageTimeManager.Start();
            
            //var musicScore = musicScoreRepo.Data[musicScoreId];
            var path = "D:/Workspace/Ringtone/Assets/Ringtone/Resources/sample.csv";
            noteDataLoader = new NoteDataLoader(noteRepository, notesFactory);
            noteDataLoader.Load(path);
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