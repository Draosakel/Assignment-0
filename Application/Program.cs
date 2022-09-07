namespace Application;

public class Program {
    static void Main(string[] args) {
        LeapYear lyear = new LeapYear();
        Console.WriteLine("Enter desired year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if(lyear.IsLeapYear(year)) {
            Console.WriteLine("Yay");
        } else {
            Console.WriteLine("Nay");
        }
    }
}
