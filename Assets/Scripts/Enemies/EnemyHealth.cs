using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    SpriteRenderer colour;

    void Start()
    {
        colour = this.gameObject.GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("playerBullet"))
        {
            health -= 1;
            Invoke("FadeIn",0);
            Destroy(other.gameObject);

            if(health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void FadeIn()
    {
        colour.color = new Color32((byte)255 , (byte)255 , (byte)255 , (byte)255);
        Invoke("FadeOut",0.1f);
    }

    void FadeOut()
    {
        colour.color = new Color32((byte)255, (byte)0 , (byte)0 , (byte)255); 
    }
}
