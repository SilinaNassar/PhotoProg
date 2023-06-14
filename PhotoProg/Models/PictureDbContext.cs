using Microsoft.EntityFrameworkCore;
namespace PhotoProg.Models
{
    public class PictureDbContext :DbContext{
        public DbSet<Picture> Pictures { get; set; } = null;

        public PictureDbContext(DbContextOptions<PictureDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // load with data

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                PictureID = 1,
                FileName = "pecs1.jpg",
                PictureName = "Panorama of Pécs",
                When = new DateTime(2019, 6, 14),
                Location = "Pécs"
            }, new Picture
            {
                PictureID = 2,
                FileName = "pecs2.jpg",
                PictureName = "Crypt of the Cathedral",
                When = new DateTime(2018, 5, 10),
                Location = "Pécs"
            }, new Picture
            {
                PictureID = 3,
                FileName = "pecs3.jpg",
                PictureName = "Havihegy church",
                When = new DateTime(2017, 12, 11),
                Location = "Pécs"
            });
        }

    }
}
