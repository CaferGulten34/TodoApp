using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }
        [HttpPost("add")]
        public void Create(Note note)
        {
            _noteService.Add(note);
        
            
        }
        [HttpPost("Delete")]
        public void Delete(Note note)
        {
            _noteService.Delete(note);
            
        }
        [HttpPost("update")]
        public void Update(Note note)
        {
            _noteService.Update(note);
            
        }
        
    }
}