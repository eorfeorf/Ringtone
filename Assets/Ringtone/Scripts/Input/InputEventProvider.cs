using UnityEngine;

namespace Ringtone.Scripts.Input
{
    public class InputEventProvider : MonoBehaviour
    {
        //TODO: providerを注入する形にする
        [SerializeField] private DebugInputEventProvider debugInput;
        [SerializeField] private PlayerInputEventProvider playerInput;
        
        private IInputEventProvider provider;

        private void Awake()
        {
#if UNITY_EDITOR
            provider = debugInput;
#else
            providier = playerInput;
#endif
        }

        public void SetInputEventProvider(IInputEventProvider provider)
        {
            this.provider = provider;
        }
    }
}