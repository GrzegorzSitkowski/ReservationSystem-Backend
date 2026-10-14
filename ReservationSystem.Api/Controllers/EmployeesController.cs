using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Application.Employees.Queries.GetEmployeeDetail;

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
    }
}
