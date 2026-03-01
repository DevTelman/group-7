using UnityEngine;

public class PlayerMusic : MonoBehaviour
{
    public AudioSource music; // քո background music-ը

    void OnEnable()
    {
        // 🎵 կանգնեցնում է երաժշտությունը
        if (music != null && music.isPlaying)
        {
            music.Stop();
        }

        // ⏸ կանգնեցնում է խաղը
        Time.timeScale = 0f;
    }
}