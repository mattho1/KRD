using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryInfrastructure.DataAccess;
using WebApplicationKRDWebApi.Models;

namespace WebApplicationKRDWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PackageController: Controller
    {
        public static List<Package> _packages = new List<Package>()
        {
            new Package(1, PakageStatus.Delivered, new DateTime(2018,4,18,12,0,0), UserController._users[1]),
            new Package(2, PakageStatus.InSystem, new DateTime(2018,4,19,16,12,0), UserController._users[1]),
            new Package(3, PakageStatus.InWarehouse, new DateTime(2018,4,19,17,15,0), UserController._users[2]),
            new Package(4, PakageStatus.OnTheWay, new DateTime(2018,4,20,12,18,0), UserController._users[3]),
            new Package(5, PakageStatus.InWarehouse, new DateTime(2018,4,20,12,20,0), UserController._users[4]),
            new Package(6, PakageStatus.Delivered, new DateTime(2018,4,21,14,55,0), UserController._users[4])
        };

        private CourierApplicationContext context;
        public PackageController(CourierApplicationContext _context)
        {
            context = _context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok(context.Packages.ToList());
            //return Ok(new { packages = _packages });
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetPackageById(int id)
        {
            var package = _packages.Where(x => x.number == id).FirstOrDefault();
            if(package == null)
            {
                return NotFound();
            }
            return Ok(package);
        }

        [HttpGet]
        [Route("{id:int}/owner")]
        public IActionResult GetOwnerPackage(int id)
        {
            var package = _packages.Where(x => x.number == id).FirstOrDefault();
            if (package == null)
            {
                return NotFound();
            }
            var user = package.owner;
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("owner/{fullName}")]
        public IActionResult GetPackagesByUsersName(string fullName)
        {
            List<User> users;
            List<Package> packages = new List<Package>();
            String[] _fullName = fullName.ToLower().TrimStart().Split(' ');
            if (_fullName.Length >= 2)
            {
                users = UserController._users
                .Where(x => (x.surname.ToLower().Contains(_fullName[0]) && x.name.ToLower().Contains(_fullName[1]) || x.surname.ToLower().Contains(_fullName[1]) && x.name.ToLower().Contains(_fullName[0])))
                .ToList();
            }
            else
            {
                users = UserController._users
                .Where(x => (x.surname.ToLower().Contains(_fullName[0]) || x.name.ToLower().Contains(_fullName[0])))
                .ToList();
            }
            if (users == null)
            {
                return NotFound();
            }
            foreach(User user in users)
            {
                packages.AddRange(_packages.Where(x => x.owner.id == user.id).ToList());
            }
            return Ok(packages);
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddPackage([FromBody]Package package)
        {
            int number = 0;
            bool existUser = false;
            foreach(User user in UserController._users)
            {
                if(user.id == package.owner.id && user.name.Equals(package.owner.name) && user.password.Equals(package.owner.password) && user.surname.Equals(package.owner.surname) && user.street.Equals(package.owner.street) && user.login.Equals(package.owner.login) && user.role == package.owner.role)
                {
                    existUser = true;
                    break;
                }
            }
            if (!existUser)
            {
                return BadRequest("User doesn't exist.");
            }
            foreach(Package pack in _packages)
            {
                if(pack.number > number)
                {
                    number = pack.number;
                }
            }
            package.number = number + 1;
            _packages.Add(package);
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult PutPackage(int id, [FromBody]Package package)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existingPackage = _packages.Where(x => x.number == id).FirstOrDefault();
            if (existingPackage != null)
            {
                existingPackage.hour = package.hour;
                existingPackage.number = package.number;
                existingPackage.owner = package.owner;
                existingPackage.status = package.status;
                _packages[_packages.IndexOf(_packages.Where(x => x.number == id).FirstOrDefault())] = existingPackage;
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeletePackage(int id)
        {
            var package = _packages.Where(x => x.number == id).FirstOrDefault();
            if (package == null)
            {
                return NotFound();
            }
            if (_packages.Remove(package))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
