﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO
{
    public class CustomerPost
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
