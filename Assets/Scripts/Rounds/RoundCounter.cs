using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    public Round0 round0;

    public int roundNumber;

    public List<GameObject> rounds = new List<GameObject>();

    void Start()
    {
        roundNumber = 0;

        for(int i = 0; i > -1; i++)
        {
            GameObject round = GameObject.Find("Round" + i);
            if(round == null){break;}
            rounds.Add(round);
        }
        foreach (GameObject round in rounds)
        {
            Debug.Log(round.name);
        }

        StartCoroutine("CheckRound");
    }

    IEnumerator CheckRound()
    {
        for(;;)
        {
            if(GameObject.FindWithTag("Enemy") == false)
            {
                round0.roundStart();
            }
            yield return new WaitForSeconds(.5f);
        }
    }

    
}
