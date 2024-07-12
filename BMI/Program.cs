Console.Write("Please enter your name: ");
string name = Console.ReadLine()!;

Console.Write("Please enter your height in inches: ");
//double height = double.Parse(Console.ReadLine());
if (double.TryParse(Console.ReadLine(), out double _height))
{
    Console.Write("Please enter your weight in pounds: ");
    //double weight = double.Parse(Console.ReadLine());
    if (double.TryParse(Console.ReadLine(), out double _weight))
    {
        double bmi = (_weight * 703) / (_height * _height);
        //double bmi = (_weight * 703) / (Math.Pow(bmi, 2));
        //if (bmi < 18.5)
        //{
        //    Console.WriteLine($"{name}, your BMI is {bmi}. You are underweight.");
        //}
        //else if (bmi >= 18.5 && bmi <= 24.9)
        //{
        //    Console.WriteLine($"{name}, your BMI is {bmi}. You are normal weight.");
        //}
        //else if (bmi >= 25 && bmi <= 29.9)
        //{
        //    Console.WriteLine($"{name}, your BMI is {bmi}. You are overweight.");
        //}
        //else
        //{
        //    Console.WriteLine($"{name}, your BMI is {bmi}. You are obese.");
        //}
        string weightClass = String.Empty;  // String.Empty empty readonly field and "" const
        switch (bmi)
        {
            case double n when (n < 18.5):
                weightClass = "underweight";
                //Console.WriteLine($"{name}, your BMI is {bmi:N}. You are underweight.");
                break;
            case double n when (n >= 18.5 && n <= 24.9):
                weightClass = "normal weight";
                //Console.WriteLine($"{name}, your BMI is {bmi:N}. You are normal weight.");
                break;
            case double n when (n >= 25 && n <= 29.9):
                weightClass = "overweight";
                //Console.WriteLine($"{name}, your BMI is {bmi:N}. You are overweight.");
                break;
            default:
                weightClass = "obese";
                //Console.WriteLine($"{name}, your BMI is {bmi:N}. You are obese.");
                break;
        }
        Console.WriteLine($"{name}, your BMI is {bmi:N}. You are {weightClass}");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }

}
else
{
    Console.WriteLine("Invalid input.");
}