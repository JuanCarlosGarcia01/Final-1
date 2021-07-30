using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;

    

    public void Awake()
    {
        rig = GetComponent<Rigidbody>();


    }
    public void Start()
    {
        rig.velocity = transform.right * speed;
    }

    
    

    public void OnCollisionEnter(Collision collision)
     {


        if (collision.gameObject.CompareTag("Limite"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("enemis"))
        {

            Destroy(collision.gameObject);
        }
    }


}
