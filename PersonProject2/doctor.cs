class Doctor : Person
{
    private string _pHD;

    public Doctor(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        _pHD = "pHD";
    }

    public string DisplayDoctor()
    {
        string[] tempPerson = DisplayPerson().Split(" ");
        List<string> _tempPerson = tempPerson.ToList().Insert(3,_pHD);
        return $"{tempPerson}";
    }
}