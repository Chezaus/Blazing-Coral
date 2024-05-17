using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject[] enemies;
    public MiniBossHealth health;

    private bool started = false;

    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindWithTag("Player");
        }

        StartCoroutine("CircleShoot");
        StartCoroutine("PhaseCheck");
        StartCoroutine("AimShoot");
    }

    IEnumerator PhaseCheck()
    {
        for(;;)
        {

            if(health.health >= 200 && health.health <= 400 && !started)
            {
                started = true;
                StartCoroutine("SpawnEnemy");
                StartCoroutine("OcillatingShoot");
            }

            yield return new WaitForSeconds(0.5f); 
        }
    }

    IEnumerator CircleShoot()
    {
        for(;;)
        {
            
            foreach (Transform child in this.gameObject.transform)
            {
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (child.position.x - this.gameObject.transform.position.x,child.position.y - this.gameObject.transform.position.y).normalized * 2;

            }

            yield return new WaitForSeconds(Random.Range(2f,3f));
        }
    }

    IEnumerator AimShoot()
    {
        for(;;)
        {
            if(player)
            {
                for(int i = 0; i <Random.Range(1,5); i++)
                {
                    GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);

                    recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 
                    (player.transform.position.x - this.gameObject.transform.position.x,
                    player.transform.position.y - this.gameObject.transform.position.y).normalized * 3;

                    yield return new WaitForSeconds(Random.Range(0.1f,1f));
                }
            }

            yield return new WaitForSeconds(Random.Range(0.5f,2f));
        }
    }

    IEnumerator SpawnEnemy()
    {
        for(;;)
        {
            for(int i = 0; i < Random.Range(1,3); i++)
            {
                int number = Random.Range(0,3);
                Instantiate(enemies[number],new Vector2(Random.Range(-6f,6f),Random.Range(2f,4f)),Quaternion.identity);
            }
            yield return new WaitForSeconds(Random.Range(3f,6f));
        }
    }

    IEnumerator OcillatingShoot()
    {
        for(;;)
        {
            for(float i = -4f; i<4f; i += 0.05f)
            {
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.gameObject.transform.position,Quaternion.identity);

                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (i - this.gameObject.transform.position.x,i*i -this.gameObject.transform.position.y).normalized * 3;

                yield return new WaitForSeconds(0.1f);
            }

            yield return new WaitForSeconds(Random.Range(1f,10f));
        }
        
    }

    
}
