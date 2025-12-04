CREATE TABLE TshirtsInventory (

    ProductID INT PRIMARY KEY IDENTITY(1,1),
    
  
    ProductName VARCHAR(100) NOT NULL, 
    StyleType VARCHAR(50) NULL,        
    Color VARCHAR(30) NULL,
    Size VARCHAR(10) NULL,             
    Status VARCHAR(50) NULL,           
    

    Stock INT NOT NULL DEFAULT 0,
    Price DECIMAL(10, 2) NOT NULL DEFAULT 0.00
);
INSERT INTO TshirtsInventory (ProductName, StyleType, Color, Size, Status, Stock, Price) 
VALUES 
('Basic T', 'Crew-neck', 'Blue', 'M', 'Active', 100, 19.99),
('Premium Polo', 'Polo', 'Black', 'L', 'Active', 50, 39.50),
('Vintage Tee', 'V-neck', 'Red', 'S', 'Low Stock', 20, 24.99);
SELECT * FROM TshirtsInventory;