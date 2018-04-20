using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationKRDWebApi.Models;

namespace WebApplicationKRDWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController: Controller
    {
        public static List<User> _users = new List<User>()
        {
            new User(1, "Mateusz", "Nowak", "Reja", "Mat", "Mat", UserRole.Administrator),
            new User(2, "Kacper", "Nowakowski", "Długa", "Kac", "Kac", UserRole.Client),
            new User(3, "Kamil", "Postolak", "Prosta", "Kam", "Kam", UserRole.Client),
            new User(4, "Damian", "Wolski", "Krzywa", "Dam", "Dam", UserRole.Courier),
            new User(5, "Dawid", "Kowalski", "Parabola", "Daw", "Daw", UserRole.Courier)
        };
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok(new { users = _users });
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetUserById(int id)
        {
            var user = _users.Where(x => x.id == id).FirstOrDefault();
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("{fullName}")]
        public IActionResult GetUsersByName(string fullName)
        {
            List<User> users;
            String[] _fullName = fullName.ToLower().TrimStart().Split(' ');
            if (_fullName.Length >= 2)
            {
                users = _users
                .Where(x => (x.surname.ToLower().Contains(_fullName[0]) && x.name.ToLower().Contains(_fullName[1]) || x.surname.ToLower().Contains(_fullName[1]) && x.name.ToLower().Contains(_fullName[0])))
                .ToList();
            }
            else
            {
                users = _users
                .Where(x => (x.surname.ToLower().Contains(_fullName[0]) || x.name.ToLower().Contains(_fullName[0])))
                .ToList();
            }
            if(users == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(users);
            }
        }

        [HttpGet]
        [Route("{id:int}/packages")]
        public IActionResult GetUserPackages(int id)
        {
            var user = _users.Where(x => x.id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            var packages = PackageController._packages.Where(x => x.owner.id == id).ToList();
            return Ok(packages);
        }

        [HttpGet]
        [Route("login/{login}/{password}")]
        public IActionResult GetCorrectLogin(string login, string password)
        {
            var user = _users.Where(x => x.login.Equals(login)&&x.password.Equals(password)).FirstOrDefault();
            if (user == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddUser([FromBody]User user)
        {
            int id = 0;
            foreach (User person in _users)
            {
                if (person.id > id)
                {
                    id = person.id;
                }
            }
            user.id = id + 1;
            _users.Add(user);
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult PutPackage(int id, [FromBody]User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existingUser = _users.Where(x => x.id == id).FirstOrDefault();
            if (existingUser != null)
            {
                existingUser.login = user.login;
                existingUser.name = user.name;
                existingUser.password = user.password;
                existingUser.role = user.role;
                existingUser.street = user.street;
                existingUser.surname = user.surname;
                _users[_users.IndexOf(_users.Where(x => x.id == id).FirstOrDefault())] = existingUser;
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _users.Where(x => x.id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            foreach (Package package in PackageController._packages)
            {
                if (package.owner.id == user.id)
                {
                    return BadRequest("This user have packages so user can't be remove.");
                }
            }
            if(user.role == UserRole.Administrator)
            {
                bool existAnotherAdminsitrator = false;
                foreach(User person in _users)
                {
                    if(person.role == UserRole.Administrator && person.id != user.id)
                    {
                        existAnotherAdminsitrator = true;
                        break;
                    }
                }
                if (!existAnotherAdminsitrator)
                {
                    return BadRequest("User can't be remove because this user is last administrator.");
                }
            }
            if (_users.Remove(user))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
