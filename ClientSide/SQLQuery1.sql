CREATE SCHEMA estore

CREATE TABLE estore.categories (
  id INT NOT NULL,
  category NVARCHAR(45) DEFAULT NULL,
  parent_category_id INT DEFAULT NULL,
  PRIMARY KEY (id)
)
INSERT INTO estore.categories (id, category, parent_category_id) VALUES
(2, 'Women', NULL),
(3, 'Kids', NULL),
(4, 'Casual Wear', 1),
(5, 'Party Wear', 2),
(6, 'Foot Wear', 2),
(7, 'Accessories', 3)

CREATE TABLE estore.products (
  id INT NOT NULL,
  product_name NVARCHAR(45) DEFAULT NULL,
  product_description NVARCHAR(100) DEFAULT NULL,
  price DECIMAL(10, 0) DEFAULT NULL,
  ratings INT DEFAULT NULL,
  category_id INT DEFAULT NULL,
  product_img NVARCHAR(45) DEFAULT NULL,
  PRIMARY KEY (id),
  CONSTRAINT FK_Products_Categories FOREIGN KEY (category_id)
  REFERENCES estore.categories (id) ON DELETE CASCADE ON UPDATE CASCADE
)
INSERT INTO estore.products (id, product_name, product_description, price, ratings, category_id, product_img) VALUES
(1, 'Jacket', 'Jacket description goes here', 100, 5, 5, 'shop-1.jpg'),
(2, 'Purse', 'Very nice purse', 25, 3, 7, 'shop-2.jpg'),
(3, 'Dress', 'Nice Party Dress', 45, 4, 5, 'shop-3.jpg'),
(4, 'Denim Jeans', 'Denim Jeans', 50, 4, 4, 'shop-4.jpg'),
(5, 'Laced Boots', 'Premium leather boots', 65, 4, 6, 'shop-5.jpg'),
(6, 'Back pack', 'Spacious back pack', 20, 5, 7, 'shop-6.jpg'),
(7, 'Ear rings', 'Beautiful ear rings', 10, 4, 7, 'shop-7.jpg'),
(8, 'Scarf', 'Matching scarf', 30, 4, 7, 'shop-8.jpg'),
(9, 'Boots', 'Black leather boots', 70, 4, 6, 'shop-9.jpg')

select * from estore.categories