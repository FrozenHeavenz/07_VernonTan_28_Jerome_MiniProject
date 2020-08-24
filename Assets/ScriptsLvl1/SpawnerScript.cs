using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] SpawnerX;
    public GameObject[] SpawnerNegX;
    public GameObject[] SpawnerY;
    public GameObject[] SpawnerNegY;

    public GameObject SelectedSpawnerX;
    public GameObject SelectedSpawnerNegX;
    public GameObject SelectedSpawnerY;
    public GameObject SelectedSpawnerNegY;

    public int SRandX;
    public int SRandNegX;
    public int SRandY;
    public int SRandNegY;
    public int ERand;

    public float spawnRate;

    public int EnemyCountPosX;
    public int EnemyCountNegX;
    public int EnemyCountPosY;
    public int EnemyCountNegY;

    public GameObject[] Enemies;
    
    public GameObject SelectedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        SpawnerX = GameObject.FindGameObjectsWithTag("SpawnerX");
        SpawnerNegX = GameObject.FindGameObjectsWithTag("Spawner-X");
        SpawnerY = GameObject.FindGameObjectsWithTag("SpawnerY");
        SpawnerNegY = GameObject.FindGameObjectsWithTag("Spawner-Y");


        InvokeRepeating("PositiveX", 1, spawnRate);
        InvokeRepeating("NegativeX", 1, spawnRate);
        InvokeRepeating("PositiveY", 1, spawnRate);
        InvokeRepeating("NegativeY", 1, spawnRate);
    }
        // Update is called once per frame
    void Update()
    {

    }

    public GameObject PositiveX()
    {
        SRandX = Random.Range(0, 4);
        ERand = Random.Range(0, 3);

        SelectedEnemy = Enemies[ERand];
        SelectedSpawnerX = SpawnerX[SRandX];

        GameObject tempGameObject = Instantiate(SelectedEnemy, SelectedSpawnerX.transform.position, Quaternion.identity);
        EnemyCountPosX += 1;
        return tempGameObject;
    }

    public GameObject NegativeX()
    {
        SRandNegX = Random.Range(0, 4);
        ERand = Random.Range(0, 3);

        SelectedEnemy = Enemies[ERand];
        SelectedSpawnerNegX = SpawnerNegX[SRandNegX];

        GameObject tempGameObject = Instantiate(SelectedEnemy, SelectedSpawnerNegX.transform.position, Quaternion.identity);
        EnemyCountNegX += 1;
        return tempGameObject;
    }

    public GameObject PositiveY()
    {
        SRandY = Random.Range(0, 9);
        ERand = Random.Range(0, 3);

        SelectedEnemy = Enemies[ERand];
        SelectedSpawnerY = SpawnerY[SRandY];

        GameObject tempGameObject = Instantiate(SelectedEnemy, SelectedSpawnerY.transform.position, Quaternion.identity);
        EnemyCountPosY += 1;
        return tempGameObject;
    }

    public GameObject NegativeY()
    {
        SRandNegY = Random.Range(0, 9);
        ERand = Random.Range(0, 3);

        SelectedEnemy = Enemies[ERand];
        SelectedSpawnerNegY = SpawnerNegY[SRandNegY];

        GameObject tempGameObject = Instantiate(SelectedEnemy, SelectedSpawnerNegY.transform.position, Quaternion.identity);
        EnemyCountNegY += 1;
        return tempGameObject;
    }
}
