using System.Collections.Generic;

namespace Ringtone.Scripts.MusicScore
{
    public class MusicScoreRepository
    {
        public IDictionary<int, global::Ringtone.Scripts.MusicScore.MusicScore> Repogitory => repogitory;

        private readonly Dictionary<int, global::Ringtone.Scripts.MusicScore.MusicScore> repogitory = new Dictionary<int, global::Ringtone.Scripts.MusicScore.MusicScore>();
    }
}