using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ringtone.Notes
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/NotePrefabsScriptableObject", order = 1)]
    public class NotePrefabsScriptableObject : ScriptableObject
    {
        public BaseNote[] Notes;
    }
}