using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Damage : MonoBehaviour
{
    public int LivesCounter = 3;
    public TMP_Text Lives;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (LivesCounter <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
        {
        if (other.gameObject.CompareTag("Enemy"))
            {
            LivesCounter--;
            Lives.text = "Health: " + LivesCounter.ToString();
            }
        }
}
