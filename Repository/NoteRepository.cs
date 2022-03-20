using Microsoft.EntityFrameworkCore;

public class NoteRepository : INoteRepository
{
    private DbContext _context;
public NoteRepository(DbContext context)
    {
        _context = context;
    }

    public void Add(Note note)
    {
        _context.Add(note);
    _context.SaveChanges();
    }



    public void Delete(Note note)
    {
        _context.Remove(note);
        _context.SaveChanges();
    }

    public void Update(Note note)
    {
        _context.Update(note);
        _context.SaveChanges();
    }
}