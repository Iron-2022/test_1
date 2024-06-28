using ClassLibrary1;

Student student1 = new Student();
student1.Name = "Dko";
student1.Ocenka = 4.5;
Student student2 = new Student();
student2.Name = "Dko";
student2.Ocenka = 4.5;
Student student3 = new Student();
student3.Name = "Dko";
student3.Ocenka = 4.5;

List<Student> arr =  new List<Student>();
arr.Add(student1);
arr.Add(student2);
arr.Add(student3);

Group group = new Group();
group.Students = arr;
group.Name = "12";
group.ShowAll();
Console.Write(group.Students[0].CompareTo(student2));
group.Students[0].Show();
