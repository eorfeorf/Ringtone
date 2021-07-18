using UnityEngine;

namespace Ringtone.Scripts.GameInfo
{
    public class GameInfo : ScriptableObject
    {
        public class MusicScoreScriptableObject
        {
            public int Id;
            public int Bpm;
            public int Level;
            public string Path;
        }

        public class NoteScriptableObject
        {
            public int type;
            public float time;
        }
    }
}
