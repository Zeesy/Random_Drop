using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Drop : MonoBehaviour {

    public Transform MyPrefab;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        // Spawn a new object every second
        if (timer > 1f)
        {
            Instantiate(MyPrefab);
            timer -= 1f;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
}
