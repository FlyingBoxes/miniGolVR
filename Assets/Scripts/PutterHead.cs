using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutterHead : MonoBehaviour
{
    [SerializeField] private PutterHeadFollower _putterHeadFollowerPrefab;

    private void SpawnPutterHeadFollower()
    {
        var follower = Instantiate(_putterHeadFollowerPrefab);
        follower.transform.position = transform.position;
        follower.SetFollowTarget(this);
    }

    private void Start()
    {
        SpawnPutterHeadFollower();
    }
}
