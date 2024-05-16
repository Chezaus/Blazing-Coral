using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody2D character;
    public GameObject bullet;

    public GameObject collisionDetect;
    public GameObject empty;

    public bool dashing;

    private bool safe = true;
    float cooldown = 0f;


    void Update()
    {

        collisionDetect.transform.position = new Vector2(character.transform.position.x + Input.GetAxisRaw("Horizontal"),
        character.transform.position.y + Input.GetAxisRaw("Vertical"))* 3;

        if(Input.GetButtonDown("Dash") && cooldown >= 2f)
        {
            collisionDetect.transform.position = new Vector2(character.transform.position.x + Input.GetAxisRaw("Horizontal"),
            character.transform.position.y + Input.GetAxisRaw("Vertical")).normalized  * 3;
            Invoke("dash",0.017f);

            cooldown = 0;
            
        }
        dashing = false;
        cooldown += Time.deltaTime;
    }

    void dash()
    {
        if(safe)
        {
            GameObject recentEmpty = Instantiate(empty,character.gameObject.transform.position,Quaternion.identity);
            character.gameObject.transform.position = collisionDetect.transform.position;
            foreach (Transform child in empty.gameObject.transform)
            {
                GameObject recentBullet = (GameObject)Instantiate(bullet, recentEmpty.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (child.position.x,child.position.y).normalized * 2;

            }
    
            
        }
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Boundary"))
        {
            safe = false;
        }
        else{
            safe = true;
        }
    }
}
