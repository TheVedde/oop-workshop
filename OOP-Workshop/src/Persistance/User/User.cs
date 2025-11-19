namespace OOP_Workshop.Persistance.User
{
    public abstract class User
    {
        int _id;
        string _name;
        int _age;
        string _SSN;

        public User(int id, string name, int age, string ssn)
        {
            _id = id;
            _name = name;
            _age = age;
            _SSN = ssn;
        }

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string SSN { get { return _SSN; } set { _SSN = value; } }

    }
}
