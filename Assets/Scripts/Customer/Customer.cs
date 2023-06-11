using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    [Header("Script & Components")]


    [Tooltip("Assign the script that manages customers to this variable")]
    [SerializeField]
    private CustomerManager customerManager;



    [Header("Customer Variables")]

    [Tooltip("This customer's shopping list")]
    [SerializeField]
    private Objects.ProductObject[] shoppingCart;
















    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (customerManager == null)
            customerManager = GameObject.FindGameObjectWithTag("scripts").GetComponent<CustomerManager>();
    }









    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        shoppingCart = customerManager.CustomerProducts();
        shoppingCartCreate();
    }







    /// <summary>
    /// customers' products will be created in this method!
    /// </summary>
    public void shoppingCartCreate()
    {
        // Variables
        GameObject _productGameObject = null;   // created items will be stored in this variable until next build
        ProductObjectManager pom;
        Vector3 createPosition = Vector3.zero;
        foreach (Objects.ProductObject product in shoppingCart)
        {
            _productGameObject = Instantiate(product._productModel, createPosition, Quaternion.identity);     // product created object assigned to variable. 
            pom = _productGameObject.GetComponent<ProductObjectManager>();
            pom._productObject = product;
            createPosition.y += 5f;
        }
    }
}
