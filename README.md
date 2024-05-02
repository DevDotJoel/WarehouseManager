<h3><b>Warehouse Management App</b></h3>

Overview
This  Warehouse Management App is designed to efficiently manage warehouse data for a multi-store retail business. The app facilitates tracking product movements, managing inventory across stores and warehouses, and providing insights into item history.

Requirements
The app is designed to meet the following requirements:

Data Schema: The data schema includes the following tables:
Products: Information about available products.
Stores: Details of retail stores.
Employees: Records of employees involved in warehouse operations.
WarehouseSlot: Information about warehouse slots containing products.
Items: Instances of products stored in the warehouse.
ItemMovements: Records of product movements between stores and warehouses.
Real-time Product Location: Users should be able to determine the current location of a product at any given time.
Transit Management: Products can move between stores and warehouses. The app should facilitate tracking product movements during transit.
Item Movement Tracking: Whenever a product is in movement, a new record must be added to the "ItemMovement" table. Each movement record should include two employees associated with it—one from the shipping end and one from the receiving end.
Item Management: An "Item" represents an instance of a product. While products are unique, there can be multiple items of the same product.
Warehouse Slot Information: Warehouse slots must contain at least an "Isle" and a "Slot Number" for efficient organization.
History Tracking: Users should have access to a comprehensive history of item movements, enabling them to track the journey of products within the warehouse system.
Usage
To effectively utilize the Warehouse Management App, follow these steps:

Installation: Install the app on your preferred platform (web, mobile, desktop).
Authentication: Log in using your credentials to access the system.
Navigation: Use the intuitive interface to navigate through different functionalities:
View product information.
Track product movements.
Manage warehouse slots.
Access employee records.
Search and Filter: Utilize search and filter functionalities to quickly locate specific products, movements, or employee records.
Data Entry: Add new products, update inventory, and record item movements as required.
Analytics: Leverage built-in analytics tools to gain insights into inventory trends, movement patterns, and warehouse efficiency.
