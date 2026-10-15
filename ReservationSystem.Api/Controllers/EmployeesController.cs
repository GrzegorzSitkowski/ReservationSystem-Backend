using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Application.Employees.Queries.GetEmployeeDetail;
using ReservationSystem.Application.Employees.Queries.GetEmployees;

namespace ReservationSystem.WebApi.Controllers
{
    [Route("api/employees")]
    public class EmployeesController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDetailVm>> GetDetails(Guid id)
        {
            var vm = await Mediator.Send(new GetEmployeeDetailQuery() { EmployeeId = id });
            return vm;
        }

        [HttpGet]
        public async Task<ActionResult<EmployeesVm>> GetEmployeesList()
        {
            var vm = await Mediator.Send(new GetEmployeesQuery());
            return vm;
        }
    }
}
