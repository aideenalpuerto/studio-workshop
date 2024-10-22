using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class player : MonoBehaviour
{ 
    [SerializeField] Rigidbody2D rb; 


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMove(InputValue value) 
    {
        Debug.Log("meow");
        Vector2 dir = value.Get<Vector2>();
        Debug.Log(dir);
        rb.velocity = dir * 10;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
