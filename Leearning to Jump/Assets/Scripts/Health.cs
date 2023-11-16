using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;

    public Transform startPos;

    public GameObject health1;
    public GameObject health2;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;                  //set max health to two
        currentHealth = maxHealth;      //set current health to max health
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;                        //lower health
        transform.position = new Vector2(startPos.position.x, startPos.position.y);

        if (currentHealth == 2)
        {
            health2.SetActive(false);
        }

        if (currentHealth == 1)
        {
            health1.SetActive(false);
        }


        if (currentHealth <= 0)                         //if health equal zero
        {
            SceneManager.LoadScene("GameOver");         //go to GameOver Scene

        }
    }
}
