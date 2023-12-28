using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagment.Entities;
using UserManagment.Services;

namespace UserManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        CRUD crud = new CRUD();

        [HttpPost("createMemebr")]
        public IActionResult CreateUser(Member NewMember)
        {
            DataBase.memberList.Add(NewMember);
            return Ok();
        }

        [HttpGet("GetAllMembers")]
        public IActionResult GetMembers()
        {
            return Ok(crud.ReadAllUsers());
        }

        [HttpPost("EditMember")]
        public IActionResult EditMember(Member TargetMember, string Id)
        {
            var memberForEdit = DataBase.memberList.First(x => x.Id == Id);
            memberForEdit = TargetMember;
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteMember(string Id)
        {
            var memberForDelete = DataBase.memberList.First(y => y.Id == Id);
            DataBase.memberList.Remove(memberForDelete);
            return Ok();
        }
    }
}
