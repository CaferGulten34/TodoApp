public class NoteService:INoteService
{
    private INoteRepository _noteRepository;
public NoteService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    public void Add(Note note)
    {
        _noteRepository.Add(note);
    }

 

    public void Delete(Note note)
    {
        _noteRepository.Delete(note);
    }

    public void Update(Note note)
    {
        _noteRepository.Update(note);
    }
}