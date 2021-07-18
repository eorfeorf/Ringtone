using System;
using System.Collections;
using System.Collections.Generic;
using Ringtone.Scripts.Notes;
using UniRx;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Ringtone.Notes
{
    public class NotesFactory : MonoBehaviour
    {
        [SerializeField]
        private NotePrefabsScriptableObject notePrefabs;
        [SerializeField]
        private BaseNote notePrefabsTap;


        private void Awake()
        {
        }

        private void CreateNotesData()
        {
            
        }
        
        public BaseNote Create(Type type, float judgeTime, float startTime, int id)
        {
            //var note = Instantiate(notePrefabs.Notes[(int) type]);
            var note = Instantiate(notePrefabsTap);
            note.Initialize(type, judgeTime, startTime, id);

            return note;
        }
    }
}