using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The time at the beginning of this frame (Read Only). This is the time in seconds since the start of the game.
/*public class ExampleClass : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
        }
    }
}*/
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Only allow the player to spawn a new dog after a certain amount of time has passed
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation) as GameObject;
        }
    }
}
