using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDestroy : MonoBehaviour
{
    GameObject controlPuntuacionTextoActualizar;
    ControlPuntuacion controlPuntucion2;

    private void Awake()
    {
        controlPuntuacionTextoActualizar = GameObject.FindGameObjectWithTag("ControlPuntuacion");
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Diana")
        {
            GameObject diana = this.gameObject;
            GameObject bala=collision.gameObject;
            Collider myCollider = collision.GetContact(0).otherCollider;
            if (myCollider.gameObject.tag == "Centro")
            {
                controlPuntuacionTextoActualizar.GetComponent<ControlPuntuacion>().SumarPuntuacion(10);
                Destroy(diana);
                Destroy(bala);
            }
            if (myCollider.gameObject.tag == "Medio")
            {
                controlPuntuacionTextoActualizar.GetComponent<ControlPuntuacion>().SumarPuntuacion(5);
                Destroy(diana);
                Destroy(bala);
            }
            if (myCollider.gameObject.tag == "Fuera")
            {
                controlPuntuacionTextoActualizar.GetComponent<ControlPuntuacion>().SumarPuntuacion(1);
                Destroy(diana);
                Destroy(bala);
            }
        }
        
    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Diana"))
        
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }*/
}
