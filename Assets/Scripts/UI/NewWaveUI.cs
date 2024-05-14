using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewWaveUI : MonoBehaviour
{
    public RoundCounter round;
    public TMP_Text text;

    public void SetRoundNumber()
    {
        text.text = "WAVE " + round.roundNumber;
        StartCoroutine("FadeIn");
    }

    IEnumerator FadeIn()
    {


        for(float alpha = 0f; alpha >= 0; alpha += 1f)
        {
            text.color = new Color32((byte)255 , (byte)255 , (byte)255 , (byte)alpha);

            if(alpha >= 255)
            {
                StopCoroutine("FadeIn");
                StartCoroutine("FadeOut");
            }
            yield return new WaitForSeconds(.005f);
            
        }
    }

    IEnumerator FadeOut()
    {
        for(float alpha = 255f; alpha >= 0; alpha -= 1f)
        {
            text.color = new Color32((byte)255, (byte)255 , (byte)255 , (byte)alpha);

            if(alpha <= 0)
            {
                StopCoroutine("FadeOut");
            }
            
            yield return new WaitForSeconds(.007f);
        }
    }

}
