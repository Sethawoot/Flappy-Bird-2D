using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logicScript; // Declare the logicScript variable

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown((int)MouseButton.Left)) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * 10; // Fixed the typo here
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }
}
