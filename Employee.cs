using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    internal class Employee
    {
        public Employee() { }
        public Employee(string ename , string eaddress, string ephone) {
            name = ename;
            address = eaddress;
            phone = ephone;

        }
        private string name;
        private string address;
        private string phone;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public void Input() {
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            Phone = Console.ReadLine(); 
        }
        public void Display()
        {
            Console.WriteLine("Name = {0} Address = {1} Phone {2} ",
                                Name, Address,Phone);
        }
    }
}
