using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using AirBnb.BL.Managers.AppointmentsAvailableManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.AppointmentsAvailable
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentAvailableController : ControllerBase
    {
        private readonly IApptAvailableManager _apptAvailableManager;

        public AppointmentAvailableController(IApptAvailableManager apptAvailableManager)
        {
            _apptAvailableManager = apptAvailableManager;
        }

        // Add new appointment available
        [HttpPost]
        [Authorize(Policy = "ForHost")]
        [AuthorizeCurrentUser]
        public async Task<IActionResult> Add(ApptAvailableAddDto apptAvailableAddDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ApptAvailableDto createdApptAvailable = await _apptAvailableManager.Add(apptAvailableAddDto);
            return Created("", createdApptAvailable);
        }

        // Update appointment available
        [HttpPut]
        [Route("{id}")]
        [Authorize(Policy = "ForHost")]
        [AuthorizeCurrentUser]
        public async Task<IActionResult> Update(int id, ApptAvailableAddDto apptAvailableAddDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                ApptAvailableDto updatedApptAvailable = await _apptAvailableManager.Update(id, apptAvailableAddDto);

                if (updatedApptAvailable == null)
                    return NotFound($"Amenity with ID {id} not found.");

                return Ok(updatedApptAvailable);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }

        }

        // Delete appointment available
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Policy = "ForHost")]
        [AuthorizeCurrentUser]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _apptAvailableManager.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
