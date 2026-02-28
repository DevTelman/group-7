using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEndToMenu : MonoBehaviour
{
    public VideoPlayer video;

    void Start()
    {
        video.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene("Menu");
    }
}
