using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    private Renderer renderer;
    [SerializeField] Material raycastMaterialEnter;
    [SerializeField] Material raycastMaterialExit;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        renderer.material = raycastMaterialEnter;
    }
    private void OnMouseExit()
    {
        renderer.material = raycastMaterialExit;
    }
}
