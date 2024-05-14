using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("playerBullet"))
        {
            health -= 1;
            Destroy(other.gameObject);

            if(health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
