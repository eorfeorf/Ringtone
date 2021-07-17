using System;
using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using UniRx;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Ringtone.Notes
{
    public class NotesFactory : MonoBehaviour
    {
        private NotePrefabsScriptableObject notePrefabPrefabs;

        private void Awake()
        {
            notePrefabPrefabs = ScriptableObject.CreateInstance<NotePrefabsScriptableObject>();
        }

        private void CreateNotesData()
        {
            
        }
        
        private BaseNote Create(Type type, float judgeTime, float startTime)
        {
            var note = Instantiate(notePrefabPrefabs.Notes[(int) type]);
            note.Initialize(type, judgeTime, startTime);

            return note;
        }
    }
}