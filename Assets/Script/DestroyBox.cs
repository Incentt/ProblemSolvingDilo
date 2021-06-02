using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBox : MonoBehaviour
{
    public Text ScoreText;
    private int Score;
    public bool Problem8;
    public bool Problem9;
    public RandomSpawnBox BoxSpawner;
    public AudioSource ClingSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Square")
        {
            Destroy(collision.gameObject);
            Score += 1;

            if(Problem8)
            Invoke("Respawn", 3f);

            if (Problem9)
                ClingSound.Play();
        }
    }
    private void Update()
    {
        ScoreText.text = "Score :" + Score.ToString();
        if (Problem9)
        ScoreText.text = "Money :" + Score.ToString();
    }
    void Respawn()
    {
        BoxSpawner.totalBox -= 1;
    }
}
