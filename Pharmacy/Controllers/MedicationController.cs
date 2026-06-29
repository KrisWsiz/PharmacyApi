using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Medication>> Get()
    {
        return Ok(MedicationData.Medications);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Medication> GetById(int id)
    {
        var medication = MedicationData.Medications.FirstOrDefault(m => m.Id == id);

        if (medication is null)
        {
            return NotFound();
        }

        return Ok(medication);
    }
}