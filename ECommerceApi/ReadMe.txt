1) I have create the REST API to get the products and plcae an order.
   I haven't created the GUI.

2) To run the API - change the db connection string in appsettings.json

3) Explanation -
   I have created 3 entities Products, OrderedItems and Orders.
   Migration will add the dummy data for products to see the search functionality and to place the order.

   User can get the products by either using name or category.
   /api/Products/GetProductsByNameAndCategory/{filter}
   User can also create the order which will insert record in OrderedItems as well as in Orders table.
   /api​/Orders
   Dummy JSON used to create order : 
   {
  "orderId": 0,
  "status": "open",
  "totalPrice": 525,
  "orderedItems": [
    {
      "id": 0,
      "orderedQty": 1,
      "perUnitPrice": 500,
      "productId": 3
    },
     {
      "id": 0,
      "orderedQty": 2,
      "perUnitPrice": 12.5,
      "productId": 1
    }
  ]
}