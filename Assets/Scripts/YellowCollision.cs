using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Yellow"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }

    }
}
