using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public float speed = 10f;

    private void Start()
    {
        Destroy(gameObject, 2);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if  (collision.collider.name == "TurtleShell")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
