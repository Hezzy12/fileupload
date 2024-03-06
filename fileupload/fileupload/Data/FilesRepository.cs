using fileupload.Models;

namespace fileupload.Data
{
    public class FilesRepository : RepositoryBase<Files>, IFilesRepository
    {
        public FilesRepository(AppDbContext app) : base(app)
        {
        }
    }
}