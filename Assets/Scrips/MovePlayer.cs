using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MovePlayer : MonoBehaviour
{
    [Header("Movement")]
    int cont = 0;
    public float salto = 5f;
    public Rigidbody rb;
    bool enElSuelo;

    [Header("Score")]
    public int coins;
    public Text coinsText;


    public void Awake()
    {
        coins = 0;
        coinsText.text = "Coins: " + coins;
    }


    void Update()
    {
        movimiento();
        
    }

    public void AddCoins(int value)
    {
        coins += value;
        UpdateScore();
    }

    void UpdateScore()
    {
        coinsText.text = "Coins: " + coins;
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        coins = coins + 1;
        coinsText.text = "Coins: " + coins;

    }

    void movimiento()
    {
        
        if (Input.GetKeyDown("space") && enElSuelo == true)
        {
            rb.AddForce(0, salto, 0, ForceMode.Impulse);
            enElSuelo = false;
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Suelo"))
        {
            enElSuelo = true;
        }

        if (collision.gameObject.tag == "enemis")
        {
            SceneManager.LoadScene("Dead");
        }
    }
}
