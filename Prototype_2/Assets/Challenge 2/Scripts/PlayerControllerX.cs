using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //set time since last spawn to Time.deltaTime to delay by 1 second
        timeSinceLastSpawn += Time.deltaTime;
        // On spacebar press, send dog
        // If spacebar is pressed and time since last spawn is greater than 1 second
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastSpawn >= 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //reset time since last spawn to 0
            timeSinceLastSpawn = 0;
        }
    }
}
