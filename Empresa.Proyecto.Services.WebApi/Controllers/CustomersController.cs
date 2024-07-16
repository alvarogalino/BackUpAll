using Microsoft.AspNetCore.Mvc;

using Empresa.Proyecto.Aplicacion.DTO;
using Empresa.Proyecto.Aplicacion.Interface;

namespace Empresa.Proyecto.Services.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomersAplication _customersAplication;

        public CustomersController (ICustomersAplication customersAplication)
        {
            _customersAplication = customersAplication;
        }

        #region "Metodos Sincronos"
        [HttpPost("Insert")]
        public IActionResult Insert ([FromBody]CustomersDTO customersDto)
        {
            if (customersDto == null)
                return BadRequest();
            var response = _customersAplication.Insert(customersDto);
            if(response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut("Update")]
        public IActionResult Update ([FromBody] CustomersDTO customersDto)
        {
            if (customersDto == null)
                return BadRequest();
            var response = _customersAplication.Update (customersDto);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("Delete/{customersId}")]
        public IActionResult Delete(string customersId)
        {
            if (string.IsNullOrEmpty(customersId))
                return BadRequest();
            var response = _customersAplication.Delete(customersId);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("Get/{customersId}")]
        public IActionResult Get(string customersId)
        {
            if (string.IsNullOrEmpty(customersId))
                return BadRequest();
            var response = _customersAplication.Get(customersId);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
           
            var response = _customersAplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        #endregion 


        #region "Metodos Asincronos"
        [HttpPost]
        public async Task<IActionResult> InsertAsync ([FromBody] CustomersDTO customersDto)
        {
            if (customersDto == null)
                return BadRequest();
            var response = await _customersAplication.InsertAsync(customersDto);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] CustomersDTO customersDto)
        {
            if (customersDto == null)
                return BadRequest();
            var response = await _customersAplication.UpdateAsync(customersDto);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpDelete("{customersId}")]
        public async Task<IActionResult> DeleteAsync(string customersId)
        {
            if (string.IsNullOrEmpty(customersId))
                return BadRequest();
            var response = await _customersAplication.DeleteAsync(customersId);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("{customersId}")]
        public async Task<IActionResult> GetAsync(string customersId)
        {
            if (string.IsNullOrEmpty(customersId))
                return BadRequest();
            var response = await _customersAplication.GetAsync(customersId);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            var response = await _customersAplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        #endregion

    }
}
