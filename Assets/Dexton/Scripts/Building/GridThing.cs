using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform posOfMouse;
    public Transform pos1;
    public Transform pos2;

    public Camera cam;
    public GameObject Wall;
    public SpriteRenderer Sr;

    public bool WallThere;
    public bool touchingMouse;

    public LayerMask whatWall;
    public LayerMask mouseLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (!WallThere && touchingMouse)
            {
                Instantiate(Wall, transform.position, Quaternion.identity);
            }  
        }

       // mousePos = new Vector2

    }
}
