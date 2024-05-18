using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHitBox : MonoBehaviour
{
    public GameObject ui;
    public RoundCounter round;
    public int hp = 3;

    private bool debugMode = false;

    void Start()
    {
        StartCoroutine("debug");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bullet") && !debugMode)
        {
            round.dead = true;
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
            
            foreach(GameObject damage in bullets)
            {
                Destroy(damage.gameObject);
            }

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject enemy in enemies)
            {
                Destroy(enemy.gameObject);
            }
            
            this.gameObject.transform.position = new Vector2(0,-6);
            hp -= 1;
            if(hp <= 0)
            {
                ui.SetActive(true);
                Invoke("Restart",3);
            }
        }
        if(other.CompareTag("Bullet") && debugMode)
        {
            Destroy(other.gameObject);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("level");
    }

    IEnumerator debug()
    {
        for(;;)
        {
            if(Input.GetButton("F"))
            {
                if(debugMode == false)
                {
                    debugMode = true;
                    Debug.Log("DEBUG MODE ON");
                    break;
                }
                if(debugMode == true)
                {
                    debugMode = false;
                    Debug.Log("DEBUG MODE OFF");
                    break;
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
