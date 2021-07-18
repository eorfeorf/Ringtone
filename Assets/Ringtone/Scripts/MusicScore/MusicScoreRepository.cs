using System.Collections.Generic;

namespace Ringtone.Scripts.MusicScore
{
    public class MusicScoreRepository
    {
        public IDictionary<int, GameInfo.GameInfo.MusicScoreScriptableObject> Data => repogitory;

        private readonly Dictionary<int, GameInfo.GameInfo.MusicScoreScriptableObject> repogitory = new Dictionary<int, GameInfo.GameInfo.MusicScoreScriptableObject>();
    }
}