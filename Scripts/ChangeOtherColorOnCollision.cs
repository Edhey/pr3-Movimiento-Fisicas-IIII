using UnityEngine;

public class ChangeOtherColorOnCollision : MonoBehaviour {
  private void OnCollisionEnter(Collision collision) {
    Renderer otherRenderer = collision.gameObject.GetComponent<Renderer>();
    if (otherRenderer != null) {
      otherRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
    else {
      Debug.LogWarning("The collided object does not have a Renderer component.");
    }
    Debug.Log(gameObject.name + " collided with: " + collision.gameObject.name);
  }
}
