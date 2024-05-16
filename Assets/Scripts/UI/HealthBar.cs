using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthUI;
    public Image healthUI2;
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
            healthUI.color = new Color32((byte)255 , (byte)255 , (byte)255 , (byte)255);
            healthUI2.color = new Color32((byte)255 , (byte)255 , (byte)255 , (byte)255);
            if(health.health < 0)  {value = 1;}
            else{value = (float)health.health/600;}

            bar.fillAmount = value;
        }
        else{
           healthUI.color = new Color32((byte)255 , (byte)255 , (byte)255 , (byte)0);
           healthUI2.color = new Color32((byte)255 , (byte)255 , (byte)255 , (byte)0);
        }
    }

    public void BossFind()
    {
        health = GameObject.Find("MiniBoss(Clone)").GetComponent<MiniBossHealth>();
        Debug.Log("BOSS FIND ACTIVE");
    }

}
