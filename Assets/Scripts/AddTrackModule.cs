using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTrackModule : MonoBehaviour
{
    public GameObject prefab;
    public void InstantiateTrackPrefab()
    {
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
