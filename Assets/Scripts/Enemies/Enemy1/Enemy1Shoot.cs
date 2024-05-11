using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    public float delay;

    private float timer = 0;

    void Start()
    {
        if(bullet == null)
        {
            bullet = GameObject.Find("Bullet");
        }
    }
    

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > delay)
        {
            randomShoot();
        }
    }

    void randomShoot()
    {
        GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
        recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (Random.Range(-2f,2f),Random.Range(-2f,2f)).normalized;
        timer -= delay;
    }
}
