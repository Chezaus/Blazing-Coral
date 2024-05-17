using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public PlayerHitBox main;
    public Image[] health;
    
    void Update()
    {
        switch(main.hp){
            case 3:  
                break;
            case 2: health[0].color = new Color32((byte)255,(byte)255,(byte)255,(byte)0);
                break;
            case 1:  health[0].color = new Color32((byte)255,(byte)255,(byte)255,(byte)0); health[1].color = new Color32((byte)255,(byte)255,(byte)255,(byte)0);
                break;

        }
    }
}
