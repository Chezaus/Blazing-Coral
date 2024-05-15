using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public MiniBossHealth health;

    void Start()
    {
        StartCoroutine("Phase1");
    }

    IEnumerator PhaseCheck()
    {
        for(;;)
        {
            if(health.health == 600)
            {
                Debug.Log(health.health);
                
            }

            yield return new WaitForSeconds(0.5f); 
        }
    }

    IEnumerator Phase1()
    {
        for(;;)
        {
            
            foreach (Transform child in this.gameObject.transform)
            {
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (child.position.x - this.gameObject.transform.position.x,child.position.y - this.gameObject.transform.position.y).normalized * 1;

            }
            yield return new WaitForSeconds(3f);
        }
    }
}
