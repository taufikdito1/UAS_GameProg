using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private GameObject heart1;
    private GameObject heart2;
    private GameObject heart3;

    public GameObject gameOverScreen;

    int healthCounter = 3;

    private void Start()
    {
        heart1 = GameObject.Find("heart1");
        heart2 = GameObject.Find("heart2");
        heart3 = GameObject.Find("heart3");
    }

    private void Update()
    {
        switch (healthCounter)
        {
            case 0:
                heart3.SetActive(false);
                gameOverScreen.SetActive(true);
                gameObject.SetActive(false);
                break;
            case 1:
                heart2.SetActive(false);
                break;
            case 2:
                heart1.SetActive(false);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Damage"))
        {
            healthCounter -= 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 respawnloc = new Vector2(22, 2);

        if (other.gameObject.CompareTag("Fall"))
        {
            healthCounter -= 1;
            transform.position = respawnloc;
        }

        if (other.gameObject.CompareTag("Regen"))
        {
            if (healthCounter < 3)
            {
                healthCounter += 1;
                other.gameObject.SetActive(false);
            }

            switch (healthCounter)
            {
                case 2:
                    heart2.SetActive(true);
                    break;
                case 3:
                    heart1.SetActive(true);
                    break;
            }
        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
