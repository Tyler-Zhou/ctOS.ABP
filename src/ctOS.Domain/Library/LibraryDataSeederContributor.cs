using ctOS.Library.Books;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ctOS.Library
{
    public class LibraryDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;

        public LibraryDataSeederContributor(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Book
                    {
                        sKey = "0000000001",
                        sName = "武林外传",
                        sAuthor = "宁财神",
                        sLink="localhost",
                        sTag="剧本",
                        sIntroduction="剧本",
                        tStatus=1,
                        tCreateDate = new DateTime(2006, 6, 1),
                    },
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Book
                    {
                        sKey = "0000000002",
                        sName = "仙逆",
                        sAuthor = "耳根",
                        sLink = "localhost",
                        sTag = "修仙",
                        sIntroduction = "修仙",
                        tStatus = 1,
                        tCreateDate = new DateTime(2012, 1, 1),
                    },
                    autoSave: true
                );
            }
        }
    }
}