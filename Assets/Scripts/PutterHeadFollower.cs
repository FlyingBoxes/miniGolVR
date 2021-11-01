using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutterHeadFollower : MonoBehaviour
{
    private PutterHead _putterFollower;
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    //private Vector3 lastVelocity;
   // private Vector3 _acceloration;


    [SerializeField] private float _sensitivity = 100f;

    //private void Start()
    //{
    //    lastVelocity = Vector3.zero;
    //}
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 destination = _putterFollower.transform.position;
        _rigidbody.transform.rotation = transform.rotation;

        _velocity = (destination - _rigidbody.transform.position) * _sensitivity;

        //var currentVelocity = _velocity;
        //if (currentVelocity != lastVelocity)
        //{
        //    _acceloration = (currentVelocity - lastVelocity) / Time.fixedDeltaTime;
        //}
        //lastVelocity = currentVelocity;

        _rigidbody.velocity = _velocity;
        transform.rotation = _putterFollower.transform.rotation;
    }

    public void SetFollowTarget(PutterHead putterFollower)
    {
        _putterFollower = putterFollower;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Ball"))
    //    {
    //        Vector3 force = GetComponent<Rigidbody>().mass * _acceloration;
    //        other.GetComponent<Rigidbody>().AddForce(force);
    //    }
    //}
}
