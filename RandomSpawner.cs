using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    //Spawn this object
    public GameObject spawnObject;

    //range for time
    public float maxTime = 5;
    private float minTime = 1;

    //set custom range for random position
    //width
    public float MinX = -6;
    public float MaxX = 8;
    //height
    public float MinY = 8;
    public float MaxY = 12;
    //depth
    public float MinZ = -7;
    public float MaxZ = 8;

    //turn off or on 3D placement
    public bool is3D = true;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    public float MinTime
    {
        get
        {
            return minTime;
        }

        set
        {
            minTime = value;
        }
    }

    void Start()
    {
        SetRandomTime();
        time = MinTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;

        float x = Random.Range(MinX, MaxX);
        float y = Random.Range(MinY, MaxY);
        float z = Random.Range(MinZ, MaxZ);


        Instantiate(spawnObject, new Vector3(x, y, z), spawnObject.transform.rotation);

    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(MinTime, maxTime);
    }


}
