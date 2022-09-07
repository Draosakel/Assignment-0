﻿// See https://aka.ms/new-console-template for more information
leapYear lyear = new leapYear();
Console.WriteLine("Enter desired year: ");
int year = Convert.ToInt32(Console.ReadLine());
if(lyear.IsLeapYear(year)) {
    Console.WriteLine("Yay");
} else {
    Console.WriteLine("Nay");
}
public class leapYear {
    public bool IsLeapYear(int year) {
        if(year % 100 == 0 && year % 400 != 0) return false;
        if(year % 4 == 0) return true;
        return false;
    }
}
