using System;
using UnityEngine;
using UnityEngine.UI;

namespace Menus
{
    public class SoundScript : MonoBehaviour
    {
        [SerializeField] private Button sound;
        [SerializeField] private Sprite soundOn;
        [SerializeField] private Sprite soundOff;

        private void Awake()
        {
            sound.image.sprite = soundOn;
            sound.onClick.AddListener(SoundChange);
        }

        private void SoundChange()
        {
            switch (AudioListener.pause)
            {
                case true:
                    AudioListener.pause = false;
                    sound.image.sprite = soundOn;
                    break;
                case false:
                    AudioListener.pause = true;
                    sound.image.sprite = soundOff;
                    break;
            }
        }
    }
}
