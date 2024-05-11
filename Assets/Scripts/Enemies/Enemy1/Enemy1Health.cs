using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("playerBullet"))
        {
            Destroy(this.gameObject);
        }
    }
}
