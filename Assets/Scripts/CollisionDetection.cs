using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CollisionDetection : MonoBehaviour
{
    private Rigidbody rb;
    public UnityEvent Collision;
    public string colTag;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        Collide(colTag, col);
    }

    void Collide(string tag, Collision col)
    {
        if (col.gameObject.tag == tag)
        {
            Debug.Log("Collision");

            Collision.Invoke();
        }
    }
}
