using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCollision :MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Green"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }

    }

}
