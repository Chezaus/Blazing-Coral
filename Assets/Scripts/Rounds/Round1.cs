using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1 : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;

   public void roundStart()
   {
          GameObject recentSpawn = Instantiate(Enemy2,new Vector2(-9,5), Quaternion.identity);
          recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

          recentSpawn = Instantiate(Enemy2,new Vector2(9,5), Quaternion.identity);
          recentSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
   }

}
