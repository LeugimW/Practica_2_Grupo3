using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaController : MonoBehaviour
{

    public PuertaModel model;
    public PuertaView view;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            model.doorOpen = !model.doorOpen;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            model.doorOpen = !model.doorOpen;
        }
    }

}

