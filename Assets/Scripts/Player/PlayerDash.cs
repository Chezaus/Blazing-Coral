using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody2D character;

    public GameObject collisionDetect;

    public bool dashing;

    private bool safe = true;
    float cooldown = 0f;


    void Update()
    {
        if(Input.GetButtonDown("Dash") && cooldown >= 2f)
        {
            collisionDetect.transform.position = new Vector2(character.transform.position.x + Input.GetAxisRaw("Horizontal") * 2,
            character.transform.position.y + Input.GetAxisRaw("Vertical") * 2);
            Invoke("dash",0.01f);

            cooldown = 0;
            Debug.Log("DASH");
        }
        dashing = false;
        cooldown += Time.deltaTime;
    }

    void dash()
    {
        if(safe)
        {
            character.gameObject.transform.position = collisionDetect.transform.position;
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
