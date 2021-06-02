using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBox : MonoBehaviour
{
    public Vector2 MinPos;
    public Vector2 MaxPos;
    private Vector2 _randomPosition;

    public int MinSpawn;
    public int MaxSpawn;
    private int randSpawn;

    public int totalBox;
    public GameObject Square;
    private void Start()
    {
        randSpawn = Random.Range(MinSpawn, MaxSpawn);
    }

    private void Update()
    {
        float xpos = Random.Range(MinPos.x, MaxPos.x);
        float ypos = Random.Range(MinPos.y, MaxPos.y);
        _randomPosition = new Vector2(xpos, ypos);

        if (totalBox < randSpawn)
        {
            Spawn();
        }
        
    }
    void Spawn()
    {
        Instantiate(Square, _randomPosition, Quaternion.identity);
        totalBox += 1;

    }

}
