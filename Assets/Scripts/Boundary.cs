using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public bool Destroy;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if(!Destroy)
            {
                other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            }
            else{
                Destroy(other.gameObject);
            }
        }
    }
}
