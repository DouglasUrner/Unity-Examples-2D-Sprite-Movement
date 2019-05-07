using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController2D : MonoBehaviour
{
    /*
     * Public instance variables are visible in the Unity Inspector, they
     * are a convenient way to set tuning variables. You can also declare
     * variables that you would like to watch at runtime as public - even
     * if you shouldn't be changing them manually.
     */
    public float speed = 1.0f;
    public string axisX = "Horizontal";
    public string axisY = "Vertical";

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        /*
         * GetComponent() is a relatively expensive method, so by doing it
         * here and caching the value we reduce the overhead in Update().
         * Since the update overhead is split across the Update() methods of
         * all of the game objects, it can add up in non-obvious ways.
         */
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        /*
         * Get the amount of X and Y axis movement the user is asking for. The
         * values will be between -1.0 and 1.0, with a middle value of 0 representing
         * no movement. Negative values represent left and down, positive up and
         * right.
         */
        var moveX = Input.GetAxis(axisX);
        var moveY = Input.GetAxis(axisY);

        rb.velocity = new Vector2(moveX * speed, moveY * speed);
    }
}
