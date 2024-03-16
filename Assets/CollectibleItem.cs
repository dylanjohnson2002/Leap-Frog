using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string Sphere;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Item collected: {Sphere}");
        Destroy(this.gameObject);
    }
}
