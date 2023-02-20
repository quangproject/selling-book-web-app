﻿using BusinessObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FPTBookAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeedbacksController : ControllerBase
	{
		private IFeedbackRepository repository = new FeedbackRepository();

		// GET: api/<FeedbacksController>
		[HttpGet]
		public ActionResult<IEnumerable<Feedback>> Get()
		{
			return repository.GetFeedbacks();
		}

		// GET: api/<FeedbacksController>/Checked
		[HttpGet("Checked")]
		public ActionResult<IEnumerable<Feedback>> GetCheckedFeedback()
		{
			return repository.GetCheckedFeedbacks();
		}

		// GET api/<FeedbacksController>/5
		[HttpGet("{id}")]
		public ActionResult<Feedback> Get(int id)
		{
			return repository.GetFeedbackById(id);
		}

		// POST api/<FeedbacksController>
		[HttpPost]
		public IActionResult Post([FromBody] Feedback obj)
		{
			repository.SaveFeedback(obj);
			return NoContent();
		}

		// PUT api/<FeedbacksController>/5
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] Feedback obj)
		{
			var feedback = repository.GetFeedbackById(id);
			if (feedback == null)
			{
				return NotFound();
			}
			repository.UpdateFeedback(obj);
			return NoContent();
		}

		// PUT api/<FeedbacksController>/5/Checked
		[HttpPut("{id}/Checked")]
		public IActionResult CheckedFeedback(int id)
		{
			var feedback = repository.GetFeedbackById(id);
			if (feedback == null)
			{
				return NotFound();
			}
			repository.CheckedFeedback(feedback);
			return NoContent();
		}

		// PUT api/<FeedbacksController>/5/UnChecked
		[HttpPut("{id}/UnChecked")]
		public IActionResult UnCheckedFeedback(int id)
		{
			var feedback = repository.GetFeedbackById(id);
			if (feedback == null)
			{
				return NotFound();
			}
			repository.UnCheckedFeedback(feedback);
			return NoContent();
		}

		// DELETE api/<FeedbacksController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var feedback = repository.GetFeedbackById(id);
			if (feedback == null)
			{
				return NotFound();
			}
			repository.DeleteFeedback(feedback);
			return NoContent();
		}
	}
}