using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductObjectManager : MonoBehaviour
{
    [Header("Scripts And Object")]


    [Tooltip("Game Manager Script")]
    [SerializeField]
    private GameManager gameManager;


    [Space(10f)]

    [Tooltip("The class in the scriptable type that holds the product information")]
    [SerializeField]
    private Objects.ProductObject productObject;


    
#region property

    public Objects.ProductObject _productObject { get { return this.productObject; }  set { this.productObject = value; } }

#endregion





    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (gameManager == null)
             this.gameManager = GameObject.FindWithTag("scripts").GetComponent<GameManager>();
        
    }




    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "fail")
            productObject.Buy(gameManager); // method of purchasing the object!
    }
}
