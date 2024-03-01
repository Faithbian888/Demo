using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var temp = rb.velocity;
        if (Input.GetKeyDown(KeyCode.W))
        {
            print(111);
            temp.y = 1;
            rb.velocity = temp * Time.deltaTime;
        }
        else
        {
            temp.y = 0;
        }
    }
}
