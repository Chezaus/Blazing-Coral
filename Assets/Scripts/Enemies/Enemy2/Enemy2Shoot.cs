using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    public float delay;
    public float bulletSpeed;

    void Start()
    {
        if(bullet == null)
        {
            bullet = GameObject.Find("Bullet");
        }

        StartCoroutine("shoot");
    }
    
    IEnumerator shoot ()
    {
        for(;;)
        {
            foreach (Transform child in this.gameObject.transform)
            {
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (child.position.x - this.gameObject.transform.position.x,child.position.y - this.gameObject.transform.position.y).normalized * bulletSpeed;

            }
        
            yield return new WaitForSeconds(delay);
        }
        
    }

    
}
