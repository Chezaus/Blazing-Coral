using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    public float bulletSpeed;
    public float delay;

    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        StartCoroutine("shoot");
    }

    IEnumerator shoot()
    {
        for(;;)
        {
            GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);

                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 
                (player.transform.position.x - this.gameObject.transform.position.x,
                player.transform.position.y - this.gameObject.transform.position.y).normalized * bulletSpeed;

                yield return new WaitForSeconds(delay);
        }

            
    }
}
