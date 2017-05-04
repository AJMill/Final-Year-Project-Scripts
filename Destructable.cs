using UnityEngine;
using System.Collections;

public class Destructable : MonoBehaviour
{

    public GameObject destroyedVersion;

    void OnCollisionEnter()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
