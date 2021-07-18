using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ringtone.Scripts.Notes
{
    public class NotesRepository
    {
        public IDictionary Data => repogitory;
        private Dictionary<int, BaseNote> repogitory = new Dictionary<int, BaseNote>();

        public void Add(BaseNote note)
        {
            repogitory[note.Id] = note;
        }
    }
}
