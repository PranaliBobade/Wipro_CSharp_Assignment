using System;
using System.Collections.Generic;

public class CustomerList
{
    private Dictionary<string, List<string>> customerList;

    public CustomerList()
    {
        customerList = new Dictionary<string, List<string>>();
    }

    public void AddCustomer(string plan, string customerName)
    {
        if (!customerList.ContainsKey(plan))
        {
            customerList.Add(plan, new List<string>());
        }
        customerList[plan].Add(customerName);
    }

    public void RemoveCustomer(string plan, string customerName)
    {
        if (customerList.ContainsKey(plan))
        {
            customerList[plan].Remove(customerName);
        }
    }

    public void PrintCustomers(string plan)
    {
        if (customerList.ContainsKey(plan))
        {
            foreach (var customer in customerList[plan])
            {
                Console.WriteLine(customer);
            }
        }
        else
        {
            Console.WriteLine("No customers found in this plan");
        }
    }

    public void AddNewCustomerBasedOnPlan(string plan, string newCustomerName)
    {
        if (!customerList.ContainsKey(plan))
        {
            Console.WriteLine("Plan does not exist. Please create a plan first");
            return;
        }
        customerList[plan].Add(newCustomerName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomerList customerList = new CustomerList();

        customerList.AddCustomer("PlanA", "John");
        customerList.AddCustomer("PlanA", "Alice");
        customerList.AddCustomer("PlanB", "Bob");

        customerList.PrintCustomers("PlanA");

        customerList.AddNewCustomerBasedOnPlan("PlanA", "Jane");

        customerList.PrintCustomers("PlanA");
    }
}
