/** Ejercicio 1: Crea un personaje, controla su desplazamiento con las teclas 
  * WASD o las flechas, el movimiento debe estar influenciado por usando un 
  * Rigidbody, pero manteniendo el control total.
  */

using UnityEngine;

public class ASWDMove : MonoBehaviour {
  [SerializeField] private float speed = 5f;
  private Rigidbody rb;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    float verticalInput = Input.GetAxis("Vertical");
    float horizontalInput = Input.GetAxis("Horizontal");

    Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed;
    Vector3 newPosition = rb.position + movement * Time.deltaTime;
    rb.MovePosition(newPosition);
  }
}
