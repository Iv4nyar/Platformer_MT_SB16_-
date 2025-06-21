using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
        {
        if (other.CompareTag("Potion"))
            {
            Destroy(other.gameObject);
            transform.localScale = new Vector2(0.050f, 0.050f);
            }
        }
}
