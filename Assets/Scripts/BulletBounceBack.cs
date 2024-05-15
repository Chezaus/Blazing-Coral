using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBounceBack : MonoBehaviour
{
    public GameObject bullet;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {
            foreach (Transform child in this.gameObject.transform)
            {
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 
                (child.position.x - this.gameObject.transform.position.x,
                child.position.y - this.gameObject.transform.position.y).normalized;

                Destroy(this.gameObject);
            }

        }
    }
}
