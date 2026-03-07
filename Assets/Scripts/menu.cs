using UnityEngine;
using UnityEngine.UI;

public class MatchButtonToImage : MonoBehaviour
{
    public Image img;

    void Start()
    {
        RectTransform buttonRect = GetComponent<RectTransform>();
        RectTransform imageRect = img.GetComponent<RectTransform>();

        buttonRect.sizeDelta = imageRect.sizeDelta;
    }
}
