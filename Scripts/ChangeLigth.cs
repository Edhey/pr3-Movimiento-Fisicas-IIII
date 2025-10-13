using UnityEngine;

public class ChangeLigth : MonoBehaviour {
  [SerializeField] private Light sceneLight;
  private float originalIntensity;
  private Color originalColor;

  void OnTriggerEnter(Collider other) {
    originalIntensity = sceneLight.intensity;
    originalColor = sceneLight.color;
    sceneLight.intensity = 2.0f;
    sceneLight.color = Color.red;
  }

  void OnTriggerExit(Collider other) {
    sceneLight.intensity = originalIntensity;
    sceneLight.color = originalColor;
  }
}
