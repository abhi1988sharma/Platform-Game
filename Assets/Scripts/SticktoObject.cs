using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SticktoObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {// makes the other game object child of the collided game object
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {// when object moves out of that object its comes back to the normal hierarchy
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }

    }

}
