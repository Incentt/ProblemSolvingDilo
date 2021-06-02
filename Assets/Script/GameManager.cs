using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Box;
    public bool problem1;
    public bool problem2;
    public bool problem3;
    public bool problem4;
    public bool problem5;
    public bool problem6;
    public bool problem7;
    public bool problem8;
    public bool problem9;

    private int Xforce = 1;
    private int Yforce = 1;
    void Start()
    {
        //Problem2
        if (problem2)
            Invoke("Problem2", 1f);
        if (problem3)
        {
            Instantiate(Box);
            Invoke("Problem2", 1f);
        }


    }

    // Update is called once per frame
    void Problem2()
    {
            float rand = Random.Range(0, 2);
            if (rand == 1)
            {
                Yforce *= -1;
            }
            else
            {
                Yforce *= 1;
            }
            float rand2 = Random.Range(0, 2);
            if (rand2 == 1)
            {
                Xforce *= -1;
            }
            else
            {
                Xforce *= 1;
            }
            Circle.GetComponent<Rigidbody2D>().AddForce(new Vector2(Xforce * 100, Yforce * 100));
    }
    private void Update()
    {
        if (problem4)
        {
            float move = Input.GetAxis("Horizontal");
            float move2 = Input.GetAxis("Vertical");
            Circle.GetComponent<Rigidbody2D>().velocity = new Vector2(move* Time.deltaTime * 2000, move2 * Time.deltaTime * 2000);
        }
        if (problem5)
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Circle.transform.position = Vector2.Lerp(Circle.transform.position, mousepos, 6f * Time.deltaTime);
            
        }
    }
}
