using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    void OnMousDown()
    {
        transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
    }
}
