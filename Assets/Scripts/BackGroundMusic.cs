using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;
    public bool levelFinished = false; // սա կդարձնես true, երբ լեվելը վերջանա

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.Play();
    }

    void Update()
    {
        if (levelFinished && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}