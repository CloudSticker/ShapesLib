SELECT A.Name
FROM Product A
         LEFT JOIN Category C ON A.CategoryId = C.Id