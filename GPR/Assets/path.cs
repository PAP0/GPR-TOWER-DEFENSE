using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _arrival = 0.1f;
    int waypointIndex = 0;

    private void Update()
    {
        Vector3 heightOffsetPosition = new Vector3(_target.position.x, transform.position.y, _target.position.z);
        float distance = Vector3.Distance(transform.position, heightOffsetPosition);


        if (distance <= _arrival)
        {
            print("Ik ben er!");
        }
        else
        {
            transform.LookAt(heightOffsetPosition);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        
        }
    }
}
