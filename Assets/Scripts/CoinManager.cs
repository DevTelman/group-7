using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int coinCount = 0;
    public TextMeshProUGUI coinText; 

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddCoin()
    {
        coinCount++;
        coinText.text = coinCount.ToString();
        Debug.Log("Կոպեկներ: " + coinCount);
    }
}