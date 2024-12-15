using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneOnCollision : MonoBehaviour
{

    [SerializeField]
    string nextLevel;
   void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scenes/" + nextLevel);
        }
    }
}