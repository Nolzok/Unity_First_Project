using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            Rigidbody.velocity = Vector2.up * 2;
        }
        if (Input.GetKey(KeyCode.A))
        {

            Rigidbody.velocity = Vector2.left * 2;
        }
        if (Input.GetKey(KeyCode.S))
        {

            Rigidbody.velocity = Vector2.down * 2;
        }
        if (Input.GetKey(KeyCode.D))
        {

            Rigidbody.velocity = Vector2.right * 2;
        }
    }

   // private void OnCollisionEnter2D(Collision2D collision)
    //{
      //  logic.gameOver();
    //}
}
