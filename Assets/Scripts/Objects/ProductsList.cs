using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Objects;

public class ProductsList : MonoBehaviour
{
    // maksimun kac adet yiyecek oldugunu giriniz!
    private int foodMaxValue = 100;

    [Header("Variables")]

    [Tooltip("List of foods")]
    [SerializeField]
    private List<Objects.ProductObject> foods = new List<Objects.ProductObject>();


    #region Propertys

    public List<Objects.ProductObject> _foods { get { return foods; } }

    #endregion

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
    }

   

    private void FoodLoad()
    {
        Objects.ProductObject product;
        
            product = new Objects.ProductObject("", 0, Objects.ProductType.Food, false);
        
    }
}
