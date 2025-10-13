using UnityEngine;

public class Damage : MonoBehaviour {
  private int damage = 0;

  public void TakeDamage(int amount) {
    damage += amount;
    Debug.Log(gameObject.name + " has taken " + amount + " damage. Total damage: " + damage);
  }
}
