namespace backend.Prototype;



class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("idriss" , "idriss@gmail.com");
        
        Customer copycustomer = (Customer)customer1.Clone(); //on caste car il renvoie un object pas un customer 
        copycustomer.setName("ibrahim");
        copycustomer.setEmail("ibrahim@gmail.com");
        
        
        Console.WriteLine(customer1.getName());
        Console.WriteLine(copycustomer.getEmail());
    }
}