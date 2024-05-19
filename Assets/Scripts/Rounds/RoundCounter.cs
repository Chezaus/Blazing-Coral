using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundCounter : MonoBehaviour
{
    public int roundNumber;
    public bool dead = false;

    public NewWaveUI UI;
    public HealthBar bar;
    public AudioSource splash;
    public AudioSource boom;
    public GameObject healthUI;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    public GameObject miniBoss;

    private GameObject nextRound;
    private bool boss;

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
                Invoke("roundStart", 3);
                if(!dead)
                {
                    roundNumber += 1;
                }
                UI.SetRoundNumber();

                GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
                foreach(GameObject damage in bullets)
                {
                    Destroy(damage.gameObject);
                }
                float timer = 0f;
                while(timer < 3f)
                {
                    yield return null;
                    timer += Time.deltaTime;
                }

            }
            if(roundNumber == 5 && GameObject.Find("MiniBoss(Clone)") == null && boss) 
            {
                SceneManager.LoadScene("win");
            }
            if(roundNumber < 0)
            {
                roundNumber = 0;
            }
            yield return new WaitForSeconds(.5f);
        }
    }

    public void roundStart()
    {
        dead = false;
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
                case 5: round5();
            break;
                case 6: SceneManager.LoadScene("win");
            break;

        }
    }

    void round0()
    {
        GameObject recentSpawn = Instantiate(Enemy1,new Vector2(-7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-0.5f);

        recentSpawn = Instantiate(Enemy1,new Vector2(7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-0.5f);

        splash.Play();
    }

    void round1()
    {
        GameObject recentSpawn = Instantiate(Enemy2,new Vector2(-8,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy2,new Vector2(8,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        splash.Play();
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

        splash.Play();

        Invoke("round2b",3);
    }

    void round2b()
    {
        GameObject recentSpawn = Instantiate(Enemy1,new Vector2(-7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (-1,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(6,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy1,new Vector2(-6,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        splash.Play();
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

        splash.Play();
    }

    void round4()
    {
        GameObject recentSpawn;
        recentSpawn = Instantiate(Enemy3,new Vector2(-7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(-5,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(-3,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(-1,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(1,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(3,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(5,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy3,new Vector2(7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        splash.Play();

        Invoke("round4b",3);
    }

    void round4b()
    {
        GameObject recentSpawn;

        recentSpawn = Instantiate(Enemy2,new Vector2(-2,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        recentSpawn = Instantiate(Enemy2,new Vector2(2,5), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,-1);

        splash.Play();

        Invoke("round4c",3);

    }

    void round4c()
    {
        GameObject recentSpawn;
        recentSpawn = Instantiate(Enemy1,new Vector2(-7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-5,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-3,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(-1,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(1,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(3,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(5,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        recentSpawn = Instantiate(Enemy1,new Vector2(7,6), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

        splash.Play();

    }

    void round5()
    {
        Instantiate(miniBoss,new Vector2(0f,6.5f), Quaternion.identity);
        healthUI.SetActive(true);
        bar = healthUI.GetComponent<HealthBar>();
        boss = true;
        bar.BossFind();

        boom.Play();
    }

    

    
}
