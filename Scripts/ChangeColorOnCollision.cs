using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour {
  Renderer objectRenderer;
  void Start() {
    objectRenderer = GetComponent<Renderer>();
    if (objectRenderer == null) {
      Debug.LogError("No Renderer component found on this GameObject.");
    }
  }

  private void OnCollisionEnter(Collision collision) {
    Debug.Log(gameObject.name + " collided with: " + collision.gameObject.name);
    if (objectRenderer != null) {
      objectRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
  }
}
