using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagment.Entities;
using UserManagment.Models;
using UserManagment.Utilities;

namespace UserManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        Serializer serialize = new Serializer();
        DataAccess dataAccess = new DataAccess(Directory.GetCurrentDirectory() + "\\members.jsom");


        [HttpPost("Register")]
        public IActionResult Register([FromForm] Member NewMember)
        {
            DataBase.memberList = DataBase.LoadMembers(Directory.GetCurrentDirectory() + "\\members.jsom");

            DataBase.memberList.Add(NewMember);
            var json = serialize.Serialize(DataBase.memberList);
            dataAccess.SaveToFile(json);
            return Ok(NewMember);

            //string json = serialize.Serialize(NewMember);
            //dataAccess.SaveToFile(json);
            //return Ok(NewMember);
        }

        [HttpPost("SignIn")]
        public IActionResult SignIn([FromForm] LoginDTO signInModel)
        {
            DataBase.memberList = DataBase.LoadMembers(Directory.GetCurrentDirectory() + "\\members.jsom");

            //List<SignupModel> signupModels = dataAccess.ReadFile();
            var currentUser = DataBase.memberList.FirstOrDefault(x => x.Email == signInModel.Email && x.Password == signInModel.Password);

            if(currentUser == null)
            {
                //throw new Exception(message: "Icorrect Email or Password");
                return BadRequest();
            }
            else
            {
                return Ok(currentUser);
            }
        }

    }
}