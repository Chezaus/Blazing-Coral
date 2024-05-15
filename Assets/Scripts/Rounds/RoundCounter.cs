using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    public int roundNumber;

    public NewWaveUI UI;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    public GameObject miniBoss;

    private GameObject nextRound;

    void Start()
    {
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
                UI.SetRoundNumber();
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
                case 0: round0();
            break;
                case 1: round1();
            break;
                case 2: round2();
            break;
                case 3: round3();
            break;
                case 4: round4();
            break;
                case 5: round2();
            break;
                case 6: round2();
            break;
                case 7: round2();
            break;

        }
    }

    void round0()
    {
        GameObject recentSpawn = Instantiate(Enemy1,new Vector2(-8,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-0.5f);

        recentSpawn = Instantiate(Enemy1,new Vector2(8,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-0.5f);
    }

    void round1()
    {
        GameObject recentSpawn = Instantiate(Enemy2,new Vector2(-8,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy2,new Vector2(8,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
    }

    void round2()
    {
        GameObject recentSpawn = Instantiate(Enemy2,new Vector2(-8,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy2,new Vector2(8,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-8,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(8,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-1);
        Invoke("round2b",3);
    }

    void round2b()
    {
        GameObject recentSpawn = Instantiate(Enemy1,new Vector2(-7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(6,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(-6,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);
    }

    void round3()
    {
        GameObject recentSpawn;
        recentSpawn= Instantiate(Enemy3,new Vector2(-7,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-0.5f);

        recentSpawn= Instantiate(Enemy3,new Vector2(7,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-0.5f);

        recentSpawn = Instantiate(Enemy2,new Vector2(-2,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy2,new Vector2(2,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

    }

    void round4()
    {
        GameObject recentSpawn;
        recentSpawn = Instantiate(Enemy3,new Vector2(-7,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(-5,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(-3,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(-1,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(1,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(3,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(5,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(7,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        Invoke("round4b",3);
    }

    void round4b()
    {
        GameObject recentSpawn;

        recentSpawn = Instantiate(Enemy2,new Vector2(-6,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(-4,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(-2,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(0,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(2,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(4,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(6,9), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        Invoke("round4c",3);

    }

    void round4c()
    {
        GameObject recentSpawn;
        recentSpawn = Instantiate(Enemy1,new Vector2(-7,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-5,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-3,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-1,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(1,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(3,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(5,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(7,7), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

    }

    void round5()
    {
        Instantiate(miniBoss,new Vector2(0f,6.5f), Quaternion.identity);
    }

    

    
}
