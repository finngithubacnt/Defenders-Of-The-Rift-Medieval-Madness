using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    Vector2 MousePos;
    public Camera cam;
    void Update()
    {
        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(MousePos.x, MousePos.y, 0);
    }
}
