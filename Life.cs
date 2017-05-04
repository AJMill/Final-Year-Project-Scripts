using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour
{

    public int lives = 3;
    public GameObject destroyedVersion;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bullet")
        {
            lives -= 1;
        }
    }

    void Update()
    {
        if (lives <= 0)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}