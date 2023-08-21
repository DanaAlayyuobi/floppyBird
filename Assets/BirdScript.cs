using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D rb2D;
    public Text scoreText;
    int Score = 0;
    public GameObject GameOverObjects;
    public GameObject ClickUpButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }

    }
    public void toClickUp() {
        rb2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        print("dead");
        Time.timeScale = 0;
        GameOverObjects.SetActive(true);
        ClickUpButton.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Score++;
        scoreText.text = Score.ToString();
        print("out");
       
    }
}
