using fileupload.Models;
using Microsoft.EntityFrameworkCore;

namespace fileupload.Data
{
    public class SeedData
    {
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Files.Any())
            {
                context.Files.AddRange(
                    new Files { FileID = 1, fileName = "Keke Proof of registration.pdf", Data = GetFileBytes("C:\\Users\\MOTAUNG_TP\\Documents\\Keke Proof of registration.pdf"), Content = "application/pdf", UploadDate = DateTime.Now },
                    new Files { FileID = 2, fileName = "NSFAS-2024-Applications-Consent-Form.pdf", Data = GetFileBytes("C:\\Users\\MOTAUNG_TP\\Documents\\NSFAS-2024-Applications-Consent-Form.pdf"), Content = "application/pdf", UploadDate = DateTime.Now },
                    new Files { FileID = 3, fileName = "Neo Motaung - ID.pdf", Data = GetFileBytes("C:\\Users\\MOTAUNG_TP\\Documents\\Neo\\Neo Motaung - ID.pdf"), Content = "application/pdf", UploadDate = DateTime.Now },
                    new Files { FileID = 4, fileName = "Neo Motaung - Updated CV.pdf", Data = GetFileBytes("C:\\Users\\MOTAUNG_TP\\Documents\\Neo\\Neo Motaung - Updated CV.pdf"), Content = "application/pdf", UploadDate = DateTime.Now }
                    );
            }
            context.SaveChanges();
        }

        private static byte[] GetFileBytes(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, (int)fileStream.Length);
                return buffer;
            }
        }
    }
}
