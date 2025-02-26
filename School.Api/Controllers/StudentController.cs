using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Api.Extensions;
using School.Application.Dtos;
using School.Application.Services;
using School.Domain.Entities;
namespace School.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(IStudentServices studentService) : ControllerBase
{
	private readonly IStudentServices _studentService = studentService;


	[HttpGet]
	[Route("GetAll")]
	[Authorize]
	public async Task<Response<List<Student>>> GetAllStudents([FromQuery] int page, [FromQuery] int size)
	{
		Response<List<Student>> response = await this.Execute(async () =>
		{
			return await _studentService.GetAllStudents(page, size);
		});
		return response;
	}

	[HttpGet]
	[Route("GetByFilter")]
	[Authorize]
	public async Task<Response<List<Student>>> GetByfilterStudents([FromQuery] Guid? id, [FromQuery] string? DNI, [FromQuery] string? name, [FromQuery] string? email)
	{
		Response<List<Student>> response = await this.Execute(async () =>
		{
			return await _studentService.GetByFilter(id, DNI, name, email);
		});
		return response;
	}

	[HttpPost]
	[Route("Create")]
	[Authorize]
	public async Task<Response<Student>> CreateStudent(CreateStudentDto createStudentDto)
	{
		Response<Student> response = await this.Execute(async () =>
		{
			return await _studentService.CreateStudent(createStudentDto);
		});
		response.Message = response.Success == true ? "Estudiante Creado con Exito" : response.Message;
		return response;
	}

	[HttpPut]
	[Route("Edit")]
	[Authorize]
	public async Task<Response<Student>> EditStudent(EditStudentDto editStudentDto)
	{
		Response<Student> response = await this.Execute(async () =>
		{
			return await _studentService.EditStudent(editStudentDto);
		});
		response.Message = response.Success == true ? "Estudiante Editado con Exito" : response.Message;
		return response;
	}

	[HttpDelete]
	[Route("Delete")]
	[Authorize]
	public async Task<Response<Student>> DeleteStudent(Guid id)
	{
		Response<Student> response = await this.Execute(async () =>
		{
			return await _studentService.DeleteStudent(id);
		});
		response.Message = response.Success == true ? "Estudiante eliminado con Exito" : response.Message;
		return response;
	}
	
}
