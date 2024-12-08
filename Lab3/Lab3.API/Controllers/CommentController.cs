using Lab3.BLL.DTOs.Comments;
using Lab3.BLL.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentService _service;

    public CommentController(ICommentService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAllAsync([FromRoute] int id)
    {
        var post = await _service.GetByIdAsync(id);

        return Ok(post);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteById([FromRoute] int id)
    {
        await _service.DeleteAsync(id);

        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] UpdateCommentDTO updateDTO)
    {
        await _service.UpdateAsync(updateDTO);

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCommentDTO createPostDTO)
    {
        await _service.CreateAsync(createPostDTO);

        return Ok();
    }
}
