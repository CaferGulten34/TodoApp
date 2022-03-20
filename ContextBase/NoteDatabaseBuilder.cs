using Microsoft.EntityFrameworkCore;


namespace network
{
    public static class NoteDatabaseBuilder
    {
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Description);
                entity.Property(e=>e.Type);

            });
           
        }

    }
}