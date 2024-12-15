using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffToggle : MonoBehaviour
{
    public void Toggle(){
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
