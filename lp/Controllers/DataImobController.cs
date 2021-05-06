using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDataImob.Model;
using ApiDataImob.Repositories;
using ApiDataImob.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiDataImob.Controllers
{
    public class DataImobController : Controller
    {
        [HttpPost]
     
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login ([FromBody] User model)
        {
               var user = UserRepository.Get(model.Username, model.Password);
         
            if (user == null)
            { return NotFound(new { message = "Usuário ou senha inválidos" }); }
          
            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new 
            {
                user = user,
                token = token
            };
        }

     
   
    }
}
