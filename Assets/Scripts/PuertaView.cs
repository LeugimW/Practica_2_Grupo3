using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaView : MonoBehaviour
{
    public PuertaModel model;
    void Update()
    {
        if (model.doorOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0, model.doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, model.smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, model.doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, model.smooth * Time.deltaTime);
        }
    }
}
