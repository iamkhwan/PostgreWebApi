using Microsoft.AspNetCore.Mvc;
using PostgreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private PostgreWebApiContext _context;

		public UsersController(PostgreWebApiContext context)
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<IEnumerable<UserProfile>> GetAllUserProfile()
		{
			var item = _context.UserProfile.ToList();
			if (item == null)
				return NotFound();
			else
				return item;
		}

		[HttpGet()]
		[Route("GetUserProfileById/{id}")]
		public ActionResult<UserProfile> GetUserProfileById(int id)
		{
			var item = _context.UserProfile.Find(id);
			if (item == null)
				return NotFound();
			else
				return item;
		}

		[HttpPost()]
		[Route("AddUserProfile")]
		public ActionResult AddUserProfile(UserProfile user)
		{
			if (user != null)
			{
				_context.UserProfile.Add(user);
				_context.SaveChanges();
				return Ok();
			}
			else
				return BadRequest();
		}
	}
}
