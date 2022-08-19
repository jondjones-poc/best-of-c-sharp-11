namespace JonDJones.NetCore6.Examples;

public class DeconstructionExample
{
    public (string, string) GetName(string name = "Jon", string surname = "Jones")
    {
        return (name, surname);
    }

    public string GetNameOldWays()
    {
        (string firstName, string surname) = GetName();

        string firstNameAlt, surnameAlt;
        (firstNameAlt, surnameAlt) = GetName();

        return firstName + surname + firstNameAlt + surnameAlt;
    }

    public string GetNameNew()
    {
        (string firstName, string surname) = GetName();
        (firstName, string newSurname) = GetName();

        return firstName + newSurname + surname;
    }


}