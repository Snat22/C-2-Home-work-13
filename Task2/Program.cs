using Task2;

PhotoBook photobook1 = new PhotoBook(16);

PhotoBook photobook2 = new PhotoBookTest(24);
PhotoBook photobook3 = new BigPhotoBook(64);

System.Console.WriteLine(photobook1.GetNumberPages());
System.Console.WriteLine(photobook2.GetNumberPages());
System.Console.WriteLine(photobook3.GetNumberPages());

