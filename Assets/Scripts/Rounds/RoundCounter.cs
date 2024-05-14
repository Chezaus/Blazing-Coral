using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    public Round0 round0;
    public int roundNumber;

    public GameObject Enemy1;
    public GameObject Enemy2;

    private GameObject nextRound;

    void Start()
    {
        roundNumber = -1;
        StartCoroutine("CheckRound");
    }

    IEnumerator CheckRound()
    {
        for(;;)
        {
            if(GameObject.FindWithTag("Enemy") == false)
            {
                roundNumber += 1;
                Invoke("roundStart", 3);
                float timer = 0f;
                while(timer < 3f)
                {
                    yield return null;
                    timer += Time.deltaTime;
                }

            }
            yield return new WaitForSeconds(.5f);
        }
    }

    void roundStart()
    {
        switch(roundNumber)
        {
            case 0: GameObject recentSpawn = Instantiate(Enemy1,new Vector2(-8,7), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-0.5f);

                    recentSpawn = Instantiate(Enemy1,new Vector2(8,7), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-0.5f);
            break;

            case 1: recentSpawn = Instantiate(Enemy2,new Vector2(-8,5), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

                    recentSpawn = Instantiate(Enemy2,new Vector2(8,5), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
            break;

            case 2: recentSpawn = Instantiate(Enemy2,new Vector2(-8,5), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

                    recentSpawn = Instantiate(Enemy2,new Vector2(8,5), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

                    recentSpawn = Instantiate(Enemy1,new Vector2(-8,6), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-1);

                    recentSpawn = Instantiate(Enemy1,new Vector2(8,6), Quaternion.identity);
                    recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-1);
            break;


        }
    }

    
}
