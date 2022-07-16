using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Touch theTouch;
    private Vector2 touchStartPosition, touchEndPosition;

    // Update is called once per frame
    void Update () {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
     
            if (touch.phase == TouchPhase.Moved) 
            {
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
                // transform.position = Vector3.Lerp(transform.position, new Vector3(touchedPos.x, transform.position.y, transform.position.z), 1f);

                // Move slowly the player to the touched position
                transform.position = Vector3.Lerp(transform.position, new Vector3(touchedPos.x, transform.position.y, transform.position.z), 0.1f);
            }
        }
    }
}
