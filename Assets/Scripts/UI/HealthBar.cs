using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject healthUI;
    public MiniBossHealth health;
    float value;
    [SerializeField] Image bar;

    void Start()
    {
        if(!health)
        {
            health = GameObject.Find("MiniBoss").GetComponent<MiniBossHealth>();
        }
    }

    void Update()
    {
        if(health)
        {
            healthUI.SetActive(true);
            if(health.health < 0)  {value = 1;}
            else{value = (float)health.health/600;}

            bar.fillAmount = value;
        }
        else{
            healthUI.SetActive(false);
        }
    }

    public void BossFind()
    {
        health = GameObject.Find("MiniBoss").GetComponent<MiniBossHealth>();
    }

}
