using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil3 : MonoBehaviour {
    public float radio;
    public float fuerzaExplosion;
    public float fuerzaSalto;
    public float tiempoParaExplotar;
    public LayerMask capaEnemigos;
	void Start () {
        Invoke("Detonar", tiempoParaExplotar);
	}
	
	private void Detonar()
    {
        GetComponent<Rigidbody>().isKinematic = true;//Desactivamos el rigidbody del proyectil
        Collider[] afectados = Physics.OverlapSphere(transform.position, radio, capaEnemigos);
        foreach (Collider afectado in afectados)
        {
            if (afectado.GetComponent<Rigidbody>() != null)
            {
                afectado.GetComponent<Rigidbody>().AddExplosionForce(
                    fuerzaExplosion, 
                    transform.position, 
                    radio,
                    fuerzaSalto);
            }
        }
    }
}
