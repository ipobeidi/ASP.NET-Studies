using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.CustomValidations;

namespace Vidly.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
                        
       // [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
                
        public byte MembershipTypeId { get; set; }
    }
}