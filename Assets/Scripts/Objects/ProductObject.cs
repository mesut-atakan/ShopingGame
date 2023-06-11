using UnityEngine;




namespace Objects
{
    [System.Serializable]
    public class ProductObject
    {
        [Header("Product Properties")]


        [Tooltip("Name of the product")]
        [SerializeField]
        private string productName;






        [Tooltip("The price of the product")]
        [SerializeField]
        private int buyMoney = 10;



        [Tooltip("It's the guy who makes sure the ball doesn't miss the bowl")]
        [SerializeField]
        private bool productBuy = false;



        [Space(8f)]

        [Tooltip("Products Type")]
        [SerializeField]
        private ProductType productType;





        [Space(15f)]

        [Header("Design & Model Variables")]


        [Tooltip("Add a 2-dimensional photo of the product here")]
        [SerializeField]
        private Sprite productImage;


        [Tooltip("Add the model of the product here")]
        [SerializeField]
        private GameObject productModel;






    #region Propertys:

        public ProductType _productType { get { return productType; }  set { productType = value; } }
        public string _productName { get { return productName; }  set { productName = value; } }
        public bool _productBuy { get { return productBuy; }  set { productBuy = value;} }
        public int _buyMoney { get { return buyMoney; }  set { buyMoney = value; } }
        public GameObject _productModel { get {return productModel; } }

    #endregion



        // CONSTRUCTOR
        public ProductObject(string _name, int _money, ProductType type,bool _buy = false)
        {
            // To create a new product, the information entered as a parameter and the variables are synchronized.
            this.productName = _name;
            this.buyMoney = _money;
            this.productType = type;
            this.productBuy = _buy;

            return;
        }

        // Null Constructor
        public ProductObject()
        {

        }






#region Functions and Methods


        /// <summary>
        /// The method used to purchase this item
        /// </summary>
        /// <param name="gameManager">Add the gameManager script as a parameter to update the game!</param>
        public void Buy(GameManager gameManager)
        {
            productBuy = true;
            gameManager.MoneyChange(this.buyMoney);
            Debug.Log($"{this.productName} product named {this.buyMoney} <color=blue>TL</color> Sold for the price!");
            return;
        }


#endregion
    }





    public enum ProductType
    {
        Food,
        Drink,
        Furniture // esya
    }
}
