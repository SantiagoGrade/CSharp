Random random = new Random ();
int dayUntilExpiration = 10;
int discountPercentage = 0;

if (dayUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(dayUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.\n Renew now and save 10%!");
    discountPercentage = 10;
}
else if(dayUntilExpiration == 1)
{
    
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires {dayUntilExpiration} within a day! \n Renew now and save {discountPercentage}%");
}
else if(dayUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

