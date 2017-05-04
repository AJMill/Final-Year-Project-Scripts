using UnityEngine;
using System.Collections;

public class Bullet_Destroy : MonoBehaviour {

    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}