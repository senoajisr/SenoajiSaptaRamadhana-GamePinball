using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider ball;
    public Material onMaterial;
    public Material offMaterial;
    public Renderer switchRenderer;

    private bool isOn = false;

    private void OnTriggerEnter(Collider other) {
        isOn = !isOn;

        if (isOn) {
            switchRenderer.material = onMaterial;
        } else {
            switchRenderer.material = offMaterial;
        }
    }
}
