using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta2 : MonoBehaviour {

    public Transform puntoMira;
    private void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            Ray rayo = new Ray(puntoMira.position, puntoMira.forward);
            Debug.DrawRay(puntoMira.position, puntoMira.forward * 10, Color.red, Mathf.Infinity);
            bool hayImpacto = Physics.Raycast(rayo, out hit, Mathf.Infinity);
            if (hayImpacto)
            {
                if (hit.rigidbody!=null)
                {
                    hit.rigidbody.AddForce(Vector3.forward * 100);
                }
            }
        }
    }
}
