using System;
using UniRx;
using UnityEngine;

namespace Ringtone.Input
{
    public class DebugInputEventProvider : MonoBehaviour, IInputEventProvider
    {
        public IReadOnlyReactiveProperty<Vector2> Touch => touch;
        private ReactiveProperty<Vector2> touch = new ReactiveProperty<Vector2>();

        private int noteLayer;

        private void Awake()
        {
            noteLayer = LayerMask.GetMask("Note");
        }

        private void Update()
        {
            // クリックしたら座標を計算して座標を入れる
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                Debug.Log("[InputEventProvider] Clicked");
                var clieckPos = UnityEngine.Input.mousePosition;

                Ray ray = Camera.main.ScreenPointToRay(clieckPos);

                //RaycastFrom3D(ray);
                RaycastFrom2D(ray);
            }
        }

        private void RaycastFrom2D(Ray ray)
        {
            var hit = Physics2D.Raycast((Vector2) ray.origin, (Vector2) ray.direction, noteLayer);
            if (hit.collider != null)
            {
                Hit(hit.point);
            }
        }

        private void RaycastFrom3D(Ray ray)
        {
            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.collider != null)
                {
                    Hit(hit.point);
                }
            }
        }

        private void Hit(Vector2 hitPos)
        {
            Debug.Log($"[InputEventProvider] Touched {hitPos}");
            touch.Value = hitPos;
        }
    }
}