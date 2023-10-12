using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float MoveSpeed=5;
    public float DeadZone = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;


        if (transform.position.x < DeadZone)
        {
            Debug.Log("Spike Deleted");
            Destroy(gameObject);
        }
    }

}
