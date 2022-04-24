using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HospedagemController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;
    public HospedagemController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await unitOfWork.Hospedagem.GetAllAsync();
        return Ok (data);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await unitOfWork.Hospedagem.GetByIdAsync(id);
        if (data == null) return Ok();
        return Ok(data);
    }
    [HttpPost]
    public async Task<IActionResult> Add(Hospedagem product)
    {
        var data = await unitOfWork.Hospedagem.AddAsync(product);
        return Ok(data);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var data = await unitOfWork.Hospedagem.DeleteAsync(id);
        return Ok(data);
    }
    [HttpPut]
    public async Task<IActionResult> Update(Hospedagem product)
    {
        var data = await unitOfWork.Hospedagem.UpdateAsync(product);
        return Ok(data);
    }
}