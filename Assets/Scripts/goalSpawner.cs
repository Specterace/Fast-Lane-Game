using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalSpawner : MonoBehaviour {

    public GameObject goal;
    public float maxPos = 0f;
    public float delayTimer = 1f;
    float timer;
    bool goalSpawned;
    // Use this for initialization
    void Start () {
        timer = delayTimer;
        goalSpawned = false;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (!goalSpawned)
            {
                Vector3 goalPos = new Vector3(maxPos, transform.position.y, transform.position.z);
                Instantiate(goal, goalPos, transform.rotation);
                goalSpawned = true;
            }
            
        }
    }
}
