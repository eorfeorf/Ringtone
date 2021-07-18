using UniRx;
using UnityEngine;

namespace Ringtone.Scripts.Input
{
    /// <summary>
    /// デバッグ入力を検出して座標をイベントに流すクラス。
    /// </summary>
    public class DebugInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch => touch;
        private ReactiveProperty<Vector2> touch = new ReactiveProperty<Vector2>();

        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                Debug.Log("[InputEventProvider] Clicked");
                touch.Value = UnityEngine.Input.mousePosition;
            }
        }
    }
}