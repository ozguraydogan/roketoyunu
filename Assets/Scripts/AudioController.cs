using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioListener listener;

    void Start()
    {
        // PlayerPrefs'te "AudioEnabled" anahtarı varsa değerini al ve dinleyiciyi buna göre ayarla
        if (PlayerPrefs.HasKey("AudioEnabled"))
        {
            bool isAudioEnabled = PlayerPrefs.GetInt("AudioEnabled") == 1;
            listener.enabled = isAudioEnabled;
        }
        else
        {
            // Anahtar yoksa, varsayılan olarak sesi açık olarak ayarla ve kaydet
            listener.enabled = true;
            PlayerPrefs.SetInt("AudioEnabled", 1);
            PlayerPrefs.Save();
        }
    }

    public void ListenerController()
    {
        listener.enabled = !listener.enabled;

        // Sesin yeni durumunu PlayerPrefs'e kaydet
        PlayerPrefs.SetInt("AudioEnabled", listener.enabled ? 1 : 0);
        PlayerPrefs.Save();
    }
}