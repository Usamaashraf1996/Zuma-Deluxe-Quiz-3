using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCollision :MonoBehaviour
{
   

    public  void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blue"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }

    }


}
