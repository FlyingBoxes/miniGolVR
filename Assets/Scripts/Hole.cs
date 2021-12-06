using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    [SerializedField] private GameMaster GM;
    [SerializeField] private AudioSource inHole;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            inHole.Play(0);
            GameMaster.sceneIndex++;
            StartCoroutine("LoadNextHole");
        }
    }

    IEnumerator LoadNextHole()
    {
        yield return new WaitForSeconds(5);
        GameMaster.LoadNextScene();
    }
}
