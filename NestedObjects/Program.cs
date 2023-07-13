using NestedObjects;

Advisor compSciAdvisor = new()
{
	Email = "Annemarie@cptc.edu",
	FullName = "Annemarie Smith",
	OfficeLocation = "B17 Rm 150"
};

Student stu1 = new()
{
	Firstname = "Homer",
	Lastname = "Simpson",
	DateOfBirth = new DateOnly(2000, 3, 20),
	AssignedAdvisor = compSciAdvisor,
	PhoneNumber = "2535215512",
	SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.Firstname} has {stu1.AssignedAdvisor.FullName}");