using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round0 : MonoBehaviour
{
    public GameObject Enemy1;

   public void roundStart()
   {
        GameObject recentSpawn = Instantiate(Enemy1,new Vector2(2,2), Quaternion.identity);
        recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (1,-1);
   }

}
