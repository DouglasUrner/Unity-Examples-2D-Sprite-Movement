using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController2DMinimal : MonoBehaviour
{
    public float speed = 1.0f;
    public string axisX = "Horizontal";
    public string axisY = "Vertical";

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        var moveX = Input.GetAxis(axisX);
        var moveY = Input.GetAxis(axisY);

        rb.velocity = new Vector2(moveX * speed, moveY * speed);
    }

    /*
     * OnCollisionEnter() is called whenever we collide with another game
     * object with a collider component. We are passed a Collision 2D object,
     * other, that we can examine to determine what we collided with. When we
     * collide with an
     * object the behavior of our sprite and of the object we collided with is
     * determined by the Unity physics engine - if you just want to detect the
     * collision, use OnTriggerEnter() and set the IsTrigger property on the
     * game object's collider.
     */
    void OnCollisionEnter2D(Collision2D other) {
      Debug.Log("OnCollisionEnter2D(): hit " + other);
        throw new System.NotImplementedException();
    }
}
