using System;
using Ringtone.Scripts.Input;
using Ringtone.Touch;
using UniRx;
using UnityEngine;

namespace Ringtone.Player
{
    /// <summary>
    /// 入力イベントの座標からノーツのタッチ判定を行うクラス。
    /// TODO: 離したときの処理
    /// </summary>
    public class PlayerNoteToucher : MonoBehaviour
    {
        public IReadOnlyReactiveProperty<ITouchable> CurrentTouch => currentTouch;
        private ReactiveProperty<ITouchable> currentTouch = new ReactiveProperty<ITouchable>();

        private IInputEventProvider inputEventProvider;
        private int noteLayer;

        public void SetInputEventProvider(IInputEventProvider provider)
        {
            inputEventProvider = provider;
        }

        private void Awake()
        {
            inputEventProvider = GameObject.Find("InputEventProvider").GetComponent<IInputEventProvider>();
            noteLayer = LayerMask.GetMask("Note");

            inputEventProvider.Touch.Subscribe(touchPos =>
            {
                Debug.Log("Note Touch!");

                var ray = Camera.main.ScreenPointToRay(touchPos);
                RaycastFrom2D(ray);
            }).AddTo(this);
        }

        private void RaycastFrom2D(Ray ray)
        {
            var hit = Physics2D.Raycast(ray.origin, ray.direction, noteLayer);
            if (hit.collider != null)
            {
                Hit(hit.point, hit.transform.gameObject);
            }
        }

        private void RaycastFrom3D(Ray ray)
        {
            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.collider != null)
                {
                    Hit(hit.point, hit.transform.gameObject);
                }
            }
        }

        private void Hit(Vector2 hitPos, GameObject gameObject)
        {
            Debug.Log($"[InputEventProvider] Touched {hitPos}");

            var touchable = gameObject.GetComponent<ITouchable>();
            currentTouch.Value = touchable;
            touchable.Touch();
        }
    }
}