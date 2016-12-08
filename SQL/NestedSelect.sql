/* This is an example of an inner join combined with a nested select.
It will display the highest-priced item for each manufacturer with the product name, product price and manufacturer's name. */

SELECT P.Name, P.Price, M.Name
	   FROM Products AS P INNER JOIN Manufacturers AS M
	   ON P.Manufacturer = M.Code
		 AND P.Price =
		 (
			SELECT MAX(P.Price)
			FROM Products P
			WHERE P.Manufacturer = M.Code
		 )