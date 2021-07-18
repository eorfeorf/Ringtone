using System;
using System.Globalization;
using System.IO;
using Ringtone.Notes;
using Ringtone.Scripts.Notes;
using UnityEngine;
using Type = Ringtone.Notes.Type;

namespace Ringtone.Scripts.MusicScore
{
    public class NoteDataLoader
    {
        private NotesRepository notesRepository;
        private NotesFactory notesFactory;
        
        public NoteDataLoader(NotesRepository notesRepository, NotesFactory notesFactory)
        {
            // TODO:GameManagerから引っ張ってくる？Injectする？
            this.notesRepository = notesRepository;
            this.notesFactory = notesFactory;
        }

        public void Load(string path)
        {
            int id = 0;

            // TODO:ひとまずCSV形式で読み込む。データフォーマットを考える
            // TODO:実際のパスに置き換える
            
            using var reader = new StreamReader(path);

            while (reader.Peek() != -1)
            {
                var line = reader.ReadLine();
                var param = line.Split(',');

                Type type = (Type)Int32.Parse(param[0]);
                float time = float.Parse(param[1]);
                
                var note = notesFactory.Create(type, time, 0f, id++);
                notesRepository.Add(note);    
            }
        }
    }
}
