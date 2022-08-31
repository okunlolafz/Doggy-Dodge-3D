using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private int dogPosX;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure dog is set to spawn origin after every three seconds
        InvokeRepeating("TimeManager", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

        // send dog on spacebar press only when dog is at the spawn origin (taken abitrarily as 0)
        if (Input.GetKeyDown(KeyCode.Space) && dogPosX == 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            dogPosX = 100; // dog is no longer at the origin
        }

    }

    // Set dog position to spawn origin
    void TimeManager()
    {
        dogPosX = 0;
    }

}
