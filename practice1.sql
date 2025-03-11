

select * from [university].[students]
  
  
  insert into university.students(studentID, firstname, lastname, email, dateofbirth)
  values (2, 'charry', 'singla', 'charry12@gmail.com', '2002-07-12'),
  (3, 'prince', 'sharma', 'prince05@gmail.com', '1997-02-14'),
  (4, 'hardeep', 'singh', 'hardeepsingh@gmial.com', '1995-08-24'),
  (5, 'jaspreet', 'kaur', 'jaskaur@gmail.com', '1998-03-21'),
  (6 ,'simran', 'kalra', 'simikalra@gmail.com', '2003-04-18'),
  (7, 'kulwinder', 'kaur', 'kulwinder23@gmail.com', '1999-07-23'),
  (8, 'Mehak', 'Sandhu', 'mehaksandhu@gmial.com', '1998-05-28'),
  (9, 'Mandeep', 'singh', 'ms07066@gmial.com', '1996-09-07');


  Begin tran

  select * from university.students where studentID=2,3,4

