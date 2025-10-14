using UnityEngine;

public class IsTrigger : MonoBehaviour {
  private void OnTriggerEnter(Collider other) {
    Debug.Log("Trigger Enter with " + other.name);
  }

  private void OnTriggerStay(Collider other) {
    Debug.Log("Trigger Stay with " + other.name);
  }

  private void OnTriggerExit(Collider other) {
    Debug.Log("Trigger Exit with " + other.name);
  }

  private void OnCollisionEnter(Collision collision) {
    Debug.Log("Collision Enter with " + collision.gameObject.name);
  }
}
