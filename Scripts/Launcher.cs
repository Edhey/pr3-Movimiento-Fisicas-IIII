using UnityEngine;

public class Launcher : MonoBehaviour {
  [SerializeField] private float launchForce = 700f;
  private Rigidbody projectile;

  void Start() {
    projectile = gameObject.GetComponent<Rigidbody>();
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.X)) {
      projectile.AddForce(Vector3.forward * launchForce);
    }
  }
}
