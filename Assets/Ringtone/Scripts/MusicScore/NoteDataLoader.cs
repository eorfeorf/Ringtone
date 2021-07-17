namespace Ringtone.Scripts.MusicScore
{
    public class NoteDataLoader
    {
        private MusicScoreRepository repogitory;

        public NoteDataLoader()
        {
            // TODO:GameManagerから引っ張ってくる？Injectする？
            repogitory = new MusicScoreRepository();
        }
        
        public void Load(int musicScoreId)
        {
            // 
        }
    }
}
