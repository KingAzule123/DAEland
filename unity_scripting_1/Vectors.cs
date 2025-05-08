public class Vectors : MonoBehaviour
{
    // Start is called before the first frame update
    void UseVector()
    {
        Vector2 position = new Vector2(3.0f, 2.0f); 
    }

    void UseVector3()
    {
        Vector3 position3D = new Vector(3.0f, 2.0f, 3.0f);
    }

    // Update is called once per frame
    void UseStaticPoperties()
    {
        Vector3 moveForward = Vector3.forward;
        Vector3 moveUp  = Vector3.up;
        Vector3 moveDown = Vector3.down;
        Vector3 moveLeft = Vector3.left;
        Vector3 moveRight = Vector3.right;
    }


    void update()
    {

    }
}
