using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Speed ​​of moving an item")]
    [SerializeField]
    private float productMoveSpeed = 15f;



    [Tooltip("Variable showing the object the player is holding!")]
    [SerializeField]
    private Transform grabProductTransform;



    [Tooltip("Boolean variable that controls whether an object is actively moved")]
    [SerializeField]
    private bool dragging = false;



    private new Camera camera;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        camera = Camera.main;
    }



    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        
    }



    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        RaySystem();
    }





    public void RaySystem()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "product")
            {
                if (Input.GetMouseButton(0))
                    ProductMove(hit.transform, ray, mousePosition);
                else if (Input.GetMouseButtonUp(0))
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.GetComponent<Collider>().isTrigger = false;
                }
            }
        }
    }




    /// <summary>
    /// The function of moving the item that the player caught with the raycast!
    /// </summary>
    /// <param name="_product">Add the retained product as a parameter!</param>
    public void ProductMove(Transform _product, Ray ray, Vector3 mousePosition)
    {
        Rigidbody rb = _product.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        Collider collider = _product.GetComponent<Collider>();
        collider.isTrigger = true;



        float zAxis = _product.position.z - camera.transform.position.z;
        mousePosition.z = zAxis;
        Vector3 dragPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        _product.transform.position = dragPosition;
    }
}
