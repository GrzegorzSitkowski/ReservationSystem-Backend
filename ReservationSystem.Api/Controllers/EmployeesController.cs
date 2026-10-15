using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Application.Employees.Commands.CreateEmployee;
using ReservationSystem.Application.Employees.Commands.DeleteEmployee;
using ReservationSystem.Application.Employees.Commands.UpdateEmployee;
using ReservationSystem.Application.Employees.Queries.GetEmployeeDetail;
using ReservationSystem.Application.Employees.Queries.GetEmployees;
using ReservationSystem.Persistance;

namespace ReservationSystem.WebApi.Controllers
{
    [Route("api/employees")]
    public class EmployeesController : BaseController
    {
        private readonly ReservationDbContext _context;

        public EmployeesController(ReservationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDetailVm>> GetDetails(Guid id)
        {
            var vm = await Mediator.Send(new GetEmployeeDetailQuery() { EmployeeId = id });
            return vm;
        }

        [HttpGet]
        public async Task<ActionResult<EmployeesVm>> GetEmployeesList()
        {
            var employess = await _context.Employees.AsNoTracking().ToListAsync();
            return Ok(employess);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateEmployee(CreateEmployeeCommand command)
        {
            var employeeId = await Mediator.Send(command);
            return Ok(employeeId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Guid id, [FromBody]UpdateEmployeeCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            await Mediator.Send(new DeleteEmployeeCommand { EmployeeId = id });
            return NoContent();
        }
    }
}
