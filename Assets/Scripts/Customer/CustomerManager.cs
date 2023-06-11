using UnityEngine;


public class CustomerManager : MonoBehaviour
{
    [Header("Components & Scripts")]


    [Tooltip("Called script to take advantage of the lists in the `ProductList` class to see all the products in the market")]
    [SerializeField]
    private ProductsList productsList;







    [Space(15f)]

    [Header("Objects")]

    [Tooltip("Name the Mustery Prefab this way")]
    [SerializeField]
    private GameObject customerPrefab;







    [Space(15f)]

    [Header("Variables")]


    [Tooltip("Enter the number of customers that should be on the stage!")]
    [SerializeField]
    private int customerValue = 5;










    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        CustomerCreate();
    }









    /// <summary>
    /// This method is used to deliver the product to the desired customer!
    /// </summary>
    /// <returns>randomly selected items will be sent back</returns>
    public Objects.ProductObject[] CustomerProducts()
    {
        // Variables
        int maxProductValue = productsList._foods.Count;                // Shows the maximum number of items in the menu!
        int customerProductsValue = Random.Range(0, maxProductValue);   // A random number is generated between the maximum number of elements in the list and 1, which displays the number of elements the customer has
        Objects.ProductObject[] customerProducts = new Objects.ProductObject[customerProductsValue];    // A customer's array is created and the products the customer has purchased are listed in this array.
        int randomIndex;                                                // To pull a random product from the list, this variable is assigned a value within the loop.

        for (int foodProduct = 0; foodProduct < customerProductsValue; foodProduct++)   // The items in the customer's hands are put into the loop and the customer is given random items from the list.
        {
            randomIndex = Random.Range(0, maxProductValue);                     // A random value is drawn from the product list in the market.
            customerProducts[foodProduct] = productsList._foods[randomIndex];   // A randomly picked product is added to the customer's product list!
        }

        Debug.Log($"To the customer's cart {customerProducts.Length} so much has been added");
        return customerProducts;                            // The products in the hands of the customer are returned!
    }







    public void CustomerCreate()
    {
        Vector3 createPosition = Vector3.zero;
        for (int i = 0; i < customerValue; i++)
        {
            Instantiate(customerPrefab, createPosition, Quaternion.identity);
            createPosition.x += 5f;
        }
    }
}