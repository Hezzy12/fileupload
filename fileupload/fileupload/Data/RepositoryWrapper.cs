namespace fileupload.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _app;

        public RepositoryWrapper(AppDbContext app)
        {
            _app = app;
        }
        private IFilesRepository _files;

        public IFilesRepository File
        {
            get
            {
                if (_files == null)
                    _files = new FilesRepository(_app);

                return _files;
            }
        }
    }
}
