using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] public GameObject bullet;
    [SerializeField] public AudioSource shoot;
    [SerializeField] public float bulletSpeed;
    [SerializeField] public float fireDelay;

    private float cooldown;
    private float angle;

    void Update()
    {
        cooldown += Time.deltaTime;
        if(cooldown >= fireDelay)
        {
            if(Input.GetButton("Shoot"))
            {
            
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,5).normalized * bulletSpeed;

                if(!shoot.isPlaying)
                {
                    shoot.Play();
                }

                
                cooldown = 0f;

            }
        }     

        if(Input.GetButtonUp("Shoot"))
        {
            shoot.Stop();
        }
    }
}
