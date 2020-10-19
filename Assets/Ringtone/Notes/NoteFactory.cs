using System.Collections;
using System.Collections.Generic;
using Ringtone.Judge;
using UniRx;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Ringtone.Notes
{
    public class NoteFactory : MonoBehaviour
    {
        private NotePrefabsScriptableObject _notePrefabPrefabs = ScriptableObject.CreateInstance<NotePrefabsScriptableObject>();
        
        public BaseNote Create(Type type)
        {
            return Instantiate(_notePrefabPrefabs.Notes[(int) type]);
        }
    }
}