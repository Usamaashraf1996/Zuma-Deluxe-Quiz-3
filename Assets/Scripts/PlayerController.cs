using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;


public class PlayerController : MonoBehaviour
{
    public Vector3 mouseposition;
    public float angle;
    public Vector3 direction;
    public GameObject ballPosition;
    public static PlayerController instance;
    private void Awake()
    {
        instance = this;    
    }
    void Update()
    {
       //use for lookat or throw at mouse direction
        mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseposition.y = 0;
        direction = mouseposition - transform.position;
        direction.y = 0;

        transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
    
    }
    
    
}