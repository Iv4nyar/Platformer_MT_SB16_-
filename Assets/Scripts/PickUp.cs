
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{
    private int CoinCounter = 0;
    public TMP_Text coinText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
        {
        if (other.CompareTag("item"))
            {
            Destroy(other.gameObject);
            CoinCounter++;
            coinText.text = "Coins: " + CoinCounter.ToString();
            }
        }
}
