Random random = new Random ();
int dayUntilExpiration = 11;
int discountPercentage = 0;

if (dayUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(dayUntilExpiration <= 5)
{
    Console.WriteLine("Your subscription expires in _ days.\n Renew now and save 10%!");
    discountPercentage = 10;
}
else if(dayUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day! \n Renew now and save 20%");
    discountPercentage = 20;
}
else if(dayUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{

}
