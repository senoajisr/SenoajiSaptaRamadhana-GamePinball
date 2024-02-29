using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
  public Collider ball;
  public CameraController cameraController;

  private void OnTriggerEnter(Collider other)
  {
    if (other == ball)
    {
        cameraController.GoBackToDefault();
    }
	}
}