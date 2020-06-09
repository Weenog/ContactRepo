using ContactListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListApp.Controllers
{

    public class ContactController
    {
      private readonly IContactDataBase _contactDataBase;

        public ContactController(IContactDatabase contacts)
        {
            _contactDataBase = contacts;
        }
    }

    [HttpPost]
    public IActionResult CreateNewContact()
    {
  
          Contact person = new Contact
          {



          }
            
     }
