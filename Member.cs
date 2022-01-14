using System;

namespace AssDay1
{
    class Member
    {
        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private string _birthday;
        public string BirthDay
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _place;
        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private bool _graduated;
        public bool Graduated
        {
            get { return _graduated; }
            set { _graduated = value; }
        }
        public Member() { }
        public Member(string fistname, string lastname, string gender, string birth, string phone, string place, int age, bool graduated)
        {
            FirstName = fistname;
            LastName = lastname;
            Gender = gender;
            BirthDay = birth;
            Phone = phone;
            Place = place;
            Age = age;
            Graduated = graduated;
        }
         public void Show()
        {
            Console.WriteLine(FirstName + "\t" + LastName + "\t" + Gender + "\t" + BirthDay + "\t" + Phone + "\t" + Place + "\t" + Age + "\t" + Graduated);
        }
        public string ToString()
        {
            return  Gender + "\t" + BirthDay + "\t" + Phone + "\t" + Place + "\t" + Age + "\t" + Graduated;
        }
           public void Add()
        {
            Console.WriteLine("FirstName: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            LastName= Console.ReadLine();
            Console.WriteLine("Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Date of Birthday:");
            BirthDay = Console.ReadLine();
            //Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Phone: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Place: ");
            Place = Console.ReadLine();
            Console.WriteLine("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Graduated: ");
            Graduated =Convert.ToBoolean(Console.ReadLine());
        }
    }
}