using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideDetector : MonoBehaviour
{
    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        // Get child and its particle sytstem
        ps = gameObject.transform.GetChild(0).GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BunsenBurner")
        {
            Debug.Log("BunsenBurner");
            ps.Play();
        }
    }
}
