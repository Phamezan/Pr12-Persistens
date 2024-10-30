namespace Persistens
{
    public class Person
    {
        private string _name;
        private DateTime _birthDate;
        private double _height;
        private bool _isMarried;
        private int _noOfChildren;
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public double Height { get; set; }

        public bool IsMarried { get; set; }

        public int NoOfChildren { get; set; }

        public Person(string name, DateTime _birthDate, double height, bool _isMarried, int _noOfChildren)
        {
            Name = name;
            BirthDate = _birthDate;
            Height = height;
            IsMarried = _isMarried;
            NoOfChildren = _noOfChildren;
        }

        public string MakeTitle()
        {
            return $"{Name};{BirthDate};{Height};{IsMarried};{NoOfChildren}";
        }
    }
}
