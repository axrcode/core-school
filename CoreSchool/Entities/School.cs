namespace CoreSchool.Entities
{
    class School
    {
        string name;
        public string Name { 
            get { return name; } 
            set { name = value.ToUpper(); }
        }
        public int YearFoundation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolType SchoolType { get; set; }

        // Constructor
        /* public School(string name, int year)
        {
            this.Name = name;
            YearFoundation = year;
        } */

        /** 
         *  * Otra manera de crear el Contructor
         */
        public School(string name, int year) => (Name, YearFoundation) = (name, year);

        public School(string name, int year, SchoolType type, string country="", string city="") 
        {
            (Name, YearFoundation) = (name, year);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Nombre: {Name} \nTipo: {SchoolType} {System.Environment.NewLine}País: {Country} \nCiudad: {City}";
        }
    }
}