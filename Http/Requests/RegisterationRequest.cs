﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Http.Requests
{
    public class RegisterationRequest
    {
        [Required]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public IFormFile? Image { get; set; }
        [FileExtensions]
        private string ImageName { get => Image.FileName; }
    }
}
