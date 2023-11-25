/* 
По условию данной задачи допустим у нас в базе данных существуют 3 таблицы:

Product: ProductID, Name
Category: CategoryID, Name
ProductCategory: ProductID, CategoryID

Для того чтобы получить все пары «Имя продукта – Имя категории», нужно выполнить следующий запрос:
*/

SELECT Product.Name AS "Имя продукта", Category.Name AS "Имя категории"
FROM Product
LEFT JOIN ProductCategory ON Product.ProductID = ProductCategory.ProductID
LEFT JOIN Category ON ProductCategory.CategoryID = Category.CategoryID

-- LEFT JOIN поволяет получить названия даже тех продуктов, у которых нет категории

