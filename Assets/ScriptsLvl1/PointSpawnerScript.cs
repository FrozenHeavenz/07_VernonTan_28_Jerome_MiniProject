using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawnerScript : MonoBehaviour
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

    public GameObject Point;

    public int ERand;
    public int SelectSide;
    // Start is called before the first frame update
    void Start()
    {
        SpawnerX = GameObject.FindGameObjectsWithTag("SpawnerX");
        SpawnerNegX = GameObject.FindGameObjectsWithTag("Spawner-X");
        SpawnerY = GameObject.FindGameObjectsWithTag("SpawnerY");
        SpawnerNegY = GameObject.FindGameObjectsWithTag("Spawner-Y");
        if (SelectSide == 0)
        {
            InvokeRepeating("PositiveX", 1, 1.5f);
        }

        else if (SelectSide == 1)
        {
            InvokeRepeating("NegativeX", 1, 1.5f);
        }
        else if (SelectSide == 2)
        {
            InvokeRepeating("PositiveY", 1, 1.5f);
        }
        else if (SelectSide == 3)
        {
            InvokeRepeating("NegativeY", 1, 1.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        SelectSide = Random.Range(0, 4);
    }

    public void PositiveX()
    {
        SRandX = Random.Range(0, 4);
        ERand = Random.Range(0, 10);

 
        SelectedSpawnerX = SpawnerX[SRandX];

        //Instantiate(Point, SelectedSpawnerX.transform.position, Quaternion.identity);
        if(ERand >=6)
        {
            Instantiate(Point, SelectedSpawnerX.transform.position, Quaternion.identity);
        }

    }

    public void NegativeX()
    {
        SRandNegX = Random.Range(0, 4);
        ERand = Random.Range(0, 10);

 
        SelectedSpawnerNegX = SpawnerNegX[SRandNegX];

        if (ERand >= 6)
        {
            Instantiate(Point, SelectedSpawnerX.transform.position, Quaternion.identity);
        }
    }

    public void PositiveY()
    {
        SRandY = Random.Range(0, 9);
        ERand = Random.Range(0, 10);

 
        SelectedSpawnerY = SpawnerY[SRandY];

        if (ERand >= 6)
        {
            Instantiate(Point, SelectedSpawnerX.transform.position, Quaternion.identity);
        }
    }

    public void NegativeY()
    {
        SRandNegY = Random.Range(0, 9);
        ERand = Random.Range(0, 10);

 
        SelectedSpawnerNegY = SpawnerNegY[SRandNegY];

        if (ERand >= 6)
        {
            Instantiate(Point, SelectedSpawnerX.transform.position, Quaternion.identity);
        }
    }
}
