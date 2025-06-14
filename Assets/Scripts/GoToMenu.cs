using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
        {
        if (other.gameObject.CompareTag("Ukraine"))
            {
            SceneManager.LoadScene(0);
            }
        }
}
