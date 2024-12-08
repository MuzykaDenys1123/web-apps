using Lab4.BLL.DTOs.Posts;
using Lab4.BLL.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class PostController : ControllerBase
{
    private readonly IPostService _service;

    public PostController(IPostService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var posts = await _service.GetAllAsync();

        return Ok(posts);
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
    public async Task<IActionResult> UpdateAsync([FromBody] UpdatePostDTO updateDTO)
    {
        await _service.UpdateAsync(updateDTO);

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreatePostDTO createPostDTO)
    {
        await _service.CreateAsync(createPostDTO);

        return Ok();
    }
}
