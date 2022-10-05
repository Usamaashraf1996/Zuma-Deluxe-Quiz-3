using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : GameManager
{
    public float speed = 10f;
    private Rigidbody rbb;

    void Start()

    {
        rbb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      Force () ;

        Bounds();

    }
    private void Bounds()
    {
        if (transform.position.x > 20)
        {
            Destroy(gameObject);
        }
    }
    private void Force() {

        rbb.AddForce(PlayerController.instance.direction * speed, ForceMode.Impulse);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
