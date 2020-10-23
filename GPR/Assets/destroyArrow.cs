using UnityEngine;
using System.Collections;

public class destroyArrow : MonoBehaviour
{
    public float lifetime = 10f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
