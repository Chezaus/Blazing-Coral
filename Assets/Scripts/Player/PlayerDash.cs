using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    [SerializeField] public Rigidbody2D character;
    public bool dashing;

    float cooldown = 0f;


    void Update()
    {
        if(Input.GetButtonDown("Dash") && cooldown >= 2f)
        {
            dashing = true;
            character.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")).normalized * 5;
            cooldown = 0;
        }
        dashing = false;
        cooldown += Time.deltaTime;
        Debug.Log(cooldown);
    }
}
