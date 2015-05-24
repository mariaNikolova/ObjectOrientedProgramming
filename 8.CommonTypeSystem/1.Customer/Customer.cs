using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Customer
{
    enum CustomerType
    {
        OneTime , Regular, Golden, Diamond
    }
    class Customer: ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int id;
        private string address;
        private string mobilePhone;
        private string email;
        private List<Payment> payment ;
        private CustomerType customerType ;

        public Customer(string fName,string mName, string lName, int id, string address,
            string mobilePhone, string email, List<Payment> payment, CustomerType customerType)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.Id = id;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payment = payment;
            this.customerType = customerType;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can not be empty! ");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can not be empty! ");
                }
                this.middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can not be empty! ");
                }
                this.lastName = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The address can not be empty! ");
                }
                this.address = value;
            }
        }
        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The phone can not be empty! ");
                }
                this.mobilePhone = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The email can not be empty! ");
                }
                this.email = value;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.id = value;
            }
        }
        public List<Payment> Payment
        {
            get
            {
                return this.payment;
            }
            set
            {
                this.payment = value;
            }
        }
        public override bool Equals(object param)
        {
            Customer customer = param as Customer;
            if (customer == null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, customer.FirstName) || !Object.Equals(this.MiddleName, customer.MiddleName) ||
                !Object.Equals(this.LastName, customer.lastName) || !Object.Equals(this.MobilePhone, customer.mobilePhone) ||
                !Object.Equals(this.Address, customer.Address))
            {
                return false;
            }
            if (this.Id != customer.Id || this.customerType != customer.customerType)
            {
                return false;
            }
            for (int i = 0; i < payment.Count; i++)
            {
                if(!Object.Equals(this.payment[i], customer.payment[i]))
                {
                    return false;
                }
            }
                return true;
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode()^ Address.GetHashCode()^
                Email.GetHashCode()^ MobilePhone.GetHashCode()^Id.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("First name: " + this.firstName);
            result.AppendLine("Middle name: " + this.middleName);
            result.AppendLine("Last name: " + this.lastName);
            result.AppendLine("Id: " + this.id);
            result.AppendLine("Address: " + this.address);
            result.AppendLine("Mobile phone: " + this.mobilePhone);
            result.AppendLine("Email: " + this.email);
            foreach (var item in payment)
            {
                result.Append(item);
            }
            result.AppendLine();
            result.AppendLine("Customer type: " + this.customerType);

            return result.ToString(); 
        }
        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }
        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Customer Clone()
        {
           
            string newFirstName = this.FirstName;
            string newMiddleName = this.MiddleName;
            string newLastName = this.LastName;
            int newId = this.id;
            string newAddress = this.address;
            string newEmail = this.email;
            string newMobilePhone = this.mobilePhone;
            CustomerType newCustomerType = this.customerType;
            List<Payment> newPayment = new List<Payment>();
            foreach(var item in this.payment)
            {
                newPayment.Add(item);
            }

            Customer customer = new Customer(newFirstName,newMiddleName,newLastName,newId,
                newAddress,newMobilePhone,newEmail,newPayment,newCustomerType);
            return customer;
        }

        public int CompareTo(Customer otherCustomer)
        {
            if (this.FirstName != otherCustomer.FirstName)
            {
                return this.FirstName.CompareTo(otherCustomer.FirstName);
            }
            return this.Id.CompareTo(otherCustomer.Id);
        }
    }
}
