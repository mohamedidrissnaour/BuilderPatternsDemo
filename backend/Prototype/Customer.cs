namespace backend.Prototype;

public class Customer : Iprototype
{
    public string name { get; set; }
    public string email { get; set; }


    public Customer(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

    public Iprototype Clone()
    {
        try
        {
            return (Customer)this.MemberwiseClone();
        }
        catch(Exception e)
        {
            throw new Exception("Clonage Impossible", e);
        }
    }


    public string getName()
    {
        return this.name;
    }

    public string getEmail()
    {
        return this.email;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public override string ToString()
    {
        return "Customer [name=" + name + ", email=" + email + "]";
    }
}