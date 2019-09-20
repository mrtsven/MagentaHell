using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        transform.gameObject.SetActive(false);
    }
}
