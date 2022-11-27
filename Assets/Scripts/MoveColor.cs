using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class MoveColor : MonoBehaviour
{
    public Material redMaterial;
    public Material greenMaterial;

    private void Awake()
    {
        GetComponent<Renderer>().enabled = false;
    }

    public void Green()
    {
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<MeshRenderer>().sharedMaterial = greenMaterial;
    }

    public void Red()
    {
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<MeshRenderer>().sharedMaterial = redMaterial;
    }

    public void Reset()
    {
        GetComponent<MeshRenderer>().sharedMaterial = null;
        GetComponent<MeshRenderer>().enabled = false;
    }
}
