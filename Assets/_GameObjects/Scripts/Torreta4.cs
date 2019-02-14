using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta4 : MonoBehaviour {

    public Transform puntoMira;
    public GameObject prefabImpacto;
    float x, y;
    private void Update()
    {
        MoveTurrent();
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            Ray rayo = new Ray(puntoMira.position, puntoMira.forward);
            Debug.DrawRay(puntoMira.position, puntoMira.forward * 10, Color.red, Mathf.Infinity);
            bool hayImpacto = Physics.Raycast(rayo, out hit, Mathf.Infinity);
            if (hayImpacto)
            {
                Instantiate(prefabImpacto, hit.point, Quaternion.LookRotation(hit.normal));
            }
        } 
        
    }
    private void MoveTurrent()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(y, x, 0);
    }
}
