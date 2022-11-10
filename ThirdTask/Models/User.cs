
namespace CoolSmFramework.ThirdTask.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public User(int id, string firstName, string lastName, string email, int age, int salary, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Salary = salary;
            Department = department;
        }

        public bool IsEqualTo(User gameInfo)
        {
            return String.Equals(this.FirstName, gameInfo.FirstName) &&
                String.Equals(this.LastName, gameInfo.LastName) &&
                String.Equals(this.Email, gameInfo.Email) &&
                String.Equals(this.Age, gameInfo.Age) &&
                String.Equals(this.Salary, gameInfo.Salary) &&
                String.Equals(this.Department, gameInfo.Department);
        }
    }
}
