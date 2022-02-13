using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour
{
    public string targetTag = "Player";
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == targetTag) 
        {
            GetComponentInParent<SlimeBehaviour>().target = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.Equals(GetComponentInParent<SlimeBehaviour>().target))
        {
            GetComponentInParent<SlimeBehaviour>().target = null;
        }
    }
}
