using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] public Rigidbody2D character;
    [SerializeField] public float characterSpeed;

    [SerializeField] public PlayerDash dash;

    public Vector2 characterVector;

    void Update()
    {
        if(!dash.dashing)
        {
            character.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")).normalized * characterSpeed;
        }
    }
}
