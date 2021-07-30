using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    void Update()
    {
        move();
    }

    void move()
    {
        this.transform.position = this.transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
