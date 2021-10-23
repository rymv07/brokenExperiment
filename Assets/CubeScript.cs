using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject mainCube;
    public GameObject mCube;
    public GameObject sphereHolder;

    public Rigidbody rb;
    public Collider bc;


    // to set the Main Cube and disabled the Spheres
    private void Start()
    {
        mainCube.SetActive(true);
        mCube.SetActive(true);
        sphereHolder.SetActive(false);
        bc.gameObject.SetActive(true);
        rb.useGravity = true;
    }

    // this will disable the Cubea and enable the Sphere to make the shatter effect
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            mCube.SetActive(false);
            sphereHolder.SetActive(true);
            bc.gameObject.SetActive(false);
            rb.useGravity = false;
            mainCube.SetActive(true);
        }

    }


}
