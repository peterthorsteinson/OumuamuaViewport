using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleOumuamuaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Tumble Oumuamua
        transform.Rotate(Vector3.up * Time.deltaTime * 80.0f);
        transform.Rotate(Vector3.right * Time.deltaTime * 20.0f);
    }
}
