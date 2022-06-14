using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public static float speed = 300;
    private bool collisionChecker;

    void Start()
    {
        collisionChecker = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.Equals(GameObject.FindGameObjectsWithTag("checker")))
       // collisionChecker = true;
        //Debug.Log("in");
    }

    public bool GetCollisionChecker()
    {
        return collisionChecker;
    }

    public void SetCollisionChecker(bool b)
    {
        collisionChecker = b;
    }
}
