
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
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
            }
        }
}
