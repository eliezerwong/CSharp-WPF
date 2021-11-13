using System;
using System.Collections.Generic;
using System.Text;

namespace WPFContactList
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }


        public Contact()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Image = string.Empty;
        }

        public Contact(int id, string first, string last, string email, string image)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            Email = email;
            Image = image;
        }

        public override string ToString()
        {
            return $"{LastName},{FirstName}";
        }
    }


}
