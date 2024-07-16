using Microsoft.AspNetCore.Mvc;
using AppCrud.Data;
using AppCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AppCrud.Controllers
{
    [Route("[controller]")]
    public class EmpleadoController(AppDBContext appDBContext) : Controller
    {

        private readonly AppDBContext _appDBContext = appDBContext;

        [HttpGet ("GetAll")]
        public async Task<IActionResult> Mostrar()
        {
            List<Empleado>lista = await _appDBContext.Empleado.ToListAsync();
            return Ok(lista);
        }

        [HttpGet ("/{id}")]
        public async Task<IActionResult> Cargar(int id)
        {
            var empleado = await _appDBContext.Empleado.FirstOrDefaultAsync(e => e.IdEmpleado == id);
            
            return Ok(empleado);
        }

        [HttpPost ("Insert")]
        public async Task<IActionResult> Nuevo (Empleado empleado)
        {
            await _appDBContext.Empleado.AddAsync(empleado);
            await _appDBContext.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return Ok(empleado);
        }

       /* [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            Empleado empleado = await _appDBContext.Empleado.FirstAsync(e => e.IdEmpleado == id);
            return Ok(empleado);
        }*/

        [HttpPut ("Update") ]
        public async Task<IActionResult> Actualizar (int id)
        {
            Empleado empleado = await _appDBContext.Empleado.FirstAsync(e => e.IdEmpleado == id);
            _appDBContext.Empleado.Update(empleado);
            await _appDBContext.SaveChangesAsync(); 
            //return RedirectToAction(nameof(Lista));
            return Ok(empleado) ;
        }

        [HttpDelete ("/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            Empleado empleado = await _appDBContext.Empleado.FirstAsync(e => e.IdEmpleado == id);
            _appDBContext.Empleado.Remove(empleado);
            await _appDBContext.SaveChangesAsync();
            //return RedirectToAction(nameof(Lista));
            return Ok(empleado);
        }
    }
}
