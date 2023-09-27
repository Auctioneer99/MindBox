-- create
CREATE TABLE Product (
  Id int,
  Name varchar(15)
);

CREATE TABLE Tag (
  Id int,
  Name varchar(15)
);

CREATE TABLE ProductOnTag (
  Id int,
  ProductId int,
  TagId int
);

-- insert
INSERT INTO Product(Id, Name) VALUES (1, 'Bounty');
INSERT INTO Product(Id, Name) VALUES (2, 'Milkyway');
INSERT INTO Product(Id, Name) VALUES (3, 'M&M''s');


INSERT INTO Tag(Id, Name) VALUES (1, 'White');
INSERT INTO Tag(Id, Name) VALUES (2, 'Bar');


INSERT INTO ProductOnTag(Id, ProductId, TagId) VALUES (1, 1, 1);
INSERT INTO ProductOnTag(Id, ProductId, TagId) VALUES (2, 1, 2);
INSERT INTO ProductOnTag(Id, ProductId, TagId) VALUES (3, 2, 2);

-- fetch 
SELECT p.Name, COALESCE(STRING_AGG(t.Name, ', '), '') Tags FROM Product p 
  LEFT JOIN ProductOnTag pt ON pt.ProductId = p.Id
  LEFT JOIN Tag t ON t.Id = pt.TagId
  GROUP BY p.Name;
GO