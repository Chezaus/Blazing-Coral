using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHitBox : MonoBehaviour
{
    
    public RoundCounter round;
    public int hp = 3;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bullet"))
        {
            round.dead = true;
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
            
            foreach(GameObject damage in bullets)
            {
                Destroy(damage.gameObject);
            }

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject enemy in enemies)
            {
                Destroy(enemy.gameObject);
            }
            
            this.gameObject.transform.position = new Vector2(0,-6);
            hp -= 1;
            if(hp <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
