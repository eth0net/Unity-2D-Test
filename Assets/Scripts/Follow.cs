using System;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position;
    }

    void Update()
    {
        var targetPosition = target.position;
        transform.position = new Vector3(targetPosition.x + _offset.x, targetPosition.y + _offset.y, _offset.z);
    }
}