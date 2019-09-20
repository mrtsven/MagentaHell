using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public GameObject limb;
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            transform.gameObject.SetActive(false);
        }
    }
}
