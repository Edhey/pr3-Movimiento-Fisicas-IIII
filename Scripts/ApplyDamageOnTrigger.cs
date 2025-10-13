using UnityEngine;

public class DamageZone : MonoBehaviour {
  [SerializeField] private int damageAmount = 10;

  private void OnTriggerEnter(Collider other) {
    Damage damageComponent = other.GetComponent<Damage>();
    if (damageComponent != null) {
      damageComponent.TakeDamage(damageAmount);
    }
    else {
      Debug.Log("The collided object does not have a Damage component.");
    }
  }
}
