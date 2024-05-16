using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    
    public RoundCounter round;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bullet"))
        {
            
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
            
            foreach(GameObject damage in bullets)
            {
                Destroy(damage.gameObject);
            }

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            round.roundNumber -= 1;
            foreach(GameObject enemy in enemies)
            {
                Destroy(enemy.gameObject);
            }
            
            this.gameObject.transform.position = new Vector2(0,-6);
        }
    }
}
